using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    class Empolyee
    {
        public string name;
        public double basic;
        public double houseRestPercent;
        public double medicalAllowncePercent;
        public double salary;
        public double CalculateSalary()
        {
            return basic + GetHouseRentPercentAmount() + GetMadicalAllowancePercentAmount();
        }

        private double GetMadicalAllowancePercentAmount()
        {
            return (basic*houseRestPercent)/100;
        }

        private double GetHouseRentPercentAmount()
        {
            return (basic * medicalAllowncePercent) / 100;
        }
    }
}
