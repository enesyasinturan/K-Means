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
    public partial class FormKMeans : Form
    {
        int minDeger;
        int maksDeger;
        int iterasyon = 0;
        int veriSayisi = 0;
        int kumeSayisi = 0;
        int bitti = 0;

        Point veri = new Point();
        List<Point> veriListesi = new List<Point>();

        Point kumeMerkez = new Point();
        List<Point> kumeMerkezListesi = new List<Point>();

        List<Point> kume = new List<Point>();
        List<List<Point>> kumeListesi = new List<List<Point>>();

        List<double> uzakliklar = new List<double>();

        Dictionary<int, Point> keyVeMerkez = new Dictionary<int, Point>();
        

        Random rnd = new Random();

        void chartTemizle()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            chart1.Series.Clear();
        }

        public FormKMeans()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            nudKumeSayisi.Maximum = nudVeriSayisi.Value;
            buttonKumele.Enabled = false;
            buttonKumele.Text = "VERİ BEKLENİYOR...";
            buttonKumele.ForeColor = Color.MidnightBlue;
            buttonKumele.BackColor = Color.DarkGray;
            nudKumeSayisi.Maximum = 11;
            nudKumeSayisi.Minimum = 2;

            this.WindowState = FormWindowState.Maximized;

            
        }


        public void btnRastgeleUret_Click(object sender, EventArgs e)
        {
            bitti = 0;

            buttonKumele.Enabled = true;
            buttonKumele.Text = "KÜMELE";
            buttonKumele.ForeColor = Color.Gainsboro;
            buttonKumele.BackColor = Color.Green;
            labelKumeBitis.Text = "";
            

            listBoxVeriler.Items.Clear();
            listBoxKumeMerkezleri.Items.Clear();

            chartTemizle();
            veriListesi.Clear();
            kumeListesi.Clear();
            uzakliklar.Clear();
            keyVeMerkez.Clear();

            iterasyon = 0;
            labeliterasyonSayisi.Text = iterasyon.ToString();

            minDeger = Convert.ToInt32(nudMinDeger.Value);
            maksDeger = Convert.ToInt32(nudMaksDeger.Value);


            veriSayisi = Convert.ToInt32(nudVeriSayisi.Value);


            chart1.Series.Add("Veriler");
            chart1.Series.Add("KumeMerkezleri");

            chart1.Series["Veriler"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chart1.Series["Veriler"].Color = Color.Blue;
            chart1.Series["Veriler"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            chart1.Series["Veriler"].MarkerSize = 8;

            chart1.Series["KumeMerkezleri"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chart1.Series["KumeMerkezleri"].Color = Color.FromArgb(255, 0, 127);
            
            chart1.Series["KumeMerkezleri"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star10;
            chart1.Series["KumeMerkezleri"].MarkerSize = 20;


            //Verilerin oluşturulması ve grafiğe eklenmesi
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


            //Kümelerin ve küme merkezlerinin oluşturulması ve grafiğe eklenmesi
            kumeSayisi = Convert.ToInt32(nudKumeSayisi.Value);

            for (int i = 0; i < kumeSayisi; i++)
            {

                kumeMerkez.X = rnd.Next(minDeger, maksDeger);
                kumeMerkez.Y = rnd.Next(minDeger, maksDeger);

                kumeMerkezListesi.Add(kumeMerkez);
                keyVeMerkez.Add(i, kumeMerkez);


                //********************************************//
                kumeListesi.Add(new List<Point> {kumeMerkez});
                //***********UĞRAŞTIRAN KOD PARÇACIĞI*********//

                

                chart1.Series["KumeMerkezleri"].Points.AddXY(kumeMerkez.X, kumeMerkez.Y);

                listBoxKumeMerkezleri.Items.Add(i + 1);
                listBoxKumeMerkezleri.Items.Add("X - Y");
                listBoxKumeMerkezleri.Items.Add(kumeMerkez);
                listBoxKumeMerkezleri.Items.Add("");
            }

            
            //foreach (var item in kumeListesi)
            //{
            //    MessageBox.Show(item[0].ToString());
                
            //}
        }

        private void buttonKumele_Click(object sender, EventArgs e)
        {
            chartTemizle();
            iterasyon++;
            labeliterasyonSayisi.Text = iterasyon.ToString();
            int renkKodu = 0;

            foreach (Point veri in veriListesi)
            {
                uzakliklar.Clear();
                double min = 0.0;
                int index = 0;
                double uzaklik = 0.0;

                foreach (List<Point> kume in kumeListesi)
                {
                    uzaklik = Math.Sqrt(Math.Pow((veri.X - kume[0].X), 2) + Math.Pow((veri.Y - kume[0].Y), 2));

                    uzakliklar.Add(uzaklik);
                }


                min = uzakliklar.Min();
                index = uzakliklar.IndexOf(min);

                kumeListesi[index].Add(veri);
            }

            List<Color> renkList = new List<Color>();

            Color renk = new Color();

            renk = Color.Blue;
            renkList.Add(renk);

            renk = Color.Lime;
            renkList.Add(renk);

            renk = Color.Indigo;
            renkList.Add(renk);

            renk = Color.DarkOrange;
            renkList.Add(renk);
            
            renk = Color.DarkSalmon;
            renkList.Add(renk);

            renk = Color.Gold;
            renkList.Add(renk);

            renk = Color.MediumSpringGreen;
            renkList.Add(renk);

            renk = Color.DimGray;
            renkList.Add(renk);

            renk = Color.Chartreuse;
            renkList.Add(renk);

            renk = Color.CornflowerBlue;
            renkList.Add(renk);

            renk = Color.Teal;
            renkList.Add(renk);

            int l = 1;
            

            foreach (List<Point> kume in kumeListesi)
            {
                int xToplam = 0;
                int yToplam = 0;
                int xYeni = 0;
                int yYeni = 0;
                
                Point yeniMerkez = new Point();

                chart1.Series.Add("Kume "+l);
                chart1.Series.Add("Kume Merkezi " + l);
                

                chart1.Series["Kume " + l].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chart1.Series["Kume " + l].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                chart1.Series["Kume " + l].Color = renkList[renkKodu];
                chart1.Series["Kume " + l].MarkerSize = 8;
                renkKodu++;


                chart1.Series["Kume Merkezi " + l].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chart1.Series["Kume Merkezi " + l].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star10;
                chart1.Series["Kume Merkezi " + l].MarkerSize = 20;

                chart1.Series["Kume Merkezi " + l].Color = Color.FromArgb(255, 0, 127);

                chart1.Series["Kume Merkezi " + l].Points.AddXY(kume[0].X, kume[0].Y);

                foreach (Point veri in kume.Skip(1))
                {
                    chart1.Series["Kume "+l].Points.AddXY(veri.X, veri.Y);

                    xToplam = xToplam + veri.X;
                    yToplam = yToplam + veri.Y;
                }

                if((kume.Count() - 1) == 0 || (kume.Count() - 1) == 1)
                {
                    xYeni = xToplam / kume.Count();
                    yYeni = yToplam / kume.Count();
                    
                }

                else
                {
                    xYeni = xToplam / (kume.Count() - 1);
                    yYeni = yToplam / (kume.Count() - 1);
                }



                yeniMerkez.X = xYeni;
                yeniMerkez.Y = yYeni;


                if (xYeni == kume[0].X && yYeni == kume[0].Y)
                    bitti++;

                if(bitti == 3)
                {
                    labelKumeBitis.Text = "KÜMELEME TAMAMLANDI";

                    buttonKumele.Enabled = false;
                    buttonKumele.Text = "VERİ BEKLENİYOR...";
                    buttonKumele.ForeColor = Color.MidnightBlue;
                    buttonKumele.BackColor = Color.DarkGray;
                    bitti = 0;
                }

                kume.Clear();
                kume.Add(yeniMerkez);

                
                l++;
                
            }

            
            
        }

        
        

        private void nudVeriSayisi_ValueChanged(object sender, EventArgs e)
        {
            nudKumeSayisi.Maximum = nudVeriSayisi.Value;
        }

        private void nudMinDeger_ValueChanged(object sender, EventArgs e)
        {
            nudMaksDeger.Minimum = nudMinDeger.Value;
        }

        private void nudKumeSayisi_ValueChanged(object sender, EventArgs e)
        {
            buttonKumele.Enabled = false;
            buttonKumele.Text = "VERİ BEKLENİYOR...";
            buttonKumele.ForeColor = Color.MidnightBlue;
            buttonKumele.BackColor = Color.DarkGray;
        }
    }
}
