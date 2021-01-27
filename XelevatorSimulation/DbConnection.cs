using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace XelevatorSimulation
{
    //
    //this is the class that handle the database connection
    //to get conection, to open the database, to close database
    //and to insert the Elevator events into database table
    //
    public class DbConnection
    {      
        public static OleDbConnection dbCon = new OleDbConnection();
        public static OleDbCommand dbCmd = new OleDbCommand("", dbCon);
        public static OleDbDataReader dbRd;
        public static OleDbDataAdapter dbAdapter;          

        public static string insertData;
        public static string accessData;

        public static string getDbConnection()
        {            
            string dbConnection = "Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source=" +
                Application.StartupPath + "\\ElevatorDatabase.accdb;";

            return dbConnection;
        }
        public static void openDbConnection()
        {
            try
            {
                if (dbCon.State == ConnectionState.Closed)
                {
                    dbCon.ConnectionString = getDbConnection();
                    dbCon.Open();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("System failed to open the database connection!!! " + ex.Message);
            }
        }
        public static void closeDbConnection()
        {
            try
            {
                if (dbCon.State == ConnectionState.Open)
                {
                    dbCon.Close();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("System did not close the database connection!!!" + ex.Message);
            }
        }
        public static void insertDatabase(string action)
        { 
            try
            {
                DbConnection.insertData = "INSERT INTO [ActionDetails] ([elevatorDate],[elevatorTime],[elevatorAction]) VALUES (@data, @time, @action)";
                string date = DateTime.Now.ToShortDateString();
                string time = DateTime.Now.ToLongTimeString();
                
                Form1.admenu.dbList_Box.Items.Add(date + "   " + time + "   " + action);

                DbConnection.dbCmd.Parameters.Clear();
                DbConnection.dbCmd.CommandType = CommandType.Text;
                DbConnection.dbCmd.CommandText = DbConnection.insertData;

                DbConnection.dbCmd.Parameters.AddWithValue("@date", date);
                DbConnection.dbCmd.Parameters.AddWithValue("@time", time);
                DbConnection.dbCmd.Parameters.AddWithValue("@action", action);
                                
                DbConnection.openDbConnection();
                DbConnection.dbRd = DbConnection.dbCmd.ExecuteReader();

                DbConnection.dbRd.Close();
                DbConnection.closeDbConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is: " + ex.Message);
            }         
        }
    }
    
}
