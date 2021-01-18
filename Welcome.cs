using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salley
{
    public partial class frmSplash : Form
    {
        int isCheck;
        public frmSplash()
        {
            InitializeComponent();
            btnReset.Enabled = false;
        }

        //Submit(Enter) Button Click
        private void btnEmpNoSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtNumOfEmp.Text, out isCheck))
                {
                    var empNumberPass = int.Parse(txtNumOfEmp.Text);
                    if (empNumberPass > 0)
                    {
                        frmEntryEditor frmEditor = new frmEntryEditor(empNumberPass);
                        frmEditor.Show();
                        txtNumOfEmp.Enabled = false;
                        btnEmpNoSubmit.Enabled = false;
                        btnReset.Enabled = true;
                    }

                    else
                    {
                        MessageBox.Show("Please Enter The Correct Number of Employees! Value Must Be At Least One.");
                        txtNumOfEmp.Focus();
                        txtNumOfEmp.Clear();
                    }
                }

                else
                {
                    MessageBox.Show("Please Enter The Number of Employees!");
                    txtNumOfEmp.Focus();
                    txtNumOfEmp.Clear();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Resetting
        private void btnReset_09_Click(object sender, EventArgs e)
        {
            txtNumOfEmp.Enabled = true;
            txtNumOfEmp.Clear();
            btnEmpNoSubmit.Enabled = true;

            //Closing Entry Editor Form
            frmEntryEditor editorform = (frmEntryEditor)Application.OpenForms["frmEntryEditor"];
            if (editorform != null)
            {
                editorform.Close();
            }

            //Closing Report Form
            frmReport reportform = (frmReport)Application.OpenForms["frmReport"];
            if (reportform != null)
            {
                reportform.Close();
            }

            btnReset.Enabled = false;
        }

    }
}
