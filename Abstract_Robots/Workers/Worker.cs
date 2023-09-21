using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public abstract class Worker
    {
        private string fullName;
        private string idNumber;
        private DateTime birthDate;
        private string password;


        public Worker(string name, string id, DateTime bDate, string pass)
        {
            this.fullName = name;
            this.idNumber = id;
            this.birthDate = bDate;
            this.password = pass;
        }
        public string Password { get { return password; } set { password = value; } }
        public string FullName { get { return fullName; } }

        public string GetidNumber() { return this.idNumber; }
        public DateTime GetBirthDate() { return this.birthDate; }

        public abstract double Salary();

        public override string ToString()
        {
            string str = "";
            if (birthDate.Equals(DateTime.Today))
                str = " - HappyBirthDay";
            return fullName + " ID." + idNumber + str;

        }
    }
}
