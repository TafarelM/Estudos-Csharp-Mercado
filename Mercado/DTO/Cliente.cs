using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nome { get; set; }
        public string cpf_cnpj { get; set; }
        public string rg_ie { get; set; }
        public string razaoSocial { get; set; }
        public DateTime dataNascimento_Abertura { get; set; }
        public string sexo { get; set; }
        public string tipoCliente { get; set; }
        public string cep { get; set; }
        public string rua { get; set; }
        public string numero{ get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
    }
}
