using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class GeneralManager : Worker
    {
        private double monthlySalary;
        private int NumOfRobots;

        public GeneralManager(string name, string id, DateTime bDate, string pass, double monthlySalary, int NumOfRobots)
            : base(name, id, bDate, pass)
        {
            this.monthlySalary = monthlySalary;
            this.NumOfRobots = NumOfRobots;
        }

        public override double Salary()
        {
            double bonus = 0;
            if (this.NumOfRobots >= 30) { bonus = monthlySalary * 15 / 100.0; }
            return monthlySalary + bonus;
        }
    }
}
