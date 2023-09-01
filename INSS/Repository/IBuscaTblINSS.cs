using INSS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public interface IBuscaTblINSS
	{
        TabelaINSS BuscaTabela(int year, decimal salario);
    }
}
