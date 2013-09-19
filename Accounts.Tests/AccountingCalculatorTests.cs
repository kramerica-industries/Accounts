using System;
using Accounts.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Accounts.Tests
{
    [TestClass]
    public class AccountingCalculatorTests
    {
        [TestMethod]
        public void CalculateProfit()
        {
            IAccountingCalculator calc = new AccountingCalculator();
            decimal net = calc.CalculateNet(1000m, 750m);

            Assert.AreEqual(250m, net);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeRevenue()
        {
            IAccountingCalculator calc = new AccountingCalculator();
            decimal net = calc.CalculateNet(-1000m, 1000m);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeExpenses()
        {
            IAccountingCalculator calc = new AccountingCalculator();
            decimal net = calc.CalculateNet(1000m, -1000m);
        }

        [TestMethod]
        public void CalculateOER()
        {
            IAccountingCalculator calc = new AccountingCalculator();
            decimal net = calc.CalculateOER(1000m, 500m);

            Assert.AreEqual(0.5m, net);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ZeroRevenueWhenCalculatingOER()
        {
            IAccountingCalculator calc = new AccountingCalculator();
            decimal net = calc.CalculateOER(0m, 1000m);
        }
    }
}
