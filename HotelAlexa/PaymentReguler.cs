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
    public partial class PaymentReguler : Form
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
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT pesan.id_pesan, pesan.nama_pemesan, kamar.jenis_kamar, kamar.harga  FROM pesan RIGHT JOIN kamar ON pesan.kelas_kamar = kamar.jenis_kamar WHERE kamar.jenis_kamar = 'Reguler';", conn);
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
        public PaymentReguler()
        {
            InitializeComponent();
        }

        private void PaymentReguler_Load(object sender, EventArgs e)
        {   
            clear();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtkamar_TextChanged(object sender, EventArgs e)
        {

        }
       
        

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT harga FROM kamar WHERE id_kamar = 'A'";
            int hargaKamar = 0;
            
            using (SqlCommand cmd = new SqlCommand(query))
            {
                hargaKamar = Convert.ToInt32(cmd.ExecuteScalar()); // Ambil harga dari database
            }
            if (txtPayment.Text != "" && Convert.ToInt32(txtPayment.Text) < hargaKamar)
            {
                MessageBox.Show("Pembayaran kurang dari harga kamar.");
            }

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
    }
}
