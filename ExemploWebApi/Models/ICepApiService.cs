using Refit;
using System.Threading.Tasks;

namespace ExemploWebApi.Models
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);

    }
}
