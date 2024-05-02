
namespace VeriTabanıÖdev
{
    partial class frmDersSil
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
            this.btnSil = new System.Windows.Forms.Button();
            this.txtSilmeKodu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSil
            // 
            this.lblSil.AutoSize = true;
            this.lblSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSil.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblSil.Location = new System.Drawing.Point(131, 157);
            this.lblSil.Name = "lblSil";
            this.lblSil.Size = new System.Drawing.Size(287, 31);
            this.lblSil.TabIndex = 0;
            this.lblSil.Text = "Silinecek Dersin Kodu:";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Lavender;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Teal;
            this.btnSil.Location = new System.Drawing.Point(494, 288);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(215, 60);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Kaydı Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtSilmeKodu
            // 
            this.txtSilmeKodu.BackColor = System.Drawing.Color.Lavender;
            this.txtSilmeKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSilmeKodu.Location = new System.Drawing.Point(494, 156);
            this.txtSilmeKodu.Name = "txtSilmeKodu";
            this.txtSilmeKodu.Size = new System.Drawing.Size(144, 32);
            this.txtSilmeKodu.TabIndex = 2;
            // 
            // frmDersSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(944, 486);
            this.Controls.Add(this.txtSilmeKodu);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblSil);
            this.Name = "frmDersSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDersSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtSilmeKodu;
    }
}