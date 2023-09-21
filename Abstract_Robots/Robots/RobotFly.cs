using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    //כתבו את המחלקה על פי המחלקות הקודמות
    //שימו לב שעליכם להתייחס גם לתעופה
    class RobotFly : RobotSpy
    {
        private int[] location;

        public RobotFly() : base("RoBoquad") { }

        public override void MoveBackward()
        {
            for (int i = 0; i < 4; i++)
            {
                this.moveLeg(i, -1);
            }
        }
        public override void MoveForward()
        {
            for (int i = 0; i < 4; i++)
            {
                this.moveLeg(i, 1);
            }
        }
        public override void TurnRight()
        {
            this.moveLeg(0, 1);
            this.moveLeg(1, 1);
            this.moveLeg(2, -1);
            this.moveLeg(3, -1);
        }
        public override void TurnLeft()
        {
            this.moveLeg(0, -1);
            this.moveLeg(1, -1);
            this.moveLeg(2, 1);
            this.moveLeg(3, 1);
        }
        public void moveLeg(int i, int j)
        {
            location[i] = j;
            SetBatteryStatus(GetBatteryStatus() - 2);
        }
        private void fly()
        {
            SetBatteryStatus(GetBatteryStatus() - 1.5);
        }
    }
}
