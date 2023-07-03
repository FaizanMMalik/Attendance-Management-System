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
    public partial class Contact : Form
    {
        string strConn = "Integrated Security=SSPI;Persist Security Info = True;  Initial Catalog = Project2 ; Data Source = FAIZAN101";
        public Contact()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            DGV.Rows.Clear();
            SqlConnection con = new SqlConnection(strConn);
            string query = "select * from Contact";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                DGV.Rows.Add(dataReader[0], dataReader[1], dataReader[2], dataReader[3], dataReader[4]);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string query = "INSERT INTO dbo.Contact(Name,DOB,Year,Email) VAlUES('" + txtname.Text + "','" + txtdob.Text + "','" + txtsy.Text + "','" + txtemail.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Added Succesfully ! ");
        }

        private void policyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apolicy a = new Apolicy();
            a.Show();
            this.Hide();
        }

        private void absenceFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apolicy a = new Apolicy();
            a.Show();
            this.Hide();
        }

        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact a = new Contact();
            a.Show();
            this.Hide();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Msg a = new Msg();
            a.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }
    }
}
