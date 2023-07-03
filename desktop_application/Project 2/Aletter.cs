using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Aletter : Form
    {
        public Aletter()
        {
            InitializeComponent();
        }

        private void Aletter_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btngb_Click(object sender, EventArgs e)
        {
            Aform a = new Aform();
            a.Show();
            this.Hide();
        }
    }
}
