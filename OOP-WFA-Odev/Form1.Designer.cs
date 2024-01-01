namespace OOP_WFA_Odev
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
            gb_araclar = new GroupBox();
            btn_olustur = new Button();
            btn_aracResimEkle = new Button();
            btn_resim = new Button();
            chk_garanti = new CheckBox();
            nmr_motorGucu = new NumericUpDown();
            nmr_model = new NumericUpDown();
            lbl_aracinRengi = new Label();
            btn_aracinRengi = new Button();
            cmb_kasaTipi = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            cmb_yakitTuru = new ComboBox();
            label5 = new Label();
            cmb_sanzimanTuru = new ComboBox();
            label4 = new Label();
            cmb_aracModeli = new ComboBox();
            label3 = new Label();
            cmb_aracMarkasi = new ComboBox();
            label2 = new Label();
            cmb_aracTuru = new ComboBox();
            label1 = new Label();
            pb_resim = new PictureBox();
            cd_aracinRengi = new ColorDialog();
            ofd_aracResmi = new OpenFileDialog();
            label10 = new Label();
            lst_arabaIncele = new ListBox();
            gb_araclar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_motorGucu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_model).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_resim).BeginInit();
            SuspendLayout();
            // 
            // gb_araclar
            // 
            gb_araclar.Controls.Add(btn_olustur);
            gb_araclar.Controls.Add(btn_aracResimEkle);
            gb_araclar.Controls.Add(btn_resim);
            gb_araclar.Controls.Add(chk_garanti);
            gb_araclar.Controls.Add(nmr_motorGucu);
            gb_araclar.Controls.Add(nmr_model);
            gb_araclar.Controls.Add(lbl_aracinRengi);
            gb_araclar.Controls.Add(btn_aracinRengi);
            gb_araclar.Controls.Add(cmb_kasaTipi);
            gb_araclar.Controls.Add(label8);
            gb_araclar.Controls.Add(label9);
            gb_araclar.Controls.Add(label7);
            gb_araclar.Controls.Add(label6);
            gb_araclar.Controls.Add(cmb_yakitTuru);
            gb_araclar.Controls.Add(label5);
            gb_araclar.Controls.Add(cmb_sanzimanTuru);
            gb_araclar.Controls.Add(label4);
            gb_araclar.Controls.Add(cmb_aracModeli);
            gb_araclar.Controls.Add(label3);
            gb_araclar.Controls.Add(cmb_aracMarkasi);
            gb_araclar.Controls.Add(label2);
            gb_araclar.Controls.Add(cmb_aracTuru);
            gb_araclar.Controls.Add(label1);
            gb_araclar.Location = new Point(12, 12);
            gb_araclar.Name = "gb_araclar";
            gb_araclar.Size = new Size(358, 620);
            gb_araclar.TabIndex = 0;
            gb_araclar.TabStop = false;
            gb_araclar.Text = "Araçlar:";
            // 
            // btn_olustur
            // 
            btn_olustur.Location = new Point(202, 389);
            btn_olustur.Name = "btn_olustur";
            btn_olustur.Size = new Size(150, 29);
            btn_olustur.TabIndex = 10;
            btn_olustur.Text = "Oluştur";
            btn_olustur.UseVisualStyleBackColor = true;
            btn_olustur.Click += btn_olustur_Click;
            // 
            // btn_aracResimEkle
            // 
            btn_aracResimEkle.Location = new Point(10, 389);
            btn_aracResimEkle.Name = "btn_aracResimEkle";
            btn_aracResimEkle.Size = new Size(150, 29);
            btn_aracResimEkle.TabIndex = 10;
            btn_aracResimEkle.Text = "Aracın Resmi";
            btn_aracResimEkle.UseVisualStyleBackColor = true;
            btn_aracResimEkle.Click += btn_aracResimEkle_Click;
            // 
            // btn_resim
            // 
            btn_resim.BackgroundImageLayout = ImageLayout.Stretch;
            btn_resim.Location = new Point(10, 436);
            btn_resim.Name = "btn_resim";
            btn_resim.Size = new Size(342, 178);
            btn_resim.TabIndex = 9;
            btn_resim.UseVisualStyleBackColor = true;
            // 
            // chk_garanti
            // 
            chk_garanti.AutoSize = true;
            chk_garanti.Location = new Point(187, 340);
            chk_garanti.Name = "chk_garanti";
            chk_garanti.Size = new Size(114, 24);
            chk_garanti.TabIndex = 8;
            chk_garanti.Text = "Garantisi Var";
            chk_garanti.UseVisualStyleBackColor = true;
            // 
            // nmr_motorGucu
            // 
            nmr_motorGucu.Location = new Point(256, 293);
            nmr_motorGucu.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
            nmr_motorGucu.Name = "nmr_motorGucu";
            nmr_motorGucu.Size = new Size(82, 27);
            nmr_motorGucu.TabIndex = 7;
            // 
            // nmr_model
            // 
            nmr_model.Location = new Point(71, 293);
            nmr_model.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            nmr_model.Name = "nmr_model";
            nmr_model.Size = new Size(72, 27);
            nmr_model.TabIndex = 7;
            // 
            // lbl_aracinRengi
            // 
            lbl_aracinRengi.BorderStyle = BorderStyle.FixedSingle;
            lbl_aracinRengi.Location = new Point(163, 247);
            lbl_aracinRengi.Name = "lbl_aracinRengi";
            lbl_aracinRengi.Size = new Size(175, 25);
            lbl_aracinRengi.TabIndex = 6;
            // 
            // btn_aracinRengi
            // 
            btn_aracinRengi.Location = new Point(6, 244);
            btn_aracinRengi.Name = "btn_aracinRengi";
            btn_aracinRengi.Size = new Size(137, 28);
            btn_aracinRengi.TabIndex = 5;
            btn_aracinRengi.Text = "Aracın Rengi";
            btn_aracinRengi.UseVisualStyleBackColor = true;
            btn_aracinRengi.Click += btn_aracinRengi_Click;
            // 
            // cmb_kasaTipi
            // 
            cmb_kasaTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_kasaTipi.FormattingEnabled = true;
            cmb_kasaTipi.Location = new Point(121, 201);
            cmb_kasaTipi.Name = "cmb_kasaTipi";
            cmb_kasaTipi.Size = new Size(217, 28);
            cmb_kasaTipi.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(160, 295);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 3;
            label8.Text = "Motor Gücü:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 341);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 3;
            label9.Text = "Garanti Durumu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 295);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 3;
            label7.Text = "Model:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 204);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 3;
            label6.Text = "Kasa Tipi:";
            // 
            // cmb_yakitTuru
            // 
            cmb_yakitTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_yakitTuru.FormattingEnabled = true;
            cmb_yakitTuru.Location = new Point(121, 167);
            cmb_yakitTuru.Name = "cmb_yakitTuru";
            cmb_yakitTuru.Size = new Size(217, 28);
            cmb_yakitTuru.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 170);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 3;
            label5.Text = "Yakıt Türü:";
            // 
            // cmb_sanzimanTuru
            // 
            cmb_sanzimanTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_sanzimanTuru.FormattingEnabled = true;
            cmb_sanzimanTuru.Location = new Point(121, 133);
            cmb_sanzimanTuru.Name = "cmb_sanzimanTuru";
            cmb_sanzimanTuru.Size = new Size(217, 28);
            cmb_sanzimanTuru.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 136);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 3;
            label4.Text = "Şanzıman Türü:";
            // 
            // cmb_aracModeli
            // 
            cmb_aracModeli.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_aracModeli.FormattingEnabled = true;
            cmb_aracModeli.Location = new Point(121, 99);
            cmb_aracModeli.Name = "cmb_aracModeli";
            cmb_aracModeli.Size = new Size(217, 28);
            cmb_aracModeli.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 102);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 3;
            label3.Text = "Aracın Modeli:";
            // 
            // cmb_aracMarkasi
            // 
            cmb_aracMarkasi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_aracMarkasi.FormattingEnabled = true;
            cmb_aracMarkasi.Location = new Point(121, 65);
            cmb_aracMarkasi.Name = "cmb_aracMarkasi";
            cmb_aracMarkasi.Size = new Size(217, 28);
            cmb_aracMarkasi.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 3;
            label2.Text = "Aracın markası:";
            // 
            // cmb_aracTuru
            // 
            cmb_aracTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_aracTuru.FormattingEnabled = true;
            cmb_aracTuru.Location = new Point(121, 31);
            cmb_aracTuru.Name = "cmb_aracTuru";
            cmb_aracTuru.Size = new Size(217, 28);
            cmb_aracTuru.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Araç Türü:";
            // 
            // pb_resim
            // 
            pb_resim.BackgroundImageLayout = ImageLayout.Stretch;
            pb_resim.BorderStyle = BorderStyle.FixedSingle;
            pb_resim.Location = new Point(627, 35);
            pb_resim.Name = "pb_resim";
            pb_resim.Size = new Size(1190, 584);
            pb_resim.TabIndex = 2;
            pb_resim.TabStop = false;
            // 
            // ofd_aracResmi
            // 
            ofd_aracResmi.FileName = "openFileDialog1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(376, 12);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 3;
            label10.Text = "Araç İncele";
            // 
            // lst_arabaIncele
            // 
            lst_arabaIncele.FormattingEnabled = true;
            lst_arabaIncele.ItemHeight = 20;
            lst_arabaIncele.Location = new Point(376, 35);
            lst_arabaIncele.Name = "lst_arabaIncele";
            lst_arabaIncele.Size = new Size(245, 584);
            lst_arabaIncele.TabIndex = 4;
            lst_arabaIncele.SelectedIndexChanged += lst_arabaIncele_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1838, 669);
            Controls.Add(lst_arabaIncele);
            Controls.Add(label10);
            Controls.Add(pb_resim);
            Controls.Add(gb_araclar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gb_araclar.ResumeLayout(false);
            gb_araclar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_motorGucu).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_model).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_resim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_araclar;
        private PictureBox pb_resim;
        private ComboBox cmb_kasaTipi;
        private Label label6;
        private ComboBox cmb_yakitTuru;
        private Label label5;
        private ComboBox cmb_sanzimanTuru;
        private Label label4;
        private ComboBox cmb_aracModeli;
        private Label label3;
        private ComboBox cmb_aracMarkasi;
        private Label label2;
        private ComboBox cmb_aracTuru;
        private Label label1;
        private NumericUpDown nmr_motorGucu;
        private NumericUpDown nmr_model;
        private Label lbl_aracinRengi;
        private Button btn_aracinRengi;
        private Label label8;
        private Label label7;
        private ColorDialog cd_aracinRengi;
        private CheckBox chk_garanti;
        private Label label9;
        private Button btn_resim;
        private OpenFileDialog ofd_aracResmi;
        private Button btn_olustur;
        private Button btn_aracResimEkle;
        private Label label10;
        private ListBox lst_arabaIncele;
    }
}
