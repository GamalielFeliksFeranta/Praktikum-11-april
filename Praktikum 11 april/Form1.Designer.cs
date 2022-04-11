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
            this.LbStadium.Location = new System.Drawing.Point(336, 299);
            this.LbStadium.Name = "LbStadium";
            this.LbStadium.Size = new System.Drawing.Size(56, 16);
            this.LbStadium.TabIndex = 6;
            this.LbStadium.Text = "Stadium";
            // 
            // LbCapacity
            // 
            this.LbCapacity.AutoSize = true;
            this.LbCapacity.Location = new System.Drawing.Point(336, 344);
            this.LbCapacity.Name = "LbCapacity";
            this.LbCapacity.Size = new System.Drawing.Size(60, 16);
            this.LbCapacity.TabIndex = 7;
            this.LbCapacity.Text = "Capacity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbCapacity);
            this.Controls.Add(this.LbStadium);
            this.Controls.Add(this.LbCaptainKanan);
            this.Controls.Add(this.LbManagerKanan);
            this.Controls.Add(this.LbCaptainKiri);
            this.Controls.Add(this.LbManagerKiri);
            this.Controls.Add(this.CboxKanan);
            this.Controls.Add(this.CboxKiri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

