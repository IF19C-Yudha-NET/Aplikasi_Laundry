﻿using System;
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
    public partial class CucianMasuk : Form
    {
        public CucianMasuk()
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
        private string idCucianMasuk
        {
            get
            {
                con.Open();
                string cm = "CM-1";
                SqlCommand cmd = new SqlCommand("select max(right(Id_cucian_masuk,1)) from Cucian_masuk", con);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd[0].ToString() != "")
                    cm = "CM-" + (int.Parse(rd[0].ToString()) + 1).ToString("0");
                rd.Close();
                return cm;
            }
        }


        private void showdata()
        {

            SqlCommand cmd = new SqlCommand("select * from Cucian_masuk", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvcmasuk.DataSource = dt;
            con.Close();
        }

        private void reset()
        {
            txidcm.Clear();
            txidpenc.Clear();
            txidpel.Clear();
            txhpwangi.Clear();
            txhjenispaket.Clear();
            txhjeniscuci.Clear();
            txberat.Clear();
            txjmlcelana.Clear();
            txjmlpakaian.Clear();
            txjmllainya.Clear();
            txhpwangi.Clear();
            // rdya.Checked == false;
            rdtidak.Checked = false;
            cbjeniscuci.SelectedItem = false;
            //cbjenispaket.SelectedItem = f;
            //tglpengembalian.Text = tgldilaundry.Text;
        }

        private void CucianMasuk_Load(object sender, EventArgs e)
        {
            txidcm.Text = idCucianMasuk;
            try
            {
                showdata();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Harga", con);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                txhperkg.Text = rd[0].ToString();
                rd.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("harga belum ditetapkan !!!" +
                                "\nharap ditetapkan dahulu di harga");
            }
        }

        private void bttambah_Click(object sender, EventArgs e)
        {
            if (txidcm.Text == "" | txidpenc.Text == "" | txidcm.Text == "" | txjmlpakaian.Text == "" | txjmlcelana.Text == "" | txjmllainya.Text == "" | txberat.Text == "")
            {
                MessageBox.Show("harap diisi semua");
            }
            else
            {
                float pkilat = float.Parse(txhjenispaket.Text);
                float jcuci = float.Parse(txhjeniscuci.Text);
                float pwangi = float.Parse(txhpwangi.Text);
                float perkg = float.Parse(txhperkg.Text);
                float berat = float.Parse(txberat.Text);
                float totalharga = (pkilat + jcuci + pwangi) + berat * perkg;
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Cucian_masuk values (@Id_cucian_masuk,@Id_pencuci,@Id_pelanggan,@Jenis_cuci,@Paket_cuci,@Pewangi,@Jml_pakaian,@Jml_celana,@Jml_lainnya,@Harga_per_kg,@Berat,@Total_harga,@Tgl_masuk,@Tgl_pengembalian)", con);
                cmd.Parameters.AddWithValue("@Id_cucian_masuk", txidcm.Text);
                cmd.Parameters.AddWithValue("@Id_pencuci", txidpenc.Text);
                cmd.Parameters.AddWithValue("@Id_pelanggan", txidpel.Text);
                cmd.Parameters.AddWithValue("@Jenis_cuci", cbjeniscuci.Text);
                cmd.Parameters.AddWithValue("@Paket_cuci", cbjenispaket.Text);
                cmd.Parameters.AddWithValue("@Pewangi", pewangi);
                cmd.Parameters.AddWithValue("@Jml_pakaian", int.Parse(txjmlpakaian.Text));
                cmd.Parameters.AddWithValue("@Jml_celana", int.Parse(txjmlcelana.Text));
                cmd.Parameters.AddWithValue("@Jml_lainnya", int.Parse(txjmllainya.Text));
                cmd.Parameters.AddWithValue("@Harga_per_kg", float.Parse(txhperkg.Text));
                cmd.Parameters.AddWithValue("@Berat", berat);
                cmd.Parameters.AddWithValue("@Total_harga", totalharga);
                cmd.Parameters.AddWithValue("@Tgl_masuk", tgldilaundry.Text);
                cmd.Parameters.AddWithValue("@Tgl_pengembalian", tglpengembalian.Text);
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("insert into Pengembalian values (@Id_cucian_masuk,@Id_pelanggan,@Berat,@Harga,@Tgl_pengembalian)", con);
                cmd2.Parameters.AddWithValue("@Id_cucian_masuk", txidcm.Text);
                cmd2.Parameters.AddWithValue("@Id_pelanggan", txidpel.Text);
                cmd2.Parameters.AddWithValue("@Berat", berat);
                cmd2.Parameters.AddWithValue("@Harga", totalharga);
                cmd2.Parameters.AddWithValue("@Tgl_pengembalian", tglpengembalian.Text);
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("cucian masuk berhasil ditambah");
                reset();
                showdata();
            }
        }
        string pewangi = "";

        private void rdya_CheckedChanged(object sender, EventArgs e)
        {
            pewangi = "Ya";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Harga", con);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            txhpwangi.Text = rd[2].ToString();
            rd.Close();
            con.Close();
        }

        private void rdtidak_CheckedChanged(object sender, EventArgs e)
        {
            pewangi = "Tidak";
            txhpwangi.Text = "0";
        }

        private void cbjeniscuci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbjeniscuci.SelectedItem == "Cuci Kering")
            {
                txhjeniscuci.Text = "0";
            }
            if (cbjeniscuci.SelectedItem == "Cuci Setrika")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Harga", con);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                txhjeniscuci.Text = rd[3].ToString();
                rd.Close();
                con.Close();
            }
        }

        private void cbjenispaket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbjenispaket.SelectedItem == "Reguler (3 hari)")
            {
                txhjenispaket.Text = "0";
            }
            if (cbjenispaket.SelectedItem == "Kilat (1 hari)")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Harga", con);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                txhjenispaket.Text = rd[1].ToString();
                rd.Close();
                con.Close();
            }
        }

        private void bthapus_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Cucian_masuk where Id_cucian_masuk=@Id_cucian_masuk", con);
            cmd.Parameters.AddWithValue("@Id_cucian_masuk", txidcm.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("berhasil dihapus");
            showdata();
            con.Close();
        }

        private void btcari_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Cucian_masuk where Id_cucian_masuk=@Id_cucian_masuk", con);
            cmd.Parameters.AddWithValue("@Id_cucian_masuk", txidcm.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvcmasuk.DataSource = dt;
            con.Close();
        }

        private void btubah_Click(object sender, EventArgs e)
        {
            if (txidcm.Text == "" | txidpenc.Text == "" | txidcm.Text == "" | txjmlpakaian.Text == "" | txjmlcelana.Text == "" | txjmllainya.Text == "" | txberat.Text == "")
            {
                MessageBox.Show("harap diisi semua");
            }
            else
            {
                float pkilat = float.Parse(txhjenispaket.Text);
                float jcuci = float.Parse(txhjeniscuci.Text);
                float pwangi = float.Parse(txhpwangi.Text);
                float perkg = float.Parse(txhperkg.Text);
                float berat = float.Parse(txberat.Text);
                float totalharga = (pkilat + jcuci + pwangi) + berat * perkg;
                con.Open();
                SqlCommand cmd = new SqlCommand("update Cucian_masuk set  Id_pencuci=@Id_pencuci,Id_pelanggan=@Id_pelanggan,Jenis_cuci=@Jenis_cuci,Paket_cuci=@Paket_cuci,Pewangi=@Pewangi,Jml_pakaian=@Jml_pakaian,Jml_celana=@Jml_celana,Jml_lainnya=@Jml_lainnya,Harga_per_kg=@Harga_per_kg,Berat=@Berat,Total_harga=@Total_harga,Tgl_masuk=@Tgl_masuk,Tgl_pengembalian=@Tgl_pengembalian where Id_cucian_masuk=@Id_cucian_masuk", con);
                cmd.Parameters.AddWithValue("@Id_cucian_masuk", txidcm.Text);
                cmd.Parameters.AddWithValue("@Id_pencuci", txidpenc.Text);
                cmd.Parameters.AddWithValue("@Id_pelanggan", txidpel.Text);
                cmd.Parameters.AddWithValue("@Jenis_cuci", cbjeniscuci.Text);
                cmd.Parameters.AddWithValue("@Paket_cuci", cbjenispaket.Text);
                cmd.Parameters.AddWithValue("@Pewangi", pewangi);
                cmd.Parameters.AddWithValue("@Jml_pakaian", int.Parse(txjmlpakaian.Text));
                cmd.Parameters.AddWithValue("@Jml_celana", int.Parse(txjmlcelana.Text));
                cmd.Parameters.AddWithValue("@Jml_lainnya", int.Parse(txjmllainya.Text));
                cmd.Parameters.AddWithValue("@Harga_per_kg", float.Parse(txhperkg.Text));
                cmd.Parameters.AddWithValue("@Berat", berat);
                cmd.Parameters.AddWithValue("@Total_harga", totalharga);
                cmd.Parameters.AddWithValue("@Tgl_masuk", tgldilaundry.Text);
                cmd.Parameters.AddWithValue("@Tgl_pengembalian", tglpengembalian.Text);
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("update Pengembalian set Id_cucian_masuk=@Id_cucian_masuk,Berat=@Berat,Harga=@Harga,Tgl_pengembalian=@Tgl_pengembalian where Id_pelanggan=@Id_pelanggan", con);
                cmd2.Parameters.AddWithValue("@Id_cucian_masuk", txidcm.Text);
                cmd2.Parameters.AddWithValue("@Id_pelanggan", txidpel.Text);
                cmd2.Parameters.AddWithValue("@Berat", berat);
                cmd2.Parameters.AddWithValue("@Harga", totalharga);
                cmd2.Parameters.AddWithValue("@Tgl_pengembalian", tglpengembalian.Text);
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("cucian masuk berhasil diubah");
                reset();
                showdata();
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}