using Project_Final.Bussiness;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Ado
{
    public class StaffDAO
    {
        string connectionStr;
        public StaffDAO()
        {
            GetConnectionString();
        }

        //Get connection string 
        public void GetConnectionString() {

            connectionStr = ConfigurationManager.ConnectionStrings["Project_PRN"].ConnectionString;
        }

        //Check Login for user
        //Return staffDTO include role and fullName 
        public StaffDTO CheckLogin(string username, string password)
        {
            SqlConnection cnn = null;
            try
            {
                cnn = new SqlConnection(connectionStr);
                if(cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                string SQL = "Select staff_role, staff_name " +
                                "From staff " +
                                "Where staff_username = @username and staff_password = @password and staff_status = 1"; // 1 means true value in DB => Existed staff
                                                                                                                         //Make a command 
                SqlCommand cmd = new SqlCommand(SQL, cnn);

                //Add parameter
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                //Execute command with DataReader
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (reader.HasRows)// if there is a record match with condition
                {
                    reader.Read();
                    StaffDTO staffDTO = new StaffDTO
                    {
                        Role = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    };

                    return staffDTO;
                }
            }
            finally
            {
                if(cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return null; // null mean there is no record match with condition => Wrong user or User doesn't exist.
        }
    }
}
