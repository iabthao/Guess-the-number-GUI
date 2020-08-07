using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Program14.8
//Iab Thao

namespace Chapter14Program8
{
    static class Program
    {
        /// <summary>
        /*This application is a “guess the number” program. The app chooses a number in the range 1–1000 by selecting an int at random, 
         * and the player have to guess the number
         * The program then displays the following text in a label: Too high or To low to help player to zero down
         * As each guess is input, the background color should change to red (warmer-close to the number) or blue (colder-far from the number).
         * When the user guesses the correct answer, a message box pops up with the message “Correct!,”
         * Change the Form’s background color to green and disable the TextBox and display all the guesses in a textbox
         * A "Play the game again" button can be clicked, it will generate a new random number and reset the game.
         */
         /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
