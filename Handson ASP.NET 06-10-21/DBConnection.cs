﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
 
namespace ASPDOTNETAPP1
{
    public class DBConnection
    {
        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-TD5N63QB;Initial Catalog=SQLHandsON;Integrated Security=True");
            return conn;
        }

        public void InsertDataIntoSalesman(string Id, string Name, string city, string commision)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-TD5N63QB;Initial Catalog=SQLHandsON;Integrated Security=True");
            SqlCommand sql = new SqlCommand("insert into Salesman values("+ Id + ",'"+ Name + "','" + city + "'," + commision + ") " , conn);
            conn.Open();
            sql.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable GetSalesmans()
        {
            SqlConnection Conn = new SqlConnection("Data Source=LAPTOP-TD5N63QB;Initial Catalog=SQLHandsON;Integrated Security=True");
            SqlCommand Command = new SqlCommand("select * from Salesman", Conn);
           
            Conn.Open();
            SqlDataReader dr = Command.ExecuteReader();
            DataTable dt = new DataTable();         
            dt.Load(dr);
            Conn.Close();
           
            return dt;
        }

        public DataTable GetSalesmanById(int id)
        {
            SqlConnection Conn = new SqlConnection("Data Source=LAPTOP-TD5N63QB;Initial Catalog=SQLHandsON;Integrated Security=True");
            SqlCommand Command = new SqlCommand("select * from Salesman where salesman_id="+id+"", Conn);

            Conn.Open();
            SqlDataReader dr = Command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            Conn.Close();

            return dt;
        }

        public void DeleteSalesman(int Id)
        {
            SqlConnection Conn = new SqlConnection("Data Source=LAPTOP-TD5N63QB;Initial Catalog=SQLHandsON;Integrated Security=True");

            string sql = "Delete From Salesman where salesman_id=" + Id;
            SqlCommand Command = new SqlCommand(sql, Conn);
            Conn.Open();
            Command.ExecuteNonQuery();
            Conn.Close();

        }
        public void UpdateSalesman(int Id, string Name, string City, string Commission)
        {
            SqlConnection Conn = Connect();

            string sql = "update Salesman set name='" + Name + "' , city='" + City + "' , commission=" + Commission + " where salesman_id=" + Id + "";
           
            SqlCommand Command = new SqlCommand(sql, Conn);
            Conn.Open();
            Command.ExecuteNonQuery();
            Conn.Close();
        }









        public void InsertDataIntoCustomer(string Id, string Name, string city, string Grade, string SalesmanId)
        {
            SqlConnection conn = Connect();
            SqlCommand sql = new SqlCommand("insert into Customer values(" + Id + ",'" + Name + "','" + city + "'," + Grade +"," + SalesmanId +")", conn);
            conn.Open();
            sql.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable GetCustomer()
        {
            SqlConnection Conn = Connect();
            SqlCommand Command = new SqlCommand("select * from Customer", Conn);

            Conn.Open();
            SqlDataReader dr = Command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            Conn.Close();

            return dt;
        }

        public void UpdateCustomer(int Id, string Name, string City, string Grade, int SalesmanId)
        {
            SqlConnection Conn = Connect();

            string sql = "update Customer set cust_name='" + Name + "' , city='" + City + "' , grade=" + Grade + ", salesman_id=" + SalesmanId+ "where customer_id=" + Id + "";

            SqlCommand Command = new SqlCommand(sql, Conn);
            Conn.Open();
            Command.ExecuteNonQuery();
            Conn.Close();
        }

        public DataTable GetCustomerById(int id)
        {
            SqlConnection Conn = Connect();
            SqlCommand Command = new SqlCommand("select * from Customer where customer_id=" + id + "", Conn);

            Conn.Open();
            SqlDataReader dr = Command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            Conn.Close();

            return dt;
        }


        public void DeleteCustomer(int Id)
        {
            SqlConnection Conn = new SqlConnection("Data Source=LAPTOP-TD5N63QB;Initial Catalog=SQLHandsON;Integrated Security=True");

            string sql = "Delete From Customer where customer_id=" + Id;
            SqlCommand Command = new SqlCommand(sql, Conn);
            Conn.Open();
            Command.ExecuteNonQuery();
            Conn.Close();

        }










        public void InsertDataIntoOrders(string order_no, string purch_amt, string order_date, string customer_id, string salesman_id)
        {
            SqlConnection conn = Connect();
            SqlCommand sql = new SqlCommand("insert into Orders values(" + order_no + "," + purch_amt + ",'" + order_date + "'," + customer_id + "," + salesman_id + ")", conn);
            conn.Open();
            sql.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable GetOrders()
        {
            SqlConnection Conn = Connect();
            SqlCommand Command = new SqlCommand("select * from Orders", Conn);

            Conn.Open();
            SqlDataReader dr = Command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            Conn.Close();

            return dt;
        }

        public void UpdateOrders(int order_no, double purch_amt, string order_date, int customer_id, int salesman_id)
        {
            SqlConnection Conn = Connect();

            string sql = "update Orders set purch_amt=" + purch_amt + " , order_date='" + order_date + "' , customer_id=" + customer_id + ", salesman_id=" + salesman_id + "where order_no=" + order_no + "";

            SqlCommand Command = new SqlCommand(sql, Conn);
            Conn.Open();
            Command.ExecuteNonQuery();
            Conn.Close();
        }

        public DataTable GetOrdersByNumber(int id)
        {
            SqlConnection Conn = Connect();
            SqlCommand Command = new SqlCommand("select * from Orders where order_no=" + id + "", Conn);

            Conn.Open();
            SqlDataReader dr = Command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            Conn.Close();

            return dt;
        }


        public void DeleteOrder(int order_no)
        {
            SqlConnection Conn = Connect();
            string sql = "Delete From Orders where order_no=" + order_no;
            SqlCommand Command = new SqlCommand(sql, Conn);
            Conn.Open();
            Command.ExecuteNonQuery();
            Conn.Close();

        }


    }
}