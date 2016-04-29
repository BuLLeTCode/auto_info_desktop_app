using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AutoInformacijasUzskaite
{
    class MySQLManager
    {
        //variables for Mysql connection
        private MySqlConnection connection;
        private string server = "raivisr.me";
        private string database = "auto_info";
        private string uid = "root";
        private string password = "aspirine11";

        public MySQLManager()
        {
            CreateDBConnection();//Inicialize object by creating connection to DB
        }

        private void CreateDBConnection()
        {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //Open connection to DB
        public bool OpenDBConnection()
        {
            try
            {
                if(connection.State == System.Data.ConnectionState.Open)//Maybe already open - safety first!
                {
                    return true;
                }
                
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        //-------------------------------------SELECT
        //For getting user cars
        public List<string> SelectUserCars()
        {
            string query = "SELECT * FROM auto";

            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (OpenDBConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["Razotajs"] + " " + dataReader["Marka"] + " " +dataReader["Gads"]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string> SelectCarServices(string carMan, string carMod, string carYear)
        {
            string query = "SELECT * FROM auto_details WHERE Auto_Razotajs='" + carMan +"' AND Auto_Marka='"+ carMod +"' AND Auto_Gads='"+ carYear +"'";

            //Create a list to store the result
            List<string> list = new List<string>();
           

            //Open connection
            if (this.OpenDBConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    /*
                    list[0].Add(dataReader["Apkopes_veids"] + "");
                    list[1].Add(dataReader["Date"] + "");
                    list[2].Add(dataReader["Izmaksas"] + "");
                    list[3].Add(dataReader["Komentari"] + "");
                    */

                    list.Add(dataReader["Apkopes_veids"] + "|" + dataReader["Date"] + "|" + dataReader["Izmaksas"] + "|" + dataReader["Komentari"]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        //----------------------------------------SELECT END

        //----------------------------------------INSERT
        //For inserting data
        public bool Insert(string carManufacture, string carModel, string year)
        {
            string query = "INSERT INTO auto (Razotajs, Marka, Gads)VALUES('"+ carManufacture +"', '"+ carModel +"','"+ year +"')";

            //open connection
            if (OpenDBConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Insert(string carInfo, string[]carServiceDetails)
        {
            string[] carInfoSplit = carInfo.Split();
            string query = @"INSERT INTO auto_details (Auto_Marka, Auto_Razotajs, Auto_Gads, Apkopes_veids,
                Date, Izmaksas, Komentari)VALUES('" + carInfoSplit[1] + "', '" + carInfoSplit[0] + "','" + carInfoSplit[2] + "', '"+ carServiceDetails[0] +@"',
                '"+ carServiceDetails[1] +"', '"+ Convert.ToDouble(carServiceDetails[2]) +"', '"+ carServiceDetails[3] +"')";

            //open connection
            if (OpenDBConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();

                return true;
            }
            else
            {
                return false;
            }
        }
        //----------------------------------------INSERT END

            //----------------------------------------DELETE
        public bool DeleteService(string carInfo, string serviceType, string serviceDate, string serviceCost)
        {
            string[] autoDetails = carInfo.Split(' ');
            string query = "DELETE FROM auto_details WHERE Auto_Razotajs='" + autoDetails[0] + "' AND Auto_Marka='"+ autoDetails[1] + @"' AND 
                Auto_Gads='"+ autoDetails[2] + "' AND Date='"+ serviceDate + "' AND Izmaksas='"+ serviceCost +"'";

            if (this.OpenDBConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    this.CloseConnection();
                    return false;
                }
                this.CloseConnection();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
