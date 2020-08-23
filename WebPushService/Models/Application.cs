using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPushService.Models
{
    public class Application
    {
        public string id { get; set; }

        public string name { get; set; }

        public string publicKey { get; set; }

        public string privateKey { get; set; }

        public string userId { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime lastUpdated { get; set; }

    }
}
