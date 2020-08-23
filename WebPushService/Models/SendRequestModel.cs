using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPushService.Models
{
    public class SendRequestModel
    {
        public string id { get; set;  }

        public string title { get; set; }
        
        public string message { get; set; }
    }
}
