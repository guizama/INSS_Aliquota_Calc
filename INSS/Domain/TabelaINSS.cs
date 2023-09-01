using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Domain
{
    public class TabelaINSS
    {
        public int Ano { get; set; }
        public decimal SalarioIni { get; set; }
        public decimal? SalarioFim { get; set; }
        public int Aliquota { get; set; }
        public decimal? ValorTeto { get; set; } 
    }
}
