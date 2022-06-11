using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullApp3
{
    public partial class SendMoney : Form
    {
        public static Korisnik Primatelj;
        public static Korisnik Davatelj = Blackjack.AktivniKorisnik;
        public SendMoney()
        {
            InitializeComponent();


            tbDavatelj.Text = Davatelj.username;

        }

        //Provjerava jesu li svi podatci ispravni i vrši transakciju
        private void btnUplati_Click(object sender, EventArgs e)
        {
            int svota;
            if(tbPrimatelj.Text!=""&&tbIznos.Text!="")
            {
                try
                {
                    svota = int.Parse(tbIznos.Text);
                    if(svota>Blackjack.Balance)
                    {
                        MessageBox.Show("Morate imati dovoljno novca na računu");
                    }
                    else
                    {
                        List<Korisnik> SviKorisnici = Admin.DatListaKorisnika();
                        bool PostojiLiKorisnik = false;
                        foreach (Korisnik k in SviKorisnici)
                        {
                            if(k.username.ToLower()==tbPrimatelj.Text.ToLower())
                            {
                                PostojiLiKorisnik = true;
                                Primatelj = k;
                                break;
                            }
                        }
                        if (PostojiLiKorisnik == false)
                        {
                            MessageBox.Show("Ne postoji korisnik s ovim usernameom");
                        }
                        else if (PostojiLiKorisnik == true)
                        {
                            Blackjack.Balance -= svota;
                            int PrimateljBalance = svota+ int.Parse(Primatelj.balance);
                            Admin.KorisnikUpdate(Davatelj, Blackjack.Balance);
                            Admin.KorisnikUpdate(Primatelj, PrimateljBalance);
                            tbIznos.Clear();
                            tbPrimatelj.Clear();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Iznos mora biti broj");
                }
            }
            else
            {
                MessageBox.Show("Sva polja moraju biti popunjena");
            }
        }
    }
}
