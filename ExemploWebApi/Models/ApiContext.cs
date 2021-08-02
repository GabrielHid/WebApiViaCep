using System.Data.Entity;

namespace ExemploWebApi.Models
{
    public class ApiContext : DbContext
    {

        public ApiContext() : base("DefaultConnection")
        {

        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

        }

        public System.Data.Entity.DbSet<ExemploWebApi.Models.Endereco> Enderecoes { get; set; }
    }
}