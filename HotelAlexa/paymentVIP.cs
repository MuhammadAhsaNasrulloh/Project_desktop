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
    public partial class paymentVIP : Form
    {
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
        void showData()
        {
            try
            {
                conn.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT pesan.id_pesan, pesan.nama_pemesan, kamar.jenis_kamar, kamar.harga  FROM pesan RIGHT JOIN kamar ON pesan.kelas_kamar = kamar.jenis_kamar WHERE kamar.jenis_kamar = 'VIP';", conn);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                dataGridView1.DataSource = dt;
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
        void clear()
        {
            txtOrder.Text = string.Empty;
            txtPayment.Text = string.Empty;
            txtkamar.Text = string.Empty;
            txtWaktu.Text = string.Empty;
            txtID.Text = string.Empty;
            showData();
        }
        public paymentVIP()
        {
            InitializeComponent();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paymentVIP_Load(object sender, EventArgs e)
        {
            clear();
            showData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.dataGridView1.Rows[e.RowIndex];

            txtID.Text = dr.Cells[0].Value.ToString();
            txtOrder.Text = dr.Cells[1].Value.ToString();
            txtkamar.Text = dr.Cells[2].Value.ToString();
            txtHarga.Text = dr.Cells[3].Value.ToString();
            showData();
        }

        private void txtkamar_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            int bayar = Convert.ToInt32(txtPayment.Text);
            int harga = Convert.ToInt32(txtHarga.Text);
            int kembalian;
            if (bayar < harga)
            {
                MessageBox.Show("Pembayaran kurang dari harga kamar.");
            }
            else
            {
                kembalian = bayar - harga;
                command("INSERT INTO bayar VALUES ('" + txtID.Text + "', '" + txtOrder.Text + "', '" + txtkamar.Text + "', '" + txtPayment.Text + "', '" + kembalian + "')");
                strukvip f2 = new strukvip();
                f2.Show();
                this.Hide();
            }
        }
    }
}
