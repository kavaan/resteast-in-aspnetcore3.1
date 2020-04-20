using System.Collections.Generic;

namespace TakC.Api.Extensions {
    public class RestEaseOptions {
        public IEnumerable<Service> Services { get; set; }
        public class Service {
            public string Name { get; set; }
            public string Scheme { get; set; }
            public string Host { get; set; }
            public int Port { get; set; }
        }
    }
}