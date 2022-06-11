using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullApp3
{
    public static class UcitavanjeDeka
    {

        //Korišteno za testiranje
        public static void FakeGeneriranje(List<Karta> Dek)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    string zog;
                    if (j == 0)
                        zog = "S";
                    else if (j == 1)
                        zog = "H";
                    else if (j == 2)
                        zog = "D";
                    else
                        zog = "C";
                    Karta k1 = new Karta(zog, "A", 11, "Gore");
                    Dek.Add(k1);
                    Karta k2 = new Karta(zog, "K", 10, "Gore");
                    Dek.Add(k2);
                    Karta k3 = new Karta(zog, "Q", 10, "Gore");
                    Dek.Add(k3);
                    Karta k4 = new Karta(zog, "J", 10, "Gore");
                    Dek.Add(k4);
                    Karta k5 = new Karta(zog, "10", 10, "Gore");
                    Dek.Add(k5);
                    Karta k6 = new Karta(zog, "9", 10, "Gore");
                    Dek.Add(k6);
                    Karta k7 = new Karta(zog, "8", 10, "Gore");
                    Dek.Add(k7);
                    Karta k8 = new Karta(zog, "7", 10, "Gore");
                    Dek.Add(k8);
                    Karta k9 = new Karta(zog, "6", 10, "Gore");
                    Dek.Add(k9);
                    Karta k10 = new Karta(zog, "5", 10, "Gore");
                    Dek.Add(k10);
                    Karta k11 = new Karta(zog, "4", 10, "Gore");
                    Dek.Add(k11);
                    Karta k12 = new Karta(zog, "3", 10, "Gore");
                    Dek.Add(k12);
                    Karta k13 = new Karta(zog, "2", 10, "Gore");
                    Dek.Add(k13);
                }
            }
        }

        //generira dek karata
        public static void Generiranje(List<Karta> Dek)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    string zog;
                    if (j == 0)
                        zog = "S";
                    else if (j == 1)
                        zog = "H";
                    else if (j == 2)
                        zog = "D";
                    else
                        zog = "C";
                    Karta k1 = new Karta(zog, "A", 11, "Gore");
                    Dek.Add(k1);
                    Karta k2 = new Karta(zog, "K", 10, "Gore");
                    Dek.Add(k2);
                    Karta k3 = new Karta(zog, "Q", 10, "Gore");
                    Dek.Add(k3);
                    Karta k4 = new Karta(zog, "J", 10, "Gore");
                    Dek.Add(k4);
                    Karta k5 = new Karta(zog, "10", 10, "Gore");
                    Dek.Add(k5);
                    Karta k6 = new Karta(zog, "9", 9, "Gore");
                    Dek.Add(k6);
                    Karta k7 = new Karta(zog, "8", 8, "Gore");
                    Dek.Add(k7);
                    Karta k8 = new Karta(zog, "7", 7, "Gore");
                    Dek.Add(k8);
                    Karta k9 = new Karta(zog, "6", 6, "Gore");
                    Dek.Add(k9);
                    Karta k10 = new Karta(zog, "5", 5, "Gore");
                    Dek.Add(k10);
                    Karta k11 = new Karta(zog, "4", 4, "Gore");
                    Dek.Add(k11);
                    Karta k12 = new Karta(zog, "3", 3, "Gore");
                    Dek.Add(k12);
                    Karta k13 = new Karta(zog, "2", 2, "Gore");
                    Dek.Add(k13);
                }
            }
        }

        //miješa dek
        public static void Shuffle(List<Karta> Dek)
        {
            Random rnd = new Random();
            int n = rnd.Next(8000, 10000);
            for (int i = 0; i < n; i++)
            {
                Karta t = new Karta();
                int a = rnd.Next(416);
                int b = rnd.Next(416);
                t = Dek[a];
                Dek[a] = Dek[b];
                Dek[b] = t;
            }
        }
    }
}
