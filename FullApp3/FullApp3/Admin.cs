using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace FullApp3
{
    public static class Admin
    {
        //Podatke iz datoteke korisnici pretvara u listu
        public static List<Korisnik> DatListaKorisnika()
        {

            List<Korisnik> lstKorisnici = new List<Korisnik>();
            StreamReader sr = new StreamReader("Korisnici.txt");
            bool kraj = false;
            string linija;
            while(kraj==false)
            {
                linija = sr.ReadLine();
                if(linija!=null)
                {
                    string[] RazlomljenaLinija = linija.Split('|');
                    Korisnik k = new Korisnik(RazlomljenaLinija[0], RazlomljenaLinija[1], RazlomljenaLinija[2], RazlomljenaLinija[3],RazlomljenaLinija[4]);
                    lstKorisnici.Add(k);
                }
                else
                {
                    kraj = true;
                }
            }
            sr.Close();
            return lstKorisnici;
        }


            //Prilikom registrationa provjerava koristi li se username
        public static string IspravnostUsernamea(List<Korisnik> lstKorisnici, string username)
        {
            string ispravnostusernamea = "odobren";
            foreach (Korisnik k in lstKorisnici)
            {
                if(k.username.ToLower()==username.ToLower())
                {
                    ispravnostusernamea = "neispravan";
                }
            }
            return ispravnostusernamea;
        }


            //Novog korisnika zapisuje u datoteku
        public static void ZapisUDatoteku(Korisnik k)
        {

            string linija = k.InfoZaDatoteku();
            StreamWriter sw = File.AppendText("Korisnici.txt");
            sw.WriteLine(linija);
            sw.Close();
        }


            //Kod logina gleda je li password točan
        public static bool TocanPassword(List<Korisnik> lstKorisnici, string username, string password)
        {

            bool tocnost = false;
            string _name="", _surname="";
            foreach (Korisnik k in lstKorisnici)
            {
                if(k.username.ToLower()==username.ToLower()&&k.password==password)
                {
                    tocnost = true;
                    _name = k.name;
                    _surname = k.surname;
                    Form1.AktivniKorisnik = k;
                }
            }

            //Šalje podatke o korisniku koji se logira u formu blackjack
            if(tocnost==true)
            {
                Blackjack.name = _name;
                Blackjack.surname = _surname;
                Blackjack.username = username;
                Blackjack.password = password;
            }

            return tocnost;
        }


            //Ako se password i username ne podudaraju provjerava postoji li taj username.
        public static bool PostojiLiKorisnik(List<Korisnik> lstKorisnici, string username)
        {
            bool PostojanjeKorisnika = false;
            foreach (Korisnik k in lstKorisnici)
            {
                if (k.username.ToLower() == username.ToLower())
                    PostojanjeKorisnika = true;
            }

            return PostojanjeKorisnika;
        }


            //Popunjava listu bet ammount koja služi kao data base labela lblAmmount
        public static void ListaZaBetAmmount(List<int> lst)
        {

            lst.Add(1000);
            lst.Add(2000);
            lst.Add(3000);
            lst.Add(4000);
            lst.Add(5000);
            lst.Add(6000);
            lst.Add(7000);
            lst.Add(8000);
            lst.Add(9000);
            lst.Add(10000);
            lst.Add(15000);
            lst.Add(20000);
            lst.Add(25000);
            lst.Add(30000);
            lst.Add(35000);
            lst.Add(40000);
            lst.Add(45000);
            lst.Add(50000);
        }


            //Popunjava listu lstTranzicija koja u sebi sadrži sve frameove animacije tranzicije
        public static void UcitavanjeListeBitmapTranzicija(List<Bitmap> lst)
        {

            lst.Add(new Bitmap(@"Tranzicija\0001.png"));
            lst.Add(new Bitmap(@"Tranzicija\0002.png"));
            lst.Add(new Bitmap(@"Tranzicija\0003.png"));
            lst.Add(new Bitmap(@"Tranzicija\0004.png"));
            lst.Add(new Bitmap(@"Tranzicija\0005.png"));
            lst.Add(new Bitmap(@"Tranzicija\0006.png"));
            lst.Add(new Bitmap(@"Tranzicija\0007.png"));
            lst.Add(new Bitmap(@"Tranzicija\0008.png"));
            lst.Add(new Bitmap(@"Tranzicija\0009.png"));
            lst.Add(new Bitmap(@"Tranzicija\0010.png"));
            lst.Add(new Bitmap(@"Tranzicija\0011.png"));
            lst.Add(new Bitmap(@"Tranzicija\0012.png"));
            lst.Add(new Bitmap(@"Tranzicija\0013.png"));
            lst.Add(new Bitmap(@"Tranzicija\0014.png"));
            lst.Add(new Bitmap(@"Tranzicija\0015.png"));
            lst.Add(new Bitmap(@"Tranzicija\0016.png"));
            lst.Add(new Bitmap(@"Tranzicija\0017.png"));
            lst.Add(new Bitmap(@"Tranzicija\0018.png"));
            lst.Add(new Bitmap(@"Tranzicija\0019.png"));
            lst.Add(new Bitmap(@"Tranzicija\0020.png"));
            lst.Add(new Bitmap(@"Tranzicija\0021.png"));
            lst.Add(new Bitmap(@"Tranzicija\0022.png"));
            lst.Add(new Bitmap(@"Tranzicija\0023.png"));
            lst.Add(new Bitmap(@"Tranzicija\0024.png"));
        }

        //Ažurira balance određenog korisnika u datoteci.
        public static void KorisnikUpdate(Korisnik k, int balance)
        {
            string tempFile = Path.GetTempFileName();

            using (var sr = new StreamReader("Korisnici.txt"))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    //if (line != "removeme")
                    string[] RazlomljenaLinija = line.Split('|');
                    if (RazlomljenaLinija[0] == k.username)
                    {
                        line = "";
                        RazlomljenaLinija[4] = balance.ToString();
                        for (int i = 0; i < RazlomljenaLinija.Length; i++)
                        {
                            line += RazlomljenaLinija[i];
                            if (i < RazlomljenaLinija.Length - 1)
                                line += "|";
                        }
                    }
                    sw.WriteLine(line);
                }
            }

            File.Delete("Korisnici.txt");
            File.Move(tempFile, "Korisnici.txt");
        }
    }
}
