using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ClienteService
    {
        private readonly ClienteRepository _repository;

        public ClienteService()
        {
            _repository = new ClienteRepository();
        }

        public Cliente CadastrarCliente(int id, TipoPessoa tipoCliente, string nome, string cpf_cnpj)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var cliente = new Cliente
            {
                Id = id,
                TipoCliente = tipoCliente,
                Nome = nome,
                Cpf_cnpj = cpf_cnpj
            };

            _repository.Adicionar(cliente);
            return cliente;
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _repository.ObterTodos();
        }

    }
}
