using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//
// @Robert Bradu
//
namespace XelevatorSimulation
{
    public partial class ElevatorButtons : Form
    {
        //
        //object that have been delefated to the Form1 Class
        //
        public delegate void ButtonInsideClicked(object sender, EventArgs e);
        public static event ButtonInsideClicked OnBtnInsideClicked1;
        public static event ButtonInsideClicked OnBtnInsideClicked0;
        public static event ButtonInsideClicked OnBtnInsideClickedOpen;
        public static event ButtonInsideClicked OnBtnInsideClickedClose;
        public static event ButtonInsideClicked OnBtnInsideClickedAlarm;

        public ElevatorButtons()
        {
            InitializeComponent();
            
            //Admin button object delegeted.
            AdminMenu.OnBtnAdminClicked1 += AdminMenu_OnBtnAdminClicked1;
            AdminMenu.OnBtnAdminClicked0 += AdminMenu_OnBtnAdminClicked0;
            AdminMenu.OnBtnAdminClickedOpen += AdminMenu_OnBtnAdminClickedOpen;
            AdminMenu.OnBtnAdminClickedClose += AdminMenu_OnBtnAdminClickedClose;
            AdminMenu.OnBtnAdminClickedAlarm += AdminMenu_OnBtnAdminClickedAlarm;
        }
      
        public void btn_inside_1_Click(object sender, EventArgs e)
        {
            btn_inside_1.BackColor = Color.Maroon;
            btn_inside_1.ForeColor = Color.Maroon;
            OnBtnInsideClicked1(sender, e);  
        }

        public void btn_inside_0_Click(object sender, EventArgs e)
        {
            btn_inside_0.BackColor = Color.Maroon;
            btn_inside_0.ForeColor = Color.Maroon;
            OnBtnInsideClicked0(sender, e);           
        }

        public void btn_inside_open_Click(object sender, EventArgs e)
        {
            btn_inside_open.BackColor = Color.Maroon;
            OnBtnInsideClickedOpen(sender, e);
        }

        public void btn_inside_close_Click(object sender, EventArgs e)
        {
            btn_inside_close.BackColor = Color.Maroon;
            OnBtnInsideClickedClose(sender, e);
        }

        public void btn_inside_alarm_Click(object sender, EventArgs e)
        {
            btn_inside_alarm.BackColor = Color.GreenYellow;
            btn_inside_alarm.ForeColor = Color.GreenYellow;
            OnBtnInsideClickedAlarm(sender, e);           
        }

        //<<<<<<<<   >>>>>>>>>>//
        //This part is for Admin Controller///
        //delegated method for Admin
        void AdminMenu_OnBtnAdminClicked1(object sender, EventArgs e)
        {
            btn_inside_1_Click(sender, e);
            DbConnection.insertDatabase("The " + GetLogId.idName + " has pressed the First Floor Button");
        }
        void AdminMenu_OnBtnAdminClicked0(object sender, EventArgs e)
        {            
            btn_inside_0_Click(sender, e);
            DbConnection.insertDatabase("The " + GetLogId.idName + " has pressed the Ground Floor Button");
        }
        void AdminMenu_OnBtnAdminClickedOpen(object sender, EventArgs e)
        {
            btn_inside_open_Click(sender, e);
            DbConnection.insertDatabase("The " + GetLogId.idName + " has pressed the Door Open Button");                        
        }
        void AdminMenu_OnBtnAdminClickedClose(object sender, EventArgs e)
        {
            btn_inside_close_Click(sender, e);
            DbConnection.insertDatabase("The " + GetLogId.idName + " has pressed the Door Close Button");                      
        }
        void AdminMenu_OnBtnAdminClickedAlarm(object sender, EventArgs e)
        {
            btn_inside_alarm_Click(sender, e);
            DbConnection.insertDatabase("The " + GetLogId.idName + " has pressed the Alarm button!");
        }
    }
}
