using System;
using System.Web.UI;
using Accounts.BLL;

namespace Accounts.Web
{
    public partial class Default : Page
    {
        protected void btnDisplayTotals_Click(object sender, EventArgs e)
        {
            try
            {
                decimal revenue = decimal.Parse(txtRevenue.Text);
                decimal expenses = decimal.Parse(txtExpenses.Text);

                IAccountingCalculator calculator = new AccountingCalculator();
                decimal net = calculator.CalculateNet(revenue, expenses);

                litNet.Text = net.ToString("C");
                pnlError.Visible = false;
            }
            catch
            {
                pnlError.Visible = true;
            }
        }
    }
}
