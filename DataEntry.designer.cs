
namespace Salley
{
    partial class frmEntryEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtAuthLeave = new System.Windows.Forms.TextBox();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.txtNumOfHours = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblNumOfHours = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblLeave = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.EmpNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpBasicPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpAllowences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtimePay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpTotalPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRemainingEntries = new System.Windows.Forms.Label();
            this.btnViewReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Employee Name";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(102, 23);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(121, 20);
            this.txtEmpName.TabIndex = 1;
            // 
            // txtAuthLeave
            // 
            this.txtAuthLeave.Location = new System.Drawing.Point(400, 59);
            this.txtAuthLeave.Name = "txtAuthLeave";
            this.txtAuthLeave.Size = new System.Drawing.Size(100, 20);
            this.txtAuthLeave.TabIndex = 3;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(649, 23);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(100, 20);
            this.txtPayRate.TabIndex = 5;
            // 
            // txtNumOfHours
            // 
            this.txtNumOfHours.Location = new System.Drawing.Point(400, 23);
            this.txtNumOfHours.Name = "txtNumOfHours";
            this.txtNumOfHours.Size = new System.Drawing.Size(100, 20);
            this.txtNumOfHours.TabIndex = 6;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Executives",
            "Non-executives",
            "Casual Workers"});
            this.cbCategory.Location = new System.Drawing.Point(102, 58);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 7;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_09_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 62);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            // 
            // lblNumOfHours
            // 
            this.lblNumOfHours.AutoSize = true;
            this.lblNumOfHours.Location = new System.Drawing.Point(257, 26);
            this.lblNumOfHours.Name = "lblNumOfHours";
            this.lblNumOfHours.Size = new System.Drawing.Size(128, 13);
            this.lblNumOfHours.TabIndex = 9;
            this.lblNumOfHours.Text = "Number of Hours Worked";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(525, 26);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(118, 13);
            this.lblPayRate.TabIndex = 10;
            this.lblPayRate.Text = "Pay Rate Per Hour (Rs)";
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.Location = new System.Drawing.Point(257, 62);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(128, 13);
            this.lblLeave.TabIndex = 11;
            this.lblLeave.Text = "Authorised Leaves (Days)";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(649, 53);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 26);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(528, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 26);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpNo,
            this.EmpName,
            this.EmpCategory,
            this.EmpBasicPay,
            this.EmpAllowences,
            this.overtimePay,
            this.EmpTotalPay});
            this.dgvResults.Location = new System.Drawing.Point(15, 105);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(734, 186);
            this.dgvResults.TabIndex = 14;
            // 
            // EmpNo
            // 
            this.EmpNo.HeaderText = "Employee No";
            this.EmpNo.Name = "EmpNo";
            // 
            // EmpName
            // 
            this.EmpName.HeaderText = "Employee Name";
            this.EmpName.Name = "EmpName";
            // 
            // EmpCategory
            // 
            this.EmpCategory.HeaderText = "Employee Category";
            this.EmpCategory.Name = "EmpCategory";
            // 
            // EmpBasicPay
            // 
            this.EmpBasicPay.HeaderText = "Basic Pay";
            this.EmpBasicPay.Name = "EmpBasicPay";
            // 
            // EmpAllowences
            // 
            this.EmpAllowences.HeaderText = "Allowences";
            this.EmpAllowences.Name = "EmpAllowences";
            // 
            // overtimePay
            // 
            this.overtimePay.HeaderText = "Over Time";
            this.overtimePay.Name = "overtimePay";
            // 
            // EmpTotalPay
            // 
            this.EmpTotalPay.HeaderText = "Total Pay";
            this.EmpTotalPay.Name = "EmpTotalPay";
            // 
            // lblRemainingEntries
            // 
            this.lblRemainingEntries.AutoSize = true;
            this.lblRemainingEntries.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingEntries.Location = new System.Drawing.Point(12, 312);
            this.lblRemainingEntries.Name = "lblRemainingEntries";
            this.lblRemainingEntries.Size = new System.Drawing.Size(109, 16);
            this.lblRemainingEntries.TabIndex = 15;
            this.lblRemainingEntries.Text = "Remaining Entries :";
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnViewReport.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnViewReport.Location = new System.Drawing.Point(649, 306);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(100, 27);
            this.btnViewReport.TabIndex = 16;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // frmEntryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(766, 347);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.lblRemainingEntries);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblLeave);
            this.Controls.Add(this.lblPayRate);
            this.Controls.Add(this.lblNumOfHours);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtNumOfHours);
            this.Controls.Add(this.txtPayRate);
            this.Controls.Add(this.txtAuthLeave);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblName);
            this.Name = "frmEntryEditor";
            this.Text = "Payroll Calculator - Entry Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtAuthLeave;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.TextBox txtNumOfHours;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblNumOfHours;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblRemainingEntries;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpBasicPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpAllowences;
        private System.Windows.Forms.DataGridViewTextBoxColumn overtimePay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpTotalPay;
        private System.Windows.Forms.Button btnViewReport;
    }
}