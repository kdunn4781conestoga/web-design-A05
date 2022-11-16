using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A_05
{
    public partial class gameEnd : System.Web.UI.Page
    {
        protected void submitBtn_Click(object sender, EventArgs e)
        {
            string playerName = Session["playerName"] as string;
            Session.Clear();

            Session["playerName"] = playerName;

            Response.Redirect("maximumNumber.aspx");
        }
    }
}