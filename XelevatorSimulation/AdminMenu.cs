using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
// @Robert Bradu
//  
namespace XelevatorSimulation
{
    public partial class AdminMenu : Form
    {
        //
        //object that have been delefated to the EvelatorButtons Class
        //
        public delegate void ButtonAdminClicked(object sender, EventArgs e);
        public static event ButtonAdminClicked OnBtnAdminClicked1;
        public static event ButtonAdminClicked OnBtnAdminClicked0;
        public static event ButtonAdminClicked OnBtnAdminClickedOpen;
        public static event ButtonAdminClicked OnBtnAdminClickedClose;
        public static event ButtonAdminClicked OnBtnAdminClickedAlarm;
        

        public AdminMenu()
        {
            InitializeComponent();            
        }

        public void AdminMenu_Load(object sender, EventArgs e)
        {
            //lblAdminName.Text = "You are Logged as: " + GetLogId.idName;             
        }

        public void admin_btn1_Click(object sender, EventArgs e)
        {                     
            admin_btn1.BackColor = Color.Red;
            admin_btn1.ForeColor = Color.Red;
            OnBtnAdminClicked1(sender, e);            
            btn_color_delay();
        }

        public void admin_btn0_Click(object sender, EventArgs e)
        {
            admin_btn0.BackColor = Color.Red;
            admin_btn0.ForeColor = Color.Red;
            OnBtnAdminClicked0(sender, e);            
            btn_color_delay();
        }    

        public void admin_btnOpen_Click(object sender, EventArgs e)
        {
            admin_btnOpen.BackColor = Color.Red;
            OnBtnAdminClickedOpen(sender, e);
            //btn_color_delay();        
        }

        public void admin_btnClose_Click(object sender, EventArgs e)
        {
            admin_btnClose.BackColor = Color.Red;
            OnBtnAdminClickedClose(sender, e);
            //btn_color_delay();            
        }

        public void admin_btnAlarm_Click(object sender, EventArgs e)
        {
            admin_btnAlarm.BackColor = Color.GreenYellow;
            admin_btnAlarm.ForeColor = Color.GreenYellow;
            OnBtnAdminClickedAlarm(sender, e);            
            //btn_color_delay();            
        }

        public async void btn_color_delay()
        {
            await Task.Delay(4000);
            admin_btn0.BackColor = Color.Black;
            admin_btn0.ForeColor = Color.White;
            admin_btn1.BackColor = Color.Black;
            admin_btn1.ForeColor = Color.White;
            admin_btnClose.BackColor = Color.Black;
            admin_btnOpen.BackColor = Color.Black;
            admin_btnAlarm.BackColor = Color.Black;
            admin_btnAlarm.ForeColor = Color.White;
        }
        public void btn_displayLog_Click(object sender, EventArgs e)
        {   
            //here is to check if the database table is empty or not
            try
            {
                DataSet ds = new DataSet();
                DbConnection.accessData = "SELECT * FROM  ActionDetails;";

                DbConnection.dbCmd.Parameters.Clear();
                DbConnection.dbCmd.CommandType = CommandType.Text;
                DbConnection.dbCmd.CommandText = DbConnection.accessData;

                DbConnection.openDbConnection();

                DbConnection.dbAdapter = new OleDbDataAdapter(DbConnection.dbCmd);
                DbConnection.dbAdapter.Fill(ds);

                DbConnection.closeDbConnection();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dbList_Box.Items.Add(row["elevatorDate"] + " - " + row["elevatorTime"] + " - " + row["elevatorAction"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The error is: " + ex.Message);
            }

            if (dbList_Box.Items.Count == 0)
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("The Database Log Events is empty!");
                }
            }    // end of part if the database is empty
            
                 // this is part where is displaying the Log Events from database if is not empty
            else {
                try
                {
                    DataSet ds = new DataSet();
                    DbConnection.accessData = "SELECT * FROM  ActionDetails;";

                    DbConnection.dbCmd.Parameters.Clear();
                    DbConnection.dbCmd.CommandType = CommandType.Text;
                    DbConnection.dbCmd.CommandText = DbConnection.accessData;

                    DbConnection.openDbConnection();

                    DbConnection.dbAdapter = new OleDbDataAdapter(DbConnection.dbCmd);
                    DbConnection.dbAdapter.Fill(ds);

                    DbConnection.closeDbConnection();

                    dbList_Box.Items.Clear();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dbList_Box.Items.Add(row["elevatorDate"] + " - " + row["elevatorTime"] + " - " + row["elevatorAction"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The error is: " + ex.Message);
                } 
            }            
        }

        public void btn_clearLog_Click(object sender, EventArgs e)
        {
            if (dbList_Box.Items.Count == 0)
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("The List Log Events is empty!");
                }                             
            }
            else
            {
                dbList_Box.Items.Clear();
            }
        }

        public void btn_close_Click(object sender, EventArgs e)
        {
            using (new CenterWinDialog(this))
            {

                DialogResult dialogResult = MessageBox.Show("Do you want to close Administrator Menu?  Yes/No", "Close Admin Menu", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    dbList_Box.Items.Clear();
                    DbConnection.insertDatabase(GetLogId.idName + " has been LOGGED OUT from the Administrator Control Panel");
                }
            }
        }

        public void btn_delete_Click(object sender, EventArgs e)
        {             
            using (new CenterWinDialog(this))
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete all Log Events?  Yes/No", "Delete DataBase LogEvents", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                    try
                    {
                        DbConnection.accessData = "DELETE * FROM  ActionDetails;";

                        DbConnection.dbCmd.Parameters.Clear();
                        DbConnection.dbCmd.CommandType = CommandType.Text;
                        DbConnection.dbCmd.CommandText = DbConnection.accessData;

                        DbConnection.openDbConnection();
                        DbConnection.dbRd = DbConnection.dbCmd.ExecuteReader();

                        DbConnection.dbRd.Close();
                        DbConnection.closeDbConnection();

                        dbList_Box.Items.Clear();
                        DbConnection.insertDatabase(GetLogId.idName + " has been DELETED the database from the admin menu");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The error is: " + ex.Message);
                    }
                }
            }
        }
    }
}
