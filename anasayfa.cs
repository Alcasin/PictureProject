using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PictureProject
{
    public partial class anasayfa : Form
    {
        private string secilenKlasorYolu = "";
        private string secilenKlasor = string.Empty;

        DataTable dataTable = new DataTable();
        DataTable dataTable2 = new DataTable(); // ✅ Tab 2 için ayrı tablo

        List<string> tableList = new List<string>();

        public anasayfa()
        {
            InitializeComponent();
            dataTable.Columns.Add("DosyaAdi", typeof(string));
            dataTable2.Columns.Add("DosyaAdi", typeof(string));
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_png(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2_jpg(sender, e);
        }
        private void checkBox1_png(object sender, EventArgs e) {}

        private void checkBox2_jpg(object sender, EventArgs e) {}
        private void page2Format_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(secilenKlasor))
            {
                MessageBox.Show("Lütfen önce bir klasör seçin.");
                return;
            }

            if (!checkBox3.Checked && !checkBox4.Checked)
            {
                MessageBox.Show("Lütfen bir format seçin (.png veya .jpg)");
                return;
            }

            string yeniUzanti = checkBox3.Checked ? ".png" : ".jpg";

            foreach (DataRow dosya in dataTable.Rows)
            {
                string dosyaAdi = dosya["DosyaAdi"].ToString();
                string eskiDosyaYolu = Path.Combine(secilenKlasor, dosyaAdi);
                string dosyaAdiUzantisiz = Path.GetFileNameWithoutExtension(dosyaAdi);
                string yeniDosyaYolu = Path.Combine(secilenKlasor, dosyaAdiUzantisiz + yeniUzanti);

                int sayac = 1;
                while (File.Exists(yeniDosyaYolu))
                {
                    yeniDosyaYolu = Path.Combine(secilenKlasor, $"{dosyaAdiUzantisiz}({sayac}){yeniUzanti}");
                    sayac++;
                }

                try
                {
                    File.Copy(eskiDosyaYolu, yeniDosyaYolu);
                    File.Delete(eskiDosyaYolu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"'{dosyaAdi}' dosyası yeniden adlandırılamadı.\n\n{ex.Message}");
                }
            }

            MessageBox.Show("Tüm dosyaların uzantısı başarıyla değiştirildi.");
        }
          
        private void anasayfa_Load(object sender, EventArgs e) {}


        private void btnKlosorSec_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Bir klasör seçin";
                dialog.ShowNewFolderButton = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    secilenKlasor = dialog.SelectedPath;
                    secilenKlasorYolu = secilenKlasor;

                    lblKlasorYolu.Text = secilenKlasor;

                    dataTable.Clear();
                    tableList.Clear();

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    string[] dosyalar = System.IO.Directory.GetFiles(secilenKlasor);
                    foreach (string dosya in dosyalar)
                    {
                        string dosyaAdi = System.IO.Path.GetFileName(dosya);
                        dataTable.Rows.Add(dosyaAdi);
                    }

                    // 4️⃣ Göster
                    dataGridView1.DataSource = dataTable;
                    lblDosyaSayisi.Text = $"Toplam dosya: {dosyalar.Length}";
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Lütfen bir format seçin (.png veya .jpg)");
                return;
            }

            string silinecekBaslangic = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(silinecekBaslangic))
            {
                MessageBox.Show("Lütfen silinecek başlangıcı girin.");
                return;
            }

            List<string> yeniIsimler = new List<string>();
            int toplamDosya = dataTable.Rows.Count;
            int degisenDosya = 0;

            // Sayaçları güncelle
            lblDosyaSayisi.Text = $"Toplam dosya: {toplamDosya}";
            lblDegisenSayisi.Text = $"İsmi değişen dosya: 0";

            // ProgressBar ayarları
            progressBar1.Minimum = 0;
            progressBar1.Maximum = toplamDosya;
            progressBar1.Value = 0;

            foreach (DataRow dosya in dataTable.Rows)
            {
                string dosyaAdi = dosya["DosyaAdi"].ToString();

                if (!dosyaAdi.StartsWith(silinecekBaslangic))
                {
                    progressBar1.Value++;
                    Application.DoEvents();
                    continue;
                }

                string dosyaAdiKirilmis = dosyaAdi.Substring(silinecekBaslangic.Length);
                string dosyaAdiUzantisiz = Path.GetFileNameWithoutExtension(dosyaAdiKirilmis);

                int ilkTire = dosyaAdiUzantisiz.IndexOf('-');
                int ucuncuTire = -1;
                int sayac = 0;

                for (int i = 0; i < dosyaAdiUzantisiz.Length; i++)
                {
                    if (dosyaAdiUzantisiz[i] == '-')
                    {
                        sayac++;
                        if (sayac == 3)
                        {
                            ucuncuTire = i;
                            break;
                        }
                    }
                }

                if (ilkTire == -1 || ucuncuTire == -1 || ucuncuTire <= ilkTire)
                {
                    progressBar1.Value++;
                    Application.DoEvents();
                    continue;
                }

                string yeniDosyaAdi = dosyaAdiUzantisiz.Substring(ilkTire + 1, ucuncuTire - ilkTire - 1);
                string uzanti = checkBox1.Checked ? ".png" : ".jpg";
                string hedefYol = Path.Combine(secilenKlasor, yeniDosyaAdi + uzanti);

                int kopya = 1;
                while (File.Exists(hedefYol))
                {
                    hedefYol = Path.Combine(secilenKlasor, $"{yeniDosyaAdi}({kopya}){uzanti}");
                    kopya++;
                }

                string eskiDosyaYolu = Path.Combine(secilenKlasor, dosyaAdi);

                try
                {
                    File.Move(eskiDosyaYolu, hedefYol);
                    yeniIsimler.Add(Path.GetFileName(hedefYol));
                    degisenDosya++;

                    // Label'ı güncelle
                    lblDegisenSayisi.Text = $"İsmi değişen dosya: {degisenDosya}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"'{dosyaAdi}' dosyası taşınamadı.\n\n{ex.Message}");
                }

                progressBar1.Value++;
                Application.DoEvents();
            }

            MessageBox.Show("İsim ve format dönüşümü tamamlandı.");
        }
        
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string baslangic = textBox2.Text.Trim();
            DataView view = new DataView(dataTable);

            if (string.IsNullOrWhiteSpace(baslangic))
                view.RowFilter = "";
            else
                view.RowFilter = $"DosyaAdi LIKE '{baslangic}%'";

            dataGridView1.DataSource = view;
        }
        private void progressBar1_Click(object sender, EventArgs e) {}

        private void lblDosyaSayisi_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Bir klasör seçin";
                dialog.ShowNewFolderButton = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    secilenKlasor = dialog.SelectedPath;
                    secilenKlasorYolu = secilenKlasor;

                    lblKlasorYolu.Text = secilenKlasor;

                    dataTable.Clear();
                    tableList.Clear();

                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    string[] dosyalar = System.IO.Directory.GetFiles(secilenKlasor);
                    foreach (string dosya in dosyalar)
                    {
                        string dosyaAdi = System.IO.Path.GetFileName(dosya);
                        dataTable.Rows.Add(dosyaAdi);
                    }

                    dataGridView2.DataSource = dataTable;
                    lblDosyaSayisi.Text = $"Toplam dosya: {dosyalar.Length}";
                }
            }
        }
       
        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                checkBox4.Checked = false;
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                checkBox3.Checked = false;
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {}
        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e) {}
        private void lblKlasorYolu_Click_1(object sender, EventArgs e) {}
        private void label1_Click(object sender, EventArgs e) {}
        private void label10_Click(object sender, EventArgs e) {}
    }
}
