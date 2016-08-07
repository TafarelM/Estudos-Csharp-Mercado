using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PessoaFisica
    {
        public Pessoa pessoa { get; set; }
        public String nome { get; set; }
        public String cpf { get; set; }
        public String rg { get; set; }
        public DateTime dataNascimento { get; set; }
        public Sexo sexo { get; set; }
    }
}
