namespace Praktikum_11_april
{
    partial class Form1
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
            this.CboxKiri = new System.Windows.Forms.ComboBox();
            this.CboxKanan = new System.Windows.Forms.ComboBox();
            this.LbManagerKiri = new System.Windows.Forms.Label();
            this.LbCaptainKiri = new System.Windows.Forms.Label();
            this.LbManagerKanan = new System.Windows.Forms.Label();
            this.LbCaptainKanan = new System.Windows.Forms.Label();
            this.LbStadium = new System.Windows.Forms.Label();
            this.LbCapacity = new System.Windows.Forms.Label();
            this.LbTanggal = new System.Windows.Forms.Label();
            this.LbSkor = new System.Windows.Forms.Label();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.DtHasil = new System.Windows.Forms.DataGridView();
            this.LbTanggalFormat = new System.Windows.Forms.Label();
            this.LbSkorAkhir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtHasil)).BeginInit();
            this.SuspendLayout();
            // 
            // CboxKiri
            // 
            this.CboxKiri.FormattingEnabled = true;
            this.CboxKiri.Location = new System.Drawing.Point(85, 55);
            this.CboxKiri.Name = "CboxKiri";
            this.CboxKiri.Size = new System.Drawing.Size(121, 24);
            this.CboxKiri.TabIndex = 0;
            this.CboxKiri.SelectedIndexChanged += new System.EventHandler(this.CboxKiri_SelectedIndexChanged);
            // 
            // CboxKanan
            // 
            this.CboxKanan.FormattingEnabled = true;
            this.CboxKanan.Location = new System.Drawing.Point(596, 55);
            this.CboxKanan.Name = "CboxKanan";
            this.CboxKanan.Size = new System.Drawing.Size(121, 24);
            this.CboxKanan.TabIndex = 1;
            this.CboxKanan.SelectedIndexChanged += new System.EventHandler(this.CboxKanan_SelectedIndexChanged);
            // 
            // LbManagerKiri
            // 
            this.LbManagerKiri.AutoSize = true;
            this.LbManagerKiri.Location = new System.Drawing.Point(85, 111);
            this.LbManagerKiri.Name = "LbManagerKiri";
            this.LbManagerKiri.Size = new System.Drawing.Size(67, 16);
            this.LbManagerKiri.TabIndex = 2;
            this.LbManagerKiri.Text = "Manager :";
            this.LbManagerKiri.Click += new System.EventHandler(this.LbManagerKiri_Click);
            // 
            // LbCaptainKiri
            // 
            this.LbCaptainKiri.AutoSize = true;
            this.LbCaptainKiri.Location = new System.Drawing.Point(85, 159);
            this.LbCaptainKiri.Name = "LbCaptainKiri";
            this.LbCaptainKiri.Size = new System.Drawing.Size(59, 16);
            this.LbCaptainKiri.TabIndex = 3;
            this.LbCaptainKiri.Text = "Captain :";
            // 
            // LbManagerKanan
            // 
            this.LbManagerKanan.AutoSize = true;
            this.LbManagerKanan.Location = new System.Drawing.Point(593, 111);
            this.LbManagerKanan.Name = "LbManagerKanan";
            this.LbManagerKanan.Size = new System.Drawing.Size(67, 16);
            this.LbManagerKanan.TabIndex = 4;
            this.LbManagerKanan.Text = "Manager :";
            // 
            // LbCaptainKanan
            // 
            this.LbCaptainKanan.AutoSize = true;
            this.LbCaptainKanan.Location = new System.Drawing.Point(593, 159);
            this.LbCaptainKanan.Name = "LbCaptainKanan";
            this.LbCaptainKanan.Size = new System.Drawing.Size(59, 16);
            this.LbCaptainKanan.TabIndex = 5;
            this.LbCaptainKanan.Text = "Captain :";
            // 
            // LbStadium
            // 
            this.LbStadium.AutoSize = true;
            this.LbStadium.Location = new System.Drawing.Point(334, 190);
            this.LbStadium.Name = "LbStadium";
            this.LbStadium.Size = new System.Drawing.Size(62, 16);
            this.LbStadium.TabIndex = 6;
            this.LbStadium.Text = "Stadium :";
            // 
            // LbCapacity
            // 
            this.LbCapacity.AutoSize = true;
            this.LbCapacity.Location = new System.Drawing.Point(334, 218);
            this.LbCapacity.Name = "LbCapacity";
            this.LbCapacity.Size = new System.Drawing.Size(66, 16);
            this.LbCapacity.TabIndex = 7;
            this.LbCapacity.Text = "Capacity :";
            // 
            // LbTanggal
            // 
            this.LbTanggal.AutoSize = true;
            this.LbTanggal.Location = new System.Drawing.Point(334, 283);
            this.LbTanggal.Name = "LbTanggal";
            this.LbTanggal.Size = new System.Drawing.Size(67, 16);
            this.LbTanggal.TabIndex = 8;
            this.LbTanggal.Text = "Tanggal : ";
            // 
            // LbSkor
            // 
            this.LbSkor.AutoSize = true;
            this.LbSkor.Location = new System.Drawing.Point(352, 320);
            this.LbSkor.Name = "LbSkor";
            this.LbSkor.Size = new System.Drawing.Size(44, 16);
            this.LbSkor.TabIndex = 9;
            this.LbSkor.Text = "Skor : ";
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(325, 246);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(75, 23);
            this.BtnCheck.TabIndex = 10;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // DtHasil
            // 
            this.DtHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtHasil.Location = new System.Drawing.Point(25, 370);
            this.DtHasil.Name = "DtHasil";
            this.DtHasil.RowHeadersWidth = 51;
            this.DtHasil.RowTemplate.Height = 24;
            this.DtHasil.Size = new System.Drawing.Size(745, 196);
            this.DtHasil.TabIndex = 11;
            // 
            // LbTanggalFormat
            // 
            this.LbTanggalFormat.AutoSize = true;
            this.LbTanggalFormat.Location = new System.Drawing.Point(419, 283);
            this.LbTanggalFormat.Name = "LbTanggalFormat";
            this.LbTanggalFormat.Size = new System.Drawing.Size(0, 16);
            this.LbTanggalFormat.TabIndex = 12;
            // 
            // LbSkorAkhir
            // 
            this.LbSkorAkhir.AutoSize = true;
            this.LbSkorAkhir.Location = new System.Drawing.Point(419, 320);
            this.LbSkorAkhir.Name = "LbSkorAkhir";
            this.LbSkorAkhir.Size = new System.Drawing.Size(0, 16);
            this.LbSkorAkhir.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.LbSkorAkhir);
            this.Controls.Add(this.LbTanggalFormat);
            this.Controls.Add(this.DtHasil);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.LbSkor);
            this.Controls.Add(this.LbTanggal);
            this.Controls.Add(this.LbCapacity);
            this.Controls.Add(this.LbStadium);
            this.Controls.Add(this.LbCaptainKanan);
            this.Controls.Add(this.LbManagerKanan);
            this.Controls.Add(this.LbCaptainKiri);
            this.Controls.Add(this.LbManagerKiri);
            this.Controls.Add(this.CboxKanan);
            this.Controls.Add(this.CboxKiri);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtHasil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboxKiri;
        private System.Windows.Forms.ComboBox CboxKanan;
        private System.Windows.Forms.Label LbManagerKiri;
        private System.Windows.Forms.Label LbCaptainKiri;
        private System.Windows.Forms.Label LbManagerKanan;
        private System.Windows.Forms.Label LbCaptainKanan;
        private System.Windows.Forms.Label LbStadium;
        private System.Windows.Forms.Label LbCapacity;
        private System.Windows.Forms.Label LbTanggal;
        private System.Windows.Forms.Label LbSkor;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.DataGridView DtHasil;
        private System.Windows.Forms.Label LbTanggalFormat;
        private System.Windows.Forms.Label LbSkorAkhir;
    }
}

