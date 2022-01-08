
namespace Aplikasi_Laundry
{
    partial class Pengembalian
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
            this.btcari = new System.Windows.Forms.Button();
            this.txcari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btdikembalikan = new System.Windows.Forms.Button();
            this.dgvpengembalian = new System.Windows.Forms.DataGridView();
            this.tglkeluar = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txidcm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpengembalian)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(386, 31);
            this.label7.TabIndex = 71;
            this.label7.Text = "PENGEMBALIAN LAUNDRY";
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(264, 202);
            this.btrefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(122, 52);
            this.btrefresh.TabIndex = 70;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // btcari
            // 
            this.btcari.Location = new System.Drawing.Point(1084, 231);
            this.btcari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(104, 42);
            this.btcari.TabIndex = 69;
            this.btcari.Text = "Cari";
            this.btcari.UseVisualStyleBackColor = true;
            this.btcari.Click += new System.EventHandler(this.btcari_Click);
            // 
            // txcari
            // 
            this.txcari.Location = new System.Drawing.Point(942, 237);
            this.txcari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txcari.Name = "txcari";
            this.txcari.Size = new System.Drawing.Size(132, 31);
            this.txcari.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(874, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 67;
            this.label2.Text = "Cari :";
            // 
            // btdikembalikan
            // 
            this.btdikembalikan.Location = new System.Drawing.Point(76, 202);
            this.btdikembalikan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btdikembalikan.Name = "btdikembalikan";
            this.btdikembalikan.Size = new System.Drawing.Size(162, 52);
            this.btdikembalikan.TabIndex = 66;
            this.btdikembalikan.Text = "Dikembalikan";
            this.btdikembalikan.UseVisualStyleBackColor = true;
            this.btdikembalikan.Click += new System.EventHandler(this.btdikembalikan_Click);
            // 
            // dgvpengembalian
            // 
            this.dgvpengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpengembalian.Location = new System.Drawing.Point(62, 312);
            this.dgvpengembalian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvpengembalian.Name = "dgvpengembalian";
            this.dgvpengembalian.RowHeadersWidth = 62;
            this.dgvpengembalian.RowTemplate.Height = 28;
            this.dgvpengembalian.Size = new System.Drawing.Size(1126, 365);
            this.dgvpengembalian.TabIndex = 65;
            // 
            // tglkeluar
            // 
            this.tglkeluar.CustomFormat = "dd-MM-yyyy";
            this.tglkeluar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tglkeluar.Location = new System.Drawing.Point(922, 87);
            this.tglkeluar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tglkeluar.Name = "tglkeluar";
            this.tglkeluar.Size = new System.Drawing.Size(266, 31);
            this.tglkeluar.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(916, 60);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 25);
            this.label13.TabIndex = 63;
            this.label13.Text = "Tgl pengembalian";
            // 
            // txidcm
            // 
            this.txidcm.Location = new System.Drawing.Point(252, 115);
            this.txidcm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txidcm.Name = "txidcm";
            this.txidcm.Size = new System.Drawing.Size(132, 31);
            this.txidcm.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "Id cucian masuk";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 2);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 52);
            this.button5.TabIndex = 60;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "CUCIAN YANG BELUM DIAMBIL";
            // 
            // Pengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 694);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btrefresh);
            this.Controls.Add(this.btcari);
            this.Controls.Add(this.txcari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btdikembalikan);
            this.Controls.Add(this.dgvpengembalian);
            this.Controls.Add(this.tglkeluar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txidcm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pengembalian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengembalian";
            this.Load += new System.EventHandler(this.Pengembalian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpengembalian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.Button btcari;
        private System.Windows.Forms.TextBox txcari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btdikembalikan;
        private System.Windows.Forms.DataGridView dgvpengembalian;
        private System.Windows.Forms.DateTimePicker tglkeluar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txidcm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
    }
}