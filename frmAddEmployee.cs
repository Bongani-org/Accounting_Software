/*Lefaso Bongani Mabizela
 * 2016074458
 * CSIS 2614 Project1*/
using Accounting.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class frmAddEmployee : Form
    {
        private CEmployee employee;

        public frmAddEmployee()
        {
            InitializeComponent();
        }//constructor

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (radCommisioned.Checked)
            {
                employee = new CComEmployee(txtID.Text, txtSurname.Text, txtName.Text, dtpDOB.Value, double.Parse(txtGSalary.Text));
            }
            else
            {
                employee = new CSalEmployee(txtID.Text, txtSurname.Text, txtName.Text, dtpDOB.Value, double.Parse(txtGSalary.Text));
            }
            //Show Details of Employees depending on radio button clicked
        }//btn_OK_Click

        public CEmployee Employee => employee;

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {

        }
    }//frmAddEmployee
}//namespace
