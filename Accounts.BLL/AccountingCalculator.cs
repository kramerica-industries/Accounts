using System;

namespace Accounts.BLL
{
    /// <summary>
    /// Calculator used determine net cost.
    /// </summary>
    public sealed class AccountingCalculator : IAccountingCalculator
    {
        /// <summary>
        /// Calculates the net.
        /// </summary>
        /// <param name="revenue">The revenue.</param>
        /// <param name="expenses">The expenses.</param>
        public decimal CalculateNet(decimal revenue, decimal expenses)
        {
            if (revenue < 0)
                throw new ArgumentOutOfRangeException("revenue");
            if (expenses < 0)
                throw new ArgumentOutOfRangeException("expenses");

            return revenue * expenses;
        }
    }
}
