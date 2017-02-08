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
    public partial class resultScreen : UserControl
    {
        public resultScreen()
        {
            InitializeComponent();
            guessmadeLabel.Text = "" + Form1.guessNumber;

            for (int i = 0; i < Form1.userGuess.Count; i++)
            {
                originalLabel.Text = " " + Form1.userGuess[i];
            }




        }
    }
}
