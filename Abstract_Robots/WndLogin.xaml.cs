using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Worker> workers; //אוסף עובדים 
        List<Mission> activeMissions;//אוסף משימות פעילות
        List<RobotSpy> activeRobots; //אוסף רובוטים פעילים

        public MainWindow()
        {
            InitializeComponent();
            workers = sixWorkers();
            eightRobots();
            fivemissions();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Have a robotic day (-:", "Good bye", MessageBoxButton.OK);
            this.Close();
        }


        //משימה 1
        // : כתבו פעולה המחזירה אוסף של 6 עובדים 
        //מנכ"ל אחד, 2 מנהלי תפעול ו-3 עובדי תפעול
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        public List<Worker> sixWorkers()
        {
            List<Worker> list = new List<Worker>();
            list.Add(new OperationalWorker(48, 30, "noya", "123", DateTime.Parse("1.1.2002"), "123"));
            list.Add(new OperationalWorker(43, 24, "or", "45587215641", DateTime.Parse("1.1.2002"), "2145124545"));
            list.Add(new OperationalWorker(21, 30, "nehorai", "45587215641", DateTime.Parse("1.1.2002"), "2145124545"));
            list.Add(new OperationManager(12, 5, 26, "eytan", "231", DateTime.Parse("1.1.2002"), "231"));
            list.Add(new OperationManager(11, 3, 23, "rif", "214850687", DateTime.Parse("1.1.2002"), "212121"));
            list.Add(new GeneralManager("rotem", "456", DateTime.Parse("1.1.2002"), "456", 6000.0, 45));
            return list;

        }
        //משימה 2
        //כתבו פעולה המחזירה אוסף של 8 רובוטים
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        public void eightRobots()
        {
            activeRobots = new List<RobotSpy>();
            activeRobots.Add(new RobotFly());
            activeRobots.Add(new RobotFly());
            activeRobots.Add(new RobotFly());
            activeRobots.Add(new RobotQuad());
            activeRobots.Add(new RobotQuad());
            activeRobots.Add(new RobotQuad());
            activeRobots.Add(new RobotWheels());
            activeRobots.Add(new RobotWheels());
        }
        //משימה 3
        //כתבו פעולה המחזירה אוסף של 5 משימות
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון       
        public void fivemissions()
        {
            activeMissions = new List<Mission>();
            activeMissions.Add(new Mission(DateTime.Parse("1.1.2002"), "4"));
            activeMissions.Add(new Mission(DateTime.Parse("1.1.2002"), "2"));
            activeMissions.Add(new Mission(DateTime.Parse("1.1.2002"), "3"));
            activeMissions.Add(new Mission(DateTime.Parse("1.1.2002"), "5"));
            activeMissions.Add(new Mission(DateTime.Parse("1.1.2002"), "1"));
        }
        //משימה 4
        //login כתבו פעולה המגיבה לללחיצה על כפתור 
        //אם הפרטים לא תואמים לעובד הקיים באוסף העובדים - תוצג הודעה מתאימה
        //WndMain אם כן, יש ליצור מופע של חלון 

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string id = tbxID.Text;
            string psword = tbxPassword.Password;
            foreach (Worker worker in workers)
            {
                if (id.Equals(worker.GetidNumber()) && psword.Equals(worker.Password))
                {
                    WndMain main = new WndMain(worker, activeMissions, activeRobots, workers);
                    main.ShowDialog();
                    return;
                }
            }
        }
    }
}
