using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace appRecordCompany.data
{
    class Data
    {
        /*Step 1: Create the connection string*/
        string connectionString = @"Data Source=localhost;User ID=bases1;Password=oracle";

        //Step 2: Create the method that executes a DML operation (insert, update, delete)
        public int ExecuteDML(string query)
        {
            int rowsAffected = 0;
            //Step 1: Create a connection
            OracleConnection myConnection = new OracleConnection(connectionString);

            //Step 2: Create a Command object that sets the SQL statement to be executed in the DB
            OracleCommand myCommand = new OracleCommand(query, myConnection);

            //Step 3: Open the connection
            myConnection.Open();

            /*Step 4: Execute the command. When executing the command,
             * it returns an integer value representing the rows
             * affected in the DML operation (insert, update, delete).*/
            rowsAffected = myCommand.ExecuteNonQuery();

            //Step 5: Close the connection
            myConnection.Close();

            //Step 6: Return the rows affected by the DML operation
            return rowsAffected;
        }

        //Method to execute SELECT statements
        public DataSet ExecuteSELECT(string query)
        {
            //Step 1: Create an empty DataSet
            DataSet ds = new DataSet();

            //Step 2: Create an adapter
            OracleDataAdapter myAdapter = new OracleDataAdapter(query, connectionString);

            //Step 3: Fill the data set
            myAdapter.Fill(ds, "ResultData");
            return ds;
        }
    }
}