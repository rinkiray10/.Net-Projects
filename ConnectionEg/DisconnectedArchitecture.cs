using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ConnectionEg
{
    class DAL
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection GetConnection()
        {
            con = new SqlConnection(
                    "Data Source = LAPTOP-L9V5B8LP; Initial Catalog = Northwind; Integrated Security = true");

            con.Open();
            return con;
        }

        public void DisplayRegion()
        {
            con = GetConnection();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select * from Region", con);
            DataSet ds = new DataSet();//Collection of tables
            //putting the table inside dataset
            da.Fill(ds, "NWREGION");

            //reading the table info from dataset

            DataTable dt;
            dt = ds.Tables["NWREGION"];

            foreach(DataRow row in dt.Rows)
            {
                foreach(DataColumn col in dt.Columns)
                {
                    Console.Write(row[col]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }

            //adding one more table to dataset :shipper
            Console.WriteLine("-------------------------");
            Console.WriteLine("------Shipper table--------");
            da = new SqlDataAdapter("Select * from Shippers", con);
            da.Fill(ds, "NWSHIPPER");

            DataTable dt1 = ds.Tables["NWSHIPPER"];

            foreach(DataRow row in dt1.Rows)
            {
                foreach(DataColumn col in dt1.Columns)
                {
                    Console.Write(row[col]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }

            //Inserting new row in region table in dataset
            //Insert,Update,delete operation
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            da.Fill(ds);

            //Inserting or adding a new row
            //Creating a new row in NWREGION in dataset
            DataRow row1 = ds.Tables["NWREGION"].NewRow();
            row1["RegionID"] = 13;
            row1["RegionDescription"] = "Northwest";
            //Adding row to datatable in dataset
            ds.Tables["NWREGION"].Rows.Add(row1);

            da.Update(ds, "NWREGION");
            Console.WriteLine("----------------");

            dt = ds.Tables["NWREGION"];

            foreach (DataRow dataRow in dt1.Rows)
            {
                foreach (DataColumn dataCol in dt1.Columns)
                {
                    Console.Write(dataRow[dataCol]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
        }
    }
    class DisconnectedArchitecture
    {

    }
}
