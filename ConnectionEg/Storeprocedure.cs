using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ConnectionEg
{
    class DAL
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(
                    "Data Source = LAPTOP-L9V5B8LP; Initial Catalog = Northwind; Integrated Security = true");

            con.Open();
            return con;
        }

        internal void CallTenMostExpensiveProduct()
        {
            try
            {
                con = GetConnection();
                //Procedure name is sqlserver
                cmd = new SqlCommand("Ten Most Expensive Products", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1])
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        internal void CallCustOrdersOrders(string cid)
        {
            try
            {
                con = GetConnection();

                //Procedure name is sqlserver
                cmd = new SqlCommand("CustOrdersOrders", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["orderID"] + " " + dr["OrderDate"] + " " + dr["ShippedDate"]);
                }
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
        class Storeprocedure
        {
            static void Main()
            {

            }
            /* static void Main()
             {
                 DataAccessLayer spobject = new DataAccessLayer();
                 //spobject.CallTenMostExpensiveProducts();

                 Console.WriteLine("Enter the Customer id");
                 string cid = Console.ReadLine();
                 spobject.CallCustOrdersOrders(cid);
             }*/
        }
    }
}
