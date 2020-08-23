using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPushService.Models
{
    public class DeviceRequestModel
    {
        public string publicKey { get; set; }

        public string externalId { get; set; }

        public string pushEndpoint { get; set; }

        public string pushP256DH { get; set; }

        public string pushAuth { get; set; }

    }
}
