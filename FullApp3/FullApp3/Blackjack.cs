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
    public partial class Blackjack : Form
    {
        public static Korisnik AktivniKorisnik;
        List<int> lstBetAmmount = new List<int>();
        List<Bitmap> lstTranzicija = new List<Bitmap>();

        public static List<PictureBox> EveryPicturebox = new List<PictureBox>();

        public static Label lblBalance = new Label();
        public static Label lblDobitak = new Label();
        public static Label lblReturnMessage = new Label();

        public static Label lblHint = new Label();

        public static bool DopustiPotez = false;
        public static bool DoubleDownPossible = false;
        public static bool SplitPossible = false;

        public static string ActivePlayer = "";

        public static string name, surname, username, password;
        public static int MaxOsX = 0;
        public static int MaxOsY = 0;
        public static int PocetnaOsX = 0;
        public static int PocetnaOsY = 0;
        public static int BetAmmountIndex = 0;
        public static int TranzicijaFrameIndex = 0;

        public static double Omjer = 0;

        public static int ActualBetAmmount;
        public static int Balance = 100000;

        public static List<Karta> Dek = new List<Karta>();
        public static List<Karta> lstDealer = new List<Karta>();
        public static List<Karta> lstIgrac1 = new List<Karta>();
        public static List<Karta> lstIgrac2 = new List<Karta>();
        public static List<Karta> lstIgrac3 = new List<Karta>();
        public static List<Karta> lstIgrac4 = new List<Karta>();

        public static bool GotovaIgra=true;
        public static bool FastPlay = false;
        
        public static bool ResetAvailible = false;
        public static bool PozicijaVelicinaComplete = false;
        public static bool PozicijaVelicinaSettingsComplete = false;



        //Postavlja novu pozadinu(frame 1) i postavlja buttone i labele koji su potrebni
        private void btnPlay_Click(object sender, EventArgs e)
        {

            this.BackgroundImage = new Bitmap(@"Tranzicija\0001.png");
            btnPlay.Visible = false;
            btnFriends.Visible = false;
            btnProfile.Visible = false;
            
            pbBlackPlaceBet.Visible = true;
            //
            if(PozicijaVelicinaComplete==false)
            {

            PozicijaVelicina.PrilagodbaPictureBox(pbBlackPlaceBet);
            PozicijaVelicina.PrilagodbaLabel(lblPlaceBet);
            PozicijaVelicina.PrilagodbaLabel(lblAdjustBet);
            PozicijaVelicina.PrilagodbaLabel(lblBet);
            PozicijaVelicina.PrilagodbaLabel(lblAmmount);
            PozicijaVelicina.PrilagodbaLabel(lblDobitak);
            PozicijaVelicina.PrilagodbaLabel(lblReturnMessage);

            PozicijaVelicina.PrilagodbaLabel(lblHit);
            PozicijaVelicina.PrilagodbaLabel(lblSplit);
            PozicijaVelicina.PrilagodbaLabel(lblStand);
            PozicijaVelicina.PrilagodbaLabel(lblDoubleDown);
            PozicijaVelicina.PrilagodbaPictureBox(pbBlackPotez);
            PozicijaVelicina.PrilagodbaPictureBox(pbHit);
            PozicijaVelicina.PrilagodbaPictureBox(pbSplit);
            PozicijaVelicina.PrilagodbaPictureBox(pbStand);
            PozicijaVelicina.PrilagodbaPictureBox(pbDoubleDown);
            PozicijaVelicina.PrilagodbaPictureBox(pbPlaceBetB);
            PozicijaVelicina.PrilagodbaPictureBox(pbAdjustBetUpDown);
            PozicijaVelicina.PrilagodbaLabel(lblBalance);
            PozicijaVelicina.PrilagodbaLabel(lblBalanceChange1);
                PozicijaVelicinaComplete = true;
            }

            lblHit.Font = new Font("Agency FB", 22);
            lblSplit.Font = new Font("Agency FB", 22);
            lblStand.Font = new Font("Agency FB", 22);
            lblDoubleDown.Font = new Font("Agency FB", 22);



            lblPlaceBet.Visible = true;
            lblAdjustBet.Visible = true;
            lblBet.Visible = true;
            lblAmmount.Visible = true;

            lblPlaceBet.Font = new Font("Agency FB", 22);
            lblAdjustBet.Font = lblBet.Font = lblAmmount.Font = lblPlaceBet.Font;

            lblReturnMessage.Font = new Font("Agency FB", 16);

            pbPlaceBetB.Visible = true;
            pbAdjustBetUpDown.Visible = true;

            lblBalance.Visible = true;
            lblBalance.Font = new Font("Agency FB", 26,FontStyle.Bold);
            lblBalance.Text = "Balance: " + Balance.ToString();
            lblDobitak.Font = lblBalance.Font;

            lblBalanceChange1.Font=new Font("Agency FB", 26, FontStyle.Bold);

            BetAmmountIndex = 0;
            lblAmmount.Text = lstBetAmmount[BetAmmountIndex].ToString();
        }


        //Kad se ugasi ova forma, gasi se i cijela aplikacija
        private void Blackjack_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Postavlja neke konstante, prilagođava početne buttone i ucitaje potrebne nizove
        private void Blackjack_Load(object sender, EventArgs e)
        {
            PocetnaOsY = this.Size.Height;
            PocetnaOsX = this.Size.Width;
            this.WindowState = FormWindowState.Maximized;
            MaxOsX = this.Size.Width;
            MaxOsY = this.Size.Height;
            Omjer = MaxOsX / double.Parse(1536.ToString());

            PozicijaVelicina.PrilagodbaButton(btnPlay);

            PozicijaVelicina.PrilagodbaButton(btnFriends);

            PozicijaVelicina.PrilagodbaButton(btnProfile);

            Admin.ListaZaBetAmmount(lstBetAmmount);

            Admin.UcitavanjeListeBitmapTranzicija(lstTranzicija);

            UcitavanjeDeka.Generiranje(Dek);
            UcitavanjeDeka.Shuffle(Dek);
        }


        //Button koji gasi aplikaciju, prije toga sprema promjenjeni balance u datoteku
        private void button1_Click(object sender, EventArgs e)
        {
            Admin.KorisnikUpdate(AktivniKorisnik, Balance);
            Application.Exit();
        }

        public Blackjack(Korisnik k)
        {
            InitializeComponent();
            AktivniKorisnik = k;
            Balance = int.Parse(k.balance);
            lblBalance.AutoSize = true;
            lblBalance.BackColor = System.Drawing.Color.Transparent;
            lblBalance.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBalance.ForeColor = System.Drawing.Color.Black;
            lblBalance.Location = new System.Drawing.Point(21, 19);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new System.Drawing.Size(96, 24);
            lblBalance.TabIndex = 27;
            lblBalance.Text = "Balance: 1000";
            lblBalance.Visible = false;
            this.Controls.Add(lblBalance);

            lblDobitak.AutoSize = true;
            lblDobitak.BackColor = System.Drawing.Color.Transparent;
            lblDobitak.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDobitak.ForeColor = System.Drawing.Color.White;
            lblDobitak.Location = new System.Drawing.Point(56, 0);
            lblDobitak.Name = "lblDobitak";
            lblDobitak.Size = new System.Drawing.Size(96, 24);
            lblDobitak.TabIndex = 27;
            lblDobitak.Text = "+";
            lblDobitak.Visible = false;
            this.Controls.Add(lblDobitak);

            lblHint.AutoSize = false;
            lblHint.Visible = false;
            lblHint.Size = new System.Drawing.Size(15, 15);
            lblHint.BackColor = Color.Yellow;
            lblHint.Location = new Point(0, 0);
            lblHint.Text = "";
            this.Controls.Add(lblHint);


            // 
            // lblReturnMessage
            // 
            lblReturnMessage.BackColor = System.Drawing.Color.Black;
            lblReturnMessage.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblReturnMessage.ForeColor = System.Drawing.Color.White;
            lblReturnMessage.TextAlign = ContentAlignment.MiddleLeft;
            lblReturnMessage.Location = new System.Drawing.Point(5,150);
            lblReturnMessage.MaximumSize = new System.Drawing.Size(600, 200);
            lblReturnMessage.Name = "lblReturnMessage";
            lblReturnMessage.Size = new System.Drawing.Size(89, 24);
            lblReturnMessage.AutoSize = true;
            lblReturnMessage.TabIndex = 36;
            lblReturnMessage.Text = "ReturnMessage";
            lblReturnMessage.Visible = false;
            this.Controls.Add(lblReturnMessage);

        }
        
        //Pali settings
        private void button2_Click(object sender, EventArgs e)
        {
            pbSettings.Visible = lblSettings.Visible = btnToggleQuickPlay.Visible = btnMainMenu.Visible = btnExit.Visible = true;
            pbSettings.BringToFront();
            lblSettings.BringToFront();
            btnExit.BringToFront();
            btnMainMenu.BringToFront();
            btnToggleQuickPlay.BringToFront();
            if(PozicijaVelicinaSettingsComplete==false)
            {

                PozicijaVelicina.PrilagodbaPictureBox(pbSettings);
                PozicijaVelicina.PrilagodbaLabel(lblSettings);
                PozicijaVelicina.PrilagodbaButton(btnExit);
                PozicijaVelicina.PrilagodbaButton(btnMainMenu);
                PozicijaVelicina.PrilagodbaButton(btnToggleQuickPlay);
                PozicijaVelicinaSettingsComplete = true;
            }
        }

        //Gasi settings
        private void btnExit_Click(object sender, EventArgs e)
        {
            pbSettings.Visible = lblSettings.Visible = btnToggleQuickPlay.Visible = btnMainMenu.Visible = btnExit.Visible = false;

        }

        // kontrolira fastplay
        private void btnToggleQuickPlay_Click(object sender, EventArgs e)
        {
            if (btnToggleQuickPlay.Text == "Toggle QuickPlay: On")
            {
                btnToggleQuickPlay.Text = "Toggle QuickPlay: Off";
                Blackjack.FastPlay = false;
            }
            else if (btnToggleQuickPlay.Text == "Toggle QuickPlay: Off")
            {
                btnToggleQuickPlay.Text = "Toggle QuickPlay: On";
                Blackjack.FastPlay = true;
            }
        }

        //Vraća main menu
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            lstIgrac1.Clear();
            lstIgrac2.Clear();
            lstIgrac3.Clear();
            lstIgrac4.Clear();
            lstDealer.Clear();
            Dek.Clear();

            foreach (PictureBox pb in EveryPicturebox)
            {
                this.Controls.Remove(pb);
            }

            UcitavanjeDeka.Generiranje(Dek);
            UcitavanjeDeka.Shuffle(Dek);
            this.BackgroundImage = new Bitmap(@"main menu.png");
            pbBlackPlaceBet.Visible = false;
            pbPlaceBetB.Visible = false;
            pbAdjustBetUpDown.Visible = false;

            lblAdjustBet.Visible = false;
            lblAmmount.Visible = false;
            lblPlaceBet.Visible = false;
            lblBet.Visible = false;
            lblDobitak.Visible = false;
            lblReturnMessage.Visible = false;
            pbBlackPlaceBet.Visible = false;
            pbPlaceBetB.Visible = false;
            pbAdjustBetUpDown.Visible = false;

            lblAdjustBet.Visible = true;
            lblAmmount.Visible = false;
            lblPlaceBet.Visible = false;
            lblBet.Visible = false;

            lblPlaceBet.Visible = false;
            lblAdjustBet.Visible = false;
            lblBet.Visible = false;
            lblAmmount.Visible = false;
            pbPlaceBetB.Visible = false;
            pbAdjustBetUpDown.Visible = false;

            lblBalance.Visible = false;

            pbBlackPotez.Visible = false;
            lblHint.Visible = false;
            lblHit.Visible = false;
            lblStand.Visible = false;
            lblSplit.Visible = false;
            lblDoubleDown.Visible = false;
            pbHit.Visible = false;
            pbStand.Visible = false;
            pbSplit.Visible = false;
            pbDoubleDown.Visible = false;

            pbSettings.Visible = lblSettings.Visible = btnToggleQuickPlay.Visible = btnMainMenu.Visible = btnExit.Visible = false;


            TranzicijaFrameIndex = 0;

            btnPlay.Visible = true;
            btnFriends.Visible = true;
            btnProfile.Visible = true;
        }
        
        //Pokreće formu send money
        private void btnFriends_Click(object sender, EventArgs e)
        {
            SendMoney sm = new SendMoney();
            sm.Show();
            sm.TopMost = true;
        }

        //Pokreće formu profile
        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profil pr = new Profil();
            pr.Show();
            pr.TopMost = true;
        }

        //----------------------------------TIMERI---------------------------------------------------------------


        //Prikazuje promjenu balance
        private void tmrBalanceChange1_Tick(object sender, EventArgs e)
        {
            lblBalanceChange1.Visible = false;
            tmrBalanceChange1.Enabled = false;
        }

        //Mjenja pozadine za animaciju
        private void tmrTranzicija_Tick(object sender, EventArgs e)
        {

            TranzicijaFrameIndex++;
            try
            {
                this.BackgroundImage = lstTranzicija[TranzicijaFrameIndex];
            }
            catch
            {
                lblBalance.ForeColor = Color.Yellow;
                if (TranzicijaFrameIndex==24)
                {
                    TranzicijaFrameIndex = 23;
                    tmrTranzicija.Enabled = false;
                }
                lblBalance.ForeColor = Color.Yellow;
                pbBlackPlaceBet.Visible = false;
                pbPlaceBetB.Visible = false;
                pbAdjustBetUpDown.Visible = false;

                lblAdjustBet.Visible = false;
                lblAmmount.Visible = false;
                lblPlaceBet.Visible = false;
                lblBet.Visible = false;

                Igra.PrvaRuka(Dek, lstDealer, lstIgrac1);
                PozicijaVelicina.PrilagodbaPictureBox(pictureBox1);

                pbBlackPotez.Visible = true;
                pbHit.Visible = true;
                pbSplit.Visible = true;
                pbStand.Visible = true;
                pbDoubleDown.Visible = true;
                lblHit.Visible = true;
                lblStand.Visible = true;
                lblSplit.Visible = true;
                lblDoubleDown.Visible = true;
                if (GotovaIgra == true)
                {

                    //MessageBox.Show("Igra je gotova");
                    if (FastPlay == true)
                    {
                        if (ActualBetAmmount <= Balance)
                        {
                            tmrGotovaIgraQuickplay.Enabled = true;
                        }
                        else if (ActualBetAmmount > Balance)
                        {
                            tmrGotovaIgraPlay.Enabled = true;
                        }
                    }
                    else if (FastPlay != true)
                    {
                        tmrGotovaIgraPlay.Enabled = true;
                    }
                }
            }
            
        }

        //Mjenja pozadine za animaciju unatrag
        private void tmrTranzicijaReverse_Tick(object sender, EventArgs e)
        {
            TranzicijaFrameIndex--;
            try
            {
                this.BackgroundImage = lstTranzicija[TranzicijaFrameIndex];
                lblBalance.ForeColor = Color.Black;
            }
            catch
            {
                if (TranzicijaFrameIndex == -1)
                {
                    TranzicijaFrameIndex = 0;
                    tmrTranzicijaReverse.Enabled = false;
                }
                pbBlackPlaceBet.Visible = true;
                pbPlaceBetB.Visible = true;
                pbAdjustBetUpDown.Visible = true;

                lblAdjustBet.Visible = true;
                lblAmmount.Visible = true;
                lblPlaceBet.Visible = true;
                lblBet.Visible = true;
            }
        }

        //Pomaže sljedećem timeru
        private void tmrQuickplay_Tick(object sender, EventArgs e)
        {

                Igra.PrvaRuka(Dek, lstDealer, lstIgrac1);
                PozicijaVelicina.PrilagodbaPictureBox(pictureBox1);
            tmrQuickplay.Enabled = false;
            if (GotovaIgra == true)
            {

                //MessageBox.Show("Igra je gotova");
                if (FastPlay == true)
                {
                    if (ActualBetAmmount <= Balance)
                    {
                        tmrGotovaIgraQuickplay.Enabled = true;
                    }
                    else if (ActualBetAmmount > Balance)
                    {
                        tmrGotovaIgraPlay.Enabled = true;
                    }
                }
                else if (FastPlay != true)
                {
                    tmrGotovaIgraPlay.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Greska");
                }
            }
        }

        //kada je quickplay odabran, nakon što završi jedna igra pali drugu
        private void tmrGotovaIgraQuickplay_Tick(object sender, EventArgs e)
        {
            GotovaIgra = false;
            ResetAvailible = false;
            Balance -= ActualBetAmmount;
            lblBalanceChange1.Visible = true;
            ChangelblBalanceText();
            tmrBalanceChange1.Enabled = true;
            foreach (PictureBox pb in EveryPicturebox)
            {
                this.Controls.Remove(pb);
            }
            lstIgrac1.Clear();
            lstIgrac2.Clear();
            lstIgrac3.Clear();
            lstIgrac4.Clear();
            lstDealer.Clear();
            Dek.Clear();
            UcitavanjeDeka.Generiranje(Dek);
            UcitavanjeDeka.Shuffle(Dek);
            tmrGotovaIgraPlay.Interval = 2000;
            tmrGotovaIgraQuickplay.Interval = 2000;
            lblDobitak.Visible = false;
            lblReturnMessage.Visible = false;
            lblBalance.ForeColor = Color.Yellow;
            if (TranzicijaFrameIndex == 24)
            {
                TranzicijaFrameIndex = 23;
                tmrTranzicija.Enabled = false;
            }
            lblBalance.ForeColor = Color.Yellow;
            pbBlackPlaceBet.Visible = false;
            pbPlaceBetB.Visible = false;
            pbAdjustBetUpDown.Visible = false;

            lblAdjustBet.Visible = false;
            lblAmmount.Visible = false;
            lblPlaceBet.Visible = false;
            lblBet.Visible = false;

            tmrQuickplay.Enabled = true;
            tmrGotovaIgraQuickplay.Enabled = false;
            
        }

        //Kad quickplay nije uključen, nakon završetka igre pali novu
        private void tmrGotovaIgraPlay_Tick_1(object sender, EventArgs e)
        {
            GotovaIgra = false;
            foreach (PictureBox pb in EveryPicturebox)
            {
                this.Controls.Remove(pb);
            }
            lstIgrac1.Clear();
            lstIgrac2.Clear();
            lstIgrac3.Clear();
            lstIgrac4.Clear();
            lstDealer.Clear();
            Dek.Clear();
            lblHint.Visible = false;
            UcitavanjeDeka.Generiranje(Dek);
            UcitavanjeDeka.Shuffle(Dek);
            lblDobitak.Visible = false;
            lblReturnMessage.Visible = false;

            tmrGotovaIgraPlay.Interval = 2000;
            tmrGotovaIgraQuickplay.Interval = 2000;

            tmrTranzicijaReverse.Enabled = true;

            pbBlackPotez.Visible = false;
            pbHit.Visible = false;
            pbSplit.Visible = false;
            pbStand.Visible = false;
            pbDoubleDown.Visible = false;
            lblHit.Visible = false;
            lblStand.Visible = false;
            lblSplit.Visible = false;
            lblDoubleDown.Visible = false;
            if (GotovaIgra == true)
            {

                //MessageBox.Show("Igra je gotova");
                if (FastPlay == true)
                {
                    if (ActualBetAmmount <= Balance)
                    {
                        tmrGotovaIgraQuickplay.Enabled = true;
                    }
                    else if (ActualBetAmmount > Balance)
                    {
                        tmrGotovaIgraPlay.Enabled = true;
                    }
                }
                else if (FastPlay != true)
                {
                    tmrGotovaIgraPlay.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Greska");
                }
            }

            tmrGotovaIgraPlay.Enabled = false;
        }



        //----------------------------------------------KEYS-----------------------------------------------------------------
        private void Blackjack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B && TranzicijaFrameIndex == 0&&btnPlay.Visible==false&&pbSettings.Visible==false)
            {
                //Koristi se kad korisnik pritisne B za bet, pokreće animaciju i namješta buttone
                if (lstBetAmmount[BetAmmountIndex] > Balance)
                { MessageBox.Show("Your bet must be lower than your balance.");}
                else
                {
                    GotovaIgra = false;
                    ActualBetAmmount = lstBetAmmount[BetAmmountIndex];

                    Blackjack.ResetAvailible = false;
                    Balance -= ActualBetAmmount;
                    lblBalance.Text = "Balance: " + Balance.ToString();
                    lblBalanceChange1.Text = "-" + ActualBetAmmount.ToString();
                    lblBalanceChange1.ForeColor = Color.Red;
                    tmrTranzicija.Enabled = true;
                    lblBalanceChange1.Visible = true;
                    tmrBalanceChange1.Enabled = true;

                    
                }
            }
        }

        //Strelice
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {//Registrira pritiskanje arrowsa

            //capture up arrow key
            if (keyData == Keys.Up)
            {
                if (lblPlaceBet.Visible == true)
                {
                    if (BetAmmountIndex < lstBetAmmount.Count - 1)
                    {
                        BetAmmountIndex++;
                    }
                    lblAmmount.Text = lstBetAmmount[BetAmmountIndex].ToString();
                }

                //doubledown
                if (DopustiPotez == true && DoubleDownPossible == true)
                {

                    DopustiPotez = false;
                    DoubleDownPossible = false;
                    SplitPossible = false;
                    lblBalanceChange1.Visible = true;
                    ChangelblBalanceText();
                    if (ActivePlayer == "Igrac1")
                    {
                        Balance -= lstIgrac1[0].bet;
                        ChangelblBalanceText();
                        tmrBalanceChange1.Enabled = true;
                        lstIgrac1[0].bet *= 2;
                        Igra.DoubleDown(Dek, lstIgrac1, lstDealer, lstIgrac2, lstIgrac3, lstIgrac4);
                    }


                    if (ActivePlayer == "Igrac2")
                    {
                        Balance -= lstIgrac2[0].bet;
                        ChangelblBalanceText();
                        lblBalanceChange1.Visible = true;
                        tmrBalanceChange1.Enabled = true;
                        lstIgrac2[0].bet *= 2;
                        Igra.DoubleDown(Dek, lstIgrac2, lstDealer, lstIgrac1, lstIgrac3, lstIgrac4);
                    }


                    if (ActivePlayer == "Igrac3")
                    {
                        Balance -= lstIgrac3[0].bet;
                        ChangelblBalanceText();
                        lblBalanceChange1.Visible = true;
                        tmrBalanceChange1.Enabled = true;
                        lstIgrac3[0].bet *= 2;
                        Igra.DoubleDown(Dek, lstIgrac3, lstDealer, lstIgrac2, lstIgrac1, lstIgrac4);
                    }


                    if (ActivePlayer == "Igrac4")
                    {
                        Balance -= lstIgrac4[0].bet;
                        ChangelblBalanceText();
                        lblBalanceChange1.Visible = true;
                        tmrBalanceChange1.Enabled = true;
                        lstIgrac4[0].bet *= 2;
                        Igra.DoubleDown(Dek, lstIgrac4, lstDealer, lstIgrac2, lstIgrac3, lstIgrac1);
                    }
                    if (GotovaIgra == true)
                    {

                        //MessageBox.Show("Igra je gotova");
                        if (FastPlay == true)
                        {
                            if (ActualBetAmmount <= Balance)
                            {
                                tmrGotovaIgraQuickplay.Enabled = true;
                            }
                            else if(ActualBetAmmount>Balance)
                            {
                                tmrGotovaIgraPlay.Enabled = true;
                            }
                        }
                        else if (FastPlay != true)
                        {
                            tmrGotovaIgraPlay.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Greska");
                        }
                    }
                }
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                if (lblPlaceBet.Visible == true)
                {
                    if (BetAmmountIndex > 0)
                    {
                        BetAmmountIndex--;
                    }
                    lblAmmount.Text = lstBetAmmount[BetAmmountIndex].ToString();
                }

                //hit
                if (DopustiPotez == true)
                {
                    DopustiPotez = false;
                    DoubleDownPossible = false;
                    SplitPossible = false;

                    if (ActivePlayer == "Igrac1")
                    {
                        Igra.Hit(Dek, lstIgrac1, lstDealer, lstIgrac2, lstIgrac3, lstIgrac4);
                    }

                    if (ActivePlayer == "Igrac2")
                    {
                        Igra.Hit(Dek, lstIgrac2, lstDealer, lstIgrac1, lstIgrac3, lstIgrac4);
                    }

                    if (ActivePlayer == "Igrac3")
                    {
                        Igra.Hit(Dek, lstIgrac3, lstDealer, lstIgrac2, lstIgrac1, lstIgrac4);
                    }

                    if (ActivePlayer == "Igrac4")
                    {
                        Igra.Hit(Dek, lstIgrac4, lstDealer, lstIgrac2, lstIgrac3, lstIgrac1);
                    }

                    if (GotovaIgra == true)
                    {

                        //MessageBox.Show("Igra je gotova");
                        if (FastPlay == true)
                        {
                            if (ActualBetAmmount <= Balance)
                            {
                                tmrGotovaIgraQuickplay.Enabled = true;
                            }
                            else if (ActualBetAmmount > Balance)
                            {
                                tmrGotovaIgraPlay.Enabled = true;
                            }
                        }
                        else if (FastPlay != true)
                        {
                            tmrGotovaIgraPlay.Enabled = true;
                        }
                    }
                }
            }
            //capture left arrow key
            if (keyData == Keys.Left)
            {

                //stand
                if (DopustiPotez == true)
                {
                    DopustiPotez = false;
                    DoubleDownPossible = false;
                    SplitPossible = false;

                    if (ActivePlayer == "Igrac1")
                    {
                        Igra.PrilagodiQueue(lstIgrac1, lstIgrac2, lstIgrac3, lstIgrac4);
                        Igra.OdrediListuKojaIde(lstIgrac1, lstIgrac2, lstIgrac3, lstIgrac4);
                    }

                    if (ActivePlayer == "Igrac2")
                    {
                        Igra.PrilagodiQueue(lstIgrac2, lstIgrac1, lstIgrac3, lstIgrac4);
                        Igra.OdrediListuKojaIde(lstIgrac2, lstIgrac1, lstIgrac3, lstIgrac4);
                    }

                    if (ActivePlayer == "Igrac3")
                    {
                        Igra.PrilagodiQueue(lstIgrac3, lstIgrac2, lstIgrac1, lstIgrac4);
                        Igra.OdrediListuKojaIde(lstIgrac3, lstIgrac2, lstIgrac1, lstIgrac4);
                    }

                    if (ActivePlayer == "Igrac4")
                    {
                        Igra.PrilagodiQueue(lstIgrac4, lstIgrac2, lstIgrac3, lstIgrac1);
                        Igra.OdrediListuKojaIde(lstIgrac4, lstIgrac2, lstIgrac3, lstIgrac1);
                    }

                    if (GotovaIgra == true)
                    {

                        //MessageBox.Show("Igra je gotova");
                        if (FastPlay == true)
                        {
                            if (ActualBetAmmount <= Balance)
                            {
                                tmrGotovaIgraQuickplay.Enabled = true;
                            }
                            else if (ActualBetAmmount > Balance)
                            {
                                tmrGotovaIgraPlay.Enabled = true;
                            }
                        }
                        else if (FastPlay == false)
                        {
                            tmrGotovaIgraPlay.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Greska");
                        }
                    }
                }
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {

                //split
                if (DopustiPotez == true && SplitPossible == true)
                {
                    DopustiPotez = false;
                    DoubleDownPossible = false;
                    SplitPossible = false;
                    Balance -= ActualBetAmmount;
                    ChangelblBalanceText();
                    lblBalanceChange1.Visible = true;
                    tmrBalanceChange1.Enabled = true;
                    tmrGotovaIgraPlay.Interval += 1000;
                    tmrGotovaIgraQuickplay.Interval += 1000;
                    if (ActivePlayer == "Igrac1")
                    {
                        Igra.SplitOdredivanjeIgraca(lstIgrac1, lstIgrac2, lstIgrac3, lstIgrac4, Dek, lstDealer);
                    }
                    else if (ActivePlayer == "Igrac2")
                    {
                        //MessageBox.Show("Active player player2");
                        Igra.SplitOdredivanjeIgraca(lstIgrac2, lstIgrac3, lstIgrac4, lstIgrac1, Dek, lstDealer);
                    }
                    else if (ActivePlayer == "Igrac3")
                    {
                        //.Show("Active player player3");
                        Igra.SplitOdredivanjeIgraca(lstIgrac3, lstIgrac4, lstIgrac1, lstIgrac2, Dek, lstDealer);
                    }

                    if (GotovaIgra == true)
                    {
                        //MessageBox.Show("Igra je gotova");
                        if (FastPlay == true)
                        {
                            if (ActualBetAmmount <= Balance)
                            {
                                tmrGotovaIgraQuickplay.Enabled = true;
                            }
                            else if (ActualBetAmmount > Balance)
                            {
                                tmrGotovaIgraPlay.Enabled = true;
                            }
                        }
                        else if (FastPlay == false)
                        {
                            tmrGotovaIgraPlay.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Greska");
                        }
                    }
                }
            }
            if (keyData != Keys.Enter && keyData != Keys.Space)
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
            else
            {
                return true;
            }
        }
        //---------------------------------------------------------------------------------------------------------------
        public static void ChangelblBalanceText()
        {
            lblBalance.Text = "Balance: " + Balance.ToString();
        }
    }
}
