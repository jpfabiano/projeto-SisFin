using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public enum TipoPessoa { PESSOA_FISICA=1, PESSOA_JURIDICA=2 };

    public enum EstadoPagamento { ESTADO_PENDENTE=1, ESTADO_QUITADO=2, ESTADO_CANCELADO=3 };

    public enum MeioPagamento { PIX = 1, BOLETO = 2, CARTAO_DE_CREDITO = 3, CARTAO_DE_DEBITO = 4, DINHEIRO = 5 };

    public enum TipoConta { CONTA_PAGAR = 1, CONTA_RECEBER = 2 };
}
