using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class DivideMyException : Exception
    {
        public DivideMyException(string msg) : base(msg) { }
    }
    public class Calc
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Calc));

        //5,20 -> 100
        //3,4 -> 12
        public double Multiply(double first, double second)
        {
            return first * second;
        }

        public double Divide(double first, double second)
        {
            if (second == 0)
            {
                log.Error("Denominator should not be zero.");
                throw new DivideMyException("Denominator should not be zero.");
            }
            double result = first / second;
            return result;
        }
    }
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            double product1 = calc.Multiply(5.0, 20.0);
            log.Info($"calc.Multiply(5.0, 20.0)={product1}");
            double product2 = calc.Multiply(3.0, 4.0);
            log.Info($"calc.Multiply(3.0, 4.0)={product2}");
            double quotient1 = calc.Divide(10.0, 2.0);
            log.Info($"calc.Divide(10.0, 2.0)={quotient1}");
            try
            {
                double quotient2 = calc.Divide(10.0, 0.0);
                log.Info($"calc.Divide(10.0, 0.0)={quotient2}");
            }
            catch (DivideMyException ex)
            {
                log.Error($"{ex.Message}");
            }


        }
    }
}

------------------------------------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestMethod()]
        public void Multiply_ShouldReturn100ForGiven5And20()
        {
            Calc calc = new Calc();
            double product = calc.Multiply(5.0, 20.0);
            Assert.AreEqual(100.0, product);
        }
        [TestMethod()]
        public void Multiply_ShouldReturn12ForGiven3And4()
        {
            Calc calc = new Calc();
            double product = calc.Multiply(3.0, 4.0);
            Assert.AreEqual(12.0, product);
        }
    }
}
----------------------------------------------------------

  using CalculatorApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorAppTests
{
    [TestClass]
    public class CalcDivideTests
    {
        [TestMethod]
        public void DivideShouldReturn2ForGiven10And5()
        {
            Calc calc = new Calc();
            double quotient = calc.Divide(10.0, 5.0);
            Assert.AreEqual(2.0, quotient);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideMyException))]
        public void DivideShouldThrowExceptionForGiven10And0()
        {
            Calc calc = new Calc();
            double quotient = calc.Divide(10.0, 0.0);
            //Assert.AreEqual(2.0, quotient);
        }
    }
}

  
