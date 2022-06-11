using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FullApp3
{
    public class Karta
    {
        private string _ime, _zog, _orijentacija,_imeliste;
        private int _vrijednost, _pozicija, _inqueue, _xaxis, _yaxis, _bet;

        public string ime
        {
            get { return _ime; }
            set { _ime = value; }
        }
        public string imeliste
        {
            get { return _imeliste; }
            set { _imeliste = value; }
        }
        public string zog
        {
            get { return _zog; }
            set { _zog = value; }
        }
        public int vrijednost
        {
            get { return _vrijednost; }
            set { _vrijednost = value; }
        }
        public int pozicija
        {
            get { return _pozicija; }
            set { _pozicija = value; }
        }
        public int inQueue
        {
            get { return _inqueue; }
            set { _inqueue = value; }
        }
        public int xAxis
        {
            get { return _xaxis; }
            set { _xaxis = value; }
        }
        public int yAxis
        {
            get { return _yaxis; }
            set { _yaxis = value; }
        }
        public int bet
        {
            get { return _bet; }
            set { _bet = value; }
        }
        public string orijentacija
        {
            get { return _orijentacija; }
            set { _orijentacija = value; }
        }
        public Karta(string zog, string ime, int vrijednost, string orijentacija)
        {
            _zog = zog;
            _ime = ime;
            _vrijednost = vrijednost;
            _orijentacija = orijentacija;
            _pozicija = 7;
            _inqueue = 0;
            _xaxis = 0;
            _yaxis = 0;
            _bet = 0;
            _imeliste = "";
        }
        public Karta()
        {
            _zog = "";
            _ime = "";
            _vrijednost = 0;
            _orijentacija = "";
            _pozicija = 7;
            _inqueue = 0;
            _xaxis = 0;
            _yaxis = 0;
            _bet = 0;
            _imeliste = "";
        }

        //Računa lokaciju karata u lstDealer
        public static void DealerLokacija(List<Karta>lstDealer)
        {
            double double12 = 12.0;
            double value = (lstDealer.Count() - 1) / double12;

            value = Math.Ceiling(value);
            lstDealer[lstDealer.Count() - 1].xAxis = Convert.ToInt32((1000 - Convert.ToInt32(Math.Ceiling(value)) * 105 - (lstDealer.Count() - 1) * 28)* 8/10*Blackjack.Omjer);
            lstDealer[lstDealer.Count() - 1].yAxis = Convert.ToInt32(47*8/10*Blackjack.Omjer);
        }

        //Računa lokaciju karata u lstIgrac
        public static void IgracLokacija(List<Karta>lstIgrac)
        {
            lstIgrac[lstIgrac.Count() - 1].xAxis = Convert.ToInt32((440+ lstIgrac[0].pozicija * 248 + (lstIgrac.Count() - 1) * 23)*8/10*Blackjack.Omjer);
            lstIgrac[lstIgrac.Count() - 1].yAxis = Convert.ToInt32((692 - 27 * (lstIgrac.Count() - 1))*8/10*Blackjack.Omjer);
            lstIgrac[lstIgrac.Count() - 1].pozicija = lstIgrac[0].pozicija;
            lstIgrac[lstIgrac.Count() - 1].bet = lstIgrac[0].bet;
        }

        //Na izračunatoj lokaciji stvara picturebox kartu
        public static void NovaKartaPictureBox(List <Karta> lstKarta)
        {
            string bitmapime = "";
            if (lstKarta[lstKarta.Count - 1].orijentacija == "dolje")
            {
                bitmapime = @"JPEG\Red_back.jpg";
            }
            else
            {
                bitmapime = @"JPEG\" + lstKarta[lstKarta.Count() - 1].ime + lstKarta[lstKarta.Count() - 1].zog + ".jpg";

            }
            PictureBox pb = new PictureBox();
            pb.BackColor = Color.Purple;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(Convert.ToInt32(93* 8/10*Blackjack.Omjer), Convert.ToInt32(139*8/10*Blackjack.Omjer));
            pb.Visible = true;
            pb.BackgroundImageLayout = ImageLayout.Zoom;
            pb.Enabled = true;
            pb.Location = new Point(lstKarta[lstKarta.Count - 1].xAxis, lstKarta[lstKarta.Count() - 1].yAxis);
            pb.Image = new Bitmap(bitmapime);
            pb.BringToFront();
            try
            {
                System.Windows.Forms.Form.ActiveForm.Controls.Add(pb);
            }
            catch
            {
            }

            //for (int i = 100; i > 0; i--)
            //{
            //    try
            //    {

            //        System.Windows.Forms.Form.ActiveForm.Controls.RemoveAt(i);
            //        MessageBox.Show(i.ToString());
            //    }
            //    catch
            //    {

            //    }
            //}
            pb.BringToFront();
            Blackjack.EveryPicturebox.Add(pb);
            Blackjack.EveryPicturebox.Add(pb);
        }

        //DoubleDown karta je bočna i zbog toga ima svoju metodu
        public static void NovaKartaPictureBoxDoubleDown(List<Karta> lstKarta)
        {
            string bitmapime = "";
            bitmapime = @"DD\" + lstKarta[lstKarta.Count() - 1].ime + lstKarta[lstKarta.Count() - 1].zog + ".jpg";

            PictureBox pb = new PictureBox();
            pb.BackColor = Color.Purple;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size( 139 * 8 / 10,93 * 8 / 10);
            pb.Visible = true;
            pb.BackgroundImageLayout = ImageLayout.Zoom;
            pb.Enabled = true;
            pb.Location = new Point(lstKarta[lstKarta.Count - 1].xAxis-31, lstKarta[lstKarta.Count() - 1].yAxis-12);
            pb.Image = new Bitmap(bitmapime);
            pb.BringToFront();

            System.Windows.Forms.Form.ActiveForm.Controls.Add(pb);
            pb.BringToFront();
            Blackjack.EveryPicturebox.Add(pb);
            Blackjack.EveryPicturebox.Add(pb);
        }

        //test
        public static void TestLokacija(List<Karta>lstDealer)
        {
            lstDealer[lstDealer.Count() - 1].xAxis = 200;
            lstDealer[lstDealer.Count() - 1].yAxis = 200;

        }
    }
}
