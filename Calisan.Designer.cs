namespace WindowsFormsApp1
{
    partial class Calisan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calisan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.CalisanDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCalSifre = new DevExpress.XtraEditors.ButtonEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCalAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bnfBtnKatdet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfBtnDuzenle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfBtnSil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalisanDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 550);
            this.panel1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(64, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Çıkış";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.Location = new System.Drawing.Point(35, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 25);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışan";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(195, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 50);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("Magneto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(171, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kan Bankası Yönetim Sistemi";
            // 
            // CalisanDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CalisanDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CalisanDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CalisanDGV.ColumnHeadersHeight = 20;
            this.CalisanDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CalisanDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.CalisanDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CalisanDGV.Location = new System.Drawing.Point(201, 154);
            this.CalisanDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalisanDGV.Name = "CalisanDGV";
            this.CalisanDGV.RowHeadersVisible = false;
            this.CalisanDGV.RowHeadersWidth = 51;
            this.CalisanDGV.RowTemplate.Height = 20;
            this.CalisanDGV.Size = new System.Drawing.Size(676, 233);
            this.CalisanDGV.TabIndex = 47;
            this.CalisanDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CalisanDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CalisanDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CalisanDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CalisanDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CalisanDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CalisanDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CalisanDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.MidnightBlue;
            this.CalisanDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CalisanDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalisanDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CalisanDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CalisanDGV.ThemeStyle.HeaderStyle.Height = 20;
            this.CalisanDGV.ThemeStyle.ReadOnly = false;
            this.CalisanDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CalisanDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CalisanDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalisanDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CalisanDGV.ThemeStyle.RowsStyle.Height = 20;
            this.CalisanDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Red;
            this.CalisanDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CalisanDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CalisanDGV_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(421, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 23);
            this.label12.TabIndex = 43;
            this.label12.Text = "Şifre";
            // 
            // txtCalSifre
            // 
            this.txtCalSifre.Location = new System.Drawing.Point(425, 414);
            this.txtCalSifre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCalSifre.Name = "txtCalSifre";
            this.txtCalSifre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCalSifre.Size = new System.Drawing.Size(149, 22);
            this.txtCalSifre.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(201, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 23);
            this.label11.TabIndex = 41;
            this.label11.Text = "Adı Soyadı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(427, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 28);
            this.label10.TabIndex = 39;
            this.label10.Text = "Çalışan";
            // 
            // txtCalAdSoyad
            // 
            this.txtCalAdSoyad.Location = new System.Drawing.Point(205, 414);
            this.txtCalAdSoyad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCalAdSoyad.Name = "txtCalAdSoyad";
            this.txtCalAdSoyad.Size = new System.Drawing.Size(161, 22);
            this.txtCalAdSoyad.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(779, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // bnfBtnKatdet
            // 
            this.bnfBtnKatdet.ActiveBorderThickness = 1;
            this.bnfBtnKatdet.ActiveCornerRadius = 20;
            this.bnfBtnKatdet.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bnfBtnKatdet.ActiveForecolor = System.Drawing.Color.White;
            this.bnfBtnKatdet.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bnfBtnKatdet.BackColor = System.Drawing.SystemColors.Control;
            this.bnfBtnKatdet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfBtnKatdet.BackgroundImage")));
            this.bnfBtnKatdet.ButtonText = "Kaydet";
            this.bnfBtnKatdet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfBtnKatdet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfBtnKatdet.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfBtnKatdet.IdleBorderThickness = 1;
            this.bnfBtnKatdet.IdleCornerRadius = 20;
            this.bnfBtnKatdet.IdleFillColor = System.Drawing.Color.White;
            this.bnfBtnKatdet.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bnfBtnKatdet.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bnfBtnKatdet.Location = new System.Drawing.Point(226, 481);
            this.bnfBtnKatdet.Margin = new System.Windows.Forms.Padding(5);
            this.bnfBtnKatdet.Name = "bnfBtnKatdet";
            this.bnfBtnKatdet.Size = new System.Drawing.Size(106, 41);
            this.bnfBtnKatdet.TabIndex = 51;
            this.bnfBtnKatdet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfBtnKatdet.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bnfBtnDuzenle
            // 
            this.bnfBtnDuzenle.ActiveBorderThickness = 1;
            this.bnfBtnDuzenle.ActiveCornerRadius = 20;
            this.bnfBtnDuzenle.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bnfBtnDuzenle.ActiveForecolor = System.Drawing.Color.White;
            this.bnfBtnDuzenle.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bnfBtnDuzenle.BackColor = System.Drawing.SystemColors.Control;
            this.bnfBtnDuzenle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfBtnDuzenle.BackgroundImage")));
            this.bnfBtnDuzenle.ButtonText = "Düzenle";
            this.bnfBtnDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfBtnDuzenle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfBtnDuzenle.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfBtnDuzenle.IdleBorderThickness = 1;
            this.bnfBtnDuzenle.IdleCornerRadius = 20;
            this.bnfBtnDuzenle.IdleFillColor = System.Drawing.Color.White;
            this.bnfBtnDuzenle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bnfBtnDuzenle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bnfBtnDuzenle.Location = new System.Drawing.Point(371, 481);
            this.bnfBtnDuzenle.Margin = new System.Windows.Forms.Padding(5);
            this.bnfBtnDuzenle.Name = "bnfBtnDuzenle";
            this.bnfBtnDuzenle.Size = new System.Drawing.Size(112, 41);
            this.bnfBtnDuzenle.TabIndex = 52;
            this.bnfBtnDuzenle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfBtnDuzenle.Click += new System.EventHandler(this.bnfBtnDuzenle_Click);
            // 
            // bnfBtnSil
            // 
            this.bnfBtnSil.ActiveBorderThickness = 1;
            this.bnfBtnSil.ActiveCornerRadius = 20;
            this.bnfBtnSil.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bnfBtnSil.ActiveForecolor = System.Drawing.Color.White;
            this.bnfBtnSil.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bnfBtnSil.BackColor = System.Drawing.SystemColors.Control;
            this.bnfBtnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfBtnSil.BackgroundImage")));
            this.bnfBtnSil.ButtonText = "Sil";
            this.bnfBtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfBtnSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfBtnSil.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfBtnSil.IdleBorderThickness = 1;
            this.bnfBtnSil.IdleCornerRadius = 20;
            this.bnfBtnSil.IdleFillColor = System.Drawing.Color.White;
            this.bnfBtnSil.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bnfBtnSil.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bnfBtnSil.Location = new System.Drawing.Point(522, 481);
            this.bnfBtnSil.Margin = new System.Windows.Forms.Padding(5);
            this.bnfBtnSil.Name = "bnfBtnSil";
            this.bnfBtnSil.Size = new System.Drawing.Size(124, 41);
            this.bnfBtnSil.TabIndex = 53;
            this.bnfBtnSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfBtnSil.Click += new System.EventHandler(this.bnfBtnSil_Click);
            // 
            // Calisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 550);
            this.Controls.Add(this.bnfBtnSil);
            this.Controls.Add(this.bnfBtnDuzenle);
            this.Controls.Add(this.bnfBtnKatdet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CalisanDGV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCalSifre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCalAdSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calisan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calisan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalisanDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView CalisanDGV;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.ButtonEdit txtCalSifre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtCalAdSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfBtnKatdet;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfBtnDuzenle;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfBtnSil;
    }
}