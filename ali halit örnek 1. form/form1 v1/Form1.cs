/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1.Ödev
**				ÖĞRENCİ ADI............: Ali Halit ÖRNEK
**				ÖĞRENCİ NUMARASI.......: B231210385
**              DERSİN ALINDIĞI GRUP...: B
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void seçeneklerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //yeni menü açar
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ProductName);
        }

        //seçilen bir metin dosyasını açar
        private void dosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Dosya seçin";
            openFileDialog1.Filter = "Metin dosyası|*.txt";
            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileinfo = new FileInfo(openFileDialog1.FileName);
                StreamReader sreamreader = fileinfo.OpenText();
                richTextBox1.Text = sreamreader.ReadToEnd();
            }
            else
            {
                MessageBox.Show("Başarısız seçim");
            }

        }

        //dosyayı kaydeder
        private void dosyaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "İsim girin";
            saveFileDialog1.Filter = "Metin dosyası|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Kayıt başarısız");
            }
            else
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText);
                MessageBox.Show("Kayıt başarılı");
            }
            
        }

        //tüm metnin yazı tipini seçer
        private void yazıÇeşidiToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        //tüm metnin yazı rengini seçer
        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
      
            }

        }

        //kutunun zemin rengini seçer
        private void zeminRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
               richTextBox1.BackColor = colorDialog1.Color;
                
            }
            
        }

        //uygulamadan çıkar
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //menü ile keser
        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        //menü ile kopyalar
        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        //menü ile yapıştırır
        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        //buton ile keser
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        //buton ile kopyalar
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        //buton ile yapıştırır
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        //seçilen yerin rengini değiştirir
        private void seçilenBölgeninRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
               richTextBox1.SelectionColor = colorDialog1.Color;
                
            }
           
        }

        //seçilen yerin yazı tipini değiştirir
        private void seçilenBölgeninYazıÇeşidiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                
            }
            
        }

        //seçilen bölgeyi bir renk ile tarar
        private void seçilenBölgeyiTaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorDialog1.Color;

            }
           
        }
    }
}
