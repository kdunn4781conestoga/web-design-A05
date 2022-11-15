using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A_05
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void playerNameCustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = !Regex.IsMatch(args.Value, "[^a-z ]", RegexOptions.IgnoreCase);
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                ViewState["playerName"] = playerName.Text;

                Response.Redirect("maximumNumber.aspx");
            }
        }
    }
}