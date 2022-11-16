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
            if (string.IsNullOrEmpty(playerName))
            {
                Response.Redirect("default.aspx");
            }

            int maximumNumber = 0;
            if (Session["maximumNumber"] == null || !Int32.TryParse(Session["maximumNumber"].ToString(), out maximumNumber))
            {
                Response.Redirect("maximumNumber.aspx");
            }

            int minimumNumber = 0;
            if (Session["minimumNumber"] == null || !Int32.TryParse(Session["minimumNumber"].ToString(), out minimumNumber))
            {
                minimumNumber = 2;
                Session["minimumNumber"] = minimumNumber;
            }

            int numberToGuess = 0;
            if (Session["numberToGuess"] == null || !Int32.TryParse(Session["numberToGuess"].ToString(), out numberToGuess))
            {
                var rand = new Random();
                numberToGuess = rand.Next(2, maximumNumber + 1);

                Session["numberToGuess"] = numberToGuess;
            }


            if (!IsPostBack)
            {
                Session["playerGuess"] = null;
            }
            else
            {
                int.TryParse(userGuess.Text, out int guess);

                if (guess < numberToGuess)
                {
                    minimumNumber = guess;
                    Session["minimumNumber"] = minimumNumber;
                }
                else if (guess > numberToGuess)
                {
                    maximumNumber = guess;
                    Session["maximumNumber"] = maximumNumber;
                }
            }

            userGuessRangeValidator.MinimumValue = minimumNumber.ToString();
            userGuessRangeValidator.MaximumValue = maximumNumber.ToString();

            userGuess.Attributes.Add("placeholder", "You must enter a number between " + minimumNumber + " and " + maximumNumber);

            guessLbl.Text = $"<b>{playerName}</b><br />Please enter your guess.";

            Debug.WriteLine($"Number to guess is {numberToGuess}");
        }
        protected void submitBtn_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int.TryParse(userGuess.Text, out int guess);
                int.TryParse(Session["numberToGuess"].ToString(), out int numberToGuess);

                if (guess == numberToGuess)
                {
                    Session["playerGuess"] = userGuess.Text;
                    Response.Redirect("gameEnd.aspx");
                }

                userGuess.Text = string.Empty;
            }
        }
    }
}