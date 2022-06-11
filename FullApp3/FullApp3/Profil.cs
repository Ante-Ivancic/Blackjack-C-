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
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
            label1.Text = "Dobrodošli, " + Blackjack.AktivniKorisnik.name+"!";
            label2.Text = "username: " + Blackjack.AktivniKorisnik.username;
            label3.Text = "balance: " + Blackjack.Balance;
        }
    }
}
