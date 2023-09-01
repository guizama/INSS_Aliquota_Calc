using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class CalculadorInss : ICalculadorInss
	{
        //private readonly IBuscaTblINSS buscaTblINSS;

        //public CalculadorInss (IBuscaTblINSS buscaTblINSS)
        //{
        //    this.buscaTblINSS = buscaTblINSS;
        //}

        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            BuscaTblINSS buscaTblINSS = new BuscaTblINSS(); 

            var faixaSalarial = buscaTblINSS.BuscaTabela(data.Year, salario);

            if (faixaSalarial.ValorTeto >= 0)
            {
                return (decimal)faixaSalarial.ValorTeto;
            }

            decimal valorINSS = salario * (faixaSalarial.Aliquota / 100m);


            return valorINSS;
        }
    }
}
