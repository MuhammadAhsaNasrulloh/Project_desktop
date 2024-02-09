using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelAlexa
{
    public partial class VIP : Form
    {
        public VIP()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=hotelalexa");

        void command(String query)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void VIP_Load(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            txtNama.Text = string.Empty;
            checkIn.Text = string.Empty;
            checkOut.Text = string.Empty;
        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = new DateTimePicker();
            checkIn.Format = DateTimePickerFormat.Custom;
            checkOut.Format = DateTimePickerFormat.Custom;

            checkIn.CustomFormat = "yyyy-MM-dd";
            checkOut.CustomFormat = "yyyy-MM-dd";
            if (checkIn.Text == string.Empty || checkOut.Text == string.Empty || txtNama.Text == string.Empty)
            {
                MessageBox.Show("Isi data dengan Lengkap");
            }
            else
            {

                command("INSERT INTO pesan ( checkin, checkout, nama_pemesan, kelas_kamar) VALUES ('" + checkIn.Text + "', '" + checkOut.Text + "', '" + txtNama.Text + "', '" + txtJenisKamar.Text + "')");
                command("UPDATE kamar SET jumlah_kamar= jumlah_kamar-1 WHERE id_kamar = 'B'");
                clear();
                paymentVIP f2 = new paymentVIP();
                f2.Show();
                this.Hide();
            }
        }

        private void txtJenisKamar_TextChanged_1(object sender, EventArgs e)
        {
            MySqlConnection dra = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=hotelalexa");
            dra.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT jenis_kamar, jumlah_kamar, harga FROM kamar WHERE id_kamar='B'", dra);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard gs = new Dashboard();
            gs.Show();
            this.Hide();
        }
    }
}
