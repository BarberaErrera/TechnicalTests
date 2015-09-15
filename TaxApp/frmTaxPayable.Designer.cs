namespace TaxApp
{
    partial class frmTaxPayable
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
            this.btnCalcTax = new System.Windows.Forms.Button();
            this.lblAnnualSalary = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.txtSalaryPerAnnum = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtTaxPayable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcTax
            // 
            this.btnCalcTax.Location = new System.Drawing.Point(46, 96);
            this.btnCalcTax.Name = "btnCalcTax";
            this.btnCalcTax.Size = new System.Drawing.Size(75, 23);
            this.btnCalcTax.TabIndex = 3;
            this.btnCalcTax.Text = "Calculate Tax";
            this.btnCalcTax.UseVisualStyleBackColor = true;
            this.btnCalcTax.Click += new System.EventHandler(this.btnCalcTax_Click);
            // 
            // lblAnnualSalary
            // 
            this.lblAnnualSalary.AutoSize = true;
            this.lblAnnualSalary.Location = new System.Drawing.Point(43, 30);
            this.lblAnnualSalary.Name = "lblAnnualSalary";
            this.lblAnnualSalary.Size = new System.Drawing.Size(72, 17);
            this.lblAnnualSalary.TabIndex = 1;
            this.lblAnnualSalary.Text = "Salary p/a";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(43, 60);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(33, 17);
            this.lbAge.TabIndex = 2;
            this.lbAge.Text = "Age";
            // 
            // txtSalaryPerAnnum
            // 
            this.txtSalaryPerAnnum.Location = new System.Drawing.Point(153, 27);
            this.txtSalaryPerAnnum.Name = "txtSalaryPerAnnum";
            this.txtSalaryPerAnnum.Size = new System.Drawing.Size(161, 22);
            this.txtSalaryPerAnnum.TabIndex = 1;
            this.txtSalaryPerAnnum.Text = "0.00";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(153, 55);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(64, 22);
            this.txtAge.TabIndex = 2;
            this.txtAge.Text = "0";
            // 
            // txtTaxPayable
            // 
            this.txtTaxPayable.Location = new System.Drawing.Point(153, 151);
            this.txtTaxPayable.Name = "txtTaxPayable";
            this.txtTaxPayable.ReadOnly = true;
            this.txtTaxPayable.Size = new System.Drawing.Size(151, 22);
            this.txtTaxPayable.TabIndex = 6;
            this.txtTaxPayable.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tax Payable";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 255);
            this.Controls.Add(this.txtTaxPayable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtSalaryPerAnnum);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lblAnnualSalary);
            this.Controls.Add(this.btnCalcTax);
            this.Name = "Form1";
            this.Text = "Tax Payable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcTax;
        private System.Windows.Forms.Label lblAnnualSalary;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.TextBox txtSalaryPerAnnum;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtTaxPayable;
        private System.Windows.Forms.Label label1;
    }
}

