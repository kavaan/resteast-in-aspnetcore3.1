using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TakC.Services.BikeDelivery.Controllers {
    [ApiController]
    [Route ("[controller]")]
    public class BikeDeliveryController : ControllerBase {
        private static readonly IEnumerable<BikeDelivery> bikeDeliveryList = new List<BikeDelivery> () {
            new BikeDelivery {
            Id = 1,
            MotorcycleModelName = "Benelli  TNT 249s",
            DriverFullName = "Jack Luka",
            CostPerKilometer = 100
            },
            new BikeDelivery {
            Id = 2,
            MotorcycleModelName = "Suzuki Inazuma 250",
            DriverFullName = "Samuel Abazi",
            CostPerKilometer = 110
            },
            new BikeDelivery {
            Id = 3,
            MotorcycleModelName = "Hero Hunk 150 CC",
            DriverFullName = "Gary Chami",
            CostPerKilometer = 85
            },
        };

        private readonly ILogger<BikeDeliveryController> _logger;

        public BikeDeliveryController (ILogger<BikeDeliveryController> logger) {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<BikeDelivery> Get () => bikeDeliveryList;

    }
}