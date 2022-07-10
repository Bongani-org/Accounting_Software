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
    public partial class frmPayslip : Form
    {

        public frmPayslip()
        {
            InitializeComponent();
            
        }//constructor
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            //Close frmPayslip
        }//btnOK_Click

        public void Display(CEmployee employee)
        {
            txtDetails.Text = employee.ToString();
            ShowDialog();
            //Add employee details to txtDetails
        }//Display

        private void frmPayslip_Load(object sender, EventArgs e)
        {

        }
    }
}
