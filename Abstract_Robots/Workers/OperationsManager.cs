using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationManager : Worker
    {
        private string name;
        private string id;
        private string pass;
        private DateTime bDate;
        private int numHours;
        private int Hoursalary;
        private int succesfulprojects;
        public OperationManager(int numHours, int succesfulprojects, int Hoursalary, string name, string id, DateTime bDate, string pass)
            : base(name, id, bDate, pass)
        {
            this.numHours = numHours;
            this.Hoursalary = Hoursalary;
            this.succesfulprojects = succesfulprojects;
        }

        public override double Salary()
        {
            int sum = this.Hoursalary * this.numHours;
            int bonus = (sum * 3 / 100) * this.succesfulprojects;
            return sum + bonus;
        }

    }
}
