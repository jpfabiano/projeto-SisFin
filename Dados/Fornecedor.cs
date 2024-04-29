using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Fornecedor
    {
        private int id;
        private TipoPessoa tipoFornecedor;
        private string cpf_cnpj;
        private string razaoSocial;
        private string nome;
        private string rua;
        private int numero;
        private string bairro;
        private string cidade;
        private string complemento;
        private string cep;
        private string telefone; 
        private string celular;
        private string email;

        public int Id { get => id; set => id = value; }
        public TipoPessoa TipoFornecedor { get => tipoFornecedor; set => tipoFornecedor = value; }
        public string Cpf_cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
    }
}
