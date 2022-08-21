
namespace Hastane
{
    partial class Sira
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
            this.butonKaydet = new System.Windows.Forms.Button();
            this.textDoktorAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPolikinik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textKimlik = new System.Windows.Forms.TextBox();
            this.lblKimlik = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butonKaydet
            // 
            this.butonKaydet.BackColor = System.Drawing.Color.DarkGreen;
            this.butonKaydet.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonKaydet.ForeColor = System.Drawing.Color.White;
            this.butonKaydet.Location = new System.Drawing.Point(206, 308);
            this.butonKaydet.Name = "butonKaydet";
            this.butonKaydet.Size = new System.Drawing.Size(247, 47);
            this.butonKaydet.TabIndex = 15;
            this.butonKaydet.Text = "Sıra AL";
            this.butonKaydet.UseVisualStyleBackColor = false;
            this.butonKaydet.Click += new System.EventHandler(this.butonKaydet_Click);
            // 
            // textDoktorAd
            // 
            this.textDoktorAd.Location = new System.Drawing.Point(206, 245);
            this.textDoktorAd.Name = "textDoktorAd";
            this.textDoktorAd.Size = new System.Drawing.Size(247, 20);
            this.textDoktorAd.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(69, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Doktor Adı";
            // 
            // textPolikinik
            // 
            this.textPolikinik.Location = new System.Drawing.Point(206, 219);
            this.textPolikinik.Name = "textPolikinik";
            this.textPolikinik.Size = new System.Drawing.Size(247, 20);
            this.textPolikinik.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(69, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Polikinik";
            // 
            // textKimlik
            // 
            this.textKimlik.Location = new System.Drawing.Point(206, 193);
            this.textKimlik.Name = "textKimlik";
            this.textKimlik.Size = new System.Drawing.Size(247, 20);
            this.textKimlik.TabIndex = 13;
            // 
            // lblKimlik
            // 
            this.lblKimlik.AutoSize = true;
            this.lblKimlik.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKimlik.Location = new System.Drawing.Point(69, 191);
            this.lblKimlik.Name = "lblKimlik";
            this.lblKimlik.Size = new System.Drawing.Size(75, 22);
            this.lblKimlik.TabIndex = 8;
            this.lblKimlik.Text = "Kimlik";
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(206, 167);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(247, 20);
            this.textAd.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sıra Alma Bölümü";
            // 
            // Sira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 410);
            this.Controls.Add(this.butonKaydet);
            this.Controls.Add(this.textDoktorAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPolikinik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textKimlik);
            this.Controls.Add(this.lblKimlik);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sira";
            this.Text = "Sira";
            this.Load += new System.EventHandler(this.Sira_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butonKaydet;
        private System.Windows.Forms.TextBox textDoktorAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPolikinik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textKimlik;
        private System.Windows.Forms.Label lblKimlik;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}