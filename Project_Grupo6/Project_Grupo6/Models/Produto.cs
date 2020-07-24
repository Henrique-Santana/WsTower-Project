using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Grupo6.Models
{
    public class Produto
    {
        public string ProdutName { get; set; }
        public string Preco { get; set; }
        public string Image { get; set; }
        public string Tipo { get; set; }

        public override string ToString()
        {
            return ProdutName;
        }
    }
}
