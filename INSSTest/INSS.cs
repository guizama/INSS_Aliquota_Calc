using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using INSS;


namespace INSSTest
{
    [TestClass]
    public class INSS
    {
        [TestMethod]
        public void CalcINSS()
        {
            var data = Convert.ToDateTime("10/10/2011");
            var salario = Convert.ToDecimal("4000,00");
             
            CalculadorInss calc = new CalculadorInss(); 

            var result = calc.CalcularDesconto(data,salario);

            data = Convert.ToDateTime("10/10/2011");
            salario = Convert.ToDecimal("1000,00");

            var result2 = calc.CalcularDesconto(data, salario);

            Assert.AreEqual(result, Convert.ToDecimal("405,86"));
            Assert.AreEqual(result2, Convert.ToDecimal("80,00"));

             
             
        }
    }
}
