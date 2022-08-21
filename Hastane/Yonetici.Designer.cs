
namespace Hastane
{
    partial class Yonetici
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
            this.dataPersonel = new System.Windows.Forms.DataGridView();
            this.dataSira = new System.Windows.Forms.DataGridView();
            this.dataKayit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPersonel
            // 
            this.dataPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPersonel.Location = new System.Drawing.Point(12, 92);
            this.dataPersonel.Name = "dataPersonel";
            this.dataPersonel.Size = new System.Drawing.Size(1118, 171);
            this.dataPersonel.TabIndex = 0;
            // 
            // dataSira
            // 
            this.dataSira.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSira.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSira.Location = new System.Drawing.Point(12, 297);
            this.dataSira.Name = "dataSira";
            this.dataSira.Size = new System.Drawing.Size(1118, 171);
            this.dataSira.TabIndex = 0;
            // 
            // dataKayit
            // 
            this.dataKayit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKayit.Location = new System.Drawing.Point(12, 502);
            this.dataKayit.Name = "dataKayit";
            this.dataKayit.Size = new System.Drawing.Size(1118, 171);
            this.dataKayit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yönetici Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(481, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Tablosu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(461, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hastane Sıra Tablosu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(481, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hastane Kayıtları";
            // 
            // Yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 697);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataKayit);
            this.Controls.Add(this.dataSira);
            this.Controls.Add(this.dataPersonel);
            this.Name = "Yonetici";
            this.Text = "Yonetici";
            this.Load += new System.EventHandler(this.Yonetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPersonel;
        private System.Windows.Forms.DataGridView dataSira;
        private System.Windows.Forms.DataGridView dataKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}