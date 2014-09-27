using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Calculator
{
    public partial class SalaryUI : Form
    {
        
        public SalaryUI()
        {
            InitializeComponent();
        }

        private void showMeSalarybutton_Click(object sender, EventArgs e)
        {
            Empolyee anEmpolyee = new Empolyee();

            anEmpolyee.name = nameTextBox.Text;
            anEmpolyee.basic = Convert.ToDouble(basicRentTextBox.Text);
            anEmpolyee.houseRestPercent = Convert.ToDouble(houseRentTextBox.Text);
            anEmpolyee.medicalAllowncePercent = Convert.ToDouble(medicalAllowanceTextbox.Text);

            anEmpolyee.salary = anEmpolyee.CalculateSalary();

            MessageBox.Show(anEmpolyee.name + @", your salary is" +Convert.ToString(anEmpolyee.salary));
        }

        
    }
}
