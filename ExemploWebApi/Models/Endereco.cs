using System.ComponentModel.DataAnnotations;

namespace ExemploWebApi.Models
{
    public class Endereco
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Cep")]
        public string Cep { get; set; }

        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "Localidade")]
        public string Localidade { get; set; }

        [Display(Name = "UF")]
        public string UF { get; set; }

    }
}