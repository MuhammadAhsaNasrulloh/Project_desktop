﻿using System;
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
            OrderPage f2 = new OrderPage();
            f2.Show();
            this.Hide();
        }
    }
}