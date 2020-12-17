using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleGame
{
    public partial class Form1 : Form
    {
        int n = 0;
        int guessN=0;
        Random r = new Random();
        int step = 0;
        List<int> history = new List<int>();
        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        void RefreshLabels()
        {
            outTxt.Text = n.ToString();
            steps.Text = $"Шагов : {step}";
        }
        void OnValueChange()
        {
            step++;
            RefreshLabels();
            if (n==guessN)
            {
                MessageBox.Show($"Вы достигли нужного числа за {step} шагов !");
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            history.Add(n);
            n += 1;
            OnValueChange();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            history.Add(n);
            n *= 2;
            OnValueChange();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            history.Clear();
            n = 0;
            step = 0;
            RefreshLabels();
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            if(history.Count>0)
            {
                n = history[history.Count - 1];
                history.RemoveAt(history.Count - 1);
                OnValueChange();
            }         
        }

        private void generateNumber_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        void StartGame()
        {
            history.Add(0);
            history.Clear();
            n = 0;
            step = 0;
            guessN = r.Next(1, 100);
            numberToReach.Text = $"Число : {guessN}";
            RefreshLabels();
        }
    }
}
