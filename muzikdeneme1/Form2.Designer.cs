namespace muzikdeneme1
{
    partial class Form2
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtSarkiAdi = new System.Windows.Forms.TextBox();
            this.txtTurID = new System.Windows.Forms.TextBox();
            this.txtAlbumID = new System.Windows.Forms.TextBox();
            this.txtSanatciID = new System.Windows.Forms.TextBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArama = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvGoster = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEkle.Font = new System.Drawing.Font("SWComp", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(297, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(154, 87);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuncelle.Font = new System.Drawing.Font("SWComp", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(471, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(254, 87);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSil.Font = new System.Drawing.Font("SWComp", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(731, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(154, 87);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtSarkiAdi
            // 
            this.txtSarkiAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSarkiAdi.Location = new System.Drawing.Point(127, 22);
            this.txtSarkiAdi.Multiline = true;
            this.txtSarkiAdi.Name = "txtSarkiAdi";
            this.txtSarkiAdi.Size = new System.Drawing.Size(144, 41);
            this.txtSarkiAdi.TabIndex = 3;
            // 
            // txtTurID
            // 
            this.txtTurID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTurID.Location = new System.Drawing.Point(126, 69);
            this.txtTurID.Name = "txtTurID";
            this.txtTurID.Size = new System.Drawing.Size(108, 22);
            this.txtTurID.TabIndex = 4;
            // 
            // txtAlbumID
            // 
            this.txtAlbumID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAlbumID.Location = new System.Drawing.Point(126, 97);
            this.txtAlbumID.Name = "txtAlbumID";
            this.txtAlbumID.Size = new System.Drawing.Size(109, 22);
            this.txtAlbumID.TabIndex = 5;
            // 
            // txtSanatciID
            // 
            this.txtSanatciID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSanatciID.Location = new System.Drawing.Point(126, 125);
            this.txtSanatciID.Name = "txtSanatciID";
            this.txtSanatciID.Size = new System.Drawing.Size(109, 22);
            this.txtSanatciID.TabIndex = 6;
            // 
            // txtSure
            // 
            this.txtSure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSure.Location = new System.Drawing.Point(127, 153);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(109, 22);
            this.txtSure.TabIndex = 7;
            // 
            // txtArama
            // 
            this.txtArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtArama.Location = new System.Drawing.Point(125, 200);
            this.txtArama.Multiline = true;
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(146, 43);
            this.txtArama.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "  ŞARKI ADI    ";
            // 
            // btnArama
            // 
            this.btnArama.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnArama.Font = new System.Drawing.Font("Minion Pro", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArama.Location = new System.Drawing.Point(321, 200);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(114, 49);
            this.btnArama.TabIndex = 10;
            this.btnArama.Text = "ARA";
            this.btnArama.UseVisualStyleBackColor = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "  TÜR ID          ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "  ALBÜM ID    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "  SANATÇI ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "  SÜRE            ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(12, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "  ŞARKI GİR    ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dgvGoster
            // 
            this.dgvGoster.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoster.Location = new System.Drawing.Point(18, 263);
            this.dgvGoster.Name = "dgvGoster";
            this.dgvGoster.RowHeadersWidth = 51;
            this.dgvGoster.RowTemplate.Height = 24;
            this.dgvGoster.Size = new System.Drawing.Size(883, 277);
            this.dgvGoster.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(913, 552);
            this.Controls.Add(this.dgvGoster);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.txtSanatciID);
            this.Controls.Add(this.txtAlbumID);
            this.Controls.Add(this.txtTurID);
            this.Controls.Add(this.txtSarkiAdi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtSarkiAdi;
        private System.Windows.Forms.TextBox txtTurID;
        private System.Windows.Forms.TextBox txtAlbumID;
        private System.Windows.Forms.TextBox txtSanatciID;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvGoster;
    }
}