using INSS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class BuscaTblINSS : IBuscaTblINSS
    {
        public TabelaINSS BuscaTabela(int year, decimal salario)
        {
            //Preenchendo esse objeto, simulando a tabela num BD
            #region Preenchendo Tabela

            var tabelaINSS = new List<TabelaINSS>();

            var lineINSS1 = new TabelaINSS
            {
                Ano = 2011,
                SalarioIni = 0,
                SalarioFim = Convert.ToDecimal("1106,90"),
                Aliquota = 8
            };
            tabelaINSS.Add(lineINSS1);

            var lineINSS2 = new TabelaINSS
            {
                Ano = 2011,
                SalarioIni = Convert.ToDecimal("1106,91"),
                SalarioFim = Convert.ToDecimal("1844,83"),
                Aliquota = 9
            };
            tabelaINSS.Add(lineINSS2);

            var lineINSS3 = new TabelaINSS
            {
                Ano = 2011,
                SalarioIni = Convert.ToDecimal("1844,84"),
                SalarioFim = Convert.ToDecimal("3689,66"),
                Aliquota = 11
            };
            tabelaINSS.Add(lineINSS3);

            var lineINSS4 = new TabelaINSS
            {
                Ano = 2011,
                SalarioIni = Convert.ToDecimal("3689,67"),
                SalarioFim = null,
                Aliquota = 0,
                ValorTeto = Convert.ToDecimal("405,86")
            };
            tabelaINSS.Add(lineINSS4);

            var lineINSS5 = new TabelaINSS
            {
                Ano = 2012,
                SalarioIni = 0,
                SalarioFim = Convert.ToDecimal("1000"),
                Aliquota = 7,
            };
            tabelaINSS.Add(lineINSS5);

            var lineINSS6 = new TabelaINSS
            {
                Ano = 2012,
                SalarioIni = Convert.ToDecimal("1000,01"),
                SalarioFim = Convert.ToDecimal("1500"),
                Aliquota = 8
            };
            tabelaINSS.Add(lineINSS6);

            var lineINSS7 = new TabelaINSS
            {
                Ano = 2012,
                SalarioIni = Convert.ToDecimal("1500,01"),
                SalarioFim = Convert.ToDecimal("3000"),
                Aliquota = 9
            };
            tabelaINSS.Add(lineINSS7);

            var lineINSS8 = new TabelaINSS
            {
                Ano = 2012,
                SalarioIni = Convert.ToDecimal("3000,01"),
                SalarioFim = Convert.ToDecimal("4000"),
                Aliquota = 11
            };
            tabelaINSS.Add(lineINSS8);

            var lineINSS9 = new TabelaINSS
            {
                Ano = 2012,
                SalarioIni = Convert.ToDecimal("4000,01"),
                SalarioFim = null,
                Aliquota = 0,
                ValorTeto = Convert.ToDecimal("500")
            };
            tabelaINSS.Add(lineINSS9);

            #endregion

            //Simulando o Select do BD
            var newTblINSS = tabelaINSS
                                .Where(
                                        q => year.Equals(q.Ano)
                                        && q.SalarioFim.HasValue
                                        && q.SalarioIni <= salario 
                                        && (q.SalarioFim >= salario)
                                       )
                                .FirstOrDefault();

            if (newTblINSS == null)
            {
                newTblINSS = tabelaINSS
                                .Where(
                                        q => year.Equals(q.Ano)
                                        && q.SalarioIni <= salario
                                        && string.IsNullOrEmpty(q.SalarioFim.ToString())
                                       )
                                .FirstOrDefault();
            }

            return newTblINSS;
        }
    }
}
