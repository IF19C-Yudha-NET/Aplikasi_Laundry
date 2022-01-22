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

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CJNVJPUI;Initial Catalog=Laundry.v2;Integrated Security=True");
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

        private void reset()
        {
            txhkg.Clear();
            txhpkilat.Clear();
            txhwangi.Clear();
            txcsetrika.Clear();
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
            reset();
            showdata();
        }

        private void Harga_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void btubah_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Harga set Harga_paket_kilat=@Harga_paket_kilat,Harga_pewangi=@Harga_pewangi,Harga_jenis_cuci=@Harga_jenis_cuci where Harga_per_kg=@Harga_per_kg", con);
            cmd.Parameters.AddWithValue("@Harga_per_kg", float.Parse(txhkg.Text));
            cmd.Parameters.AddWithValue("@Harga_paket_kilat", float.Parse(txhpkilat.Text));
            cmd.Parameters.AddWithValue("@Harga_pewangi", float.Parse(txhwangi.Text));
            cmd.Parameters.AddWithValue("@Harga_jenis_cuci", float.Parse(txcsetrika.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("harga berhasil diubah");
            reset();
            showdata();
        }

        private void bthapus_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete Harga where Harga_per_kg=@Harga_per_kg", con);
                cmd.Parameters.AddWithValue("@Harga_per_kg", txhkg.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("harga berhasil dihapus");
                showdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("tidak bisa menghapus harga!!!" +
                                "\nkarena didatabase harga sudah terisi" +
                                "\nharap hapus dulu data di cucian masuk");
            }
        }
    }
}
