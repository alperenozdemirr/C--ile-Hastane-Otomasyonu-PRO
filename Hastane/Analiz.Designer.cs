
namespace Hastane
{
    partial class Analiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analiz));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Hastasayisi = new System.Windows.Forms.Label();
            this.Personelsayisi = new System.Windows.Forms.Label();
            this.Kayitlisayi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Sırada Bekleyen Hastalar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hastanedeki Toplam Personel Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toplam Hastanede Kayıtlı Olan Hastalar";
            // 
            // Hastasayisi
            // 
            this.Hastasayisi.AutoSize = true;
            this.Hastasayisi.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Hastasayisi.ForeColor = System.Drawing.Color.OliveDrab;
            this.Hastasayisi.Location = new System.Drawing.Point(441, 262);
            this.Hastasayisi.Name = "Hastasayisi";
            this.Hastasayisi.Size = new System.Drawing.Size(0, 19);
            this.Hastasayisi.TabIndex = 0;
            // 
            // Personelsayisi
            // 
            this.Personelsayisi.AutoSize = true;
            this.Personelsayisi.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Personelsayisi.ForeColor = System.Drawing.Color.OliveDrab;
            this.Personelsayisi.Location = new System.Drawing.Point(441, 292);
            this.Personelsayisi.Name = "Personelsayisi";
            this.Personelsayisi.Size = new System.Drawing.Size(0, 19);
            this.Personelsayisi.TabIndex = 1;
            // 
            // Kayitlisayi
            // 
            this.Kayitlisayi.AutoSize = true;
            this.Kayitlisayi.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayitlisayi.ForeColor = System.Drawing.Color.OliveDrab;
            this.Kayitlisayi.Location = new System.Drawing.Point(441, 324);
            this.Kayitlisayi.Name = "Kayitlisayi";
            this.Kayitlisayi.Size = new System.Drawing.Size(0, 19);
            this.Kayitlisayi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(117, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Güncel Veri Analizleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Analiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Kayitlisayi);
            this.Controls.Add(this.Personelsayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hastasayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Analiz";
            this.Text = "Analiz";
            this.Load += new System.EventHandler(this.Analiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Hastasayisi;
        private System.Windows.Forms.Label Personelsayisi;
        private System.Windows.Forms.Label Kayitlisayi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}