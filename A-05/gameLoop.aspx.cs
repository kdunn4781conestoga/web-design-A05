/*
* FILE			: gameLoop.aspx.cs
* PROJECT		: Assignment 5
* PROGRAMMERS	: Kyle Dunn, David Czachor
* FIRST VERSION : 2022-11-15
* DESCRIPTION	: This file handles all the events called by gameLoop.aspx
*/

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

            // Checks for player name
            string playerName = Session["playerName"] as string;
            if (string.IsNullOrEmpty(playerName))
            {
                Response.Redirect("default.aspx");
            }

            // Checks for maximum number
            int maximumNumber = 0;
            if (Session["maximumNumber"] == null || !Int32.TryParse(Session["maximumNumber"].ToString(), out maximumNumber))
            {
                Response.Redirect("maximumNumber.aspx");
            }

            // Checks for minimum number
            int minimumNumber = 0;
            if (Session["minimumNumber"] == null || !Int32.TryParse(Session["minimumNumber"].ToString(), out minimumNumber))
            {
                minimumNumber = 1;
                Session["minimumNumber"] = minimumNumber;
            }

            // Checks for number to guess
            int numberToGuess = 0;
            if (Session["numberToGuess"] == null || !Int32.TryParse(Session["numberToGuess"].ToString(), out numberToGuess))
            {
                var rand = new Random();
                numberToGuess = rand.Next(2, maximumNumber + 1);

                Session["numberToGuess"] = numberToGuess;
            }

            userGuessRangeValidator.MinimumValue = minimumNumber.ToString();
            userGuessRangeValidator.MaximumValue = maximumNumber.ToString();

            if (!IsPostBack)
            {
                Session["playerGuess"] = null;
            }
            else
            {
                int.TryParse(userGuess.Text, out int guess);

                // Modifies the minimumNumber and maximumNumber if the number guessed is less than or greater than the number to guess
                if (guess < numberToGuess)
                {
                    minimumNumber = guess + 1;
                    Session["minimumNumber"] = minimumNumber;
                }
                else if (guess > numberToGuess)
                {
                    maximumNumber = guess - 1;
                    Session["maximumNumber"] = maximumNumber;
                }
            }

            // Modify the range of the validator
            string rangeMessage = "You must enter a number between " + minimumNumber + " and " + maximumNumber;

            userGuess.Attributes.Add("placeholder", rangeMessage);
            userGuessRangeValidator.ErrorMessage = $"Incorrect Range. {rangeMessage}";

            guessLbl.Text = $"<b>{playerName}</b><br />Please enter your guess.";

            Debug.WriteLine($"Number to guess is {numberToGuess}");
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int.TryParse(userGuess.Text, out int guess);
                int.TryParse(Session["numberToGuess"].ToString(), out int numberToGuess);

                // Redirect to win page if the user guessed the number
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