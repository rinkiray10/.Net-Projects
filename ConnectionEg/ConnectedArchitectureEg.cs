using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ConnectionEg
{
    class Shipper
    {
        public int ShipperId { get; set; }
        public string Companyname { get; set; }
        public string Phone { get; set; }

        #region  GetShipper

        public void GetShipper()
        {
            Console.WriteLine("Enter the Shippername and Companyname");
            Companyname = Console.ReadLine();
            Console.WriteLine("Enter the Phone");
            Phone = Console.ReadLine();
        }
        #endregion
        public void LooseShipper()
        {
            Console.WriteLine("Enter the Shippername and Companyname");
            Companyname = Console.ReadLine();
        }

        public void EditShipper()
        {
            Console.WriteLine("Enter the Shipper Id");
            ShipperId = Convert.ToInt32(Console.ReadLine());
            GetShipper();
        }
    }
    class ConnectedArchitectureEg
    {
        static void Main()
        {
            //2.create sqlconnection object
            SqlConnection con = null;

            //creating command object
            SqlCommand cmd = null;

            try
            {
                //3.Windows Authentication
                    con = new SqlConnection(
                 "Data Source = LAPTOP-L9V5B8LP; Initial Catalog = Northwind; Integrated Security = true");

                //sql server authentication
                //con=new SqlConnection(
                // "Data Source= DESKTOP-U8J1M3C\\MSSQLSERVER01;
                // Initial Catalog=Northwind;User ID=sa;
                // Password=newuser123#");

                //4

                con.Open();
                //creating object of shipper class

                Shipper shipper = new Shipper();
                //calling getshipper method

                //Insertion

                shipper.GetShipper();
                cmd = new SqlCommand("insert into Shippers(CompanyName,Phone) Values(@cname,@phone)", con);
                cmd.Parameters.AddWithValue("@cname", shipper.Companyname);
                cmd.Parameters.AddWithValue("@phone", shipper.Phone);
                int i = cmd.ExecuteNonQuery(); //return int
                Console.WriteLine("No of rows Affected:{0}", i);

                //Deletion

                //Calling Loose ShipperMethod
                shipper.LooseShipper();
                cmd = new SqlCommand("Delete from shippers where CompanyName=@cname", con);
                cmd.Parameters.AddWithValue("@cname", shipper.Companyname);
                i = cmd.ExecuteNonQuery(); //returns int
                Console.WriteLine("No of rows Affected:{0}", i);
                cmd.Parameters.Clear();

                //Select
                SqlDataReader dr;
                cmd = new SqlCommand("select * from Shippers", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
                    Console.WriteLine(dr["CompanyName"] + " " + dr["Phone"]);
                }

                //Update
                #region    ShipperUpdate
                shipper.EditShipper();
                cmd = new SqlCommand("Update Shippers set CompanyName=@name, Phone=@phone and ShipperID=@id", con);
                cmd.Parameters.AddWithValue("@id", shipper.ShipperId);
                cmd.Parameters.AddWithValue("@cname", shipper.Companyname);
                cmd.Parameters.AddWithValue("@phone", shipper.Phone);

                i = cmd.ExecuteNonQuery();
                Console.WriteLine("No of rows updated is {0}", i);

                #endregion

                //Scalar value

                cmd = new SqlCommand("select count(ShipperId) from Shippers", con);
                Console.WriteLine("Total shipper:{0}", Convert.ToInt32(cmd.ExecuteScalar()));

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
