using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace WinFormsExample
{
    public partial class Form1 : Form
    {
        Employees database=null;

        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tsslCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckDatabase() 
        {
            if (database == null)
            {
                MessageBox.Show("Создайте базу данных");
                return false;
            }
            return true;
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            if (!CheckDatabase()) return; //homework 3

            frmAddEmployee frmAddEmployee = new frmAddEmployee();
            frmAddEmployee.ShowDialog();
            if (frmAddEmployee.DialogResult == DialogResult.OK)
            {
                database.Add(frmAddEmployee.Employee);
                UpdateInfo();
            }
        }

        private void UpdateInfo()
        {
            if (!CheckDatabase()) return; //homework 3
            Employee employee = database?.CurrentEmployee;
            if (employee == null)
            {
                tbName.Text = "";
                tbDescribe.Text = "";
                tbPosition.Text = "";
                tslIndex.Text = "-1";
                return;
            }
            tbName.Text = employee.Name;
            tbDescribe.Text = employee.Describe;
            tbPosition.Text = employee.Position;
            dtpBirthDay.Value = employee.BirthDay;
            tslIndex.Text = database.CurrentIndex.ToString();
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            database = new Employees();
        }

        private void tsbPrev_Click(object sender, EventArgs e)
        {
            if (!CheckDatabase()) return; //homework 3
            database.Prev();
            UpdateInfo();
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            if (!CheckDatabase()) return; //homework 3
            database.Next();
            UpdateInfo();
        }

        private void tsbRemove_Click(object sender, EventArgs e)
        {
            if (!CheckDatabase()) return; //homework 3
            database?.Remove();
            UpdateInfo();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckDatabase()) return; //homework 3
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML файл|*.XML|Все файлы|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database.Save(dialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML файл|*.XML|Все файлы|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database = new Employees();
                database.Load(dialog.FileName);
                UpdateInfo();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Андрей Заярный\nVersion 0.2.0\n(C) GeekBrains\nHomework worker: Хаблиев Таймураз"); // homework 3.3
        }
    }
}
