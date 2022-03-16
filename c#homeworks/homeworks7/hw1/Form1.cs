using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1
{
    public partial class Form1 : Form
    {
        public int count = 0;
        public int numberNeed = 0;
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            this.Text = "Удвоитель";
            btnCommand1.Enabled = false;
            btnCommand2.Enabled = false;
        }

        void PlayerClick(bool btnType)
        {
            count++;
            counter.Text = count.ToString();
            if (btnType) lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            else
                lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();

            if (numberNeed == int.Parse(lblNumber.Text))
            {
                MessageBox.Show("Поздравляю! Вы победили! Использовано попыток: " + count);
                btnReset.PerformClick();
            }
            if (numberNeed < int.Parse(lblNumber.Text))
            {
                MessageBox.Show("Вы проиграли, увы(");
                btnReset.PerformClick();
            }
        }
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            PlayerClick(true);
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            PlayerClick(false);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            counter.Text = "0";
            count = 0;
            btnCommand1.Enabled = false;
            btnCommand2.Enabled = false;
        }
        private void Играть_Click(object sender, EventArgs e)
        {
            numberNeed = new Random().Next(1, 100);
            MessageBox.Show($"Игра началась! Вам необходимо получить число:{numberNeed}");
            btnCommand1.Enabled = true;
            btnCommand2.Enabled = true;
        }
    }
}
