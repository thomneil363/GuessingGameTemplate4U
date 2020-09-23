using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class ResultScreen : UserControl
    {



        public ResultScreen()
        {
            InitializeComponent();
        }

        private void ResultScreen_Load(object sender, EventArgs e)
        {
            List<int> finalList = new List<int>(Form1.guesses);

            List<int> sortedList = new List<int>(Form1.guesses);

            sortedList.Sort();

            guessesOutput.Text = ((guessesOutput.Text) + (finalList.Count().ToString()));

            listOutput.Text = "";

            sortedListOutput.Text = "";

            for (int i = 0; i < finalList.Count(); i++)

            {

                listOutput.Text += finalList[i] + ", ";

            }

            for (int i = 0; i < sortedList.Count(); i++)

            {

                sortedListOutput.Text += sortedList[i] + ": ";

            }

        }
    }
}
