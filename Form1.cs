using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K_Means
{
    public partial class Form1 : Form
    {
        int c1;
        int c2;
        int uzaklik1 = 0;
        int uzaklik2 = 0;
        int iterasyon = 0;

        int[] sayiDizisi;
        int veriSayisi = 0;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] veri = { "5", "10", "25", "50", "75", "100", "150", "200" };
            comboBoxVeriSayisi.Items.AddRange(veri);
            comboBoxVeriSayisi.SelectedIndex = 7;
        }

        private void NoktaNesnesi(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        private void btnRastgeleUret_Click(object sender, EventArgs e)
        {
            listBoxRastgeleSayislar.Items.Clear();

            //Chart Temizleme
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            veriSayisi = Convert.ToInt32(comboBoxVeriSayisi.SelectedItem);

            Random rnd = new Random();
            sayiDizisi = Enumerable.Range(1, veriSayisi).ToArray();

            for (int i = 0; i < veriSayisi; i++)
                sayiDizisi[i] = rnd.Next(1, 100);

            c1 = rnd.Next(1, 100);
            c2 = rnd.Next(1, 100);

            labelKumeMerkezi1.Text = c1.ToString();
            labelKumeMerkezi2.Text = c2.ToString();


            for (int i = 0; i < veriSayisi; i++)
                listBoxRastgeleSayislar.Items.Add(sayiDizisi[i].ToString());

            for (int i = 0; i < veriSayisi; i++)
                chart1.Series["Veriler"].Points.Add(sayiDizisi[i]);

            chart1.Series["KumeMerkezleri"].Points.Add(c1);
            chart1.Series["KumeMerkezleri"].Points.Add(c2);

            for (int i = 0; i < veriSayisi; i++)
                listBox1.Items.Add(chart1.Series["Veriler"].Points);
        }

        private void buttonKumele_Click_1(object sender, EventArgs e)
        {
            listBoxKume1.Items.Clear();
            listBoxKume2.Items.Clear();

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            for (int i = 0; i < listBoxRastgeleSayislar.Items.Count; i++)
            {

                uzaklik1 = Math.Abs(sayiDizisi[i] - c1);
                uzaklik2 = Math.Abs(sayiDizisi[i] - c2);

                if (uzaklik1 < uzaklik2)
                    listBoxKume1.Items.Add(sayiDizisi[i]);
                else if (uzaklik2 < uzaklik1)
                    listBoxKume2.Items.Add(sayiDizisi[i]);
                //else if (uzaklik1 == uzaklik2)
                //    listBoxKume2.Items.Add(sayiDizisi[i]);
            }

            int toplam1 = 0;
            int toplam2 = 0;

            for (int i = 0; i < listBoxKume1.Items.Count; i++)
            {
                toplam1 += Convert.ToInt32(listBoxKume1.Items[i]);
            }

            c1 = toplam1 / listBoxRastgeleSayislar.Items.Count;

            for (int i = 0; i < listBoxKume2.Items.Count; i++)
            {
                toplam2 += Convert.ToInt32(listBoxKume2.Items[i]);
            }

            c2 = toplam2 / listBoxRastgeleSayislar.Items.Count;

            labelKumeMerkezi1.Text = c1.ToString();
            labelKumeMerkezi2.Text = c2.ToString();

            iterasyon++;
            labeliterasyonSayisi.Text = iterasyon.ToString();

            labelKumeSayisi1.Text = listBoxKume1.Items.Count.ToString();
            labelKumeSayisi2.Text = listBoxKume2.Items.Count.ToString();

            for (int i = 0; i < listBoxKume1.Items.Count; i++)
                chart1.Series["Kume1"].Points.Add(Convert.ToInt32(listBoxKume1.Items[i]));

            for (int i = 0; i < listBoxKume2.Items.Count; i++)
                chart1.Series["Kume2"].Points.Add(Convert.ToInt32(listBoxKume2.Items[i]));

            chart1.Series["KumeMerkezleri"].Points.Add(c1);
            chart1.Series["KumeMerkezleri"].Points.Add(c2);
        }
    }
}
