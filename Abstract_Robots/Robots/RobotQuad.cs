using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotQuad : RobotSpy
    {
        //1. עדכנו את הפעולה הבונה כך שתתאים לפעולת במחלקת העל
        public RobotQuad() : base("RobotSpy")
        { }

        public override void MoveBackward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveLeg(i, -1);
        }

        public override void MoveForward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveLeg(i, 1);
        }

        public override void TurnLeft()
        {
            for (int i = 0; i < 2; i++)
                this.MoveLeg(i, -1);
            for (int i = 2; i < 4; i++)
                this.MoveLeg(i, 1);
        }

        public override void TurnRight()
        {
            for (int i = 0; i < 2; i++)
                this.MoveLeg(i, 1);
            for (int i = 2; i < 4; i++)
                this.MoveLeg(i, -1);
        }

        //2. השלימו את התנועות החסרות מתוך המצגת או על הבנתכם

        private void MoveLeg(int legId, int dir)
        {
            SetBatteryStatus(3);
        }

    }

}
