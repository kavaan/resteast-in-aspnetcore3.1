using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using TakC.Api.Models;

namespace TakC.Api.Services {

    [SerializationMethods (Query = QuerySerializationMethod.Serialized)]
    public interface ITaxisService {

        [AllowAnyStatusCode]
        [Get ("taxis")]
        Task<IEnumerable<Taxi>> BrowseAsync ();

    }
}