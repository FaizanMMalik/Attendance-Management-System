using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Login : Form
    {
        string strConn = "Integrated Security=SSPI;Persist Security Info = True;  Initial Catalog = Project2 ; Data Source = FAIZAN101";
        public Login()
        {
            InitializeComponent();
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtEpass.Text;
            SqlConnection con = new SqlConnection(strConn);
            string query = "select * from Login where username='" + username + "' and password='" + password + "'";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                MessageBox.Show("Login Successfull !");
                Apolicy a = new Apolicy();
                a.Show();
                this.Hide();
            }
            else
            {
                string message = "Invalid Username or Password!";
                string title = "Login Failed";
                MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Retry)
                {

                    txtusername.Text = "";
                    txtEpass.Text = "";
                }
                else
                {
                    // Do something  
                }


            }
        }
    }
}
