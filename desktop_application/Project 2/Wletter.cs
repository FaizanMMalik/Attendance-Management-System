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
    public partial class Wletter : Form
    {
        public Wletter()
        {
            InitializeComponent();
        }

        private void btngb_Click(object sender, EventArgs e)
        {
            Aform a = new Aform();
            a.Show();
            this.Hide();
        }
    }
}
