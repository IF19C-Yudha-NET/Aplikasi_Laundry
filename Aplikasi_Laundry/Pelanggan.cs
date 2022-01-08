using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikasi_Laundry
{
    public partial class Pelanggan : Form
    {
        public Pelanggan()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CJNVJPUI;Initial Catalog=Laundry.v2;Integrated Security=True");

        private void showdata()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Konsumen", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvkonsumen.DataSource = dt;
            con.Close();
        }
        private void reset()
        {
            txid.Clear();
            txnama.Clear();
            txalamat.Clear();
            txnohp.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fom = new Form1();
            this.Hide();
            fom.Show();
        }

        private void Pelanggan_Load(object sender, EventArgs e)
        {

            showdata();
        }

        private void bttambah_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Konsumen values (@Id_pelanggan,@Nama,@Alamat,@No_hp)", con);
                cmd.Parameters.AddWithValue("@Id_pelanggan", txid.Text);
                cmd.Parameters.AddWithValue("@Nama", txnama.Text);
                cmd.Parameters.AddWithValue("@Alamat", txalamat.Text);
                cmd.Parameters.AddWithValue("@No_hp", txnohp.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("pelanggan berhasil ditambah");
                showdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Id pelanggan sudah ada");
            }
        }

        private void btubah_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Konsumen set Nama=@Nama,Alamat=@Alamat,No_hp=@No_hp where Id_pelanggan=@Id_pelanggan", con);
            cmd.Parameters.AddWithValue("@Id_pelanggan", txid.Text);
            cmd.Parameters.AddWithValue("@Nama", txnama.Text);
            cmd.Parameters.AddWithValue("@Alamat", txalamat.Text);
            cmd.Parameters.AddWithValue("@No_hp", txnohp.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("data pelanggan berhasil diubah");
            showdata();
        }

        private void bthapus_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete Konsumen where Id_pelanggan=@Id_pelanggan", con);
                cmd.Parameters.AddWithValue("@Id_pelanggan", txid.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("data pelanggan berhasil dihapus");
                showdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Harap hapus dahulu " +
                    "\ndata id ini di cucian masuk");
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Konsumen where Id_pelanggan=@Id_pelanggan", con);
            cmd.Parameters.AddWithValue("@Id_pelanggan", txcari.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvkonsumen.DataSource = dt;
            con.Close();
        }
    }
}
