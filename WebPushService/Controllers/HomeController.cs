using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebPush;
using WebPushService.Models;
using WebPushService.Data;
using Newtonsoft.Json;

namespace WebPushService.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;

        private readonly ApplicationDbContext _dbContext;

        public HomeController(UserManager<IdentityUser> userManager, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            IdentityUser usr = await _userManager.GetUserAsync(HttpContext.User);

            List<Application> modelList = _dbContext.Application.Where(m => m.userId == usr.Id).ToList();

            return View("~/Views/Home/List.cshtml", modelList);
        }



        public IActionResult CreateApplication()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateApplication(Application model)
        {
            IdentityUser usr = await _userManager.GetUserAsync(HttpContext.User);
            var keys = VapidHelper.GenerateVapidKeys();

            model.userId = usr.Id;
            model.privateKey = keys.PrivateKey;
            model.publicKey = keys.PublicKey;
            model.createdAt = System.DateTime.Now;
            model.lastUpdated = System.DateTime.Now;

            _dbContext.Add(model);
            await _dbContext.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }

        public IActionResult Send(string id)
        {
            return View(new SendRequestModel {
                id = id
            });
        }

        [HttpPost]
        public IActionResult Send(SendRequestModel model)
        {
            Application application =  _dbContext.Application.SingleOrDefault(m => m.id == model.id);

            List<Device> devices = _dbContext.Device.Where(m => m.appId == application.id).ToList();

            string vapidPublicKey = application.publicKey;
            string vapidPrivateKey = application.privateKey;

            PushModel payload = new PushModel
            {
                title = model.title,
                message = model.message
            };
            
            foreach (Device device in devices)
            {
                var pushSubscription = new PushSubscription(device.pushEndpoint, device.pushP256DH, device.pushAuth);
                var vapidDetails = new VapidDetails("mailto:example@example.com", vapidPublicKey, vapidPrivateKey);

                var webPushClient = new WebPushClient();
                webPushClient.SendNotification(pushSubscription, JsonConvert.SerializeObject(payload), vapidDetails);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
