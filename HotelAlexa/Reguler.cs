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
using MySql.Data.MySqlClient;

namespace HotelAlexa
{
    public partial class Reguler : Form
    {
        public Reguler()
        {
            InitializeComponent();
        }

        private void txtJenisKamar_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=hotelalexa");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT jenis_kamar, jumlah_kamar, harga FROM kamar WHERE id_kamar='A'", conn);
            cmd.Parameters.AddWithValue("id", txtJenisKamar.Text);
            MySqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            if (myreader.Read())
            {
                txtJenisKamar.Text = myreader["jenis_kamar"].ToString();
                txtJumlah.Text = myreader["jumlah_kamar"].ToString();
                txtPrice.Text = myreader["harga"].ToString();
            }
        }
    }
}
