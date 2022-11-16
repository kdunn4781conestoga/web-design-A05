/*
* FILE			: gameEnd.aspx.cs
* PROJECT		: Assignment 5
* PROGRAMMERS	: Kyle Dunn, David Czachor
* FIRST VERSION : 2022-11-15
* DESCRIPTION	: This file handles all the events called by gameEnd.aspx
*/

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
            // Stores the player name before clearing the session
            string playerName = Session["playerName"] as string;
            Session.Clear();

            // Stores the player name back into the session and redirects to the maximumNumber page
            Session["playerName"] = playerName;

            Response.Redirect("maximumNumber.aspx");
        }
    }
}