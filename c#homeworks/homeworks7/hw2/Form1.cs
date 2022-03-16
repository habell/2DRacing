using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2
{
    public partial class Form1 : Form
    {
        GameGuest gameGuestNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно закрываем приложение?", "Предупреждение", MessageBoxButtons.YesNo)==DialogResult.Yes)
            this.Close();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (gameGuestNumber == null)
            {
                MessageBox.Show("Начните игру сперва!");
                return;
            }
            int n;
            bool flag = int.TryParse(textBox1.Text, out n);
            if (!flag)
            {
                MessageBox.Show("ВВедите число!"); 
                return;
            }
            entryHistory.Text += gameGuestNumber.Attempt(n)+" "+n+"\r\n";
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameGuestNumber = new GameGuest();
            gameGuestNumber.updateInfo += GameGuestNumber_updateInfo;
            gameGuestNumber.CountEnded += GameGuestNumber_CountEnded;
            GameGuestNumber_updateInfo();
        }

        private void GameGuestNumber_CountEnded(string message)
        {
            MessageBox.Show(message);
        }

        private void GameGuestNumber_updateInfo()
        {
            label1.Text = gameGuestNumber.counter.ToString();
            maxAttempt.Text = gameGuestNumber.attemotCount.ToString();
        }

        private void entryHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Enter.PerformClick();
        }
    }
}
