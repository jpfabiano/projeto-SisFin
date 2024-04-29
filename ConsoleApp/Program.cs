using Negocio;
using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data1 = new DateTime(2024, 4, 3);
            DateTime data2 = new DateTime(2024, 4, 3, 10, 31, 0);
            DateTime data3 = new DateTime(2024, 4, 11, 12, 35, 0);


            //FORNECEDORES
            FornecedorService fornecedorService = new FornecedorService();
            Fornecedor f1 = fornecedorService.CadastrarFornecedor(1, TipoPessoa.PESSOA_FISICA, "LOJA DO TURCO", "f1@gmail.com", "112233445566");

            //PRODUTOS
            ProdutoService produtoService = new ProdutoService();
            Produto produto1 = produtoService.CadastrarProduto(1, "Papel Sulfite", 25.5m, f1);
            Produto produto2 = produtoService.CadastrarProduto(2, "Monitor LG Flatron", 1245,f1);

            //CATEGORIA
            CategoriaService categoriaService = new CategoriaService();
            Categoria categoria1 = categoriaService.CadastrarCategoria(1, "Receita");
            Categoria categoria2 = categoriaService.CadastrarCategoria(2, "Estoque");
            Categoria categoria3 = categoriaService.CadastrarCategoria(3, "Custeio");
            
            //CONTA
            ContaService contaService = new ContaService();
            Conta conta1 = contaService.CadastrarConta(1, "Venda Direta ", TipoConta.CONTA_RECEBER, true, categoria1);
            Conta conta2 = contaService.CadastrarConta(2,"Venda Corporativa", TipoConta.CONTA_RECEBER, true , categoria1 );
            Conta conta3 = contaService.CadastrarConta(3, "Produtos de Informática", TipoConta.CONTA_PAGAR, true, categoria2);
            Conta conta4 = contaService.CadastrarConta(4, "Material Construção", TipoConta.CONTA_PAGAR, true, categoria3);

            //CONTAPAGAR
            ContaPagarService contaPagarService = new ContaPagarService();
            ContaPagar cp1 = contaPagarService.CadastrarContaPagar(1, 31.75m, data1, data1, MeioPagamento.BOLETO, EstadoPagamento.ESTADO_QUITADO, conta4);
            ContaPagar cp2 = contaPagarService.CadastrarContaPagar(2, 1270, data2, data2, MeioPagamento.PIX, EstadoPagamento.ESTADO_QUITADO, conta2);

            //COMPRA
            CompraService compraService = new CompraService();
            Compra compra1 = compraService.CadastrarCompra(1, data2, " ", 0, 25.5, f1, cp1);
            Compra compra2 = compraService.CadastrarCompra(2,data2, " ",25,1270,f1, cp2);

            //CAIXA
            CaixaService caixaService = new CaixaService();
            Caixa caixa1 = caixaService.CadastrarCaixa(1, "Venda Balcão");
            Caixa caixa2 = caixaService.CadastrarCaixa(2, "Venda 0800");

            //CONTROLECAIXA
            ControleCaixaService controleCaixaService = new ControleCaixaService();
            ControleCaixa cx1 = controleCaixaService.CadastrarControleCaixa(1, 1225, data3, caixa1);
            ControleCaixa cx2 = controleCaixaService.CadastrarControleCaixa(2, 50, data3.AddHours(4), caixa2);

            //CONTARECEBER
            ContaReceberService contaReceberService = new ContaReceberService();
            ContaReceber cr1 = contaReceberService.CadastrarContaReceber(1, 50,data3.AddHours(4),data3.AddDays(3),data3.AddHours(5),0,MeioPagamento.CARTAO_DE_CREDITO,EstadoPagamento.ESTADO_PENDENTE,conta1,cx2);
            ContaReceber cr2 = contaReceberService.CadastrarContaReceber(2, 1225, data3, data3.AddDays(1), data3, 1225, MeioPagamento.PIX, EstadoPagamento.ESTADO_QUITADO, conta2,cx1);
           
            //CLIENTE
            ClienteService clienteService = new ClienteService();
            Cliente cliente1 = clienteService.CadastrarCliente(1, TipoPessoa.PESSOA_FISICA, "José Alberto Matioli", "112233445566");

            //VENDA
            VendaService vendaService = new VendaService();
            Venda venda1 = vendaService.Adicionar(1, data3, " ", 0, 1225, cliente1, cr2);
            Venda venda3 = vendaService.Adicionar(3, data3.AddHours(5), " ", 0, 50, cliente1, cr1);

            //ITEMVENDA
            ItemVendaService itemVendaService = new ItemVendaService();
            ItemVenda iv1 = itemVendaService.CadastrarItemVenda(1, 25, 0, venda1, produto1);
            ItemVenda iv2 = itemVendaService.CadastrarItemVenda(1, 1245, 0, venda1, produto2);
            ItemVenda iv3 = itemVendaService.CadastrarItemVenda(2, 50, 0, venda3, produto1);

            //ITEMCOMPRA
            ItemCompraService itemCompraService = new ItemCompraService();
            itemCompraService.CadastrarItemCompra(10, 3.5m,compra2, produto2);
            itemCompraService.CadastrarItemCompra(2, 100, compra1, produto1);

            //-------------------------------------------------------------

            //FORNECEDORES
            Console.WriteLine("FORNECEDORES CADASTRADOS:");
            foreach (Fornecedor f in fornecedorService.ObterTodos())
            {
                Console.WriteLine("\nID : " + f.Id + "\nNome : " +f.Nome+"\nTipo : "+f.TipoFornecedor+"\nEmail : "+f.Email+"\nCPF/CNPJ : "+f.Cpf_cnpj);
                Console.WriteLine("--------------------------");
            }

            //PRODUTOS
            Console.WriteLine("\nPRODUTOS CADASTRADOS : ");

            foreach (Produto p in produtoService.ObterTodos()) 
            {
                Console.WriteLine("\nID : " + p.Id + "\nNome : " +p.Nome +"\nPreço : " + p.Preco + "\nFornecedor : " + p.Fornecedor.Nome);
                Console.WriteLine("--------------------------");

            }

            //CATEGORIAS
            Console.WriteLine("\nCATEGORIAS CADASTRADAS : ");

            foreach(Categoria c in categoriaService.ObterTodos())
            {
                Console.WriteLine("\nID : " + c.Id + "\nNome : " + c.Nome);
                Console.WriteLine("--------------------------");
            }

            //CONTA
            Console.WriteLine("\nCONTAS CADASTRADAS : ");

            foreach(Conta c in contaService.ObterTodos())
            {
                Console.WriteLine("\nID : " + c.Id + "\nDescrição : " + c.Descricao + "\nTipo : " + c.Tipo + "\nStatus : " + c.Status + "\nCategoria : " + c.Categoria.Nome);
                Console.WriteLine("--------------------------");

            }

            //CONTAPAGAR
            Console.WriteLine("\nCONTAS A PAGAR : ");

            foreach(ContaPagar cp in contaPagarService.ObterTodos())
            {
                Console.WriteLine("\nID : " + cp.Id + "\nValor : " + cp.Valor + "\nData Vencimento : " + cp.DataVencimento + "\nMeio Pagamento : " + cp.Meiopagamento + "\nSituação : " + cp.Situacao + "\nID Conta : " + cp.Conta.Id);
                Console.WriteLine("--------------------------");
               
            }

            //COMPRA
            Console.WriteLine("\nCOMPRAS : ");
            foreach(Compra c in compraService.ObterTodos())
            {
                Console.WriteLine("\nID : " + c.Id + "\nInstante : " + c.Instance + "\nValor total : " + c.Valor_total + "\nConta pagar ID : " + c.ContaPagar.Id+"\nFornecedor ID : "+c.Fornecedor.Id);
                Console.WriteLine("--------------------------");

            }

            //CAIXA
            Console.WriteLine("\nCAIXAS : ");
            foreach(Caixa c in caixaService.ObterTodos())
            {
                Console.WriteLine("\nID : " + c.Id + "\nNome : " + c.Nome);
                Console.WriteLine("--------------------------");

            }

            //CONTROLE CAIXA
            Console.WriteLine("\nCONTROLE CAIXAS : ");
            foreach(ControleCaixa cc in controleCaixaService.ObterTodos())
            {
                Console.WriteLine("\nID : " + cc.Id + "\nValor : " + cc.Valor + "\nData : " + cc.Data + "\nCaixa ID : " + cc.Caixa.Id);
                Console.WriteLine("--------------------------");

            }

            //CONTA RECEBER
            Console.WriteLine("\nCONTA RECEBER : ");
            foreach(ContaReceber cb in contaReceberService.ObterTodos())
            {
                Console.WriteLine("\nID : " + cb.Id + "\nValor : " + cb.Valor + "\nData Vencimento : " + cb.DataVencimento + "\nValor Recebido " + cb.ValorRecebido + "\nMeio Pagamento : " + cb.MeioPagamento + "\nSituação : " + cb.Situacao + "\nConta ID : " + cb.Conta.Id + "\nControle Caixa ID : " + cb.ControleCaixa.Id);
                Console.WriteLine("--------------------------");
            }

            //CLIENTE 
            Console.WriteLine("\nCLIENTE : ");
            foreach(Cliente c in clienteService.ObterTodos())
            {
                Console.WriteLine("\nID : " + c.Id + "\nNome : " + c.Nome + "\nTipo Cliente : " + c.TipoCliente + "\nCPF : " + c.Cpf_cnpj);
                Console.WriteLine("--------------------------");

            }

            //VENDA 
            Console.WriteLine("\nVENDAS : ");
            foreach(Venda v in vendaService.ObterTodos())
            {
                Console.WriteLine("\nID : " + v.Id + "\nData : " + v.Instance + "\nValor Total : " + v.Valor_total + "\nCliente ID : " + v.Cliente.Id+"\nConta Receber ID : "+v.ContaReceber.Id);
                Console.WriteLine("--------------------------");

            }

            //ITEM VENDA 
            Console.WriteLine("\nITEM VENDA : ");
            foreach(ItemVenda iv in itemVendaService.ObterTodos())
            {
                Console.WriteLine("\nQuantidade : "+iv.Quantidade+"\nPreço : "+iv.Preco+"\nProduto ID : "+iv.Produto.Id+"\nVenda ID : "+iv.Venda.Id);
                Console.WriteLine("--------------------------");

            }

            //ITEM COMPRA
            Console.WriteLine("\nITEM COMPRA : ");
            foreach(ItemCompra ic in itemCompraService.ObterTodos())
            {
                Console.WriteLine("\nQuantidade : " + ic.Quantidade + "\nPreço : " + ic.Preco + "\nProduto ID : " + ic.Produto.Id + "\nCompra ID : " + ic.Compra.Id);
                Console.WriteLine("--------------------------");
            }


            Console.ReadLine();
        }
    }
}
