
namespace Salley
{
    partial class frmReport
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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.EmpNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpBasicPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpAllowences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtimePay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpTotalPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalPayout = new System.Windows.Forms.Label();
            this.lblReportTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpNo,
            this.EmpName,
            this.EmpCategory,
            this.EmpBasicPay,
            this.EmpAllowences,
            this.overtimePay,
            this.EmpTotalPay});
            this.dgvReport.Location = new System.Drawing.Point(35, 109);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(741, 293);
            this.dgvReport.TabIndex = 15;
            // 
            // EmpNo
            // 
            this.EmpNo.HeaderText = "Employee No";
            this.EmpNo.Name = "EmpNo";
            this.EmpNo.ReadOnly = true;
            // 
            // EmpName
            // 
            this.EmpName.HeaderText = "Employee Name";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // EmpCategory
            // 
            this.EmpCategory.HeaderText = "Employee Category";
            this.EmpCategory.Name = "EmpCategory";
            this.EmpCategory.ReadOnly = true;
            // 
            // EmpBasicPay
            // 
            this.EmpBasicPay.HeaderText = "Basic Pay";
            this.EmpBasicPay.Name = "EmpBasicPay";
            this.EmpBasicPay.ReadOnly = true;
            // 
            // EmpAllowences
            // 
            this.EmpAllowences.HeaderText = "Allowences";
            this.EmpAllowences.Name = "EmpAllowences";
            this.EmpAllowences.ReadOnly = true;
            // 
            // overtimePay
            // 
            this.overtimePay.HeaderText = "Over Time";
            this.overtimePay.Name = "overtimePay";
            this.overtimePay.ReadOnly = true;
            // 
            // EmpTotalPay
            // 
            this.EmpTotalPay.HeaderText = "Total Pay";
            this.EmpTotalPay.Name = "EmpTotalPay";
            this.EmpTotalPay.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkGray;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(701, 414);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotalPayout
            // 
            this.lblTotalPayout.AutoSize = true;
            this.lblTotalPayout.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayout.Location = new System.Drawing.Point(32, 419);
            this.lblTotalPayout.Name = "lblTotalPayout";
            this.lblTotalPayout.Size = new System.Drawing.Size(102, 16);
            this.lblTotalPayout.TabIndex = 17;
            this.lblTotalPayout.Text = "Total Payout: 0";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(287, 38);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(270, 34);
            this.lblReportTitle.TabIndex = 18;
            this.lblReportTitle.Text = "Final Payout Report";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(807, 454);
            this.Controls.Add(this.lblReportTitle);
            this.Controls.Add(this.lblTotalPayout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvReport);
            this.Name = "frmReport";
            this.Text = "Payroll Calculator - Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpBasicPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpAllowences;
        private System.Windows.Forms.DataGridViewTextBoxColumn overtimePay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpTotalPay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalPayout;
        private System.Windows.Forms.Label lblReportTitle;
    }
}