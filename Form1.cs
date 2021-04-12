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
        int minDeger;
        int maksDeger;
        int uzaklik1 = 0;
        int uzaklik2 = 0;
        int iterasyon = 0;
        int veriSayisi = 0;
        int xToplam1 = 0;
        int yToplam1 = 0;
        int xToplam2 = 0;
        int yToplam2 = 0;
        int yeniX1 = 0;
        int yeniY1 = 0;
        int yeniX2 = 0;
        int yeniY2 = 0;

        List<object> veriListesi = new List<object>();
        List<object> Kume1 = new List<object>();
        List<object> Kume2 = new List<object>();
        Point kumeMerkezi1 = new Point();
        Point kumeMerkezi2 = new Point();
        Point veri = new Point();

        Random rnd = new Random();

        void chartTemizle()
        {
            
            listBoxKume1.Items.Clear();
            listBoxKume2.Items.Clear();

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            nudKumeSayisi.Maximum = nudVeriSayisi.Value;
            buttonKumele.Enabled = false;
        }


        public void btnRastgeleUret_Click(object sender, EventArgs e)
        {
            buttonKumele.Enabled = true;
            listBoxVeriler.Items.Clear();
            chartTemizle();
            veriListesi.Clear();
            iterasyon = 0;
            labeliterasyonSayisi.Text = iterasyon.ToString();

            veriSayisi = Convert.ToInt32(nudVeriSayisi.Value);

            minDeger = Convert.ToInt32(nudMinDeger.Value);
            maksDeger = Convert.ToInt32(nudMaksDeger.Value);

            for (int i=0; i<veriSayisi; i++)
            {
                veri.X = rnd.Next(minDeger, maksDeger);
                veri.Y = rnd.Next(minDeger, maksDeger);

                veriListesi.Add(veri);

                chart1.Series["Veriler"].Points.AddXY(veri.X, veri.Y);

                listBoxVeriler.Items.Add(i+1);
                listBoxVeriler.Items.Add("X - Y");
                listBoxVeriler.Items.Add(veri);
                listBoxVeriler.Items.Add("");
            }

            kumeMerkezi1.X = rnd.Next(minDeger, maksDeger);
            kumeMerkezi1.Y = rnd.Next(minDeger, maksDeger);

            labelKumeMerkezi1.Text = kumeMerkezi1.ToString();

            chart1.Series["KumeMerkezleri"].Points.AddXY(kumeMerkezi1.X, kumeMerkezi1.Y);



            kumeMerkezi2.X = rnd.Next(minDeger, maksDeger);
            kumeMerkezi2.Y = rnd.Next(minDeger, maksDeger);

            labelKumeMerkezi2.Text = kumeMerkezi2.ToString();

            chart1.Series["KumeMerkezleri"].Points.AddXY(kumeMerkezi2.X, kumeMerkezi2.Y);
        }

        public void buttonKumele_Click_1(object sender, EventArgs e)
        {
            Kume1.Clear();
            Kume2.Clear();

            chartTemizle();

            foreach(Point veri in veriListesi)
            {
                uzaklik1 = Convert.ToInt32(Math.Sqrt(Math.Pow((veri.X - kumeMerkezi1.X), 2) + Math.Pow((veri.Y - kumeMerkezi1.Y), 2)));
                uzaklik2 = Convert.ToInt32(Math.Sqrt(Math.Pow((veri.X - kumeMerkezi2.X), 2) + Math.Pow((veri.Y - kumeMerkezi2.Y), 2)));

                int x1 = kumeMerkezi1.X - uzaklik1;
                int y1 = kumeMerkezi1.Y - uzaklik1;

                int x2 = kumeMerkezi2.X - uzaklik1;
                int y2 = kumeMerkezi2.X - uzaklik1;

                if (uzaklik1 < uzaklik2)
                {
                    Kume1.Add(veri);
                    chart1.Series["Kume1"].Points.AddXY(veri.X, veri.Y);
                    listBoxKume1.Items.Add(veri);
                }

                else if (uzaklik2 < uzaklik1)
                {
                    Kume2.Add(veri);
                    chart1.Series["Kume2"].Points.AddXY(veri.X, veri.Y);
                    listBoxKume2.Items.Add(veri);
                }

                else if (uzaklik1 == uzaklik2)
                {
                    Kume1.Add(veri);
                    chart1.Series["Kume1"].Points.AddXY(veri.X, veri.Y);
                    listBoxKume1.Items.Add(veri);
                }
            }

            labelKumeSayisi1.Text = Kume1.Count.ToString();
            labelKumeSayisi2.Text = Kume2.Count.ToString();


            xToplam1 = 0;
            yToplam1 = 0;

            foreach (Point veri1 in Kume1)
            {
                xToplam1 = xToplam1 + veri1.X;
                yToplam1 = yToplam1 + veri1.Y;
            }

            labelToplamx1.Text = xToplam1.ToString();
            labelToplamy1.Text = yToplam1.ToString();

            int yeniX1 = Convert.ToInt32(xToplam1 / Kume1.Count);
            int yeniY1 = Convert.ToInt32(yToplam1 / Kume1.Count);

            kumeMerkezi1.X = yeniX1;
            kumeMerkezi1.Y = yeniY1;

            labelKumeMerkezi1.Text = kumeMerkezi1.ToString();
            chart1.Series["KumeMerkezleri"].Points.AddXY(kumeMerkezi1.X, kumeMerkezi1.Y);


            xToplam2 = 0;
            yToplam2 = 0;

            foreach (Point veri2 in Kume2)
            {
                xToplam2 += veri2.X;
                yToplam2 += veri2.Y;
            }

            labelToplamx2.Text = xToplam2.ToString();
            labelToplamy2.Text = yToplam2.ToString();

            int yeniX2 = Convert.ToInt32(xToplam2 / Kume2.Count);
            int yeniY2 = Convert.ToInt32(yToplam2 / Kume2.Count);

            kumeMerkezi2.X = yeniX2;
            kumeMerkezi2.Y = yeniY2;

            labelKumeMerkezi2.Text = kumeMerkezi2.ToString();
            chart1.Series["KumeMerkezleri"].Points.AddXY(kumeMerkezi2.X, kumeMerkezi2.Y);

            iterasyon++;
            labeliterasyonSayisi.Text = iterasyon.ToString();
        }

        private void nudVeriSayisi_ValueChanged(object sender, EventArgs e)
        {
            nudKumeSayisi.Maximum = nudVeriSayisi.Value;
        }

        private void nudMinDeger_ValueChanged(object sender, EventArgs e)
        {
            nudMaksDeger.Minimum = nudMinDeger.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Kume1.Clear();
            Kume2.Clear();

            listBoxKume1.Items.Add(Kume1);
            listBoxKume2.Items.Add(Kume2);
        }
    }
}
