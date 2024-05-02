
namespace VeriTabanıÖdev
{
    partial class frmTranskriptGoruntule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGano = new System.Windows.Forms.Button();
            this.lblGano = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(790, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Lavender;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.Teal;
            this.btnListele.Location = new System.Drawing.Point(68, 332);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(157, 50);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Görüntüle";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGano
            // 
            this.btnGano.BackColor = System.Drawing.Color.Lavender;
            this.btnGano.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGano.ForeColor = System.Drawing.Color.Teal;
            this.btnGano.Location = new System.Drawing.Point(252, 332);
            this.btnGano.Name = "btnGano";
            this.btnGano.Size = new System.Drawing.Size(157, 50);
            this.btnGano.TabIndex = 2;
            this.btnGano.Text = "GANO Hesapla";
            this.btnGano.UseVisualStyleBackColor = false;
            this.btnGano.Click += new System.EventHandler(this.btnGano_Click);
            // 
            // lblGano
            // 
            this.lblGano.AutoSize = true;
            this.lblGano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGano.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblGano.Location = new System.Drawing.Point(456, 342);
            this.lblGano.Name = "lblGano";
            this.lblGano.Size = new System.Drawing.Size(202, 26);
            this.lblGano.TabIndex = 5;
            this.lblGano.Text = "Hesaplanan Sonuç:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblSonuc.Location = new System.Drawing.Point(673, 342);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 26);
            this.lblSonuc.TabIndex = 6;
            // 
            // frmTranskriptGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblGano);
            this.Controls.Add(this.btnGano);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTranskriptGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTranskriptGoruntule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGano;
        private System.Windows.Forms.Label lblGano;
        private System.Windows.Forms.Label lblSonuc;
    }
}