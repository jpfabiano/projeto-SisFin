using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class FornecedorService
    {
        private readonly FornecedorRepository _repository;

        public FornecedorService()
        {
            _repository = new FornecedorRepository();
        }

        public Fornecedor CadastrarFornecedor(int id, TipoPessoa tipoFornecedor, string nome, string email, string cpf_cnpj)
        {
            var fornecedor = new Fornecedor
            {
                Id = id,
                TipoFornecedor = tipoFornecedor,
                Cpf_cnpj = cpf_cnpj,
                Nome = nome,
                Email = email
            };

            _repository.Adicionar(fornecedor);
            return fornecedor;
        }

        public IEnumerable<Fornecedor> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}
