using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0405hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int CharsTotal = 0;
            string Text = "sample text 1";
            CharsTotal += Text.Length;
            MessageBox.Show(Text);
            Text = "sample text 2";
            CharsTotal += Text.Length;
            MessageBox.Show(Text);
            Text = "sample text 3";
            CharsTotal += Text.Length;
            MessageBox.Show(Text,"Average: " + Convert.ToString(CharsTotal/3) );
            InitializeComponent();
            GuessNumber();
        }
        public void GuessNumber()
        {
            int Attempts = 0;
            MessageBox.Show("Think of a number from 0 to 2000");
            Random r=new Random();
            DialogResult Result;
            while (true)
            {
                Result=MessageBox.Show(Convert.ToString(r.Next(0, 2000)), "Is this your number?", MessageBoxButtons.YesNo);
                Attempts++;
                if (Result == DialogResult.Yes)
                {
                    break;
                }
            }
            MessageBox.Show("It took me " + Convert.ToString(Attempts) + " attempts","Results");
        }
    }
}
