namespace Salary_Calculator
{
    partial class SalaryUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.basicRentTextBox = new System.Windows.Forms.TextBox();
            this.houseRentTextBox = new System.Windows.Forms.TextBox();
            this.medicalAllowanceTextbox = new System.Windows.Forms.TextBox();
            this.showMeSalarybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(49, 68);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Basic Rent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "House Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Medical Allowance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "% of basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "% of basic";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(121, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(212, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // basicRentTextBox
            // 
            this.basicRentTextBox.Location = new System.Drawing.Point(121, 65);
            this.basicRentTextBox.Name = "basicRentTextBox";
            this.basicRentTextBox.Size = new System.Drawing.Size(212, 20);
            this.basicRentTextBox.TabIndex = 2;
            // 
            // houseRentTextBox
            // 
            this.houseRentTextBox.Location = new System.Drawing.Point(121, 105);
            this.houseRentTextBox.Name = "houseRentTextBox";
            this.houseRentTextBox.Size = new System.Drawing.Size(212, 20);
            this.houseRentTextBox.TabIndex = 3;
            // 
            // medicalAllowanceTextbox
            // 
            this.medicalAllowanceTextbox.Location = new System.Drawing.Point(121, 147);
            this.medicalAllowanceTextbox.Name = "medicalAllowanceTextbox";
            this.medicalAllowanceTextbox.Size = new System.Drawing.Size(212, 20);
            this.medicalAllowanceTextbox.TabIndex = 4;
            // 
            // showMeSalarybutton
            // 
            this.showMeSalarybutton.Location = new System.Drawing.Point(173, 193);
            this.showMeSalarybutton.Name = "showMeSalarybutton";
            this.showMeSalarybutton.Size = new System.Drawing.Size(126, 23);
            this.showMeSalarybutton.TabIndex = 5;
            this.showMeSalarybutton.Text = "Show Me Salary";
            this.showMeSalarybutton.UseVisualStyleBackColor = true;
            this.showMeSalarybutton.Click += new System.EventHandler(this.showMeSalarybutton_Click);
            // 
            // SalaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 254);
            this.Controls.Add(this.showMeSalarybutton);
            this.Controls.Add(this.medicalAllowanceTextbox);
            this.Controls.Add(this.houseRentTextBox);
            this.Controls.Add(this.basicRentTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Name = "SalaryUI";
            this.Text = "Salary CalculatorUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox basicRentTextBox;
        private System.Windows.Forms.TextBox houseRentTextBox;
        private System.Windows.Forms.TextBox medicalAllowanceTextbox;
        private System.Windows.Forms.Button showMeSalarybutton;
    }
}

