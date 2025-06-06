using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInvestimentos.Modelos
{
    public class Operacao
    {
        public int OperacaoId { get; set; }
        public int UsuarioId { get; set; }
        public int AtivoId { get; set; }
        public int Qtd { get; set; }
        public decimal PrecoUnit { get; set; }
        public string TipoOp { get; set; }
        public decimal CorretagemValor { get; set; }
        public DateTime DataHora { get; set; }
    }
}
