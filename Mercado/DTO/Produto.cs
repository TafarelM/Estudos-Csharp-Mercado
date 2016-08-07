using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Produto
    {
        public int idProduto { get; set; }
        public String nome { get; set; }
        public int quantidade { get; set; }
        public decimal preco { get; set; }
        public DateTime dataFabricacao { get; set; }
        public DateTime dataValidade { get; set; }
        public Categoria categoria { get; set; }
    }
}
