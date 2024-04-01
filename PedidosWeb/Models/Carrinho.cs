using System.ComponentModel.DataAnnotations;

namespace PedidosWeb.Models
{
    public class Carrinho
    {
        public long Id { get; set; }


        public string Nome { get; set; }

        public int Quantidade { get; set; }


        public string Descricao { get; set; }


        public decimal Preco { get; set; }





    }
}