using System.ComponentModel.DataAnnotations;

namespace CadCustomer.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome completo")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o seu estado civil")]
        [Display(Name = "Estado Civil")]
        [StringLength(100)]
        public string EstadoCivil { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o endereço")]
        [Display(Name = "Endereço")]
        [StringLength(100)]
        public string Logradouro { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o número")]
        [Display(Name = "Número")]
        [StringLength(30)]
        public string Numero { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o bairro")]
        [Display(Name = "Bairro")]
        [StringLength(30)]
        public string Bairro { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe a cidade")]
        [Display(Name = "Cidade")]
        [StringLength(30)]
        public string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe a UF")]
        [Display(Name = "UF")]
        [StringLength(30)]
        public string UF { get; set; } = string.Empty;

        [Display(Name = "País")]
        public string? Pais { get; set; } = "BR";

        [Required(ErrorMessage = "Informe o CEP")]
        [Display(Name = "CEP")]
        [StringLength(10)]
        public string CEP { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o RG")]
        [Display(Name = "RG")]
        [StringLength(50)]
        public string RG { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o nome do seu pai")]
        [StringLength(100)]
        public string NomePai { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o nome da sua mãe")]
        [StringLength(100)]
        public string NomeMae { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe sua data de nascimento")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNasc { get; set; }
    }
}
