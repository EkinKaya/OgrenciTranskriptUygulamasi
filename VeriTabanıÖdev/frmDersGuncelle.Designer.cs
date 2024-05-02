
namespace VeriTabanıÖdev
{
    partial class frmDersGuncelle
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
            this.lblSil = new System.Windows.Forms.Label();
            this.txtGuncellenecekDers = new System.Windows.Forms.TextBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.dataGridViewGüncelleme = new System.Windows.Forms.DataGridView();
            this.lblKod = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownKredi = new System.Windows.Forms.NumericUpDown();
            this.lblAKTS = new System.Windows.Forms.Label();
            this.numericUpDownAKTS = new System.Windows.Forms.NumericUpDown();
            this.lblOgr = new System.Windows.Forms.Label();
            this.txtOgr = new System.Windows.Forms.TextBox();
            this.lblDonem = new System.Windows.Forms.Label();
            this.txtDonem = new System.Windows.Forms.TextBox();
            this.lblNot = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGüncelleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKredi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAKTS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSil
            // 
            this.lblSil.AutoSize = true;
            this.lblSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSil.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblSil.Location = new System.Drawing.Point(147, 35);
            this.lblSil.Name = "lblSil";
            this.lblSil.Size = new System.Drawing.Size(358, 31);
            this.lblSil.TabIndex = 1;
            this.lblSil.Text = "Güncellenecek Dersin Kodu:";
            // 
            // txtGuncellenecekDers
            // 
            this.txtGuncellenecekDers.BackColor = System.Drawing.Color.Lavender;
            this.txtGuncellenecekDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuncellenecekDers.Location = new System.Drawing.Point(528, 34);
            this.txtGuncellenecekDers.Name = "txtGuncellenecekDers";
            this.txtGuncellenecekDers.Size = new System.Drawing.Size(144, 32);
            this.txtGuncellenecekDers.TabIndex = 3;
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.Lavender;
            this.btnGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoster.ForeColor = System.Drawing.Color.Teal;
            this.btnGoster.Location = new System.Drawing.Point(729, 80);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(185, 51);
            this.btnGoster.TabIndex = 4;
            this.btnGoster.Text = "Kaydı Görüntüle";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // dataGridViewGüncelleme
            // 
            this.dataGridViewGüncelleme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGüncelleme.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridViewGüncelleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGüncelleme.Location = new System.Drawing.Point(125, 153);
            this.dataGridViewGüncelleme.Name = "dataGridViewGüncelleme";
            this.dataGridViewGüncelleme.RowHeadersWidth = 51;
            this.dataGridViewGüncelleme.RowTemplate.Height = 24;
            this.dataGridViewGüncelleme.Size = new System.Drawing.Size(790, 68);
            this.dataGridViewGüncelleme.TabIndex = 5;
            this.dataGridViewGüncelleme.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewGüncelleme_CellMouseClick);
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKod.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblKod.Location = new System.Drawing.Point(31, 261);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(121, 26);
            this.lblKod.TabIndex = 6;
            this.lblKod.Text = "Ders Kodu:";
            // 
            // txtKod
            // 
            this.txtKod.BackColor = System.Drawing.Color.Lavender;
            this.txtKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKod.Location = new System.Drawing.Point(177, 255);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(144, 32);
            this.txtKod.TabIndex = 10;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblAd.Location = new System.Drawing.Point(50, 321);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(102, 26);
            this.lblAd.TabIndex = 11;
            this.lblAd.Text = "Ders Adı:";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.Lavender;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(177, 318);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(144, 32);
            this.txtAd.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(15, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ders Kredisi:";
            // 
            // numericUpDownKredi
            // 
            this.numericUpDownKredi.BackColor = System.Drawing.Color.Lavender;
            this.numericUpDownKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownKredi.Location = new System.Drawing.Point(177, 386);
            this.numericUpDownKredi.Name = "numericUpDownKredi";
            this.numericUpDownKredi.Size = new System.Drawing.Size(144, 32);
            this.numericUpDownKredi.TabIndex = 19;
            // 
            // lblAKTS
            // 
            this.lblAKTS.AutoSize = true;
            this.lblAKTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAKTS.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblAKTS.Location = new System.Drawing.Point(430, 261);
            this.lblAKTS.Name = "lblAKTS";
            this.lblAKTS.Size = new System.Drawing.Size(75, 26);
            this.lblAKTS.TabIndex = 20;
            this.lblAKTS.Text = "AKTS:";
            // 
            // numericUpDownAKTS
            // 
            this.numericUpDownAKTS.BackColor = System.Drawing.Color.Lavender;
            this.numericUpDownAKTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownAKTS.Location = new System.Drawing.Point(528, 255);
            this.numericUpDownAKTS.Name = "numericUpDownAKTS";
            this.numericUpDownAKTS.Size = new System.Drawing.Size(144, 32);
            this.numericUpDownAKTS.TabIndex = 21;
            // 
            // lblOgr
            // 
            this.lblOgr.AutoSize = true;
            this.lblOgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgr.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblOgr.Location = new System.Drawing.Point(348, 324);
            this.lblOgr.Name = "lblOgr";
            this.lblOgr.Size = new System.Drawing.Size(157, 26);
            this.lblOgr.TabIndex = 22;
            this.lblOgr.Text = "Öğretim Üyesi:";
            // 
            // txtOgr
            // 
            this.txtOgr.BackColor = System.Drawing.Color.Lavender;
            this.txtOgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgr.Location = new System.Drawing.Point(528, 321);
            this.txtOgr.Name = "txtOgr";
            this.txtOgr.Size = new System.Drawing.Size(144, 32);
            this.txtOgr.TabIndex = 23;
            // 
            // lblDonem
            // 
            this.lblDonem.AutoSize = true;
            this.lblDonem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDonem.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblDonem.Location = new System.Drawing.Point(416, 388);
            this.lblDonem.Name = "lblDonem";
            this.lblDonem.Size = new System.Drawing.Size(89, 26);
            this.lblDonem.TabIndex = 24;
            this.lblDonem.Text = "Dönem:";
            // 
            // txtDonem
            // 
            this.txtDonem.BackColor = System.Drawing.Color.Lavender;
            this.txtDonem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDonem.Location = new System.Drawing.Point(528, 385);
            this.txtDonem.Name = "txtDonem";
            this.txtDonem.Size = new System.Drawing.Size(144, 32);
            this.txtDonem.TabIndex = 25;
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNot.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblNot.Location = new System.Drawing.Point(724, 257);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(111, 26);
            this.lblNot.TabIndex = 26;
            this.lblNot.Text = "Harf Notu:";
            // 
            // txtNot
            // 
            this.txtNot.BackColor = System.Drawing.Color.Lavender;
            this.txtNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNot.Location = new System.Drawing.Point(852, 255);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(144, 32);
            this.txtNot.TabIndex = 27;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.Lavender;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.Color.Teal;
            this.btnGüncelle.Location = new System.Drawing.Point(811, 367);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(185, 51);
            this.btnGüncelle.TabIndex = 28;
            this.btnGüncelle.Text = "Kaydı Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // frmDersGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1022, 468);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.txtDonem);
            this.Controls.Add(this.lblDonem);
            this.Controls.Add(this.txtOgr);
            this.Controls.Add(this.lblOgr);
            this.Controls.Add(this.numericUpDownAKTS);
            this.Controls.Add(this.lblAKTS);
            this.Controls.Add(this.numericUpDownKredi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.dataGridViewGüncelleme);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.txtGuncellenecekDers);
            this.Controls.Add(this.lblSil);
            this.Name = "frmDersGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDersGuncelle";
            this.Load += new System.EventHandler(this.frmDersGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGüncelleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKredi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAKTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSil;
        private System.Windows.Forms.TextBox txtGuncellenecekDers;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.DataGridView dataGridViewGüncelleme;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownKredi;
        private System.Windows.Forms.Label lblAKTS;
        private System.Windows.Forms.NumericUpDown numericUpDownAKTS;
        private System.Windows.Forms.Label lblOgr;
        private System.Windows.Forms.TextBox txtOgr;
        private System.Windows.Forms.Label lblDonem;
        private System.Windows.Forms.TextBox txtDonem;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Button btnGüncelle;
    }
}