/*Lefaso Bongani Mabizela
 * 2016074458
 * CSIS 2614 Project1*/
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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            //Close this form
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
