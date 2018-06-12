using System;
using System.Configuration;
using System.Data.SqlClient;

namespace NawazEyeWebProject.Models
{
    public class Account
    {
        SqlConnection con;
        SqlCommand cmd;
        string query;
        int id, acntId;
        string username, password;
        bool blockFlag;
        public Account(int buyerId)
        {
            SetValues(buyerId);
        }
        public Account(string userName, string password)
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
                query = "INSERT INTO [ACCOUNTS] ([BuyerId] ,[Username] ,[Password]) VALUES (" + id + " ,'" + userName + "' ,'" + password + "'); Select MAX(BuyerId) from ACCOUNTS;";
                cmd = new SqlCommand(query, con);
                con.Open();
                id = (int)cmd.ExecuteScalar();
                con.Close();
                SetValues(id);
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == 2601)
                {
                    Exception e = new Exception("The Username is already Taken");
                    throw e;
                }
                else
                {
                    Exception e = new Exception("Database Connection Error. " + ex.Message);
                    throw e;
                }
            }
        }
        public Buyer Buyer
        {
            get
            {
                return new Buyer(id);
            }
        }
        public int AccountId
        {
            get
            {
                return acntId;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                try
                {
                    con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
                    query = "Update ACCOUNTS set Password='" + value + "' where BuyerId=" + id;
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() != 1)
                    {
                        Exception e = new Exception("Database Proccessing Error.");
                        throw e;
                    }
                    else
                    {
                        SetValues(id);
                    }
                    con.Close();
                }
                catch (SqlException ex)
                {
                    Exception e = new Exception("Database Connection Error. " + ex.Message);
                    throw e;
                }
            }
        }
        public bool IsBlocked
        {
            get
            {
                return blockFlag;
            }
            set
            {
                try
                {
                    int i = Convert.ToInt16(value);
                    con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
                    query = "update ACCOUNTS set BlockFlag=" + i + " where BuyerId=" + id;
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() != 1)
                    {
                        Exception e = new Exception("Database Proccessing Error.");
                        throw e;
                    }
                    else
                    {
                        SetValues(id);
                    }
                    con.Close();
                }
                catch (SqlException ex)
                {
                    Exception e = new Exception("Database Connection Error. " + ex.Message);
                    throw e;
                }
            }
        }
        private void SetValues(int id)
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
                query = "select * from ACCOUNTS where BuyerId="+id;
                cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.id = (int)reader[0];
                    acntId = (int)reader[1];
                    username = (string)reader[2];
                    blockFlag = (bool)reader[3];
                    password = (string)reader[4];
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Exception e = new Exception("Database Connection Error. " + ex.Message);
                throw e;
            }
        }
        public static bool IsUsernameTaken(string username)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
                string query = "select * from ACCOUNTS where Username='" + username + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            catch (SqlException ex)
            {
                Exception e = new Exception("Database Connection Error. " + ex.Message);
                throw e;
            }
        }
        public bool Delete()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
                string query = "DELETE FROM [dbo].ACCOUNTS WHERE BuyerId = " + id;
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    con.Close();
                    return true;
                }
                else if (cmd.ExecuteNonQuery() < 1)
                {
                    con.Close();
                    return false;
                }
                else
                {
                    throw new Exception("Something Went Wrong in deleting.");
                }
            }
            catch (SqlException ex)
            {
                Exception e = new Exception("Database Connection Error. " + ex.Message);
                throw e;
            }
        }

    }
}