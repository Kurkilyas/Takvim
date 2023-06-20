namespace Proje
{
    partial class EventFormcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventFormcs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnkaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOlayTip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOlayAciklama = new System.Windows.Forms.TextBox();
            this.txtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.txtOlayınTanım = new System.Windows.Forms.MaskedTextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.bttnSil = new System.Windows.Forms.Button();
            this.bttnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "baslangic:";
            // 
            // btnnkaydet
            // 
            this.btnnkaydet.Location = new System.Drawing.Point(365, 371);
            this.btnnkaydet.Name = "btnnkaydet";
            this.btnnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnnkaydet.TabIndex = 5;
            this.btnnkaydet.Text = "Kaydet";
            this.btnnkaydet.UseVisualStyleBackColor = true;
            this.btnnkaydet.Click += new System.EventHandler(this.btnnkaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "olayın tanımlanması:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "olayın tipi:";
            // 
            // txtOlayTip
            // 
            this.txtOlayTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOlayTip.Location = new System.Drawing.Point(74, 251);
            this.txtOlayTip.Name = "txtOlayTip";
            this.txtOlayTip.Size = new System.Drawing.Size(366, 30);
            this.txtOlayTip.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "olayın açıklaması:\r\n";
            // 
            // txtOlayAciklama
            // 
            this.txtOlayAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOlayAciklama.Location = new System.Drawing.Point(74, 326);
            this.txtOlayAciklama.Name = "txtOlayAciklama";
            this.txtOlayAciklama.Size = new System.Drawing.Size(366, 30);
            this.txtOlayAciklama.TabIndex = 4;
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaslangic.Location = new System.Drawing.Point(74, 117);
            this.txtBaslangic.Mask = "00:00";
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(366, 30);
            this.txtBaslangic.TabIndex = 1;
            this.txtBaslangic.ValidatingType = typeof(System.DateTime);
            // 
            // txtOlayınTanım
            // 
            this.txtOlayınTanım.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOlayınTanım.Location = new System.Drawing.Point(74, 184);
            this.txtOlayınTanım.Mask = "00:00";
            this.txtOlayınTanım.Name = "txtOlayınTanım";
            this.txtOlayınTanım.Size = new System.Drawing.Size(366, 30);
            this.txtOlayınTanım.TabIndex = 2;
            this.txtOlayınTanım.ValidatingType = typeof(System.DateTime);
            // 
            // txtTarih
            // 
            this.txtTarih.Enabled = false;
            this.txtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.Location = new System.Drawing.Point(74, 56);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(366, 30);
            this.txtTarih.TabIndex = 14;
            // 
            // bttnSil
            // 
            this.bttnSil.Location = new System.Drawing.Point(365, 400);
            this.bttnSil.Name = "bttnSil";
            this.bttnSil.Size = new System.Drawing.Size(75, 23);
            this.bttnSil.TabIndex = 6;
            this.bttnSil.Text = "Sil";
            this.bttnSil.UseVisualStyleBackColor = true;
            this.bttnSil.Click += new System.EventHandler(this.bttnSil_Click);
            // 
            // bttnGuncelle
            // 
            this.bttnGuncelle.Location = new System.Drawing.Point(365, 429);
            this.bttnGuncelle.Name = "bttnGuncelle";
            this.bttnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.bttnGuncelle.TabIndex = 7;
            this.bttnGuncelle.Text = "Güncelle";
            this.bttnGuncelle.UseVisualStyleBackColor = true;
            this.bttnGuncelle.Click += new System.EventHandler(this.bttnGuncelle_Click);
            // 
            // EventFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 528);
            this.Controls.Add(this.bttnGuncelle);
            this.Controls.Add(this.bttnSil);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtOlayınTanım);
            this.Controls.Add(this.txtBaslangic);
            this.Controls.Add(this.txtOlayAciklama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOlayTip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnnkaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventFormcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventFormcs";
            this.Load += new System.EventHandler(this.EventFormcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnkaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOlayTip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOlayAciklama;
        private System.Windows.Forms.MaskedTextBox txtBaslangic;
        private System.Windows.Forms.MaskedTextBox txtOlayınTanım;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Button bttnSil;
        private System.Windows.Forms.Button bttnGuncelle;
    }
}