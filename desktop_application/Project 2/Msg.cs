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
    public partial class Msg : Form
    {
        string strConn = "Integrated Security=SSPI;Persist Security Info = True;  Initial Catalog = Project2 ; Data Source = FAIZAN101";
        public Msg()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string query = "INSERT INTO dbo.Msg(Name,Email,NewMessage) VAlUES('" + txtname.Text + "','" + txtemail.Text + "','" + txtmsg.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Message Sent !");
        }

        private void policyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apolicy a = new Apolicy();
            a.Show();
            this.Hide();
        }

        private void absenceFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aform a = new Aform();
            a.Show();
            this.Hide();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Msg a = new Msg();
            a.Show();
            this.Hide();
        }

        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact a = new Contact();
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
