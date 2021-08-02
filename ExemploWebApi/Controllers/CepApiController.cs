using ExemploWebApi.Models;
using Refit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace ExemploWebApi.Controllers
{
    public class CepApiController : ApiController
    {

        private ApiContext  db = new ApiContext();
        private static List<Endereco> enderecos = new List<Endereco>();
        
        public List<Endereco> Get()
        {
            enderecos = db.Enderecoes.ToList();
            return enderecos;
        }

        public async Task PostAsync(string cep)
        {
            if (!string.IsNullOrEmpty(cep))
            {
                var cepClient = RestService.For<ICepApiService>("https://viacep.com.br/");

                var address = await cepClient.GetAddressAsync(cep);

                db.Enderecoes.Add(new Endereco
                {
                    Cep = address.Cep,
                    Logradouro =  address.Logradouro,
                    Complemento = address.Complemento,
                    Bairro = address.Bairro,
                    Localidade = address.Localidade,
                    UF = address.Uf,
                });

                db.SaveChanges();
            }
        }

       public void Delete(string cep)
       {

            if (!string.IsNullOrEmpty(cep))
            {
                var cepFormatado = cep.Insert(5, "-");

                var end = db.Enderecoes.Where(e => e.Cep == cepFormatado).FirstOrDefault();

                db.Enderecoes.Remove(end);

                db.SaveChanges();
            }

       }

    }
}
