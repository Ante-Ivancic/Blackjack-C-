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

namespace FullApp3
{
    public partial class Form1 : Form
    {
        public static Korisnik AktivniKorisnik;
        List<Korisnik> lstKorisnici = new List<Korisnik>();
        public Form1()
        {
            InitializeComponent();
        }

            //Uređen izgled forme
        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Visible = false;
            btnRegister.Visible = true;

            btnLoginConfirm.Visible = true;
            btnLoginConfirm.Location = new Point(240 * 3 / 4, 400);
            btnRegisterConfirm.Visible = false;

            lblLoginUsername.Visible = true;
            tbLoginUsername.Visible = true;
            lblLoginPassword.Visible = true;
            tbLoginPassword.Visible = true;

            lblRegisterName.Visible = false;
            tbRegisterName.Visible = false;
            lblRegisterSurname.Visible = false;
            tbRegisterSurname.Visible = false;
            lblRegisterUsername.Visible = false;
            tbRegisterUsername.Visible = false;
            lblRegisterPassword.Visible = false;
            tbRegisterPassword.Visible = false;

            btnRegister.Size = new Size(60*3/4, 30);
            btnRegister.Location = new Point(270*3/4, 450);
            btnRegister.Font = new Font("Agency FB", 12);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            btnRegister.Visible = false;
            btnLogin.Visible = true;

            btnRegisterConfirm.Visible = true;
            btnRegisterConfirm.Location = new Point(240*3/4, 400);
            btnLoginConfirm.Visible = false;

            lblRegisterName.Visible = true;
            tbRegisterName.Visible = true;
            lblRegisterSurname.Visible = true;
            tbRegisterSurname.Visible = true;
            lblRegisterUsername.Visible = true;
            tbRegisterUsername.Visible = true;
            lblRegisterPassword.Visible = true;
            tbRegisterPassword.Visible = true;

            lblLoginUsername.Visible = false;
            tbLoginUsername.Visible = false;
            lblLoginPassword.Visible = false;
            tbLoginPassword.Visible = false;

            btnLogin.Size = new Size(60*3/4, 30);
            btnLogin.Location = new Point(270*3/4, 450);
            btnLogin.Font = new Font("Agency FB", 12);
        }
            //Provjerava unešene podatke i omogućuje login
        private void btnLoginConfirm_Click(object sender, EventArgs e)
        {

            if(tbLoginPassword.Text!="" && tbLoginUsername.Text!="")
            {
                lstKorisnici = Admin.DatListaKorisnika();
                bool TocnostPassworda = Admin.TocanPassword(lstKorisnici, tbLoginUsername.Text, tbLoginPassword.Text);
                if(TocnostPassworda==true)
                {
                    Blackjack blackjackform = new Blackjack(AktivniKorisnik);
                    this.Hide();
                    blackjackform.Show();

                }
                else
                {
                    if (Admin.PostojiLiKorisnik(lstKorisnici, tbLoginUsername.Text) == true)
                        MessageBox.Show("Unijeli ste krivu šifru.");
                    else
                        MessageBox.Show("Ne postoji ovaj korisnik.");
                }
            }
        }
            //Registracija novih korisnika
        private void btnRegisterConfirm_Click(object sender, EventArgs e)
        {

            if(tbRegisterName.Text!="" && tbRegisterSurname.Text!="" && tbRegisterUsername.Text!="" && tbRegisterPassword.Text!="")
            {
                lstKorisnici = Admin.DatListaKorisnika();
                string IspravnostUsernamea = Admin.IspravnostUsernamea(lstKorisnici, tbRegisterUsername.Text);
                if (IspravnostUsernamea == "odobren")
                {
                    Korisnik k = new Korisnik(tbRegisterUsername.Text, tbRegisterPassword.Text, tbRegisterName.Text, tbRegisterSurname.Text);

                    Blackjack.name = tbRegisterName.Text;
                    Blackjack.surname = tbRegisterSurname.Text;
                    Blackjack.username = tbRegisterUsername.Text;
                    Blackjack.password = tbRegisterPassword.Text;

                    Admin.ZapisUDatoteku(k);
                    tbRegisterName.Clear();
                    tbRegisterSurname.Clear();
                    tbRegisterUsername.Clear();
                    tbRegisterPassword.Clear();
                    AktivniKorisnik = k;
                    Blackjack blackjackform = new Blackjack(k);
                    this.Hide();
                    blackjackform.Show();

                }
                else
                {
                    MessageBox.Show("Odaberite drugi username");
                }
            }
            else
            {
                MessageBox.Show("Sva polja moraju biti popunjena");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
