using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebPushService.Models;
using WebPushService.Data;
using Microsoft.AspNetCore.Cors;

namespace WebPushService.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    [Produces("application/json")]
    [Route("api/device")]
    public class DeviceController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public DeviceController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public string testMethod()
        {
            return "Hello";
        }

        [HttpPost]
        public void persistSubscriptionInfo([FromBody] DeviceRequestModel model)
        {
            Application application = _dbContext.Application.SingleOrDefault(m => m.publicKey == model.publicKey);

            if (application != null)
            {
                Device device = new Device
                {
                    appId = application.id,
                    pushAuth = model.pushAuth,
                    pushEndpoint = model.pushEndpoint,
                    pushP256DH = model.pushP256DH,
                    externalId = model.externalId,
                    lastUpdated = System.DateTime.Now,
                    createdAt = System.DateTime.Now
                };

                _dbContext.Device.Add(device);
                _dbContext.SaveChanges();
            }

        }
    }
}