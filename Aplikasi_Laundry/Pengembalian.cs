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
    public partial class Pengembalian : Form
    {
        public Pengembalian()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fom = new Form1();
            this.Hide();
            fom.Show();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CJNVJPUI;Initial Catalog=Laundry.v2;Integrated Security=True");
        private void showdata()
        {

            SqlCommand cmd = new SqlCommand("select * from Pengembalian", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvpengembalian.DataSource = dt;
            con.Close();
        }
        private void Pengembalian_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void btdikembalikan_Click(object sender, EventArgs e)
        {
            try
            {
                string berat = "";
                string harga = "";
                string id = "";
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select * from Pengembalian where Id_cucian_masuk=@Id_cucian_masuk", con);
                cmd1.Parameters.AddWithValue("@Id_cucian_masuk", txidcm.Text);
                cmd1.ExecuteNonQuery();
                SqlDataReader rd = cmd1.ExecuteReader();
                rd.Read();
                id = rd[1].ToString();
                berat = rd[2].ToString();
                harga = rd[3].ToString();
                rd.Close();
                con.Close();

                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Cucian_keluar values (@Id_cucian_masuk,@Id_pelanggan,@Berat,@Harga,@Tgl_keluar)", con);
                cmd.Parameters.AddWithValue("@Id_cucian_masuk", txidcm.Text);
                cmd.Parameters.AddWithValue("@Id_pelanggan", id);
                cmd.Parameters.AddWithValue("@Berat", float.Parse(berat));
                cmd.Parameters.AddWithValue("@Harga", float.Parse(harga));
                cmd.Parameters.AddWithValue("@Tgl_keluar", tglkeluar.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("cucian dikembalikan");

                SqlCommand cmd2 = new SqlCommand("delete Pengembalian where Id_pelanggan=@Id_pelanggan", con);
                cmd2.Parameters.AddWithValue("@Id_pelanggan", id);
                cmd2.ExecuteNonQuery();
                showdata();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("tidak ada data cucian yang dikembalikan");
            }
        }

        private void btcari_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Pengembalian where Id_cucian_masuk=@Id_cucian_masuk", con);
            cmd.Parameters.AddWithValue("@Id_cucian_masuk", txcari.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvpengembalian.DataSource = dt;
            con.Close();
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            showdata();
        }
    }
}
