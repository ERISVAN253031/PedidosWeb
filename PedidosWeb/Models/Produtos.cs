using System.ComponentModel.DataAnnotations;

namespace PedidosWeb.Models
{
    public class Produtos
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        public int Quantidade { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [MaxLength(200, ErrorMessage = "O campo Descrição deve ter no máximo 200 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Preço é obrigatório.")]
        public decimal Preco { get; set; }





    }
}