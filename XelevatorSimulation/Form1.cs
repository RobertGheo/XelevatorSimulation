using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
//
// @Robert Bradu
//
namespace XelevatorSimulation
{
    public partial class Form1 : Form
    {
        // instantiate new object
        public static ElevatorButtons insButtons = new ElevatorButtons();
        public static AdminMenu admenu = new AdminMenu();
        LogIn logAccess = new LogIn();        
        

        // elevator car variables and for the doors 

        int y_firstFloor = 129;
        int y_groundFloor = 342;
        int x_doorLeft_close = 222;
        int x_doorLeft_open = 149;
        int x_doorRight_close = 304;
        int x_doorRight_open = 376;

        //set protperties for the elevator instance
        bool move_up = false;
        bool move_down = false;
        
        bool stoped_ground = false;
        bool stoped_first = false;

        public Form1()
        {
            InitializeComponent();
            
            // object that have been delegated in ElevatorButtons Form
            ElevatorButtons.OnBtnInsideClicked1 += ElevatorButtons_OnBtnInsideClicked1;
            ElevatorButtons.OnBtnInsideClicked0 += ElevatorButtons_OnBtnInsideClicked0;
            ElevatorButtons.OnBtnInsideClickedOpen += ElevatorButtons_OnBtnInsideClickedOpen;
            ElevatorButtons.OnBtnInsideClickedClose += ElevatorButtons_OnBtnInsideClickedClose;
            ElevatorButtons.OnBtnInsideClickedAlarm += ElevatorButtons_OnBtnInsideClickedAlarm;
        }

        //
        // <<< timer methods that move the picture objects, the doors and the lift
        //
        
        public void timer_elevator_down_Tick(object sender, EventArgs e)
        {
            if (lift_picture.Top <= y_groundFloor)
            {                
                lift_picture.Top += 1;
            }
            else
            {
                timer_elevator_down.Enabled = false;
                btn_outside_first.Enabled = true;

                door_open_ground();
                stoped_ground = true;

                lift_picture.Image = global::XelevatorSimulation.Properties.Resources.elevator_2; 
                display_panelDown_picture.Image = global::XelevatorSimulation.Properties.Resources.floor_0;
                display_panelUp_picture.Image = global::XelevatorSimulation.Properties.Resources.floor_0;
                insButtons.display_inside.Image = global::XelevatorSimulation.Properties.Resources.floor_0;
                admenu.admin_display.Image = global::XelevatorSimulation.Properties.Resources.floor_0;
            }
        }

        public void timer_elevator_up_Tick(object sender, EventArgs e)
        {
            if (lift_picture.Top >= y_firstFloor)
            {
                lift_picture.Top -= 1;
            }
            else
            {
                timer_elevator_up.Enabled = false;
                btn_outside_ground.Enabled = true;
                                
                door_open_first();
                stoped_first = true;

                lift_picture.Image = global::XelevatorSimulation.Properties.Resources.elevator_2;
                display_panelUp_picture.Image = global::XelevatorSimulation.Properties.Resources.floor_1;
                display_panelDown_picture.Image = global::XelevatorSimulation.Properties.Resources.floor_1;
                insButtons.display_inside.Image = global::XelevatorSimulation.Properties.Resources.floor_1;
                admenu.admin_display.Image = global::XelevatorSimulation.Properties.Resources.floor_1;
            }
        }
        public void timer_open_door_ground_Tick(object sender, EventArgs e)
        {
            if (door_left_picture.Left >= x_doorLeft_open && door_right_picture.Left <= x_doorRight_open)
            {
                door_left_picture.Left -= 1;
                door_right_picture.Left += 1;
            }
            else
            {
                timer_open_door_ground.Enabled = false;
            }
        }
        public void timer_close_door_ground_Tick(object sender, EventArgs e)
        {
            if (door_left_picture.Left <= x_doorLeft_close && door_right_picture.Left >= x_doorRight_close)
            {
                door_left_picture.Left += 1;
                door_right_picture.Left -= 1;
            }
            else 
            {
                timer_close_door_ground.Enabled = false;

                if (move_up == true)
                {
                    lift_picture.Image = global::XelevatorSimulation.Properties.Resources.elevator_2;
                    insButtons.display_inside.Image = global::XelevatorSimulation.Properties.Resources.Up_arrow;
                    display_panelUp_picture.Image = global::XelevatorSimulation.Properties.Resources.Up_arrow;
                    display_panelDown_picture.Image = global::XelevatorSimulation.Properties.Resources.Up_arrow;
                    admenu.admin_display.Image = global::XelevatorSimulation.Properties.Resources.Up_arrow;
                    
                    timer_elevator_up.Enabled = true;
                    move_up = false;
                }
            }
        }
        public void timer_open_door_first_Tick(object sender, EventArgs e)
        {
            if (door_leftUP_picture.Left >= x_doorLeft_open && door_rightUP_picture.Left <= x_doorRight_open)
            {
                door_leftUP_picture.Left -= 1;
                door_rightUP_picture.Left += 1;
            }
            else
            {
                timer_open_door_first.Enabled = false;
            }
        }
        public void timer_close_door_first_Tick(object sender, EventArgs e)
        {
            if (door_leftUP_picture.Left <= x_doorLeft_close && door_rightUP_picture.Left >= x_doorRight_close)
            {
                door_leftUP_picture.Left += 1;
                door_rightUP_picture.Left -= 1;               
            }
            else
            {
                timer_close_door_first.Enabled = false;

                if (move_down == true)
                {
                    lift_picture.Image = global::XelevatorSimulation.Properties.Resources.elevator_2;
                    insButtons.display_inside.Image = global::XelevatorSimulation.Properties.Resources.Down_arrow;
                    display_panelUp_picture.Image = global::XelevatorSimulation.Properties.Resources.Down_arrow;
                    display_panelDown_picture.Image = global::XelevatorSimulation.Properties.Resources.Down_arrow;
                    admenu.admin_display.Image = global::XelevatorSimulation.Properties.Resources.Down_arrow;
                    timer_elevator_down.Enabled = true;
                    move_down = false;
                }
            }
        }    
        //
        // <<<< the elevator controler methodes 
        //
        public void door_close_ground()
        {            
            DbConnection.insertDatabase("Doors are closing at First Floor.");
            timer_close_door_ground.Enabled = true;
            timer_open_door_ground.Enabled = false;            
        }
        public void door_open_ground()
        {
            PlaySound.playDoorOpenGround.Play();
            DbConnection.insertDatabase("Doors are opening at Ground Floor.");            
            timer_close_door_ground.Enabled = false;
            timer_open_door_ground.Enabled = true;
            insButtons.Visible = true;
            door_delay();            
        }
        public void door_close_first()
        {            
            DbConnection.insertDatabase("Doors are closing at First Floor.");
            timer_close_door_first.Enabled = true;
            timer_open_door_first.Enabled = false;            
        }
        public void door_open_first()
        {
            PlaySound.playDoorOpenFirst.Play();
            DbConnection.insertDatabase("Doors are opening at Fist Floor.");
            insButtons.Visible = true;
            timer_close_door_first.Enabled = false;
            timer_open_door_first.Enabled = true;
            door_delay();          
        }              
        public void going_up()
        {
            PlaySound.playGoUp.Play();
            move_up = true;
            door_close_ground();
            btn_outside_ground.Enabled = false;            
            stoped_ground = false;          
            DbConnection.insertDatabase("Elevator is going up.");
        }
        public void going_down()
        {
            PlaySound.playGoDown.Play();
            move_down = true;
            door_close_first();
            btn_outside_first.Enabled = false;                     
            stoped_first = false;      
            DbConnection.insertDatabase("Elevator is going down.");
        }       
        //
        // outside buttons that call the elevator up and down
        //
        public void btn_outside_ground_Click(object sender, EventArgs e)
        {           
            btn_outside_ground.BackColor = Color.Maroon;
            btn_outside_first.BackColor = Color.Black;
            going_down();            
            DbConnection.insertDatabase("Outside ground floor button pressed!");            
        }
        public void btn_outside_first_Click(object sender, EventArgs e)
        {            
            btn_outside_first.BackColor = Color.Maroon;
            btn_outside_ground.BackColor = Color.Black;
            going_up();
            DbConnection.insertDatabase("Outside first floor button pressed!");           
        }
        //
        // <<<<< this part is to automate the function doors and buttons with Delay methods
        // <<<<< Using Delay method to automate the Elevator functionality
        //
        public async void door_delay() //this is used to close the doors after 4 second autmoated
        {
            await Task.Delay(4000);
            if (stoped_first == true)
            {                
                PlaySound.playDoorClosing.Play();
                timer_close_door_first.Enabled = true;

                DbConnection.insertDatabase("Doors are closing at First Floor.");                
            }
            else if (stoped_ground == true)
            {                
                PlaySound.playDoorClosing.Play();
                timer_close_door_ground.Enabled = true;
                DbConnection.insertDatabase("Doors are closing at Ground Floor.");
            }            
            btn_outside_first.BackColor = Color.Black;
            btn_outside_ground.BackColor = Color.Black;
            panel_display();           
        }
        public async void panel_display()
        {
            await Task.Delay(2000);
            insButtons.Visible = false;
            insButtons.btn_inside_open.BackColor = Color.Black;
            insButtons.btn_inside_close.BackColor = Color.Black;
            admenu.admin_btnClose.BackColor = Color.Black;
            admenu.admin_btnOpen.BackColor = Color.Black;
        }
        public  async void panel_delay()
        {
            await Task.Delay(2200);
            insButtons.Visible = false;
            insButtons.btn_inside_1.BackColor = Color.Black;
            insButtons.btn_inside_1.ForeColor = Color.White;
            insButtons.btn_inside_0.BackColor = Color.Black;
            insButtons.btn_inside_0.ForeColor = Color.White;                       
        }       
        public async void panel_visible()
        {
            await Task.Delay(1500);
            insButtons.Visible = true;
        }
        public async void alarm_delay()
        {                         
            await Task.Delay(2600);
            PlaySound.playTeam.Play();
            /*using (new CenterWinDialog(this))   //this was used to show a message before implemented the sound
            {
                MessageBox.Show("Emergency Team have been alerted!!!");
            } 
            */  
            DbConnection.insertDatabase("Emergency Team have been alerted!!!");            
            insButtons.Visible = true;
            insButtons.Enabled = false;            
            enableButtons();
        }
        public async void enableButtons()    // this is to make the elevator running back
        {
            await Task.Delay(5500);
            PlaySound.playOnline.Play();
            insButtons.Enabled = true;
            insButtons.btn_inside_alarm.BackColor = Color.Black;
            insButtons.btn_inside_alarm.ForeColor = Color.White;
            admenu.admin_btnAlarm.BackColor = Color.Black;
            admenu.admin_btnAlarm.ForeColor = Color.White;

            display_panelUp_picture.Image = global::XelevatorSimulation.Properties.Resources.OnAndRun;
            display_panelDown_picture.Image = global::XelevatorSimulation.Properties.Resources.OnAndRun;
            insButtons.display_inside.Image = global::XelevatorSimulation.Properties.Resources.OnAndRun;
            admenu.admin_display.Image = global::XelevatorSimulation.Properties.Resources.OnAndRun;                                   
        }
        //
        // end part of automation.>>>>>>>
        //

        //
        //<<<< Buttons that are delegated to the Inside Buttons Panel
        //
        void ElevatorButtons_OnBtnInsideClicked1(object sender, EventArgs e)
        {
            going_up();
            panel_delay();
        }
        void ElevatorButtons_OnBtnInsideClicked0(object sender, EventArgs e)
        {            
            going_down();
            panel_delay();           
        }
        void ElevatorButtons_OnBtnInsideClickedOpen(object sender, EventArgs e)
        {
            if (stoped_ground == true) 
            {
                door_open_ground();
                panel_visible();                
            }
            else if (stoped_first == true)
            {
                door_open_first();
                panel_visible();
            }            
        }
        void ElevatorButtons_OnBtnInsideClickedClose(object sender, EventArgs e)
        {
            if (stoped_ground == true)
            {
                door_close_ground();
                panel_display();
            }
            else if (stoped_first == true)
            {
                door_close_first();
                panel_display();
            }       
        }       
        void ElevatorButtons_OnBtnInsideClickedAlarm(object sender, EventArgs e)
        {
            PlaySound.playAlarm.Play();            
                                          
            timer_elevator_up.Enabled = false;
            timer_elevator_down.Enabled = false;
            timer_close_door_first.Enabled = false;
            timer_close_door_ground.Enabled = false;
            timer_open_door_ground.Enabled = false;
            timer_open_door_ground.Enabled = false;
            /*
            using (new CenterWinDialog(this))
            {
                MessageBox.Show("Emergency mode activated!!!");
            }
            */
            DbConnection.insertDatabase("Alarm button pressed!");

            insButtons.display_inside.Image = global::XelevatorSimulation.Properties.Resources.Alarm_button1;
            display_panelUp_picture.Image = global::XelevatorSimulation.Properties.Resources.Alarm_button1;
            display_panelDown_picture.Image = global::XelevatorSimulation.Properties.Resources.Alarm_button1;
            admenu.admin_display.Image = global::XelevatorSimulation.Properties.Resources.Alarm_button1;
            alarm_delay();           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {           
            logAccess.Show();            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            using (new CenterWinDialog(this))
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to close?  Yes/No", "Close Application", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}
