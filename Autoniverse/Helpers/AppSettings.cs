using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autoniverse.Helpers
{
    public class AppSettings
    {
        // Properties for JWT token signature

        public string Site { get; set; }
        public string Audience { get; set; }
        public string ExpireTime { get; set; }
        public string Secret { get; set; }
    }
}
