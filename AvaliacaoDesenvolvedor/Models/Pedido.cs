using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvaliacaoDesenvolvedor.Models
{
    public class Pedido
    {
        public String Comprador { get; set; }
        public String Descricao { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public String Endereco { get; set; }
        public String Fornecedor { get; set; }
    }
}