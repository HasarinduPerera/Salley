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
    public partial class frmEntryEditor : Form
    {
        int empNumber = 0;

        int exCountMemory = 1;
        int neCountMemory = 1;
        int cwCountMemory = 1;

        List<String[]> employeePass = new List<String[]>();
        
        int isCheck;
        //char isCheckName;
        public frmEntryEditor(int empNumberPass)
        {
            InitializeComponent();
            empNumber = empNumberPass;
            lblRemainingEntries.Text = "Remaining Entries : " + empNumber.ToString();
            btnViewReport.Enabled = false;
        }

        private void cbCategory_09_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int dropDownCheck = cbCategory.SelectedIndex;
            if (dropDownCheck == 2)
            {
                txtAuthLeave.Enabled = false;
                lblLeave.Enabled = false;
            }
            else
            {
                txtAuthLeave.Enabled = true;
                lblLeave.Enabled = true;
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (empNumber > 0) //Validating Max Employee Number
                {
                    
                    //bool nameValidation = !Regex.IsMatch(txtEmpName_09.Text, @"[a-zA-Z]");

                    bool commonValidation = txtEmpName.Text != "" & int.TryParse(txtNumOfHours.Text, out isCheck) & int.TryParse(txtPayRate.Text, out isCheck);
                    bool leaveValidation = int.TryParse(txtAuthLeave.Text, out isCheck);
                    int dropDownCheck = cbCategory.SelectedIndex;


                    if (cbCategory.SelectedItem != null)
                    {

                        //Executive
                        if (dropDownCheck == 0)
                        {
                            if (commonValidation & leaveValidation)
                            {
                                int leavePerMonth = int.Parse(txtAuthLeave.Text);
                                int hoursOfWork = int.Parse(txtNumOfHours.Text);
                                int payRateHoure = int.Parse(txtPayRate.Text);

                                string empName = txtEmpName.Text;
                                string empCategory = cbCategory.Text;

                                int overTimePay = 0;


                                if (hoursOfWork <= 240) // Validate no overtime policy. Assuming month has 30 days.
                                {
                                    if (hoursOfWork > 216 & leavePerMonth <= 3) //Validate Leaves
                                    {
                                        int basicSalary = hoursOfWork * payRateHoure;
                                        int livingAllowance = basicSalary / 100 * 10;
                                        int travellingAllowance = basicSalary / 100 * 5;

                                        int totalAllowance = livingAllowance + travellingAllowance;
                                        int totalPay = basicSalary + totalAllowance;

                                        string empNo = genID(dropDownCheck);

                                        resultsFeed(empNo, empName, empCategory, basicSalary, totalAllowance, overTimePay, totalPay);
                                        dataGridPass(empNo, empName, empCategory, basicSalary, totalAllowance, overTimePay, totalPay);



                                        // Update remaining entries
                                        empNumber--;
                                        lblRemainingEntries.Text = "Remaining Entries : " + empNumber.ToString();
                                        clearFields();
                                        reportBtnEnable();
                                    }

                                    //Calculate Reduced Salary
                                    else
                                    {
                                        int basicSalary = hoursOfWork * payRateHoure;
                                        int reducedPay = (216 - hoursOfWork) * payRateHoure;
                                        int reducedBasicSalary = basicSalary - reducedPay;
                                        int livingAllowance = basicSalary / 100 * 10;
                                        int travellingAllowance = basicSalary / 100 * 5;

                                        int totalAllowance = livingAllowance + travellingAllowance;
                                        int totalPay = reducedBasicSalary + totalAllowance;

                                        MessageBox.Show("Employee Has Taken More Than 3 Leaves! Salary Is Reduced To No Pay Leaves.");

                                        if ( totalPay < 0 || totalAllowance < 0)
                                        {
                                            totalPay = 0;
                                            totalAllowance = 0;
                                        }

                                        string empNo = genID(dropDownCheck);

                                        resultsFeed(empNo, empName, empCategory, basicSalary, totalAllowance, overTimePay, totalPay);
                                        dataGridPass(empNo, empName, empCategory, basicSalary, totalAllowance, overTimePay, totalPay);

                                        // Update remaining entries
                                        empNumber--;
                                        lblRemainingEntries.Text = "Remaining Entries : " + empNumber.ToString();
                                        clearFields();
                                        reportBtnEnable();
                                    }

                                }

                                else
                                {
                                    MessageBox.Show("Executives Are Not Entitled To Overtime! (Maximum value is 240 assuming month has 30 days!)");
                                }
                            }

                            else
                            {
                                MessageBox.Show("Please Enter The Correct Values!");
                            }
                        }


                        //Non_Executive
                        if (dropDownCheck == 1)
                        {
                            if (commonValidation & leaveValidation)
                            {
                                int leavePerMonth = int.Parse(txtAuthLeave.Text);
                                int hoursOfWork = int.Parse(txtNumOfHours.Text);
                                int payRateHoure = int.Parse(txtPayRate.Text);

                                string empName = txtEmpName.Text;
                                string empCategory = cbCategory.Text;




                                if (hoursOfWork > 224 & leavePerMonth <= 2)
                                {
                                    //Overtime
                                    if (hoursOfWork > 240)
                                    {
                                        int basicSalary = 240 * payRateHoure;
                                        int overTimeHours = hoursOfWork - 240;
                                        int overTimePay = 0;
                                        if (overTimeHours < 45)
                                        {
                                            overTimePay = overTimeHours * (payRateHoure + (payRateHoure / 2));
                                        }
                                        else
                                        {
                                            MessageBox.Show("Exceeded Overtime Limit!");
                                            overTimePay = 45 * (payRateHoure + (payRateHoure / 2));
                                        }


                                        int livingAllowance = basicSalary / 100 * 10;


                                        int totalAllowance = livingAllowance;
                                        int totalPay = basicSalary + totalAllowance + overTimePay;

                                        string empNo = genID(dropDownCheck);

                                        resultsFeed(empNo, empName, empCategory, basicSalary, totalAllowance, overTimePay, totalPay);
                                        dataGridPass(empNo, empName, empCategory, basicSalary, totalAllowance, overTimePay, totalPay);

                                        // Update remaining entries
                                        empNumber--;
                                        lblRemainingEntries.Text = "Remaining Entries : " + empNumber.ToString();
                                        clearFields();
                                        reportBtnEnable();
                                    }

                                    //No Overtime
                                    else
                                    {
                                        int basicSalary = hoursOfWork * payRateHoure;
                                        int livingAllowance = basicSalary / 100 * 10;
                                        int overTimePay = 0;

                                        int totalAllowance = livingAllowance;
                                        int totalPay = basicSalary + totalAllowance;

                                        string empNo = genID(dropDownCheck);

                                        resultsFeed(empNo, empName, empCategory, basicSalary, totalAllowance, overTimePay, totalPay);
                                        dataGridPass(empNo, empName, empCategory, basicSalary, totalAllowance, overTimePay, totalPay);

                                        // Update remaining entries
                                        empNumber--;
                                        lblRemainingEntries.Text = "Remaining Entries : " + empNumber.ToString();
                                        clearFields();
                                        reportBtnEnable();
                                    }

                                }

                                else
                                {
                                    MessageBox.Show("Employee Has Taken More Than 2 Leaves!");
                                }
                            }

                            else
                            {
                                MessageBox.Show("Please Enter The Correct Values!");
                            }
                        }

                        //Casual workers
                        if (dropDownCheck == 2)
                        {
                            if (commonValidation)
                            {

                                int hoursOfWork = int.Parse(txtNumOfHours.Text);
                                int payRateHoure = int.Parse(txtPayRate.Text);

                                string empName = txtEmpName.Text;
                                string empCategory = cbCategory.Text;

                                int basicSalary = payRateHoure * hoursOfWork;
                                int overTimePay = 0;
                                int totalAllowance = 0;
                                int totalPay = basicSalary;

                                string empNo = genID(dropDownCheck);

                                resultsFeed(empNo, empName, empCategory, basicSalary, totalAllowance, overTimePay, totalPay);
                                dataGridPass(empNo, empName, empCategory, basicSalary, totalAllowance, overTimePay, totalPay);

                                // Update remaining entries
                                empNumber--;
                                lblRemainingEntries.Text = "Remaining Entries : " + empNumber.ToString();
                                clearFields();
                                reportBtnEnable();
                            }

                            else
                            {
                                MessageBox.Show("Please Enter The Correct Values!");
                            }
                        }

                    }

                    else
                    {
                        MessageBox.Show("Please Select The Pay Scheme! (category)");
                    }

                    
                }

                else
                {
                    lblRemainingEntries.Text = "Remaining Entries : 0";
                    MessageBox.Show("You Have Entered All Entries!");
                    btnAdd.Enabled = false;
                    clearFields();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private string genID(int dropDownCheck)
        {

            if (dropDownCheck == 0)
            {
                string genID = "EX" + exCountMemory.ToString("D3");
                exCountMemory++;
                return genID;

            }

            else if (dropDownCheck == 1)
            {
                
                string genID = "NE" + neCountMemory.ToString("D3");
                neCountMemory++;
                return genID;
               
            }
            else if (dropDownCheck == 2)
            {
                
                string genID = "CW" + cwCountMemory.ToString("D3");
                cwCountMemory++;
                return genID;

            }
            else
            {
                MessageBox.Show("Error Generating EmpID!");
                return null;
            }


        }

        //Feeding Results To DataGridView
        private void resultsFeed(string empNo, string empName, string empCat, int basicPay, int allowancesPay, int overtimePay, int totalPay)
        {
            dgvResults.Rows.Add(empNo, empName, empCat, basicPay, allowancesPay, overtimePay, totalPay);
            
        }

        //Clear Fields
        private void clearFields()
        {
            txtAuthLeave.Clear();
            txtEmpName.Clear();
            txtNumOfHours.Clear();
            txtPayRate.Clear();
            cbCategory.ResetText();
        }

        //Clear Button Click
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
            dgvResults.Rows.Clear();

        }

        //Populate List With Data
        private void dataGridPass(string empNo, string empName, string empCat, int basicPay, int allowancesPay, int overtimePay, int totalPay)
        {
            string strBasicPay = basicPay.ToString();
            string strAllowancesPay = allowancesPay.ToString();
            string strOvertimePay = overtimePay.ToString();
            string strTotalPay = totalPay.ToString();

            employeePass.Add(new String[] { empNo, empName, empCat, strBasicPay, strAllowancesPay, strOvertimePay, strTotalPay });

        }

        //Report Button Click
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport(employeePass);
            frmReport.Show();
        }

        //Enabling Report Button
        private void reportBtnEnable()
        {
            
            if (empNumber == 0)
            {
                btnViewReport.Enabled = true;
            }
        }

    }

    
}
