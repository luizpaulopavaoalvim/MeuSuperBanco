using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MeuSuperBanco
{
    public class ContaBanco
    {
        public string Numero { get; }
        public string Dono { get; set; }
        public decimal Saldo 
        { 
            get
            {
                decimal saldo = 0;
                foreach (var item in todasTransacoes) 
                {
                    saldo += item.Valor;
                }
                return saldo;
            }
                
        }

        public static int numeroConta = 0123456789;

        private List<transacao> todasTransacoes = new List<transacao>();
        private string v;

        public ContaBanco(string nome, decimal valor)
        {
            this.Dono = nome;
            numeroConta++;

            this.Numero = numeroConta.ToString();
            Depositar(valor, DateTime.Now, "Saldo Inicial");

        }


        public void Depositar(decimal valor, DateTime data, string descricao)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "Não aceitamos depósito de valor 0 ou negativo");
            }
            transacao trans = new transacao(valor, data, descricao);
            todasTransacoes.Add(trans);
        }

        public void Sacar(decimal valor, DateTime data, string descricao)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "Não aceitamos saques de valor 0 ou negativo");
            }
            if (Saldo - valor < 0)
            {
                throw new InvalidOperationException("Essa operação não é permitida");
            }


            transacao trans = new transacao(-valor, data, descricao);
            todasTransacoes.Add(trans);
        }

        public string PegarMovimentacao()
        {
            var movimentacoes = new StringBuilder();

            movimentacoes.AppendLine("Data\t\tValor\tdescricao");

            foreach(var item in todasTransacoes)
            {
                movimentacoes.AppendLine($"{item.Data.ToShortDateString()}\t{item.Valor}\t{item.descricao}");
            }
            return movimentacoes.ToString();
        }
    }
}
