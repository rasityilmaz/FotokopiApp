namespace WindowsFormsApp2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1_syhbyz = new System.Windows.Forms.CheckBox();
            this.checkBox2_rnk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox3_isteslim = new System.Windows.Forms.CheckBox();
            this.checkBox4_kargo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox10_std80 = new System.Windows.Forms.CheckBox();
            this.checkBox11_mat170 = new System.Windows.Forms.CheckBox();
            this.checkBox15_mat300 = new System.Windows.Forms.CheckBox();
            this.checkBox12_prlk300 = new System.Windows.Forms.CheckBox();
            this.checkBox16_prlk170 = new System.Windows.Forms.CheckBox();
            this.checkBox17_prlk130 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBox1_dosyaism = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2_syfsayısı = new System.Windows.Forms.TextBox();
            this.button1_ekle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox9_a3 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox7_a5 = new System.Windows.Forms.CheckBox();
            this.checkBox8_a4 = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkBox5_spiral = new System.Windows.Forms.CheckBox();
            this.checkBox6_karton = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.checkBox13_tekyön = new System.Windows.Forms.CheckBox();
            this.checkBox14_önarka = new System.Windows.Forms.CheckBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(27, 502);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DOSYA İSMİ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "BASKI TİPİ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "BASKI YÖNÜ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TESLİMAT";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "CİLTLEME";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "KAĞIT BOYUTU";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "SAYFA SAYISI";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "TUTAR";
            this.Column8.Name = "Column8";
            // 
            // checkBox1_syhbyz
            // 
            this.checkBox1_syhbyz.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1_syhbyz.Location = new System.Drawing.Point(161, 25);
            this.checkBox1_syhbyz.Name = "checkBox1_syhbyz";
            this.checkBox1_syhbyz.Size = new System.Drawing.Size(187, 34);
            this.checkBox1_syhbyz.TabIndex = 4;
            this.checkBox1_syhbyz.Text = "SİYAH-BEYAZ";
            this.checkBox1_syhbyz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1_syhbyz.UseVisualStyleBackColor = true;
            this.checkBox1_syhbyz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox1_syhbyz_MouseClick);
            // 
            // checkBox2_rnk
            // 
            this.checkBox2_rnk.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2_rnk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox2_rnk.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2_rnk.Location = new System.Drawing.Point(161, 65);
            this.checkBox2_rnk.Name = "checkBox2_rnk";
            this.checkBox2_rnk.Size = new System.Drawing.Size(187, 34);
            this.checkBox2_rnk.TabIndex = 5;
            this.checkBox2_rnk.Text = "RENKLİ";
            this.checkBox2_rnk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2_rnk.UseVisualStyleBackColor = false;
            this.checkBox2_rnk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox2_rnk_MouseClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(24, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 70);
            this.label2.TabIndex = 14;
            this.label2.Text = "BASKI TİPİ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(52, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 70);
            this.label4.TabIndex = 14;
            this.label4.Text = "TESLİMAT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox3_isteslim
            // 
            this.checkBox3_isteslim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox3_isteslim.Location = new System.Drawing.Point(10, 154);
            this.checkBox3_isteslim.Name = "checkBox3_isteslim";
            this.checkBox3_isteslim.Size = new System.Drawing.Size(198, 34);
            this.checkBox3_isteslim.TabIndex = 4;
            this.checkBox3_isteslim.Text = "İŞYERİ TESLİM";
            this.checkBox3_isteslim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3_isteslim.UseVisualStyleBackColor = true;
            // 
            // checkBox4_kargo
            // 
            this.checkBox4_kargo.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4_kargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox4_kargo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox4_kargo.Location = new System.Drawing.Point(20, 194);
            this.checkBox4_kargo.Name = "checkBox4_kargo";
            this.checkBox4_kargo.Size = new System.Drawing.Size(187, 34);
            this.checkBox4_kargo.TabIndex = 5;
            this.checkBox4_kargo.Text = "KARGO";
            this.checkBox4_kargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4_kargo.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(0, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 86);
            this.label6.TabIndex = 14;
            this.label6.Text = "KAĞIT SEÇENEĞİ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox10_std80
            // 
            this.checkBox10_std80.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox10_std80.Location = new System.Drawing.Point(178, 20);
            this.checkBox10_std80.Name = "checkBox10_std80";
            this.checkBox10_std80.Size = new System.Drawing.Size(193, 34);
            this.checkBox10_std80.TabIndex = 4;
            this.checkBox10_std80.Text = "Standart 80 gr";
            this.checkBox10_std80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox10_std80.UseVisualStyleBackColor = true;
            this.checkBox10_std80.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox11_mat170
            // 
            this.checkBox11_mat170.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox11_mat170.Location = new System.Drawing.Point(178, 56);
            this.checkBox11_mat170.Name = "checkBox11_mat170";
            this.checkBox11_mat170.Size = new System.Drawing.Size(193, 34);
            this.checkBox11_mat170.TabIndex = 25;
            this.checkBox11_mat170.Text = "Mat Kuşe 170 gr";
            this.checkBox11_mat170.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox11_mat170.UseVisualStyleBackColor = true;
            // 
            // checkBox15_mat300
            // 
            this.checkBox15_mat300.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox15_mat300.Location = new System.Drawing.Point(178, 94);
            this.checkBox15_mat300.Name = "checkBox15_mat300";
            this.checkBox15_mat300.Size = new System.Drawing.Size(193, 34);
            this.checkBox15_mat300.TabIndex = 26;
            this.checkBox15_mat300.Text = "Mat Kuşe 300 gr";
            this.checkBox15_mat300.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox15_mat300.UseVisualStyleBackColor = true;
            // 
            // checkBox12_prlk300
            // 
            this.checkBox12_prlk300.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox12_prlk300.Location = new System.Drawing.Point(491, 94);
            this.checkBox12_prlk300.Name = "checkBox12_prlk300";
            this.checkBox12_prlk300.Size = new System.Drawing.Size(206, 34);
            this.checkBox12_prlk300.TabIndex = 29;
            this.checkBox12_prlk300.Text = "Parlak Kuşe 300 gr";
            this.checkBox12_prlk300.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox12_prlk300.UseVisualStyleBackColor = true;
            // 
            // checkBox16_prlk170
            // 
            this.checkBox16_prlk170.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox16_prlk170.Location = new System.Drawing.Point(491, 56);
            this.checkBox16_prlk170.Name = "checkBox16_prlk170";
            this.checkBox16_prlk170.Size = new System.Drawing.Size(206, 34);
            this.checkBox16_prlk170.TabIndex = 28;
            this.checkBox16_prlk170.Text = "Parlak Kuşe 170 gr";
            this.checkBox16_prlk170.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox16_prlk170.UseVisualStyleBackColor = true;
            // 
            // checkBox17_prlk130
            // 
            this.checkBox17_prlk130.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox17_prlk130.Location = new System.Drawing.Point(491, 19);
            this.checkBox17_prlk130.Name = "checkBox17_prlk130";
            this.checkBox17_prlk130.Size = new System.Drawing.Size(206, 35);
            this.checkBox17_prlk130.TabIndex = 27;
            this.checkBox17_prlk130.Text = "Parlak Kuşe 130 gr";
            this.checkBox17_prlk130.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox17_prlk130.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.checkBox3_isteslim);
            this.panel1.Controls.Add(this.checkBox4_kargo);
            this.panel1.Location = new System.Drawing.Point(932, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 272);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(932, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 122);
            this.panel2.TabIndex = 30;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel7.Controls.Add(this.checkBox1_syhbyz);
            this.panel7.Controls.Add(this.checkBox2_rnk);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(462, 45);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(369, 122);
            this.panel7.TabIndex = 33;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Khaki;
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(129, 122);
            this.panel8.TabIndex = 32;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.checkBox12_prlk300);
            this.panel11.Controls.Add(this.checkBox10_std80);
            this.panel11.Controls.Add(this.checkBox16_prlk170);
            this.panel11.Controls.Add(this.checkBox11_mat170);
            this.panel11.Controls.Add(this.checkBox17_prlk130);
            this.panel11.Controls.Add(this.checkBox15_mat300);
            this.panel11.Location = new System.Drawing.Point(29, 333);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(802, 151);
            this.panel11.TabIndex = 35;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Khaki;
            this.panel12.Controls.Add(this.label6);
            this.panel12.Location = new System.Drawing.Point(-2, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(122, 151);
            this.panel12.TabIndex = 32;
            // 
            // textBox1_dosyaism
            // 
            this.textBox1_dosyaism.Location = new System.Drawing.Point(1051, 354);
            this.textBox1_dosyaism.Name = "textBox1_dosyaism";
            this.textBox1_dosyaism.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1_dosyaism.Size = new System.Drawing.Size(102, 22);
            this.textBox1_dosyaism.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(932, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Dosya İsmi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(932, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "Sayfa Sayısı";
            // 
            // textBox2_syfsayısı
            // 
            this.textBox2_syfsayısı.Location = new System.Drawing.Point(1051, 392);
            this.textBox2_syfsayısı.Name = "textBox2_syfsayısı";
            this.textBox2_syfsayısı.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2_syfsayısı.Size = new System.Drawing.Size(102, 22);
            this.textBox2_syfsayısı.TabIndex = 38;
            // 
            // button1_ekle
            // 
            this.button1_ekle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1_ekle.Location = new System.Drawing.Point(1051, 447);
            this.button1_ekle.Name = "button1_ekle";
            this.button1_ekle.Size = new System.Drawing.Size(102, 37);
            this.button1_ekle.TabIndex = 40;
            this.button1_ekle.Text = "EKLE";
            this.button1_ekle.UseVisualStyleBackColor = false;
            this.button1_ekle.Click += new System.EventHandler(this.button1_ekle_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.checkBox9_a3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.checkBox7_a5);
            this.panel3.Controls.Add(this.checkBox8_a4);
            this.panel3.Location = new System.Drawing.Point(27, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 122);
            this.panel3.TabIndex = 41;
            // 
            // checkBox9_a3
            // 
            this.checkBox9_a3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox9_a3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox9_a3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox9_a3.Location = new System.Drawing.Point(148, 84);
            this.checkBox9_a3.Name = "checkBox9_a3";
            this.checkBox9_a3.Size = new System.Drawing.Size(203, 35);
            this.checkBox9_a3.TabIndex = 22;
            this.checkBox9_a3.Text = "A3";
            this.checkBox9_a3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox9_a3.UseVisualStyleBackColor = false;
            this.checkBox9_a3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox9_a3_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Khaki;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(129, 122);
            this.panel4.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(10, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 70);
            this.label5.TabIndex = 14;
            this.label5.Text = "KAĞIT BOYUTU";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox7_a5
            // 
            this.checkBox7_a5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox7_a5.Location = new System.Drawing.Point(148, 3);
            this.checkBox7_a5.Name = "checkBox7_a5";
            this.checkBox7_a5.Size = new System.Drawing.Size(203, 35);
            this.checkBox7_a5.TabIndex = 4;
            this.checkBox7_a5.Text = "A5";
            this.checkBox7_a5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox7_a5.UseVisualStyleBackColor = true;
            this.checkBox7_a5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox7_a5_MouseClick);
            // 
            // checkBox8_a4
            // 
            this.checkBox8_a4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox8_a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox8_a4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox8_a4.Location = new System.Drawing.Point(148, 42);
            this.checkBox8_a4.Name = "checkBox8_a4";
            this.checkBox8_a4.Size = new System.Drawing.Size(203, 35);
            this.checkBox8_a4.TabIndex = 5;
            this.checkBox8_a4.Text = "A4";
            this.checkBox8_a4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox8_a4.UseVisualStyleBackColor = false;
            this.checkBox8_a4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox8_a4_MouseClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel5.Controls.Add(this.checkBox5_spiral);
            this.panel5.Controls.Add(this.checkBox6_karton);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(462, 192);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 122);
            this.panel5.TabIndex = 42;
            // 
            // checkBox5_spiral
            // 
            this.checkBox5_spiral.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox5_spiral.Location = new System.Drawing.Point(133, 17);
            this.checkBox5_spiral.Name = "checkBox5_spiral";
            this.checkBox5_spiral.Size = new System.Drawing.Size(215, 44);
            this.checkBox5_spiral.TabIndex = 4;
            this.checkBox5_spiral.Text = "HELEZON SPİRAL";
            this.checkBox5_spiral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5_spiral.UseVisualStyleBackColor = true;
            // 
            // checkBox6_karton
            // 
            this.checkBox6_karton.BackColor = System.Drawing.Color.Transparent;
            this.checkBox6_karton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox6_karton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox6_karton.Location = new System.Drawing.Point(146, 67);
            this.checkBox6_karton.Name = "checkBox6_karton";
            this.checkBox6_karton.Size = new System.Drawing.Size(202, 35);
            this.checkBox6_karton.TabIndex = 5;
            this.checkBox6_karton.Text = "KARTON CİLT";
            this.checkBox6_karton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox6_karton.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Khaki;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(129, 122);
            this.panel6.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(5, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 70);
            this.label3.TabIndex = 14;
            this.label3.Text = "CİLTLEME";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel9.Controls.Add(this.checkBox13_tekyön);
            this.panel9.Controls.Add(this.checkBox14_önarka);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(27, 192);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(369, 122);
            this.panel9.TabIndex = 43;
            // 
            // checkBox13_tekyön
            // 
            this.checkBox13_tekyön.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox13_tekyön.Location = new System.Drawing.Point(164, 25);
            this.checkBox13_tekyön.Name = "checkBox13_tekyön";
            this.checkBox13_tekyön.Size = new System.Drawing.Size(187, 34);
            this.checkBox13_tekyön.TabIndex = 4;
            this.checkBox13_tekyön.Text = "TEK YÖN";
            this.checkBox13_tekyön.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox13_tekyön.UseVisualStyleBackColor = true;
            this.checkBox13_tekyön.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox13_tekyön_MouseClick_1);
            // 
            // checkBox14_önarka
            // 
            this.checkBox14_önarka.BackColor = System.Drawing.Color.Transparent;
            this.checkBox14_önarka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox14_önarka.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox14_önarka.Location = new System.Drawing.Point(164, 62);
            this.checkBox14_önarka.Name = "checkBox14_önarka";
            this.checkBox14_önarka.Size = new System.Drawing.Size(187, 34);
            this.checkBox14_önarka.TabIndex = 5;
            this.checkBox14_önarka.Text = "ÖN-ARKA";
            this.checkBox14_önarka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox14_önarka.UseVisualStyleBackColor = false;
            this.checkBox14_önarka.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox14_önarka_MouseClick_1);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Khaki;
            this.panel10.Controls.Add(this.label1);
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(129, 122);
            this.panel10.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 70);
            this.label1.TabIndex = 14;
            this.label1.Text = "BASKI YÖNÜ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 924);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1_ekle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2_syfsayısı);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1_dosyaism);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 971);
            this.MinimumSize = new System.Drawing.Size(1200, 971);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox2_rnk;
        private System.Windows.Forms.CheckBox checkBox1_syhbyz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox3_isteslim;
        private System.Windows.Forms.CheckBox checkBox4_kargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox10_std80;
        private System.Windows.Forms.CheckBox checkBox12_prlk300;
        private System.Windows.Forms.CheckBox checkBox16_prlk170;
        private System.Windows.Forms.CheckBox checkBox17_prlk130;
        private System.Windows.Forms.CheckBox checkBox15_mat300;
        private System.Windows.Forms.CheckBox checkBox11_mat170;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox textBox1_dosyaism;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2_syfsayısı;
        private System.Windows.Forms.Button button1_ekle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox9_a3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox7_a5;
        private System.Windows.Forms.CheckBox checkBox8_a4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox checkBox5_spiral;
        private System.Windows.Forms.CheckBox checkBox6_karton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.CheckBox checkBox13_tekyön;
        private System.Windows.Forms.CheckBox checkBox14_önarka;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label1;
    }
}

