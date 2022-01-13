
namespace Aplikasi_Laundry
{
    partial class Pelanggan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.btrefresh = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btcari = new System.Windows.Forms.Button();
            this.txcari = new System.Windows.Forms.TextBox();
            this.dgvkonsumen = new System.Windows.Forms.DataGridView();
            this.bthapus = new System.Windows.Forms.Button();
            this.btubah = new System.Windows.Forms.Button();
            this.txnohp = new System.Windows.Forms.TextBox();
            this.txalamat = new System.Windows.Forms.TextBox();
            this.txnama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttambah = new System.Windows.Forms.Button();
            this.txid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkonsumen)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(209, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 77;
            this.label7.Text = "PELANGGAN LAUNDRY";
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(130, 296);
            this.btrefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(61, 27);
            this.btrefresh.TabIndex = 76;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(55, 296);
            this.btreset.Margin = new System.Windows.Forms.Padding(2);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(61, 27);
            this.btreset.TabIndex = 75;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1, 2);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 27);
            this.button5.TabIndex = 74;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Cari :";
            // 
            // btcari
            // 
            this.btcari.Location = new System.Drawing.Point(665, 56);
            this.btcari.Margin = new System.Windows.Forms.Padding(2);
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(51, 26);
            this.btcari.TabIndex = 72;
            this.btcari.Text = "Cari";
            this.btcari.UseVisualStyleBackColor = true;
            this.btcari.Click += new System.EventHandler(this.btcari_Click);
            // 
            // txcari
            // 
            this.txcari.Location = new System.Drawing.Point(594, 60);
            this.txcari.Margin = new System.Windows.Forms.Padding(2);
            this.txcari.Name = "txcari";
            this.txcari.Size = new System.Drawing.Size(68, 20);
            this.txcari.TabIndex = 71;
            // 
            // dgvkonsumen
            // 
            this.dgvkonsumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkonsumen.Location = new System.Drawing.Point(287, 86);
            this.dgvkonsumen.Margin = new System.Windows.Forms.Padding(2);
            this.dgvkonsumen.Name = "dgvkonsumen";
            this.dgvkonsumen.RowHeadersWidth = 62;
            this.dgvkonsumen.RowTemplate.Height = 28;
            this.dgvkonsumen.Size = new System.Drawing.Size(447, 315);
            this.dgvkonsumen.TabIndex = 70;
            // 
            // bthapus
            // 
            this.bthapus.Location = new System.Drawing.Point(205, 253);
            this.bthapus.Margin = new System.Windows.Forms.Padding(2);
            this.bthapus.Name = "bthapus";
            this.bthapus.Size = new System.Drawing.Size(61, 27);
            this.bthapus.TabIndex = 69;
            this.bthapus.Text = "Hapus";
            this.bthapus.UseVisualStyleBackColor = true;
            this.bthapus.Click += new System.EventHandler(this.bthapus_Click);
            // 
            // btubah
            // 
            this.btubah.Location = new System.Drawing.Point(130, 253);
            this.btubah.Margin = new System.Windows.Forms.Padding(2);
            this.btubah.Name = "btubah";
            this.btubah.Size = new System.Drawing.Size(61, 27);
            this.btubah.TabIndex = 68;
            this.btubah.Text = "Ubah";
            this.btubah.UseVisualStyleBackColor = true;
            this.btubah.Click += new System.EventHandler(this.btubah_Click);
            // 
            // txnohp
            // 
            this.txnohp.Location = new System.Drawing.Point(109, 197);
            this.txnohp.Margin = new System.Windows.Forms.Padding(2);
            this.txnohp.Name = "txnohp";
            this.txnohp.Size = new System.Drawing.Size(158, 20);
            this.txnohp.TabIndex = 67;
            // 
            // txalamat
            // 
            this.txalamat.Location = new System.Drawing.Point(109, 155);
            this.txalamat.Margin = new System.Windows.Forms.Padding(2);
            this.txalamat.Name = "txalamat";
            this.txalamat.Size = new System.Drawing.Size(158, 20);
            this.txalamat.TabIndex = 66;
            // 
            // txnama
            // 
            this.txnama.Location = new System.Drawing.Point(109, 118);
            this.txnama.Margin = new System.Windows.Forms.Padding(2);
            this.txnama.Name = "txnama";
            this.txnama.Size = new System.Drawing.Size(158, 20);
            this.txnama.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "No hp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Nama";
            // 
            // bttambah
            // 
            this.bttambah.Location = new System.Drawing.Point(55, 253);
            this.bttambah.Margin = new System.Windows.Forms.Padding(2);
            this.bttambah.Name = "bttambah";
            this.bttambah.Size = new System.Drawing.Size(61, 27);
            this.bttambah.TabIndex = 61;
            this.bttambah.Text = "Tambah";
            this.bttambah.UseVisualStyleBackColor = true;
            this.bttambah.Click += new System.EventHandler(this.bttambah_Click);
            // 
            // txid
            // 
            this.txid.Location = new System.Drawing.Point(109, 82);
            this.txid.Margin = new System.Windows.Forms.Padding(2);
            this.txid.Name = "txid";
            this.txid.Size = new System.Drawing.Size(68, 20);
            this.txid.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Id konsumen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "DATA PELANGGAN LAUNDRY";
            // 
            // Pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 408);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btrefresh);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btcari);
            this.Controls.Add(this.txcari);
            this.Controls.Add(this.dgvkonsumen);
            this.Controls.Add(this.bthapus);
            this.Controls.Add(this.btubah);
            this.Controls.Add(this.txnohp);
            this.Controls.Add(this.txalamat);
            this.Controls.Add(this.txnama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttambah);
            this.Controls.Add(this.txid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pelanggan";
            this.Load += new System.EventHandler(this.Pelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkonsumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btcari;
        private System.Windows.Forms.TextBox txcari;
        private System.Windows.Forms.DataGridView dgvkonsumen;
        private System.Windows.Forms.Button bthapus;
        private System.Windows.Forms.Button btubah;
        private System.Windows.Forms.TextBox txnohp;
        private System.Windows.Forms.TextBox txalamat;
        private System.Windows.Forms.TextBox txnama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttambah;
        private System.Windows.Forms.TextBox txid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}