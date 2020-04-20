using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using TakC.Api.Models;

namespace TakC.Api.Services {

    [SerializationMethods (Query = QuerySerializationMethod.Serialized)]
    public interface IBikeDeliveryService {

        [AllowAnyStatusCode]
        [Get ("bikedelivery")]
        Task<IEnumerable<BikeDelivery>> BrowseAsync ();

    }
}