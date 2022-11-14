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
            if (IsPostBack)
            {

            }
        }

        protected void playerNameCustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Regex.IsMatch(args.Value, "^[a-z,A-Z]"))
            {
                args.IsValid = false;
            }
            else args.IsValid = true;
        }
    }
}