using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AvaliacaoDesenvolvedor.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public String Comprador { get; set; }
        public String Descricao { get; set; }
        public Decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public String Endereco { get; set; }
        public String Fornecedor { get; set; }

        public Decimal Total { get; set; }
    }
}