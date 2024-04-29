﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Compra
    {
        private int id;
        private DateTime instance;
        private string descricao;
        private double desconto;
        private double valor_total;
        private Fornecedor fornecedor;
        private ContaPagar contaPagar;

        public int Id { get => id; set => id = value; }
        public DateTime Instance { get => instance; set => instance = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public double Valor_total { get => valor_total; set => valor_total = value; }
        public Fornecedor Fornecedor { get => fornecedor; set => fornecedor = value; }
        public ContaPagar ContaPagar { get => contaPagar; set => contaPagar = value; }
    }
}
