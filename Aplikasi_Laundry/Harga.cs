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
    public partial class Harga : Form
    {
        public Harga()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fom = new Form1();
            this.Hide();
            fom.Show();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O365U80\SQLEXPRESS;Initial Catalog=Laundry.v2;Integrated Security=True");

        private void showdata()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Harga", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvharga.DataSource = dt;
            con.Close();
        }

        private void bttetapkan_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Harga values (@Harga_per_kg,@Harga_paket_kilat,@Harga_pewangi,@Harga_jenis_cuci)", con);
            cmd.Parameters.AddWithValue("@Harga_per_kg", float.Parse(txhkg.Text));
            cmd.Parameters.AddWithValue("@Harga_paket_kilat", float.Parse(txhpkilat.Text));
            cmd.Parameters.AddWithValue("@Harga_pewangi", float.Parse(txhwangi.Text));
            cmd.Parameters.AddWithValue("@Harga_jenis_cuci", float.Parse(txcsetrika.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("harga berhasil ditetapkan");
            showdata();
        }

        private void Harga_Load(object sender, EventArgs e)
        {
            showdata();
        }
    }
}
