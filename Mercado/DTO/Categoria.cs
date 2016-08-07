using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Categoria
    {
        public int idCategoria { get; set; }
        public String nome { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return nome.ToString();
        }

    }
}
