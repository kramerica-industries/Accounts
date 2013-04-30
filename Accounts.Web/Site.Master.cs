using System;
using System.IO;
using System.Web.Configuration;
using System.Web.UI;

namespace Accounts.Web
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            litWebConfigValue.Text = WebConfigurationManager.AppSettings["Accounts.Value"];

            try
            {
                litVersion.Text = File.ReadAllText(Server.MapPath("~/version.info"));
            }
            catch { }
        }
    }
}
