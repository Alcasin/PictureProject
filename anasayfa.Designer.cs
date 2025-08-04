namespace PictureProject
{
    partial class anasayfa
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            progressBar1 = new ProgressBar();
            lblDegisenSayisi = new Label();
            lblDosyaSayisi = new Label();
            lblKlasorYolu = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            btnKlosorSec = new Button();
            checkBox2 = new CheckBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            tabPage5 = new TabPage();
            button5 = new Button();
            label10 = new Label();
            label11 = new Label();
            dataGridView2 = new DataGridView();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            button6 = new Button();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Location = new Point(2, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1088, 624);
            tabControl2.TabIndex = 9;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(progressBar1);
            tabPage4.Controls.Add(lblDegisenSayisi);
            tabPage4.Controls.Add(lblDosyaSayisi);
            tabPage4.Controls.Add(lblKlasorYolu);
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(textBox2);
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Controls.Add(btnKlosorSec);
            tabPage4.Controls.Add(checkBox2);
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(checkBox1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1080, 591);
            tabPage4.TabIndex = 2;
            tabPage4.Text = "İsim Değiştirme";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(821, 131);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(125, 29);
            progressBar1.TabIndex = 12;
            progressBar1.Click += progressBar1_Click;
            // 
            // lblDegisenSayisi
            // 
            lblDegisenSayisi.AutoSize = true;
            lblDegisenSayisi.Location = new Point(822, 103);
            lblDegisenSayisi.Name = "lblDegisenSayisi";
            lblDegisenSayisi.Size = new Size(150, 20);
            lblDegisenSayisi.TabIndex = 11;
            lblDegisenSayisi.Text = "İsmi değişen dosya: 0";
            // 
            // lblDosyaSayisi
            // 
            lblDosyaSayisi.AutoSize = true;
            lblDosyaSayisi.Location = new Point(822, 72);
            lblDosyaSayisi.Name = "lblDosyaSayisi";
            lblDosyaSayisi.Size = new Size(117, 20);
            lblDosyaSayisi.TabIndex = 10;
            lblDosyaSayisi.Text = "Toplam dosya: 0";
            lblDosyaSayisi.Click += lblDosyaSayisi_Click_1;
            // 
            // lblKlasorYolu
            // 
            lblKlasorYolu.AutoSize = true;
            lblKlasorYolu.Location = new Point(12, 91);
            lblKlasorYolu.Name = "lblKlasorYolu";
            lblKlasorYolu.Size = new Size(324, 20);
            lblKlasorYolu.TabIndex = 9;
            lblKlasorYolu.Text = "Seçilen klasörün yolu (En sağdaki son klasördür)";
            lblKlasorYolu.Click += lblKlasorYolu_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(794, 328);
            label2.Name = "label2";
            label2.Size = new Size(259, 20);
            label2.TabIndex = 8;
            label2.Text = "Dönüştürmek istediğiniz formatı seçin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 137);
            label1.Name = "label1";
            label1.Size = new Size(417, 20);
            label1.TabIndex = 7;
            label1.Text = "Silinecek kısmın ismini yazın (sayıya kadar olan kısım (-) dahil)";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(373, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-4, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(766, 364);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // btnKlosorSec
            // 
            btnKlosorSec.Location = new Point(15, 131);
            btnKlosorSec.Name = "btnKlosorSec";
            btnKlosorSec.Size = new Size(315, 77);
            btnKlosorSec.TabIndex = 0;
            btnKlosorSec.Text = "Klasör Seç";
            btnKlosorSec.UseVisualStyleBackColor = true;
            btnKlosorSec.Click += btnKlosorSec_Click_1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(892, 404);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(56, 24);
            checkBox2.TabIndex = 5;
            checkBox2.Text = ".jpg";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(788, 453);
            button1.Name = "button1";
            button1.Size = new Size(265, 119);
            button1.TabIndex = 3;
            button1.Text = "İsimleri değiştir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(892, 374);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = ".png";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.Transparent;
            tabPage5.Controls.Add(button5);
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(dataGridView2);
            tabPage5.Controls.Add(checkBox4);
            tabPage5.Controls.Add(checkBox3);
            tabPage5.Controls.Add(button6);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1080, 591);
            tabPage5.TabIndex = 3;
            tabPage5.Text = "Uzantı Değiştirme";
            // 
            // button5
            // 
            button5.Location = new Point(693, 359);
            button5.Name = "button5";
            button5.Size = new Size(301, 141);
            button5.TabIndex = 7;
            button5.Text = "Formatı değiştir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += page2Format_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(699, 205);
            label10.Name = "label10";
            label10.Size = new Size(259, 20);
            label10.TabIndex = 6;
            label10.Text = "Dönüştürmek istediğiniz formatı seçin";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(293, 60);
            label11.Name = "label11";
            label11.Size = new Size(334, 20);
            label11.TabIndex = 5;
            label11.Text = "SADECE FORMAT DÖNÜŞÜMÜ İÇİN KULLANINIZ ";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 107);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(615, 476);
            dataGridView2.TabIndex = 4;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(810, 282);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(53, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "jpg";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged_1;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(810, 252);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(57, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "png";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged_1;
            // 
            // button6
            // 
            button6.Location = new Point(36, 36);
            button6.Name = "button6";
            button6.Size = new Size(174, 56);
            button6.TabIndex = 1;
            button6.Text = "Klasör Seç";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // anasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 619);
            Controls.Add(tabControl2);
            Name = "anasayfa";
            Text = "anasayfa";
            Load += anasayfa_Load;
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private ProgressBar progressBar1;
        private Label lblDegisenSayisi;
        private Label lblDosyaSayisi;
        private Label lblKlasorYolu;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button btnKlosorSec;
        private CheckBox checkBox2;
        private Button button1;
        private CheckBox checkBox1;
        private TabPage tabPage5;
        private Button button5;
        private Label label10;
        private Label label11;
        private DataGridView dataGridView2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private Button button6;
    }
}