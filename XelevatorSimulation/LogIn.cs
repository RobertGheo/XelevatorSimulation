using System;
using System.Data;
using System.Windows.Forms;
//
// @Robert Bradu
//
namespace XelevatorSimulation
{
    public partial class LogIn : Form
    {
        //
        //Log in class that check with the database the user accessibility
        //

        public LogIn()
        {
            InitializeComponent();
        }

        public void logInBtn_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(this.idBox.Text.Trim())) || (string.IsNullOrEmpty(this.passwordBox.Text.Trim())))
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("Please insert your ID and password!!!");
                }
                if (this.idBox.CanSelect)
                {
                    this.idBox.Select();
                }
                return;
            }
            DbConnection.insertDatabase(idBox.Text + " has been LOGGED INTO the Administrator Control Panel");
           
            try
            {
                DbConnection.accessData = "SELECT adminUser, passwordUser FROM LoginDetails WHERE adminUser = @ad AND passwordUser = @pa";

                DbConnection.dbCmd.Parameters.Clear();
                DbConnection.dbCmd.CommandType = CommandType.Text;
                DbConnection.dbCmd.CommandText = DbConnection.accessData;

                DbConnection.dbCmd.Parameters.AddWithValue("@ad", this.idBox.Text.Trim().ToString());
                DbConnection.dbCmd.Parameters.AddWithValue("@pa", this.passwordBox.Text.Trim().ToString());

                DbConnection.openDbConnection();

                DbConnection.dbRd = DbConnection.dbCmd.ExecuteReader();

                if (DbConnection.dbRd.HasRows)
                {
                    GetLogId.idName = idBox.Text;
                    using (new CenterWinDialog(this))
                    {
                        MessageBox.Show("Welcome " + idBox.Text + " to the administrator menu!", "Login successful");
                    }
                    this.idBox.Text = string.Empty;
                    this.passwordBox.Text = string.Empty;
                                       
                    this.Hide();

                    //AdminMenu admenu = new AdminMenu();
                    //admenu.Show();
                    Form1.admenu.Show();
                }
                else
                {
                    using (new CenterWinDialog(this))
                    {
                        MessageBox.Show("Invalid Admin ID or password, insert a valid ID and password!");
                    }    
                    if (this.idBox.CanSelect)
                    {
                        this.idBox.Select();
                    }
                }

                DbConnection.dbRd.Close();
                DbConnection.closeDbConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error:  " + ex.Message);
            }            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
