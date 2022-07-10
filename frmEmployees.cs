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
using Microsoft.VisualBasic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Accounting
{
    public partial class frmEmployees : Form
    {
        List<CEmployee> employees;
        public frmEmployees()
        {
            InitializeComponent();
            employees = new List<CEmployee>();
            lstEmployees.DisplayMember = "display";
            LoadEmployees();
            
        }//constructor

        private void LoadEmployees()
        {
            OpenFileDialog dlgFileSave = new OpenFileDialog();
            dlgFileSave.InitialDirectory = Application.StartupPath;
            dlgFileSave.FileName = "Employees.bin";
           
            if (dlgFileSave.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(dlgFileSave.FileName, FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
                employees = (List<CEmployee>)formatter.Deserialize(fs);
                fs.Close();
            }
            PopulateListBox();
            //Open Employees.bin
        }//LoadEmployees

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //Close this frmEmployees
        }//btnClose_Click

        private void btnPayslip_Click(object sender, EventArgs e)
        {
            CEmployee emp = (CEmployee)lstEmployees.SelectedItem;
            frmPayslip form = new frmPayslip();
            form.Display((CEmployee)emp);
            //Show frmPayslip
        }//btnPayslip_Click

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = int.Parse(Interaction.InputBox("Enter number of employees to add", "Add Employee(s)"));
            int j = 0;

            while(j < i) 
            {
                frmAddEmployee form = new frmAddEmployee();
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    lstEmployees.Items.Add(form.Employee);
                    employees.Add(form.Employee);
                }
                j++;
            }
            //Add Employees
        }//btnAdd_Click

        private void PopulateListBox()
        {
            
            foreach (CEmployee item in employees)
            {
                lstEmployees.Items.Add(item);
            }
            //Add items in the lstEmployees
        }//PopulateListBox

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
            //UpdateListBox
        }//lstEmployees_SelectedIndexChanged

        private void nudTax_ValueChanged(object sender, EventArgs e)
        {
            CEmployee.tax = (double)nudTax.Value;
            UpdateListBox();
            //Update list box when value in nudTax_ValueChanged changes
        }//nudTax

        private void nudCommission_ValueChanged(object sender, EventArgs e)
        {
            CComEmployee.commission = (double)nudCommission.Value;
            UpdateListBox();
            //Update list box when value in nudCommission changes
        }//nudCommision_ValueChanged

        private void UpdateListBox()
        {
            CEmployee emp = (CEmployee) lstEmployees.SelectedItem;
            if (emp != null)
            {
                lblDetails.Text = emp.ToString();
            }
            else
            {
                lblDetails.Text = "";
            }
            //update lstEmployees
        }//UpdateListBox()

        private void btnRemove_Click(object sender, EventArgs e)
        {
            employees.Remove((CEmployee)lstEmployees.SelectedItem);
            lstEmployees.Items.Remove((CEmployee)lstEmployees.SelectedItem);
            //Remove Selected Item
        }//btnRemove_Click

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgFileSave = new SaveFileDialog();
            dlgFileSave.InitialDirectory = Application.StartupPath;
            dlgFileSave.FileName = "Employees.bin";
            dlgFileSave.OverwritePrompt = false;

            if (dlgFileSave.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(dlgFileSave.FileName, FileMode.Create);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, employees);
                fs.Close();
            }
            //Save File
        }//btnSave_Click

        private void frmEmployees_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
            //Show frmAbout
        }
    }
}
 