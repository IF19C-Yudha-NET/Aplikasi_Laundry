
namespace Aplikasi_Laundry
{
    partial class CucianKeluar
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
            this.bthpusmua = new System.Windows.Forms.Button();
            this.bthapus = new System.Windows.Forms.Button();
            this.btcari = new System.Windows.Forms.Button();
            this.txcari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvcuciankeluar = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuciankeluar)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(265, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 24);
            this.label7.TabIndex = 68;
            this.label7.Text = "CUCIAN KELUAR";
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(773, 97);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(91, 42);
            this.btrefresh.TabIndex = 67;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            // 
            // bthpusmua
            // 
            this.bthpusmua.Location = new System.Drawing.Point(477, 97);
            this.bthpusmua.Name = "bthpusmua";
            this.bthpusmua.Size = new System.Drawing.Size(162, 42);
            this.bthpusmua.TabIndex = 66;
            this.bthpusmua.Text = "Hapus semua";
            this.bthpusmua.UseVisualStyleBackColor = true;
            // 
            // bthapus
            // 
            this.bthapus.Location = new System.Drawing.Point(366, 97);
            this.bthapus.Name = "bthapus";
            this.bthapus.Size = new System.Drawing.Size(91, 42);
            this.bthapus.TabIndex = 65;
            this.bthapus.Text = "Hapus";
            this.bthapus.UseVisualStyleBackColor = true;
            // 
            // btcari
            // 
            this.btcari.Location = new System.Drawing.Point(260, 97);
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(91, 42);
            this.btcari.TabIndex = 64;
            this.btcari.Text = "Cari";
            this.btcari.UseVisualStyleBackColor = true;
            // 
            // txcari
            // 
            this.txcari.Location = new System.Drawing.Point(154, 105);
            this.txcari.Name = "txcari";
            this.txcari.Size = new System.Drawing.Size(100, 26);
            this.txcari.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Id cucian masuk";
            // 
            // dgvcuciankeluar
            // 
            this.dgvcuciankeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcuciankeluar.Location = new System.Drawing.Point(27, 182);
            this.dgvcuciankeluar.Name = "dgvcuciankeluar";
            this.dgvcuciankeluar.RowHeadersWidth = 62;
            this.dgvcuciankeluar.RowTemplate.Height = 28;
            this.dgvcuciankeluar.Size = new System.Drawing.Size(837, 286);
            this.dgvcuciankeluar.TabIndex = 61;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(5, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 42);
            this.button5.TabIndex = 60;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 20);
            this.label8.TabIndex = 83;
            this.label8.Text = "CUCIAN YANG SUDAH DIAMBIL";
            // 
            // CucianKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 480);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btrefresh);
            this.Controls.Add(this.bthpusmua);
            this.Controls.Add(this.bthapus);
            this.Controls.Add(this.btcari);
            this.Controls.Add(this.txcari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvcuciankeluar);
            this.Controls.Add(this.button5);
            this.Name = "CucianKeluar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CucianKeluar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuciankeluar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.Button bthpusmua;
        private System.Windows.Forms.Button bthapus;
        private System.Windows.Forms.Button btcari;
        private System.Windows.Forms.TextBox txcari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvcuciankeluar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
    }
}