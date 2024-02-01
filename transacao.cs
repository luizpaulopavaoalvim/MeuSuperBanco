using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuSuperBanco
{
    public class transacao
    {
        public decimal Valor { get; set; }
        public DateTime Data {  get; set; }
        public string descricao {  get; set; }

        public transacao(decimal valor, DateTime data, string descricao)
        {
            this.Valor = valor;
            this.Data = data;
            this.descricao = descricao;
        }
    }
}
