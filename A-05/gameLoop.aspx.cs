using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A_05
{
    public partial class gameLoop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            string playerName = Session["playerName"] as string;
            int? numberToGuess = Session["numberToGuess"] as int?;

            if (!IsPostBack)
            {
                if (Session["playerName"] == null || string.IsNullOrEmpty(Session["playerName"].ToString()))
                {
                    Response.Redirect("default.aspx");
                }

                int maximumNumber = 0;
                if (Session["maximumNumber"] == null || !Int32.TryParse(Session["maximumNumber"].ToString(), out maximumNumber))
                {
                    Response.Redirect("maximumNumber.aspx");
                }

                var rand = new Random();
                if (numberToGuess == null)
                {
                    numberToGuess = rand.Next(2, maximumNumber + 1);

                    Session["numberToGuess"] = numberToGuess;
                }
                Session["playerGuess"] = null;

                userGuessRangeValidator.MinimumValue = 2.ToString();
                userGuessRangeValidator.MaximumValue = maximumNumber.ToString();
            }
            else
            {

            }

            guessLbl.Text = $"<b>{playerName}</b><br /> <b>{numberToGuess}</b>Please enter your guess.";
        }
        protected void submitBtn_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                if (userGuess.Text == Session["numberToGuess"].ToString())
                {
                    Session["playerGuess"] = userGuess.Text;
                    Response.Redirect("gameEnd.aspx");
                }
            }
        }
    }
}