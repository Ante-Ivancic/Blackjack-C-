using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullApp3
{
    public static class Igra
    {

        //Dealer i igrač dobiju po dvije karte
        public static void PrvaRuka(List<Karta> Dek, List<Karta> lstDealer, List<Karta> lstIgrac)
        {
            lstDealer.Add(Dek[0]);
            Dek.RemoveAt(0);
            lstDealer[0].pozicija = 6;
            lstDealer[0].orijentacija = "dolje";

            //Karta.TestLokacija(lstDealer);
            Karta.DealerLokacija(lstDealer);
            Karta.NovaKartaPictureBox(lstDealer);

            lstIgrac.Add(Dek[0]);
            Dek.RemoveAt(0);
            lstIgrac[0].pozicija = 2;
            lstIgrac[0].inQueue = 1;
            lstIgrac[0].bet = Blackjack.ActualBetAmmount;
            lstIgrac[0].imeliste = "Igrac1";
            Karta.IgracLokacija(lstIgrac);
            Karta.NovaKartaPictureBox(lstIgrac);

            lstDealer.Add(Dek[0]);
            Dek.RemoveAt(0);
            lstDealer[1].pozicija = 6;
            Karta.DealerLokacija(lstDealer);
            Karta.NovaKartaPictureBox(lstDealer);

            lstIgrac.Add(Dek[0]);
            Dek.RemoveAt(0);
            Karta.IgracLokacija(lstIgrac);
            Karta.NovaKartaPictureBox(lstIgrac);

            Igra.ProvjeraPrveRuke(lstDealer, lstIgrac);
        }

        //Provjerava je li netko odmah dobio blackjack
        public static void ProvjeraPrveRuke(List<Karta> lstDealer, List<Karta> lstIgrac)
        {
            if (lstDealer[0].vrijednost + lstDealer[1].vrijednost == 21 && lstIgrac[0].vrijednost + lstIgrac[1].vrijednost != 21)
            {
                Provjera(Blackjack.lstIgrac1, Blackjack.lstIgrac2, Blackjack.lstIgrac3, Blackjack.lstIgrac4, Blackjack.lstDealer);
                //MessageBox.Show("Iz provjere prve ruke, provjeri je li ispravno.");
                Blackjack.ResetAvailible = true;
                Blackjack.GotovaIgra = true;
            }
            else if (lstDealer[0].vrijednost + lstDealer[1].vrijednost == 21 && lstIgrac[0].vrijednost + lstIgrac[1].vrijednost == 21)
            {
                Provjera(Blackjack.lstIgrac1, Blackjack.lstIgrac2, Blackjack.lstIgrac3, Blackjack.lstIgrac4, Blackjack.lstDealer);
                //MessageBox.Show("Iz provjere prve ruke, provjeri je li ispravno.");

                Blackjack.ResetAvailible = true;
                Blackjack.GotovaIgra = true;
            }
            else if (lstDealer[0].vrijednost + lstDealer[1].vrijednost != 21 && lstIgrac[0].vrijednost + lstIgrac[1].vrijednost == 21)
            {
                Provjera(Blackjack.lstIgrac1, Blackjack.lstIgrac2, Blackjack.lstIgrac3, Blackjack.lstIgrac4, Blackjack.lstDealer);
                //MessageBox.Show("Iz provjere prve ruke, provjeri je li ispravno.");
                Blackjack.ResetAvailible = true;
                Blackjack.GotovaIgra = true;
            }
            else
            {
                Blackjack.DopustiPotez = true;
                Blackjack.DoubleDownPossible = Igra.DoubleDownPossible(lstIgrac);
                Blackjack.SplitPossible = Igra.SplitPossible(lstIgrac);
                Blackjack.ActivePlayer = "Igrac1";
                PozicijaVelicina.LblHintPozicija();
            }
        }

        //Gleda je li potez split moguć
        public static bool SplitPossible(List<Karta> lstIgrac)
        {
            bool split;
            if (lstIgrac.Count == 2 && lstIgrac[0].vrijednost == lstIgrac[1].vrijednost)
                split = true;
            else
                split = false;

            try
            {
                if (Blackjack.lstIgrac1[0].pozicija != 0 && Blackjack.lstIgrac2[0].pozicija != 0 && Blackjack.lstIgrac3[0].pozicija != 0 && Blackjack.lstIgrac4[0].pozicija != 0)
                    split = false;
            }
            catch
            {
            }
            if (Blackjack.ActualBetAmmount > Blackjack.Balance)
                split = false;


            return split;
        }

        //Gleda je li potez double down moguć
        public static bool DoubleDownPossible(List<Karta> lstIgrac)
        {
            bool doubledown;
            if (Blackjack.Balance >= lstIgrac[0].bet)
                doubledown = true;
            else
                doubledown = false;
            return doubledown;
        }

        //Nakon poteza hit obavlja provjeru
        public static void ProvjeraHit(List<Karta> lstIgrac, List<Karta> lstDealer, List<Karta> lstIgrac57, List<Karta> lstIgrac58, List<Karta> lstIgrac59)
        {
            if (Igra.IgracJacinaRuke(lstIgrac) < 21)
            {
                Blackjack.DopustiPotez = true;
                Blackjack.DoubleDownPossible = DoubleDownPossible(lstIgrac);
                Blackjack.SplitPossible = SplitPossible(lstIgrac);
            }
            else if (Igra.IgracJacinaRuke(lstIgrac) >= 21)
            {
                //MessageBox.Show("Igrac prekoracio 21");
                PrilagodiQueue(lstIgrac, lstIgrac57, lstIgrac58, lstIgrac59);
                Igra.OdrediListuKojaIde(lstIgrac, lstIgrac59, lstIgrac58, lstIgrac57);
            }
        }

        //Kada igrač odabere potez double down. Daje mu posljednju kartu, provjerava ima li još koja ruka, aktivira provjeru
        public static void DoubleDown(List<Karta> Dek, List<Karta> lstIgrac, List<Karta> lstDealer, List<Karta> lstIgrac57, List<Karta> lstIgrac58, List<Karta> lstIgrac59)
        {
            lstIgrac.Add(Dek[0]);
            Dek.RemoveAt(0);
            Karta.IgracLokacija(lstIgrac);
            Karta.NovaKartaPictureBoxDoubleDown(lstIgrac);
            Igra.PrilagodiQueue(lstIgrac, lstIgrac57, lstIgrac58, lstIgrac59);
            Igra.OdrediListuKojaIde(lstIgrac, lstIgrac59, lstIgrac58, lstIgrac57);
        }

        //Nakon splita ili nakon što jedna ruka završi, odabire ruku koja je sljedeća na redu
        public static void OdrediListuKojaIde(List<Karta> lstIgrac1, List<Karta> lstIgrac2, List<Karta> lstIgrac3, List<Karta> lstIgrac4)
        {
            try
            {
                if (lstIgrac1[0].inQueue == 1)
                {
                    if (IgracJacinaRuke(lstIgrac1) < 21)
                    {
                        //MessageBox.Show("Provjerava se prva lista u odredi listu");
                        //PrilagodiQueue(lstIgrac1, lstIgrac2, lstIgrac3, lstIgrac4);
                        Blackjack.ActivePlayer = lstIgrac1[0].imeliste;
                        PozicijaVelicina.LblHintPozicija();
                        Blackjack.DopustiPotez = true;
                        Blackjack.DoubleDownPossible = Igra.DoubleDownPossible(lstIgrac1);
                        Blackjack.SplitPossible = Igra.SplitPossible(lstIgrac1);

                        //MessageBox.Show("Active player je igrac1");
                    }
                    else if(IgracJacinaRuke(lstIgrac1)==21)
                    {
                        PrilagodiQueue(lstIgrac1, lstIgrac2, lstIgrac3, lstIgrac4);
                        OdrediListuKojaIde(lstIgrac1, lstIgrac2, lstIgrac3, lstIgrac4);
                    }
                }
                else
                {
                    lstIgrac1[1000].inQueue = 1000;
                }
            }
            catch
            {
                try
                {
                    if (lstIgrac2[0].inQueue == 1)
                    {
                        if (IgracJacinaRuke(lstIgrac2) < 21)
                        {
                            //MessageBox.Show("Provjerava se druga lista u odredi listu");
                            //PrilagodiQueue(lstIgrac2, lstIgrac1, lstIgrac3, lstIgrac4);
                            Blackjack.ActivePlayer = lstIgrac2[0].imeliste;
                            PozicijaVelicina.LblHintPozicija();

                            Blackjack.DopustiPotez = true;
                            Blackjack.DoubleDownPossible = Igra.DoubleDownPossible(lstIgrac2);
                            Blackjack.SplitPossible = Igra.SplitPossible(lstIgrac2);

                        }
                        else if (IgracJacinaRuke(lstIgrac2) == 21)
                        {
                            PrilagodiQueue(lstIgrac2, lstIgrac1, lstIgrac3, lstIgrac4);
                            OdrediListuKojaIde(lstIgrac2, lstIgrac1, lstIgrac3, lstIgrac4);
                        }

                    }

                    else
                    {
                        lstIgrac1[1000].inQueue = 1000;
                    }
                }
                catch
                {
                    try
                    {
                        if (lstIgrac3[0].inQueue == 1)
                        {
                            if (IgracJacinaRuke(lstIgrac3) < 21)
                            {
                                //MessageBox.Show("Provjerava se treca lista u odredi listu");
                                //PrilagodiQueue(lstIgrac3, lstIgrac2, lstIgrac1, lstIgrac4);
                                Blackjack.ActivePlayer = lstIgrac3[0].imeliste;
                                PozicijaVelicina.LblHintPozicija();

                                Blackjack.DopustiPotez = true;
                                Blackjack.DoubleDownPossible = Igra.DoubleDownPossible(lstIgrac3);
                                Blackjack.SplitPossible = Igra.SplitPossible(lstIgrac3);

                            }
                            else if (IgracJacinaRuke(lstIgrac3) == 21)
                            {
                                PrilagodiQueue(lstIgrac3, lstIgrac2, lstIgrac1, lstIgrac4);
                                OdrediListuKojaIde(lstIgrac3, lstIgrac2, lstIgrac1, lstIgrac4);
                            }
                        }
                        else
                        {
                            lstIgrac1[1000].inQueue = 1000;
                        }
                    }
                    catch
                    {
                        try
                        {
                            if (lstIgrac4[0].inQueue == 1)
                            {
                                if (IgracJacinaRuke(lstIgrac4) < 21)
                                {
                                    //MessageBox.Show("Provjerava se cetvrta lista u odredi listu");
                                    //PrilagodiQueue(lstIgrac4, lstIgrac2, lstIgrac3, lstIgrac1);
                                    Blackjack.ActivePlayer = lstIgrac4[0].imeliste;
                                    PozicijaVelicina.LblHintPozicija();

                                    Blackjack.DopustiPotez = true;
                                    Blackjack.DoubleDownPossible = Igra.DoubleDownPossible(lstIgrac4);
                                    Blackjack.SplitPossible = Igra.SplitPossible(lstIgrac4);

                                }
                                else if (IgracJacinaRuke(lstIgrac4) == 21)
                                {
                                    PrilagodiQueue(lstIgrac4, lstIgrac2, lstIgrac3, lstIgrac1);
                                    OdrediListuKojaIde(lstIgrac4, lstIgrac2, lstIgrac3, lstIgrac1);
                                }

                            }
                            else
                            {
                                lstIgrac1[1000].inQueue = 1000;
                            }
                        }
                        catch
                        {
                            Provjera(Blackjack.lstIgrac1, Blackjack.lstIgrac2, Blackjack.lstIgrac3, Blackjack.lstIgrac4, Blackjack.lstDealer);
                            //igra.dealer
                            Blackjack.GotovaIgra = true;
                        }
                    }
                }
            }
        }

        //Poziva funkcije koje provjeravaju jesu li potezi mogući
        public static void PostavljanjeUvjeta(List<Karta> lstIgrac, string ListaKojaIde)
        {
            Blackjack.DopustiPotez = true;
            Blackjack.DoubleDownPossible = Igra.DoubleDownPossible(lstIgrac);
            Blackjack.SplitPossible = Igra.SplitPossible(lstIgrac);
        }

        //Miče sve liste u redu za jedan
        public static void PrilagodiQueue(List<Karta> lstIgracInQueue1, List<Karta> lstIgrac57, List<Karta> lstIgrac58, List<Karta> lstIgrac59)
        {
            lstIgracInQueue1[0].inQueue = 0;
            try
            {
                if (lstIgrac57[0].inQueue > 0)
                    lstIgrac57[0].inQueue -= 1;
            }
            catch
            {

            }

            try
            {
                if (lstIgrac58[0].inQueue > 0)
                    lstIgrac58[0].inQueue -= 1;
            }
            catch
            {

            }

            try
            {
                if (lstIgrac59[0].inQueue > 0)
                    lstIgrac59[0].inQueue -= 1;
            }
            catch
            {

            }
            try
            {
                //MessageBox.Show("prilagodi queue: 1.lista:" + lstIgracInQueue1[0].inQueue.ToString() + ", 2.lista:" + lstIgrac57[0].inQueue.ToString() + ", 3.lista:" + lstIgrac58[0].inQueue.ToString() + ", 4.lista:" + lstIgrac59[0].inQueue.ToString());
            }
            catch
            {

            }
        }

        //Kada igrač odabere potez hit, daje mu kartu, vrši provjeru
        public static void Hit(List<Karta> Dek, List<Karta> lstIgrac, List<Karta> lstDealer, List<Karta> lstIgrac57, List<Karta> lstIgrac58, List<Karta> lstIgrac59)
        {
            lstIgrac.Add(Dek[0]);
            Dek.RemoveAt(0);
            Karta.IgracLokacija(lstIgrac);
            Karta.NovaKartaPictureBox(lstIgrac);
            ProvjeraHit(lstIgrac, lstDealer, lstIgrac57, lstIgrac58, lstIgrac59);
        }

        //Računa jačinu ruke igrača
        public static int IgracJacinaRuke(List<Karta> lstIgrac)
        {
            int zbroj = 0;
            int brA = 0;
            for (int i = 0; i < lstIgrac.Count; i++)
            {
                zbroj += lstIgrac[i].vrijednost;
                if (lstIgrac[i].ime == "A")
                    brA++;
            }
            if (zbroj > 21 && brA > 0)
                for (int j = 0; j < brA; j++)
                {
                    zbroj -= 10;
                    if (zbroj <= 21)
                        j = brA;
                }
            //MessageBox.Show("Jacina ruke" + zbroj.ToString());
            return zbroj;
        }

        //Određuje u koju listu ide karta koju igrač splita
        public static void SplitOdredivanjeIgraca(List<Karta> lstIgrac1, List<Karta> lstIgrac2, List<Karta> lstIgrac3, List<Karta> lstIgrac4, List<Karta> Dek, List<Karta> lstDealer)
        {

            //System.Windows.Forms.Form.ActiveForm.Controls.Remove(Blackjack.EveryPicturebox[Blackjack.EveryPicturebox.Count-1]);
            Blackjack.EveryPicturebox.RemoveAt(Blackjack.EveryPicturebox.Count - 1);
            if (lstIgrac2.Count == 0)
            {
                Igra.Split(lstIgrac1, lstIgrac2, lstIgrac3, lstIgrac4, Dek, lstDealer);
            }
            else if (lstIgrac3.Count == 0)
            {
                Igra.Split(lstIgrac1, lstIgrac3, lstIgrac2, lstIgrac4, Dek, lstDealer);
            }
            else if (lstIgrac4.Count == 0)
            {
                Igra.Split(lstIgrac1, lstIgrac4, lstIgrac3, lstIgrac2, Dek, lstDealer);
            }
        }
        //Gleda je li pozicija za novu ruku već zauzeta
        public static bool PozicijaAvailible(List<Karta> lstIgrac1, List<Karta> lstIgrac3, List<Karta> lstIgrac4, int pozicija)
        {
            bool PozicijaAvailible = true;
            try
            {
                if (lstIgrac1[0].pozicija == pozicija)
                    PozicijaAvailible = false;
            }
            catch
            {

            }

            try
            {
                if (lstIgrac3[0].pozicija == pozicija)
                    PozicijaAvailible = false;
            }
            catch
            {

            }

            try
            {
                if (lstIgrac4[0].pozicija == pozicija)
                    PozicijaAvailible = false;
            }
            catch
            {

            }
            return PozicijaAvailible;
        }
        //Nakon što igrač odabere split. jednu ruku razbija u dvije, određuje koja prva nastavlja
        public static void Split(List<Karta> lstIgracStara, List<Karta> lstIgracNova, List<Karta> lstIgrac3, List<Karta> lstIgrac4, List<Karta> Dek, List<Karta> lstDealer)
        {
            lstIgracNova.Add(lstIgracStara[lstIgracStara.Count - 1]);
            lstIgracStara.RemoveAt(lstIgracStara.Count - 1);
            for (int i = 1; i < 10; i++)
            {
                if (lstIgracStara[0].pozicija + i <= 5 && PozicijaAvailible(lstIgracStara, lstIgrac3, lstIgrac4, lstIgracStara[0].pozicija + i) == true)
                {
                    lstIgracNova[0].pozicija = lstIgracStara[0].pozicija + i;
                    break;
                }
                if (lstIgracStara[0].pozicija - i >= 0 && PozicijaAvailible(lstIgracStara, lstIgrac3, lstIgrac4, lstIgracStara[0].pozicija - i) == true)
                {
                    lstIgracNova[0].pozicija = lstIgracStara[0].pozicija - i;
                    break;
                }
            }
            PostavljanjeImenaListe(lstIgracNova, lstIgracStara, lstIgrac3, lstIgrac4);
            lstIgracNova[0].bet = Blackjack.ActualBetAmmount;
            Karta.IgracLokacija(lstIgracNova);
            Karta.NovaKartaPictureBox(lstIgracNova);
            lstIgracStara.Add(Dek[0]);
            Dek.RemoveAt(0);
            Karta.IgracLokacija(lstIgracStara);
            Karta.NovaKartaPictureBox(lstIgracStara);

            lstIgracNova.Add(Dek[0]);
            Dek.RemoveAt(0);
            Karta.IgracLokacija(lstIgracNova);
            Karta.NovaKartaPictureBox(lstIgracNova);

            PrilagodiQueueNakonSplita(lstIgracStara, lstIgracNova, lstIgrac3, lstIgrac4);
            OdrediListuKojaIde(lstIgracNova, lstIgracStara, lstIgrac3, lstIgrac4);

        }
        //Nakon splita miče queue za 1
        public static void PrilagodiQueueNakonSplita(List<Karta> lstStara, List<Karta> lstNova, List<Karta> lstIgrac3, List<Karta> lstIgrac4)
        {
            lstStara[0].inQueue = 2;
            lstNova[0].inQueue = 1;
            try
            {
                if (lstIgrac3[0].inQueue > 0)
                    lstIgrac3[0].inQueue++;
            }
            catch
            {

            }

            try
            {
                if (lstIgrac4[0].inQueue > 0)
                    lstIgrac4[0].inQueue++;
            }
            catch
            {

            }
            //MessageBox.Show(lstStara[0].inQueue.ToString());

            try
            {
                //MessageBox.Show("prilagodi queue nakon splita: 1.lista:" + lstStara[0].inQueue.ToString() + ", 2.lista:" + lstNova[0].inQueue.ToString() + ", 3.lista:" + lstIgrac3[0].inQueue.ToString() + ", 4.lista:" + lstIgrac4[0].inQueue.ToString());
            }
            catch
            {

            }

        }
        //Vraća ime liste koja je aktivna
        public static void PostavljanjeImenaListe(List<Karta> lstNova, List<Karta> lst2, List<Karta> lst3, List<Karta> lst4)
        {
            for (int i = 2; i < 5; i++)
            {
                string imeliste = "Igrac" + i.ToString();
                try
                {
                    if (lst2[0].imeliste == imeliste)
                        imeliste = "Ne moze";
                }
                catch
                {
                }

                try
                {
                    if (lst3[0].imeliste == imeliste)
                        imeliste = "Ne moze";
                }
                catch
                {
                }

                try
                {
                    if (lst4[0].imeliste == imeliste)
                        imeliste = "Ne moze";
                }
                catch
                {
                }

                if (imeliste != "Ne moze")
                    i = 5;
                lstNova[0].imeliste = imeliste;
            }
        }
        //Računa jačinu ruke dealera, ako je potrebno daje mu još karata
        public static int DealerJacinaRuke(List<Karta> lstDealer)
        {
            int dzbroj = 0;
            dzbroj = lstDealer[0].vrijednost + lstDealer[1].vrijednost;
            if (dzbroj == 22)
                dzbroj = 12;
            while (dzbroj < 17)
            {
                lstDealer.Add(Blackjack.Dek[0]);
                Blackjack.Dek.RemoveAt(0);
                Karta.DealerLokacija(lstDealer);
                Karta.NovaKartaPictureBox(lstDealer);
                dzbroj = Igra.IgracJacinaRuke(lstDealer);
            }
            return dzbroj;
        }
        //Provjerava sve ruke, uspoređuje jačinu igrača s dealerom za svaku od njih, računa dobitak, javlja rezultat porukom.
        public static void Provjera(List<Karta> Igrac1, List<Karta> Igrac2, List<Karta> Igrac3, List<Karta> Igrac4, List<Karta> Dealer)
        {
            string ReturnMessage = "";
            int Dobitak = 0;

            List<Karta> DealerPrvaKarta = new List<Karta>();
            DealerPrvaKarta.Add(Dealer[0]);
            DealerPrvaKarta[0].orijentacija = "gore";

            List<VrijednostBet> lstvrijednost = new List<VrijednostBet>();
            VrijednostBet vb = new VrijednostBet();
            lstvrijednost.Add(vb);
            VrijednostBet vb1 = new VrijednostBet();
            lstvrijednost.Add(vb1);
            VrijednostBet vb2 = new VrijednostBet();
            lstvrijednost.Add(vb2);
            VrijednostBet vb3 = new VrijednostBet();
            lstvrijednost.Add(vb3);
            int position1, position2, position3, position4;
            List<int> lstPosition = new List<int>();
            position1 = Igrac1[0].pozicija;
            lstPosition.Add(position1);
            if(Igrac2.Count>1)
            {
                position2 = Igrac2[0].pozicija;
                lstPosition.Add(position2);
            }
            if (Igrac3.Count > 1)
            {
                position3 = Igrac3[0].pozicija;
                lstPosition.Add(position3);
            }
            if (Igrac4.Count > 1)
            {
                position4 = Igrac4[0].pozicija;
                lstPosition.Add(position4);
            }
            lstPosition.Sort();
            //MessageBox.Show(lstPosition.Count.ToString());
            foreach (int position in lstPosition)
            {
                if (position == Igrac1[0].pozicija)
                {
                    if (lstvrijednost[0].vrijednost == 99)
                    {
                        lstvrijednost[0].vrijednost = IgracJacinaRuke(Igrac1);
                        lstvrijednost[0].bet = Igrac1[0].bet;
                    }
                    else
                    {
                        if (lstvrijednost[1].vrijednost == 99)
                        {
                            lstvrijednost[1].vrijednost = IgracJacinaRuke(Igrac1);
                            lstvrijednost[1].bet = Igrac1[0].bet;
                        }
                        else if (lstvrijednost[2].vrijednost == 99)
                        {
                            lstvrijednost[2].vrijednost = IgracJacinaRuke(Igrac1);
                            lstvrijednost[2].bet = Igrac1[0].bet;
                        }
                        else if (lstvrijednost[3].vrijednost == 99)
                        {
                            lstvrijednost[3].vrijednost = IgracJacinaRuke(Igrac1);
                            lstvrijednost[3].bet = Igrac1[0].bet;
                        }
                    }
                }
                else if (position == Igrac2[0].pozicija)
                {
                    if (lstvrijednost[0].vrijednost == 99)
                    {
                        lstvrijednost[0].vrijednost = IgracJacinaRuke(Igrac2);
                        lstvrijednost[0].bet = Igrac2[0].bet;
                    }
                    else if (lstvrijednost[1].vrijednost == 99)
                    {
                        lstvrijednost[1].vrijednost = IgracJacinaRuke(Igrac2);
                        lstvrijednost[1].bet = Igrac2[0].bet;

                    }
                    else if (lstvrijednost[2].vrijednost == 99)
                    {
                        lstvrijednost[2].vrijednost = IgracJacinaRuke(Igrac2);
                        lstvrijednost[2].bet = Igrac2[0].bet;

                    }
                    else if (lstvrijednost[3].vrijednost == 99)
                    {
                        lstvrijednost[3].vrijednost = IgracJacinaRuke(Igrac2);
                        lstvrijednost[3].bet = Igrac2[0].bet;

                    }
                }
                else if (position == Igrac3[0].pozicija)
                {
                    if (lstvrijednost[0].vrijednost == 99)
                    {
                        lstvrijednost[0].vrijednost = IgracJacinaRuke(Igrac3);
                        lstvrijednost[0].bet = Igrac3[0].bet;
                    }
                    else if (lstvrijednost[1].vrijednost == 99)
                    {
                        lstvrijednost[1].vrijednost = IgracJacinaRuke(Igrac3);
                        lstvrijednost[1].bet = Igrac3[0].bet;

                    }
                    else if (lstvrijednost[2].vrijednost == 99)
                    {
                        lstvrijednost[2].vrijednost = IgracJacinaRuke(Igrac3);
                        lstvrijednost[2].bet = Igrac3[0].bet;

                    }
                    else if (lstvrijednost[3].vrijednost == 99)
                    {
                        lstvrijednost[3].vrijednost = IgracJacinaRuke(Igrac3);
                        lstvrijednost[3].bet = Igrac3[0].bet;

                    }
                }
                else if (position == Igrac4[0].pozicija)
                {
                    if (lstvrijednost[0].vrijednost == 99)
                    {
                        lstvrijednost[0].vrijednost = IgracJacinaRuke(Igrac4);
                        lstvrijednost[0].bet = Igrac4[0].bet;
                    }
                    else if (lstvrijednost[1].vrijednost == 99)
                    {
                        lstvrijednost[1].vrijednost = IgracJacinaRuke(Igrac4);
                        lstvrijednost[1].bet = Igrac4[0].bet;

                    }
                    else if (lstvrijednost[2].vrijednost == 99)
                    {
                        lstvrijednost[2].vrijednost = IgracJacinaRuke(Igrac4);
                        lstvrijednost[2].bet = Igrac4[0].bet;

                    }
                    else if (lstvrijednost[3].vrijednost == 99)
                    {
                        lstvrijednost[3].vrijednost = IgracJacinaRuke(Igrac4);
                        lstvrijednost[3].bet = Igrac4[0].bet;

                    }
                }
            }
            int j = 4;
            for (int i = 0; i < j; i++)
            {
                if (lstvrijednost[i].vrijednost == 99)
                {
                    lstvrijednost.RemoveAt(i);
                    j--;
                    i--;

                }
            }
            foreach (VrijednostBet vrb in lstvrijednost)
            {
                //MessageBox.Show(vrb.vrijednost.ToString());
            }
            //MessageBox.Show(lstvrijednost.Count.ToString());
            bool AllBust = true;
            foreach (VrijednostBet vrb in lstvrijednost)
            {
                if (vrb.vrijednost <= 21)
                    AllBust = false;
            }
            bool AllBlackjack = true;
            foreach (VrijednostBet vrb in lstvrijednost)
            {
                if (vrb.vrijednost != 21)
                    AllBlackjack = false;
            }
            if (AllBust == true)
            {
                if (lstvrijednost.Count == 1)
                {
                    Karta.NovaKartaPictureBox(DealerPrvaKarta);

                    ReturnMessage = "Bust.   Dealer wins.";
                }
                else
                {
                    Karta.NovaKartaPictureBox(DealerPrvaKarta);

                    ReturnMessage = "All your hands are bust.   Dealer wins";
                }
            }
            else if (AllBlackjack == true)
            {
                int DealerVrijednost = Dealer[0].vrijednost + Dealer[1].vrijednost;
                //MessageBox.Show("Dealer vrijednost: " + DealerVrijednost.ToString());
                Karta.NovaKartaPictureBox(DealerPrvaKarta);
                if (lstvrijednost.Count == 1)
                {
                    if (DealerVrijednost == 21)
                    {
                        Dobitak = lstvrijednost[0].bet;
                        ReturnMessage = "Both you and the dealer have a blackjack.   The hand is a push";
                    }
                    else
                    {
                        Dobitak = (5 * lstvrijednost[0].bet / 2);
                        ReturnMessage = "You win.   You have a blackjack.";
                    }
                }
                else
                {
                    if (DealerVrijednost == 21)
                    {
                        foreach (VrijednostBet vrb in lstvrijednost)
                        {
                            Dobitak += vrb.bet;
                        }
                        ReturnMessage = "Both you and the dealer have a blackjack.   The hand is a push";
                    }
                    else
                    {
                        foreach (VrijednostBet vrb in lstvrijednost)
                        {
                            Dobitak += (5 * vrb.bet / 2);
                        }
                        ReturnMessage = "You win. You have a blackjack.";
                    }
                }
            }
            else
            {
                Karta.NovaKartaPictureBox(DealerPrvaKarta);
                int DealerVrijednost = DealerJacinaRuke(Dealer);
                //MessageBox.Show("Dealer vrijednost: " + DealerVrijednost.ToString());

                if (lstvrijednost.Count == 1)
                {
                    if (lstvrijednost[0].vrijednost == 21)
                    {
                        if (DealerVrijednost == 21)
                        {
                            ReturnMessage = "Both you and the dealer have a blackjack.   The hand is a push.";
                            Dobitak = lstvrijednost[0].bet;
                        }
                        else
                        {
                            Dobitak = 5 * lstvrijednost[0].bet / 2;
                            ReturnMessage = "You have a blackjack.   You win " + Dobitak.ToString() + " chips.";
                        }
                    }
                    else if (lstvrijednost[0].vrijednost < 21)
                    {
                        if (lstvrijednost[0].vrijednost > DealerVrijednost)
                        {
                            Dobitak = 2 * lstvrijednost[0].bet;
                            ReturnMessage = "You are closer to 21.   You win " + Dobitak.ToString() + " chips.";
                        }
                        else if (lstvrijednost[0].vrijednost == DealerVrijednost)
                        {
                            Dobitak = lstvrijednost[0].bet;
                            ReturnMessage = "The hand is a push.";
                        }
                        else if (lstvrijednost[0].vrijednost < DealerVrijednost)
                        {
                            if(DealerVrijednost<21)
                            {
                                ReturnMessage = "Dealer wins.   Dealer is closer to 21.";
                            }
                            else if(DealerVrijednost==21)
                            {

                                ReturnMessage = "Dealer wins.   Dealer has a blackjack.";
                            }
                            else if(DealerVrijednost>21)
                            {
                                Dobitak += 2*lstvrijednost[0].bet;
                                ReturnMessage = "The dealer is bust.   You win.";
                            }
                        }
                    }
                }
                else
                {
                    foreach (VrijednostBet vrb in lstvrijednost)
                    {
                        if (vrb.vrijednost == 21)
                        {
                            if (DealerVrijednost == 21)
                            {
                                Dobitak += vrb.bet;
                            }
                            else if (DealerVrijednost!=21)
                            {
                                Dobitak = Dobitak + (5 * vrb.bet / 2);
                            }
                        }
                        else if (vrb.vrijednost < 21)
                        {
                            if (DealerVrijednost > 21)
                                Dobitak += vrb.bet * 2;
                            if (DealerVrijednost < 21)
                            {
                                if (DealerVrijednost == vrb.vrijednost)
                                    Dobitak += vrb.bet;
                                else if (DealerVrijednost < vrb.vrijednost)
                                    Dobitak += 2 * vrb.bet;
                            }
                        }
                    }
                    if (lstvrijednost.Count == 2)
                    {
                        if (Dobitak != 0)
                        {
                            ReturnMessage = "You have " + lstvrijednost[0].vrijednost.ToString() + " in your left hand and " + lstvrijednost[1].vrijednost.ToString() + " in your right hand. You win " + Dobitak.ToString() + ".";

                        }
                        else if (Dobitak == 0)
                        {
                            ReturnMessage = "You have " + lstvrijednost[0].vrijednost.ToString() + " in your left hand and " + lstvrijednost[1].vrijednost.ToString() + " in your right hand.   Dealer wins.";
                        }
                    }
                    if (lstvrijednost.Count == 3)
                    {
                        if (Dobitak != 0)
                            ReturnMessage = "From left to right, you have " + lstvrijednost[0].vrijednost.ToString() + ", " + lstvrijednost[1].vrijednost.ToString() + " and " + lstvrijednost[2].vrijednost.ToString() + ".   You win " + Dobitak.ToString() + ".";
                        else if (Dobitak == 0)
                        {
                            ReturnMessage = "From left to right, you have " + lstvrijednost[0].vrijednost.ToString() + ", " + lstvrijednost[1].vrijednost.ToString() + " and " + lstvrijednost[2].vrijednost.ToString() + ".   Dealer wins.";
                        }

                    }
                    if (lstvrijednost.Count == 4)
                        if (Dobitak != 0)
                            ReturnMessage = "From left to right, you have " + lstvrijednost[0].vrijednost.ToString() + ", " + lstvrijednost[1].vrijednost.ToString() + ", " + lstvrijednost[2].vrijednost.ToString() + " and " + lstvrijednost[3].vrijednost.ToString()+ ".   You win " + Dobitak.ToString() + ".";
                        else if (Dobitak == 0)
                        {
                            ReturnMessage = "From left to right, you have " + lstvrijednost[0].vrijednost.ToString() + ", " + lstvrijednost[1].vrijednost.ToString() + ", " + lstvrijednost[2].vrijednost.ToString() +" and "+ lstvrijednost[3].vrijednost.ToString() + ".   Dealer wins.";
                        }
                }
                
            }
            Blackjack.Balance += Dobitak;
            Blackjack.lblDobitak.Text = "+" + Dobitak.ToString();
            Blackjack.ChangelblBalanceText();
            if(Dobitak!=0)
            {
                Blackjack.lblDobitak.Visible = true;
            }
            Blackjack.lblReturnMessage.Text = ReturnMessage;
            Blackjack.lblReturnMessage.Visible = true;

            Blackjack.GotovaIgra = true;
            Blackjack.ResetAvailible = true;
            //MessageBox.Show(ReturnMessage);
        }
    }
}