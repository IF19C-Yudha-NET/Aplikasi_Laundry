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
    public partial class Pencuci : Form
    {
        public Pencuci()
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
            SqlCommand cmd = new SqlCommand("select * from Pencuci", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvpencuci.DataSource = dt;
            con.Close();
        }

        private void reset()
        {
            txidpen.Clear();
            txnamapen.Clear();
            txalamatpen.Clear();
            txnohppen.Clear();
            rdlk.Checked = false;
            rdp.Checked = false;
        }

        private void Pencuci_Load(object sender, EventArgs e)
        {
            showdata();
        }
        string gender = "";

        private void rdlk_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Laki-laki";
        }

        private void rdp_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Perempuan";
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            txcari.Clear();
            reset();
        }

        private void bttambah_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Pencuci values (@Id_pencuci,@Nama,@Jenis_kelamin,@Alamat,@No_hp)", con);
            cmd.Parameters.AddWithValue("@Id_pencuci", txidpen.Text);
            cmd.Parameters.AddWithValue("@Nama", txnamapen.Text);
            cmd.Parameters.AddWithValue("@Jenis_kelamin", gender);
            cmd.Parameters.AddWithValue("@Alamat", txalamatpen.Text);
            cmd.Parameters.AddWithValue("@No_hp", txnohppen.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("pencuci berhasil ditambah");
            showdata();
        }

        private void btubah_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Pencuci set Nama=@Nama,Jenis_kelamin=@Jenis_kelamin,Alamat=@Alamat,No_hp=@No_hp where Id_pencuci=@Id_pencuci", con);
            cmd.Parameters.AddWithValue("@Id_pencuci", txidpen.Text);
            cmd.Parameters.AddWithValue("@Nama", txnamapen.Text);
            cmd.Parameters.AddWithValue("@Jenis_kelamin", gender);
            cmd.Parameters.AddWithValue("@Alamat", txalamatpen.Text);
            cmd.Parameters.AddWithValue("@No_hp", txnohppen.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
        }

        private void bthapus_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Pencuci where Id_pencuci=@Id_pencuci", con);
            cmd.Parameters.AddWithValue("@Id_pencuci", txidpen.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("data pencuci berhasil dihapus");
            reset();
            showdata();
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            txcari.Clear();
            showdata();
        }

        private void btcari_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Pencuci where Id_pencuci=@Id_pencuci", con);
            cmd.Parameters.AddWithValue("@Id_pencuci", txcari.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvpencuci.DataSource = dt;
            con.Close();
        }
    }
}
