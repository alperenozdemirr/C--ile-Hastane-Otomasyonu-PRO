
namespace Hastane
{
    partial class YöneticiGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici Paneline Giriş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Ad";
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(128, 100);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(217, 20);
            this.textAd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(128, 137);
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '.';
            this.textpassword.Size = new System.Drawing.Size(217, 20);
            this.textpassword.TabIndex = 2;
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.Color.DarkGreen;
            this.giris.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.ForeColor = System.Drawing.Color.White;
            this.giris.Location = new System.Drawing.Point(216, 191);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(129, 43);
            this.giris.TabIndex = 3;
            this.giris.Text = "Giriş Yap";
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // YöneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 252);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YöneticiGiris";
            this.Text = "YöneticiGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Button giris;
    }
}