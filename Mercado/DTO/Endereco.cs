using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Endereco
    {
        public int idEndereco { get; set; }
        public int idPessoa { get; set; }
        public String rua { get; set; }
        public String numero { get; set; }
        public String cidade { get; set; }
        public String estado { get; set; }
        public String cep { get; set; }
        public String descricao { get; set; }
    }
}
