using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Pessoa
    {
        public int IDPessoa { get; set; }
        public PessoaTipo pessoaTipo { get; set; }
        public Endereco endereco { get; set; }
    }
}
