using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace proj2mvc.Models
{
    public class Functions
    {
        [Required]
        public int CID { get; set; }
        [Required]
        public int MID { get; set; }
        [Required]
        public int AID { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String DOB { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public String mName { get; set; }
        [Required]
        public String mEmail { get; set; }
        [Required]
        public String newmsg { get; set; }
     
        public string FirstName { get; set; }
        public string SchoolName { get; set; }
        public int absno { get; set; }
        public string reason { get; set; }

        string dbConnection = @"data source=FAIZAN101;initial catalog=Project2;integrated security=True";

        //For Login 
        public Boolean isValidUser(string username, string password)
        {

            Boolean isValid = false;
            try
            {
                SqlConnection con = new SqlConnection(dbConnection);
                string query = @"Select * from Login where username=@username and password =@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                con.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    isValid = true;
                }
            }
            catch (Exception exp)
            {

            }
            return isValid;
        }

        //For Showing Contacts
        public List<Functions> GetCnt()
        {
            List<Functions> ContactList = new List<Functions>();
            SqlConnection con = new SqlConnection(dbConnection);

            string query = @"select * from Contact";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                ContactList.Add(new Functions
                {
                    CID= Convert.ToInt32(dataReader["id"].ToString()),
                    Name = dataReader["Name"].ToString(),
                    DOB = dataReader["DOB"].ToString(),
                    Year = Convert.ToInt32(dataReader["Year"].ToString()),
                    Email = dataReader["Email"].ToString(),


                });

            }
            con.Close();
            return ContactList;
        }
        //For Showing Messages
        public List<Functions> GetMsg()
        {
            List<Functions> MsgList = new List<Functions>();
            SqlConnection con = new SqlConnection(dbConnection);

            string query = @"select * from Msg";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                MsgList.Add(new Functions
                {
                    MID = Convert.ToInt32(dataReader["id"].ToString()),
                    mName = dataReader["Name"].ToString(),
                    mEmail = dataReader["Email"].ToString(),
                    newmsg= dataReader["NewMessage"].ToString(),

                });

            }
            con.Close();
            return MsgList;
        }

        public List<Functions> GetAform()
        {
            List<Functions> aform = new List<Functions>();
            SqlConnection con = new SqlConnection(dbConnection);

            string query = @"select * from AForm";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                aform.Add(new Functions
                {
                    AID = Convert.ToInt32(dataReader["id"].ToString()),
                    FirstName = dataReader["fname"].ToString(),
                    SchoolName = dataReader["sname"].ToString(),
                    absno = int.Parse(dataReader["ano"].ToString()),
                    reason = dataReader["reason"].ToString(),
                });

            }
            con.Close();
            return aform;
        }
        public int DeleteContacts(Int64 id)
        {
            int effectedRows = 0;

            try
            {
                SqlConnection con = new SqlConnection(dbConnection);
                string query = @"delete from Contact where id='" + id + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                effectedRows = cmd.ExecuteNonQuery();
                con.Close();
                return effectedRows;
            }
            catch (Exception exp)
            {
                return effectedRows;
            }

        }
        public int DeleteAf(Int64 id)
        {
            int effectedRows = 0;

            try
            {
                SqlConnection con = new SqlConnection(dbConnection);
                string query = @"delete from AForm where id='" + id + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                effectedRows = cmd.ExecuteNonQuery();
                con.Close();
                return effectedRows;
            }
            catch (Exception exp)
            {
                return effectedRows;
            }

        }
        public int DeleteMsg(Int64 id)
        {
            int effectedRows = 0;

            try
            {
                SqlConnection con = new SqlConnection(dbConnection);
                string query = @"delete from Msg where id='" + id + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                effectedRows = cmd.ExecuteNonQuery();
                con.Close();
                return effectedRows;
            }
            catch (Exception exp)
            {
                return effectedRows;
            }

        }
  
    }
}