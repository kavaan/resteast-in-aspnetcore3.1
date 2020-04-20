using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TakC.Api.Services;

namespace TakC.Api.Controllers {
    [ApiController]
    [Route ("[controller]")]
    public class TransportationController : ControllerBase {

        private readonly ITaxisService _taxisServie;
        private readonly IBikeDeliveryService _bikeDeliveryService;
        public TransportationController (ITaxisService taxisService,
            IBikeDeliveryService bikeDeliveryService) {
            _taxisServie = taxisService;
            _bikeDeliveryService = bikeDeliveryService;
        }

        [HttpGet ("taxis")]
        [AllowAnonymous]
        public async Task<IActionResult> GetTaxis () =>
            Ok (await _taxisServie.BrowseAsync ());

        [HttpGet ("deliveries")]
        [AllowAnonymous]
        public async Task<IActionResult> GetBikeDeivery () =>
            Ok (await _bikeDeliveryService.BrowseAsync ());
    }
}