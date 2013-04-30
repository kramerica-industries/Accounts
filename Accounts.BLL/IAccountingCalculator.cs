
namespace Accounts.BLL
{
    /// <summary>
    /// Represents a contract for an account balance calculator.
    /// </summary>
    public interface IAccountingCalculator
    {
        /// <summary>
        /// Calculates the net.
        /// </summary>
        /// <param name="revenue">The revenue.</param>
        /// <param name="expenses">The expenses.</param>
        decimal CalculateNet(decimal revenue, decimal expenses);
    }
}
