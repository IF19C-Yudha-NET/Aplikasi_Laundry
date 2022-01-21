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
    public partial class CucianKeluar : Form
    {
        public CucianKeluar()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CJNVJPUI;Initial Catalog=Laundry.v2;Integrated Security=True");
        private void showdata()
        {

            SqlCommand cmd = new SqlCommand("select * from Cucian_keluar", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvcuciankeluar.DataSource = dt;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fom = new Form1();
            this.Hide();
            fom.Show();
        }

        private void CucianKeluar_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void btcari_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Cucian_keluar where Id_cucian_masuk=@Id_cucian_masuk", con);
            cmd.Parameters.AddWithValue("@Id_cucian_masuk", txcari.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvcuciankeluar.DataSource = dt;
            con.Close();
        }

        private void bthapus_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Cucian_keluar where Id_cucian_masuk=@Id_cucian_masuk", con);
            cmd.Parameters.AddWithValue("@Id_cucian_masuk", txcari.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("berhasil dihapus");
            showdata();
            con.Close();
        }

        private void bthpusmua_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Cucian_keluar", con);
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            showdata();
        }
    }
}
