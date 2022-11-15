/*
* FILE			: maximumNumber.aspx.cs
* PROJECT		: Assignment 5
* PROGRAMMERS	: Kyle Dunn, David Czachor
* FIRST VERSION : 2022-11-15
* DESCRIPTION	: This file handles all the events called by maximumNumber.aspx
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A_05
{
    public partial class _maximumNumber : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            string playerName = Session["playerName"] as string;

            if (playerName == null || playerName.Trim().Length == 0)
            {
                Response.Redirect("default.aspx");
            }
            else
            {
                maxNumberLbl.Text = $"Welcome {playerName}<br />Enter Maximum Number";
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Session["maximumNumber"] = maxNumber.Text;

                Response.Redirect("gameLoop.aspx");
            }
        }
    }
}