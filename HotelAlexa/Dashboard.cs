using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAlexa
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnReguler_Click(object sender, EventArgs e)
        {
            Reguler f2 = new Reguler();
            f2.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnVIP_Click(object sender, EventArgs e)
        {
            VIP f2 = new VIP();
            f2.Show();
            this.Hide();
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void btnVVIP_Click(object sender, EventArgs e)
        {

        }
    }
}
