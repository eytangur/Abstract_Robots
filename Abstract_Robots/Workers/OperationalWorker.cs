using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationalWorker : Worker
    {
        private int numHours;
        private int Hoursalary;


        public OperationalWorker(int numHours, int Hoursalary, string name, string id, DateTime bDate, string pass)
            : base(name, id, bDate, pass)
        {
            this.numHours = numHours;
            this.Hoursalary = Hoursalary;
        }

        public override double Salary()
        {
            return this.numHours * this.Hoursalary;
        }

    }
}
