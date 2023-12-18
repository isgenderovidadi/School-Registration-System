namespace DersEtütü
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnETÜTOLUŞTUR = new System.Windows.Forms.Button();
            this.mskSAAT = new System.Windows.Forms.MaskedTextBox();
            this.mskTARİH = new System.Windows.Forms.MaskedTextBox();
            this.cmbOGRETMEN = new System.Windows.Forms.ComboBox();
            this.cmbDERS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtÖGRENCİ = new System.Windows.Forms.TextBox();
            this.txtDERSID = new System.Windows.Forms.TextBox();
            this.btnETÜTVER = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDERSEKLE = new System.Windows.Forms.Button();
            this.txtDERSEKLE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnÖĞRENCİEKLE = new System.Windows.Forms.Button();
            this.mskTELEFON = new System.Windows.Forms.MaskedTextBox();
            this.txtMAİL = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtÖĞRENCİSINIF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtÖĞRENCİSOYAD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtÖĞRENCİAD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnÖĞRETMENEKLE = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtÖĞRETMENSOYAD = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtÖĞRETMENAD = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnFOTOGRAFEKLE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnETÜTOLUŞTUR);
            this.groupBox1.Controls.Add(this.mskSAAT);
            this.groupBox1.Controls.Add(this.mskTARİH);
            this.groupBox1.Controls.Add(this.cmbOGRETMEN);
            this.groupBox1.Controls.Add(this.cmbDERS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnETÜTOLUŞTUR
            // 
            this.btnETÜTOLUŞTUR.Location = new System.Drawing.Point(209, 259);
            this.btnETÜTOLUŞTUR.Name = "btnETÜTOLUŞTUR";
            this.btnETÜTOLUŞTUR.Size = new System.Drawing.Size(174, 72);
            this.btnETÜTOLUŞTUR.TabIndex = 10;
            this.btnETÜTOLUŞTUR.Text = "Etüt Oluştur";
            this.btnETÜTOLUŞTUR.UseVisualStyleBackColor = true;
            this.btnETÜTOLUŞTUR.Click += new System.EventHandler(this.btnETÜTOLUŞTUR_Click);
            // 
            // mskSAAT
            // 
            this.mskSAAT.Location = new System.Drawing.Point(209, 199);
            this.mskSAAT.Mask = "00:00";
            this.mskSAAT.Name = "mskSAAT";
            this.mskSAAT.Size = new System.Drawing.Size(174, 38);
            this.mskSAAT.TabIndex = 9;
            this.mskSAAT.ValidatingType = typeof(System.DateTime);
            // 
            // mskTARİH
            // 
            this.mskTARİH.Location = new System.Drawing.Point(209, 145);
            this.mskTARİH.Mask = "00/00/0000";
            this.mskTARİH.Name = "mskTARİH";
            this.mskTARİH.Size = new System.Drawing.Size(174, 38);
            this.mskTARİH.TabIndex = 8;
            this.mskTARİH.ValidatingType = typeof(System.DateTime);
            // 
            // cmbOGRETMEN
            // 
            this.cmbOGRETMEN.FormattingEnabled = true;
            this.cmbOGRETMEN.Location = new System.Drawing.Point(209, 84);
            this.cmbOGRETMEN.Name = "cmbOGRETMEN";
            this.cmbOGRETMEN.Size = new System.Drawing.Size(174, 39);
            this.cmbOGRETMEN.TabIndex = 5;
            // 
            // cmbDERS
            // 
            this.cmbDERS.FormattingEnabled = true;
            this.cmbDERS.Location = new System.Drawing.Point(209, 27);
            this.cmbDERS.Name = "cmbDERS";
            this.cmbDERS.Size = new System.Drawing.Size(174, 39);
            this.cmbDERS.TabIndex = 4;
            this.cmbDERS.SelectedIndexChanged += new System.EventHandler(this.cmbDERS_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "SAAT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "TARİH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÖĞRETMEN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DERS:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtÖGRENCİ);
            this.groupBox2.Controls.Add(this.txtDERSID);
            this.groupBox2.Controls.Add(this.btnETÜTVER);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(408, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtÖGRENCİ
            // 
            this.txtÖGRENCİ.Location = new System.Drawing.Point(155, 95);
            this.txtÖGRENCİ.Name = "txtÖGRENCİ";
            this.txtÖGRENCİ.Size = new System.Drawing.Size(172, 38);
            this.txtÖGRENCİ.TabIndex = 14;
            // 
            // txtDERSID
            // 
            this.txtDERSID.Enabled = false;
            this.txtDERSID.Location = new System.Drawing.Point(155, 24);
            this.txtDERSID.Name = "txtDERSID";
            this.txtDERSID.Size = new System.Drawing.Size(172, 38);
            this.txtDERSID.TabIndex = 13;
            // 
            // btnETÜTVER
            // 
            this.btnETÜTVER.Location = new System.Drawing.Point(155, 161);
            this.btnETÜTVER.Name = "btnETÜTVER";
            this.btnETÜTVER.Size = new System.Drawing.Size(172, 42);
            this.btnETÜTVER.TabIndex = 11;
            this.btnETÜTVER.Text = "Etüt Ver";
            this.btnETÜTVER.UseVisualStyleBackColor = true;
            this.btnETÜTVER.Click += new System.EventHandler(this.btnETÜTVER_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Öğrenci:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ders ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(13, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(768, 257);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDERSEKLE);
            this.groupBox4.Controls.Add(this.txtDERSEKLE);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(408, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(373, 143);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btnDERSEKLE
            // 
            this.btnDERSEKLE.Location = new System.Drawing.Point(150, 80);
            this.btnDERSEKLE.Name = "btnDERSEKLE";
            this.btnDERSEKLE.Size = new System.Drawing.Size(172, 42);
            this.btnDERSEKLE.TabIndex = 15;
            this.btnDERSEKLE.Text = "Ders Ekle";
            this.btnDERSEKLE.UseVisualStyleBackColor = true;
            this.btnDERSEKLE.Click += new System.EventHandler(this.btnDERSEKLE_Click);
            // 
            // txtDERSEKLE
            // 
            this.txtDERSEKLE.Location = new System.Drawing.Point(150, 25);
            this.txtDERSEKLE.Name = "txtDERSEKLE";
            this.txtDERSEKLE.Size = new System.Drawing.Size(172, 38);
            this.txtDERSEKLE.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ders:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnÖĞRENCİEKLE);
            this.groupBox5.Controls.Add(this.mskTELEFON);
            this.groupBox5.Controls.Add(this.txtMAİL);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtÖĞRENCİSINIF);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtÖĞRENCİSOYAD);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtÖĞRENCİAD);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(787, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(319, 367);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // btnÖĞRENCİEKLE
            // 
            this.btnÖĞRENCİEKLE.Location = new System.Drawing.Point(137, 266);
            this.btnÖĞRENCİEKLE.Name = "btnÖĞRENCİEKLE";
            this.btnÖĞRENCİEKLE.Size = new System.Drawing.Size(172, 84);
            this.btnÖĞRENCİEKLE.TabIndex = 17;
            this.btnÖĞRENCİEKLE.Text = "Öğrenci Ekle";
            this.btnÖĞRENCİEKLE.UseVisualStyleBackColor = true;
            this.btnÖĞRENCİEKLE.Click += new System.EventHandler(this.btnÖĞRENCİEKLE_Click);
            // 
            // mskTELEFON
            // 
            this.mskTELEFON.Location = new System.Drawing.Point(137, 175);
            this.mskTELEFON.Mask = "(999) 000-0000";
            this.mskTELEFON.Name = "mskTELEFON";
            this.mskTELEFON.Size = new System.Drawing.Size(172, 38);
            this.mskTELEFON.TabIndex = 25;
            // 
            // txtMAİL
            // 
            this.txtMAİL.Location = new System.Drawing.Point(137, 222);
            this.txtMAİL.Name = "txtMAİL";
            this.txtMAİL.Size = new System.Drawing.Size(172, 38);
            this.txtMAİL.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 32);
            this.label12.TabIndex = 23;
            this.label12.Text = "Mail:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 32);
            this.label11.TabIndex = 21;
            this.label11.Text = "Telefon:";
            // 
            // txtÖĞRENCİSINIF
            // 
            this.txtÖĞRENCİSINIF.Location = new System.Drawing.Point(137, 127);
            this.txtÖĞRENCİSINIF.Name = "txtÖĞRENCİSINIF";
            this.txtÖĞRENCİSINIF.Size = new System.Drawing.Size(172, 38);
            this.txtÖĞRENCİSINIF.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "Sınıf:";
            // 
            // txtÖĞRENCİSOYAD
            // 
            this.txtÖĞRENCİSOYAD.Location = new System.Drawing.Point(137, 78);
            this.txtÖĞRENCİSOYAD.Name = "txtÖĞRENCİSOYAD";
            this.txtÖĞRENCİSOYAD.Size = new System.Drawing.Size(172, 38);
            this.txtÖĞRENCİSOYAD.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 32);
            this.label9.TabIndex = 17;
            this.label9.Text = "Soyad:";
            // 
            // txtÖĞRENCİAD
            // 
            this.txtÖĞRENCİAD.Location = new System.Drawing.Point(137, 28);
            this.txtÖĞRENCİAD.Name = "txtÖĞRENCİAD";
            this.txtÖĞRENCİAD.Size = new System.Drawing.Size(172, 38);
            this.txtÖĞRENCİAD.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ad:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnÖĞRETMENEKLE);
            this.groupBox6.Controls.Add(this.comboBox1);
            this.groupBox6.Controls.Add(this.txtÖĞRETMENSOYAD);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.txtÖĞRETMENAD);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(787, 375);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(319, 264);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            // 
            // btnÖĞRETMENEKLE
            // 
            this.btnÖĞRETMENEKLE.Location = new System.Drawing.Point(137, 173);
            this.btnÖĞRETMENEKLE.Name = "btnÖĞRETMENEKLE";
            this.btnÖĞRETMENEKLE.Size = new System.Drawing.Size(172, 84);
            this.btnÖĞRETMENEKLE.TabIndex = 26;
            this.btnÖĞRETMENEKLE.Text = "Öğretmen Ekle";
            this.btnÖĞRETMENEKLE.UseVisualStyleBackColor = true;
            this.btnÖĞRETMENEKLE.Click += new System.EventHandler(this.btnÖĞRETMENEKLE_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 39);
            this.comboBox1.TabIndex = 12;
            // 
            // txtÖĞRETMENSOYAD
            // 
            this.txtÖĞRETMENSOYAD.Location = new System.Drawing.Point(137, 78);
            this.txtÖĞRETMENSOYAD.Name = "txtÖĞRETMENSOYAD";
            this.txtÖĞRETMENSOYAD.Size = new System.Drawing.Size(172, 38);
            this.txtÖĞRETMENSOYAD.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 32);
            this.label13.TabIndex = 11;
            this.label13.Text = "Ders:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 32);
            this.label16.TabIndex = 17;
            this.label16.Text = "Soyad:";
            // 
            // txtÖĞRETMENAD
            // 
            this.txtÖĞRETMENAD.Location = new System.Drawing.Point(137, 28);
            this.txtÖĞRETMENAD.Name = "txtÖĞRETMENAD";
            this.txtÖĞRETMENAD.Size = new System.Drawing.Size(172, 38);
            this.txtÖĞRETMENAD.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(67, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 32);
            this.label17.TabIndex = 15;
            this.label17.Text = "Ad:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnFOTOGRAFEKLE);
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Location = new System.Drawing.Point(1112, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(268, 372);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            // 
            // btnFOTOGRAFEKLE
            // 
            this.btnFOTOGRAFEKLE.Location = new System.Drawing.Point(24, 275);
            this.btnFOTOGRAFEKLE.Name = "btnFOTOGRAFEKLE";
            this.btnFOTOGRAFEKLE.Size = new System.Drawing.Size(225, 48);
            this.btnFOTOGRAFEKLE.TabIndex = 17;
            this.btnFOTOGRAFEKLE.Text = "Fotoğraf Ekle";
            this.btnFOTOGRAFEKLE.UseVisualStyleBackColor = true;
            this.btnFOTOGRAFEKLE.Click += new System.EventHandler(this.btnFOTOGRAFEKLE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1392, 644);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbOGRETMEN;
        private System.Windows.Forms.ComboBox cmbDERS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnETÜTOLUŞTUR;
        private System.Windows.Forms.MaskedTextBox mskSAAT;
        private System.Windows.Forms.MaskedTextBox mskTARİH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnETÜTVER;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtÖGRENCİ;
        private System.Windows.Forms.TextBox txtDERSID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDERSEKLE;
        private System.Windows.Forms.TextBox txtDERSEKLE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtÖĞRENCİAD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnÖĞRENCİEKLE;
        private System.Windows.Forms.MaskedTextBox mskTELEFON;
        private System.Windows.Forms.TextBox txtMAİL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtÖĞRENCİSINIF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtÖĞRENCİSOYAD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnÖĞRETMENEKLE;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtÖĞRETMENSOYAD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtÖĞRETMENAD;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnFOTOGRAFEKLE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

