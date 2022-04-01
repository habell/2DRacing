using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsExample
{
    public partial class frmAddEmployee : Form
    {
        public Model.Employee Employee { get; } = new Model.Employee();
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Employee.Name = tbName.Text;
            Employee.Position = tbPosition.Text;
            Employee.Describe = tbDescribe.Text;
            Employee.BirthDay = dtpBirthDay.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
