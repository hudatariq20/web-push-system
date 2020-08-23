using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPushService.Models
{
    public class Device
    {
        public string id { get; set; }

        public string appId { get; set; }

        public string externalId { get; set; }

        public string pushEndpoint { get; set; }

        public string pushP256DH { get; set; }

        public string pushAuth { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime lastUpdated { get; set; }

    }
}
