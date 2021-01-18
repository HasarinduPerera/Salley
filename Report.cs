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
    public partial class frmReport : Form
    {
        
        public frmReport(List<String[]> dgvReportPass)
        {
            InitializeComponent();
            int totalPayOut = 0;

            //Disturbute Items to DGV
            for (int row = 0; row < dgvReportPass.Count; row++)
            {
                dgvReport.Rows.Add(dgvReportPass[row][0], 
                    dgvReportPass[row][1], 
                    dgvReportPass[row][2], 
                    dgvReportPass[row][3],
                    dgvReportPass[row][4],
                    dgvReportPass[row][5],
                    dgvReportPass[row][6]);
            }

            //Sorting
            dgvReport.Sort(dgvReport.Columns[0], ListSortDirection.Ascending);

            //Totalling
            for (int row = 0; row < dgvReportPass.Count; row++)
            {
                totalPayOut += int.Parse(dgvReportPass[row][6]);
            }

            lblTotalPayout.Text = "Total Payout: " + totalPayOut;

        }

        //Close Button Click
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
