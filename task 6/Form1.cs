using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_6
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string compvibor()
        {
            int choice = random.Next(1, 4);
            switch (choice)
            {
                case 1: return "Rock";
                case 2: return "Paper";
                case 3: return "Scissors";
                default: return "Rock"; 
            }
        }
        private string solve(string user, string comp)
        {
            if (user == comp)
            {
                return "It's a tie! Play again to determine the winner.";
            }
            else if ((user == "Rock" && comp == "Scissors") ||
                     (user == "Scissors" && comp == "Paper") ||
                     (user == "Paper" && comp == "Rock"))
            {
                return "You win!";
            }
            else
            {
                return "Computer wins!";
            }
        }

         private void PlayGame(string user)
        {
            string comp = compvibor();
            string result = solve(user, comp);

            // Display computer's choice and result to the user
            label1.Text = "Computer chose: " + comp;
            label2.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayGame("Rock");
        }
        private void button2_Click(object sender, EventArgs e)
        {

            PlayGame("Paper");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlayGame("Scissors");
        }
    }

}

