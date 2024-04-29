using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Cliente
    {
        private int id;
        private TipoPessoa tipoCliente;
        private string cpf_cnpj;
        private string razaoSocial;
        private DateTime dataNascimento;
        private string nome;
        private string rua;
        private int numero;
        private string bairro;
        private string cidade;
        private string complemento;
        private string cep;
        private string telefone;
        private string email;
        private string celular;
        private string limite;

        public int Id { get => id; set => id = value; }
        public TipoPessoa TipoCliente { get => tipoCliente; set => tipoCliente = value; }
        public string Cpf_cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }
        public string Nome { get => nome; set => nome = value; }


    }
}
