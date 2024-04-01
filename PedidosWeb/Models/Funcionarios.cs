using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;


namespace PedidosWeb.Models
{
    public class Funcionarios
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "O campo CPF deve ter exatamente 11 dígitos.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo E-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo E-mail deve ser um endereço de e-mail válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Celular é obrigatório.")]
        [RegularExpression(@"^\(\d{2}\) \d{4,5}-\d{4}$", ErrorMessage = "O campo Celular deve ter o formato (XX) X XXXX-XXXX.")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
        [MaxLength(200, ErrorMessage = "O campo Endereço deve ter no máximo 200 caracteres.")]
        public string Endereco { get; set; }

     


    }
}
