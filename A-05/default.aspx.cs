/*
* FILE			: default.aspx.cs
* PROJECT		: Assignment 5
* PROGRAMMERS	: Kyle Dunn, David Czachor
* FIRST VERSION : 2022-11-15
* DESCRIPTION	: This file handles all the events called by default.aspx
*/

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

        protected void submit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Session["playerName"] = playerName.Text;

                Response.Redirect("maximumNumber.aspx", true);
            }
        }
    }
}