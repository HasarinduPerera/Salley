
namespace Salley
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.btnEmpNoSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtNumOfEmp = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInfoText = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpNoSubmit
            // 
            this.btnEmpNoSubmit.BackColor = System.Drawing.Color.DarkGray;
            this.btnEmpNoSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpNoSubmit.Location = new System.Drawing.Point(183, 282);
            this.btnEmpNoSubmit.Name = "btnEmpNoSubmit";
            this.btnEmpNoSubmit.Size = new System.Drawing.Size(75, 28);
            this.btnEmpNoSubmit.TabIndex = 1;
            this.btnEmpNoSubmit.Text = "Enter";
            this.btnEmpNoSubmit.UseVisualStyleBackColor = false;
            this.btnEmpNoSubmit.Click += new System.EventHandler(this.btnEmpNoSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkGray;
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(264, 282);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 28);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_09_Click);
            // 
            // txtNumOfEmp
            // 
            this.txtNumOfEmp.Location = new System.Drawing.Point(183, 252);
            this.txtNumOfEmp.Name = "txtNumOfEmp";
            this.txtNumOfEmp.Size = new System.Drawing.Size(156, 20);
            this.txtNumOfEmp.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblName.Location = new System.Drawing.Point(109, 167);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(312, 45);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Payroll Calculator";
            // 
            // lblInfoText
            // 
            this.lblInfoText.AutoSize = true;
            this.lblInfoText.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoText.Location = new System.Drawing.Point(146, 223);
            this.lblInfoText.Name = "lblInfoText";
            this.lblInfoText.Size = new System.Drawing.Size(236, 16);
            this.lblInfoText.TabIndex = 5;
            this.lblInfoText.Text = "Enter The Number of Employees Below";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(141, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(245, 152);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(522, 333);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblInfoText);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtNumOfEmp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEmpNoSubmit);
            this.Name = "frmSplash";
            this.Text = "Salley - Payroll Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmpNoSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtNumOfEmp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInfoText;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

