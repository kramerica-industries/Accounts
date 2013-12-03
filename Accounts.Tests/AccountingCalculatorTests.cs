using System;
using Accounts.BLL;
using NUnit.Framework;

namespace Accounts.Tests
{
    [TestFixture]
    public class AccountingCalculatorTests
    {
        [Test]
        public void CalculateProfit()
        {
            IAccountingCalculator calc = new AccountingCalculator();
            decimal net = calc.CalculateNet(1000m, 1000m);

            Assert.AreEqual(0m, net);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeRevenue()
        {
            IAccountingCalculator calc = new AccountingCalculator();
            decimal net = calc.CalculateNet(-1000m, 1000m);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeExpenses()
        {
            IAccountingCalculator calc = new AccountingCalculator();
            decimal net = calc.CalculateNet(1000m, -1000m);
        }
    }
}
