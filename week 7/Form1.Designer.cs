
namespace week_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_kalimat = new System.Windows.Forms.Label();
            this.lbl_huruf = new System.Windows.Forms.Label();
            this.txtB_kalimat = new System.Windows.Forms.TextBox();
            this.lbl_jadi = new System.Windows.Forms.Label();
            this.txtB_huruf = new System.Windows.Forms.TextBox();
            this.txtB_jadi = new System.Windows.Forms.TextBox();
            this.btn_konversi = new System.Windows.Forms.Button();
            this.lbl_hasil = new System.Windows.Forms.Label();
            this.lbl_Hasiljadi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_kalimat
            // 
            this.lbl_kalimat.AutoSize = true;
            this.lbl_kalimat.Location = new System.Drawing.Point(53, 56);
            this.lbl_kalimat.Name = "lbl_kalimat";
            this.lbl_kalimat.Size = new System.Drawing.Size(122, 20);
            this.lbl_kalimat.TabIndex = 0;
            this.lbl_kalimat.Text = "Masukan Kalimat";
            // 
            // lbl_huruf
            // 
            this.lbl_huruf.AutoSize = true;
            this.lbl_huruf.Location = new System.Drawing.Point(53, 134);
            this.lbl_huruf.Name = "lbl_huruf";
            this.lbl_huruf.Size = new System.Drawing.Size(108, 20);
            this.lbl_huruf.TabIndex = 1;
            this.lbl_huruf.Text = "Masukan Huruf";
            // 
            // txtB_kalimat
            // 
            this.txtB_kalimat.Location = new System.Drawing.Point(181, 53);
            this.txtB_kalimat.Name = "txtB_kalimat";
            this.txtB_kalimat.Size = new System.Drawing.Size(362, 27);
            this.txtB_kalimat.TabIndex = 2;
            // 
            // lbl_jadi
            // 
            this.lbl_jadi.AutoSize = true;
            this.lbl_jadi.Location = new System.Drawing.Point(398, 130);
            this.lbl_jadi.Name = "lbl_jadi";
            this.lbl_jadi.Size = new System.Drawing.Size(63, 20);
            this.lbl_jadi.TabIndex = 3;
            this.lbl_jadi.Text = "Menjadi";
            // 
            // txtB_huruf
            // 
            this.txtB_huruf.Location = new System.Drawing.Point(181, 131);
            this.txtB_huruf.Name = "txtB_huruf";
            this.txtB_huruf.Size = new System.Drawing.Size(76, 27);
            this.txtB_huruf.TabIndex = 4;
            // 
            // txtB_jadi
            // 
            this.txtB_jadi.Location = new System.Drawing.Point(467, 127);
            this.txtB_jadi.Name = "txtB_jadi";
            this.txtB_jadi.Size = new System.Drawing.Size(76, 27);
            this.txtB_jadi.TabIndex = 5;
            // 
            // btn_konversi
            // 
            this.btn_konversi.Location = new System.Drawing.Point(181, 190);
            this.btn_konversi.Name = "btn_konversi";
            this.btn_konversi.Size = new System.Drawing.Size(362, 29);
            this.btn_konversi.TabIndex = 6;
            this.btn_konversi.Text = "Konversi?";
            this.btn_konversi.UseVisualStyleBackColor = true;
            this.btn_konversi.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_hasil
            // 
            this.lbl_hasil.AutoSize = true;
            this.lbl_hasil.Location = new System.Drawing.Point(53, 317);
            this.lbl_hasil.Name = "lbl_hasil";
            this.lbl_hasil.Size = new System.Drawing.Size(46, 20);
            this.lbl_hasil.TabIndex = 7;
            this.lbl_hasil.Text = "Hasil ";
            // 
            // lbl_Hasiljadi
            // 
            this.lbl_Hasiljadi.AutoSize = true;
            this.lbl_Hasiljadi.Location = new System.Drawing.Point(152, 317);
            this.lbl_Hasiljadi.Name = "lbl_Hasiljadi";
            this.lbl_Hasiljadi.Size = new System.Drawing.Size(0, 20);
            this.lbl_Hasiljadi.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Hasiljadi);
            this.Controls.Add(this.lbl_hasil);
            this.Controls.Add(this.btn_konversi);
            this.Controls.Add(this.txtB_jadi);
            this.Controls.Add(this.txtB_huruf);
            this.Controls.Add(this.lbl_jadi);
            this.Controls.Add(this.txtB_kalimat);
            this.Controls.Add(this.lbl_huruf);
            this.Controls.Add(this.lbl_kalimat);
            this.Name = "Form1";
            this.Text = "konversi huruf to huruf ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kalimat;
        private System.Windows.Forms.Label lbl_huruf;
        private System.Windows.Forms.TextBox txtB_kalimat;
        private System.Windows.Forms.Label lbl_jadi;
        private System.Windows.Forms.TextBox txtB_huruf;
        private System.Windows.Forms.TextBox txtB_jadi;
        private System.Windows.Forms.Button btn_konversi;
        private System.Windows.Forms.Label lbl_hasil;
        private System.Windows.Forms.Label lbl_Hasiljadi;
    }
}

