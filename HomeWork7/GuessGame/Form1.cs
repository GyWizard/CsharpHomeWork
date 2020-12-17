using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame
{
    public partial class Form1 : Form
    {
        public int n = 0;
        int g = 0;
        int s = 0;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            n = r.Next(0, 100);
        }

        private void guess_Click(object sender, EventArgs e)
        {
            
            if(Int32.TryParse(inText.Text, out g))
            {
                s++;
                steps.Text= $"Попыток : {s}";
                if (g > n) { outTxt.Text = "СЛИШКОМ БОЛЬШОЕ"; }
                if (g < n) { outTxt.Text = "СЛИШКОМ МАЛЕНЬКОЕ"; }
                if (g == n) 
                {
                    MessageBox.Show($"УГАДАЛИ! ЧИСЛО = {n}! Попыток : {s}");
                    outTxt.Text = "УГАДАЙ ЧИСЛО";
                    n = r.Next(0, 100);
                    g = 0;
                    s = 0;
                    inText.Text = "";
                }

            }
            else
            {
                outTxt.Text = "НУЖНО ВВЕСТИ ЧИСЛО!";
            }
        }
    }
}
