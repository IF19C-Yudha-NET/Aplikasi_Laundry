
namespace Aplikasi_Laundry
{
    partial class Harga
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvharga = new System.Windows.Forms.DataGridView();
            this.txcsetrika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txhwangi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txhpkilat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txhkg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bthapus = new System.Windows.Forms.Button();
            this.btubah = new System.Windows.Forms.Button();
            this.bttetapkan = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvharga)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 24);
            this.label2.TabIndex = 73;
            this.label2.Text = "PENETAPAN HARGA LAUNDRY";
            // 
            // dgvharga
            // 
            this.dgvharga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvharga.Location = new System.Drawing.Point(52, 306);
            this.dgvharga.Name = "dgvharga";
            this.dgvharga.RowHeadersWidth = 62;
            this.dgvharga.RowTemplate.Height = 28;
            this.dgvharga.Size = new System.Drawing.Size(714, 122);
            this.dgvharga.TabIndex = 72;
            // 
            // txcsetrika
            // 
            this.txcsetrika.Location = new System.Drawing.Point(232, 206);
            this.txcsetrika.Name = "txcsetrika";
            this.txcsetrika.Size = new System.Drawing.Size(100, 26);
            this.txcsetrika.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Harga cuci setrika";
            // 
            // txhwangi
            // 
            this.txhwangi.Location = new System.Drawing.Point(232, 158);
            this.txhwangi.Name = "txhwangi";
            this.txhwangi.Size = new System.Drawing.Size(100, 26);
            this.txhwangi.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 68;
            this.label8.Text = "Harga diberi pewangi";
            // 
            // txhpkilat
            // 
            this.txhpkilat.Location = new System.Drawing.Point(232, 112);
            this.txhpkilat.Name = "txhpkilat";
            this.txhpkilat.Size = new System.Drawing.Size(100, 26);
            this.txhpkilat.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 66;
            this.label7.Text = "Harga paket kilat";
            // 
            // txhkg
            // 
            this.txhkg.Location = new System.Drawing.Point(232, 69);
            this.txhkg.Name = "txhkg";
            this.txhkg.Size = new System.Drawing.Size(100, 26);
            this.txhkg.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Harga per kg";
            // 
            // bthapus
            // 
            this.bthapus.Location = new System.Drawing.Point(424, 189);
            this.bthapus.Name = "bthapus";
            this.bthapus.Size = new System.Drawing.Size(92, 42);
            this.bthapus.TabIndex = 63;
            this.bthapus.Text = "Hapus";
            this.bthapus.UseVisualStyleBackColor = true;
            // 
            // btubah
            // 
            this.btubah.Location = new System.Drawing.Point(520, 189);
            this.btubah.Name = "btubah";
            this.btubah.Size = new System.Drawing.Size(92, 42);
            this.btubah.TabIndex = 62;
            this.btubah.Text = "Ubah";
            this.btubah.UseVisualStyleBackColor = true;
            this.btubah.Click += new System.EventHandler(this.btubah_Click);
            // 
            // bttetapkan
            // 
            this.bttetapkan.Location = new System.Drawing.Point(424, 142);
            this.bttetapkan.Name = "bttetapkan";
            this.bttetapkan.Size = new System.Drawing.Size(188, 42);
            this.bttetapkan.TabIndex = 61;
            this.bttetapkan.Text = "Tetapkan harga";
            this.bttetapkan.UseVisualStyleBackColor = true;
            this.bttetapkan.Click += new System.EventHandler(this.bttetapkan_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 42);
            this.button5.TabIndex = 60;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "HARGA YANG DITETAPKAN";
            // 
            // Harga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 474);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvharga);
            this.Controls.Add(this.txcsetrika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txhwangi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txhpkilat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txhkg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bthapus);
            this.Controls.Add(this.btubah);
            this.Controls.Add(this.bttetapkan);
            this.Controls.Add(this.button5);
            this.Name = "Harga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harga";
            this.Load += new System.EventHandler(this.Harga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvharga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvharga;
        private System.Windows.Forms.TextBox txcsetrika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txhwangi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txhpkilat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txhkg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bthapus;
        private System.Windows.Forms.Button btubah;
        private System.Windows.Forms.Button bttetapkan;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
    }
}