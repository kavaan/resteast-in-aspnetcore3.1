using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TakC.Service.Taxis.Controllers {
    [ApiController]
    [Route ("[controller]")]
    public class TaxisController : ControllerBase {
        private static readonly IEnumerable<Taxi> taxis = new List<Taxi> {
            new Taxi {
            Id = 1,
            CarModel = "Peugeot 206",
            CarColor = "Brown",
            DriverFullName = "Gary Koller",
            LicensePlate = "147A32"
            },
            new Taxi {
            Id = 2,
            CarModel = "Mazda 3 2012",
            CarColor = "Gray",
            DriverFullName = "Alexander Egger",
            LicensePlate = "451F235"
            }
        };

        private readonly ILogger<TaxisController> _logger;

        public TaxisController (ILogger<TaxisController> logger) {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Taxi> Get () => taxis;
    }
}