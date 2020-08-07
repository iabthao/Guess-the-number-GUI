using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chapter14Program8
{
    public partial class Form1 : Form
    {
        private int targetNumber;

        private Random random = new Random();

        private int prevDifference=-1;

        private Color defaultColor;

        public Form1()
        {
            InitializeComponent();
            defaultColor = BackColor;
            GenerateRandomNmber();
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            GenerateRandomNmber();
            Reset();
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            try
            {
                int userNumber = int.Parse(inputText.Text);
                int currDifference = Math.Abs(targetNumber - userNumber);
                displayGuessText.Text += userNumber + "     ";

                if (currDifference == 0)
                {
                    ChangeBackgroundColor(Color.Green);
                    inputText.Enabled = false;
                    MessageBox.Show("Correct!");
                }
                else if (prevDifference != 0)
                {
                    if (currDifference < prevDifference)
                    {
                        ChangeBackgroundColor(Color.Red);
                    }
                    else
                    {
                        ChangeBackgroundColor(Color.Blue);
                    }
                }

                if (userNumber < targetNumber)
                {
                    infoLabel.Text = "Too Low";
                }
                else if (userNumber > targetNumber)
                {
                    infoLabel.Text = "Too High";
                }

                prevDifference = currDifference;
            }
            catch (Exception)
            {

            }
        }

        private void GenerateRandomNmber()
        {
            targetNumber = random.Next(1, 1001);
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            infoLabel.Text = "";
        }

        private void ChangeBackgroundColor(Color color)
        {
            BackColor = color;
        }

        private void Reset()
        {
            inputText.Enabled = true;
            displayGuessText.Text = "";
            ChangeBackgroundColor(defaultColor);
            prevDifference = 0;
            infoLabel.Text = "";
            inputText.Text = "";
        }
    }
}