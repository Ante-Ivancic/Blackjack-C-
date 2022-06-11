namespace FullApp3
{
    partial class Blackjack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blackjack));
            this.button1 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnFriends = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblPlaceBet = new System.Windows.Forms.Label();
            this.lblAdjustBet = new System.Windows.Forms.Label();
            this.pbBlackPlaceBet = new System.Windows.Forms.PictureBox();
            this.pbPlaceBetB = new System.Windows.Forms.PictureBox();
            this.pbAdjustBetUpDown = new System.Windows.Forms.PictureBox();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblAmmount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrTranzicija = new System.Windows.Forms.Timer(this.components);
            this.tmrBalanceChange1 = new System.Windows.Forms.Timer(this.components);
            this.lblBalanceChange1 = new System.Windows.Forms.Label();
            this.pbBlackPotez = new System.Windows.Forms.PictureBox();
            this.lblHit = new System.Windows.Forms.Label();
            this.lblStand = new System.Windows.Forms.Label();
            this.lblDoubleDown = new System.Windows.Forms.Label();
            this.lblSplit = new System.Windows.Forms.Label();
            this.tmrTranzicijaReverse = new System.Windows.Forms.Timer(this.components);
            this.tmrQuickplay = new System.Windows.Forms.Timer(this.components);
            this.pbHit = new System.Windows.Forms.PictureBox();
            this.pbStand = new System.Windows.Forms.PictureBox();
            this.pbDoubleDown = new System.Windows.Forms.PictureBox();
            this.pbSplit = new System.Windows.Forms.PictureBox();
            this.tmrGotovaIgraQuickplay = new System.Windows.Forms.Timer(this.components);
            this.tmrGotovaIgraPlay = new System.Windows.Forms.Timer(this.components);
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnToggleQuickPlay = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlackPlaceBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceBetB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdjustBetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlackPotez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoubleDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rubik", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(691, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(340, 130);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(120, 60);
            this.btnPlay.TabIndex = 17;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.BackColor = System.Drawing.Color.White;
            this.btnFriends.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFriends.FlatAppearance.BorderSize = 0;
            this.btnFriends.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFriends.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFriends.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFriends.Location = new System.Drawing.Point(311, 195);
            this.btnFriends.Margin = new System.Windows.Forms.Padding(0);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(179, 60);
            this.btnFriends.TabIndex = 18;
            this.btnFriends.Text = "Transfer Money";
            this.btnFriends.UseVisualStyleBackColor = false;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.White;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(340, 260);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(120, 60);
            this.btnProfile.TabIndex = 19;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblPlaceBet
            // 
            this.lblPlaceBet.AutoSize = true;
            this.lblPlaceBet.BackColor = System.Drawing.Color.Black;
            this.lblPlaceBet.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceBet.ForeColor = System.Drawing.Color.White;
            this.lblPlaceBet.Location = new System.Drawing.Point(635, 413);
            this.lblPlaceBet.Name = "lblPlaceBet";
            this.lblPlaceBet.Size = new System.Drawing.Size(60, 22);
            this.lblPlaceBet.TabIndex = 20;
            this.lblPlaceBet.Text = "Place bet: ";
            this.lblPlaceBet.Visible = false;
            // 
            // lblAdjustBet
            // 
            this.lblAdjustBet.AutoSize = true;
            this.lblAdjustBet.BackColor = System.Drawing.Color.Black;
            this.lblAdjustBet.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjustBet.ForeColor = System.Drawing.Color.White;
            this.lblAdjustBet.Location = new System.Drawing.Point(718, 413);
            this.lblAdjustBet.Name = "lblAdjustBet";
            this.lblAdjustBet.Size = new System.Drawing.Size(62, 22);
            this.lblAdjustBet.TabIndex = 21;
            this.lblAdjustBet.Text = "Adjust bet:";
            this.lblAdjustBet.Visible = false;
            // 
            // pbBlackPlaceBet
            // 
            this.pbBlackPlaceBet.BackColor = System.Drawing.Color.Black;
            this.pbBlackPlaceBet.Location = new System.Drawing.Point(570, 410);
            this.pbBlackPlaceBet.Name = "pbBlackPlaceBet";
            this.pbBlackPlaceBet.Size = new System.Drawing.Size(278, 28);
            this.pbBlackPlaceBet.TabIndex = 22;
            this.pbBlackPlaceBet.TabStop = false;
            this.pbBlackPlaceBet.Visible = false;
            // 
            // pbPlaceBetB
            // 
            this.pbPlaceBetB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlaceBetB.Image = ((System.Drawing.Image)(resources.GetObject("pbPlaceBetB.Image")));
            this.pbPlaceBetB.Location = new System.Drawing.Point(690, 414);
            this.pbPlaceBetB.Name = "pbPlaceBetB";
            this.pbPlaceBetB.Size = new System.Drawing.Size(20, 20);
            this.pbPlaceBetB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlaceBetB.TabIndex = 23;
            this.pbPlaceBetB.TabStop = false;
            this.pbPlaceBetB.Visible = false;
            // 
            // pbAdjustBetUpDown
            // 
            this.pbAdjustBetUpDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAdjustBetUpDown.Image = ((System.Drawing.Image)(resources.GetObject("pbAdjustBetUpDown.Image")));
            this.pbAdjustBetUpDown.Location = new System.Drawing.Point(776, 414);
            this.pbAdjustBetUpDown.Name = "pbAdjustBetUpDown";
            this.pbAdjustBetUpDown.Size = new System.Drawing.Size(20, 20);
            this.pbAdjustBetUpDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdjustBetUpDown.TabIndex = 24;
            this.pbAdjustBetUpDown.TabStop = false;
            this.pbAdjustBetUpDown.Visible = false;
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.Color.Black;
            this.lblBet.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.ForeColor = System.Drawing.Color.White;
            this.lblBet.Location = new System.Drawing.Point(573, 413);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(28, 22);
            this.lblBet.TabIndex = 25;
            this.lblBet.Text = "Bet:";
            this.lblBet.Visible = false;
            // 
            // lblAmmount
            // 
            this.lblAmmount.AutoSize = true;
            this.lblAmmount.BackColor = System.Drawing.Color.Black;
            this.lblAmmount.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmount.ForeColor = System.Drawing.Color.White;
            this.lblAmmount.Location = new System.Drawing.Point(595, 413);
            this.lblAmmount.Name = "lblAmmount";
            this.lblAmmount.Size = new System.Drawing.Size(31, 22);
            this.lblAmmount.TabIndex = 26;
            this.lblAmmount.Text = "1000";
            this.lblAmmount.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(392, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // tmrTranzicija
            // 
            this.tmrTranzicija.Interval = 42;
            this.tmrTranzicija.Tick += new System.EventHandler(this.tmrTranzicija_Tick);
            // 
            // tmrBalanceChange1
            // 
            this.tmrBalanceChange1.Interval = 2500;
            this.tmrBalanceChange1.Tick += new System.EventHandler(this.tmrBalanceChange1_Tick);
            // 
            // lblBalanceChange1
            // 
            this.lblBalanceChange1.AutoSize = true;
            this.lblBalanceChange1.BackColor = System.Drawing.Color.Transparent;
            this.lblBalanceChange1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceChange1.ForeColor = System.Drawing.Color.Black;
            this.lblBalanceChange1.Location = new System.Drawing.Point(69, 45);
            this.lblBalanceChange1.Name = "lblBalanceChange1";
            this.lblBalanceChange1.Size = new System.Drawing.Size(16, 24);
            this.lblBalanceChange1.TabIndex = 29;
            this.lblBalanceChange1.Text = "-";
            this.lblBalanceChange1.Visible = false;
            // 
            // pbBlackPotez
            // 
            this.pbBlackPotez.BackColor = System.Drawing.Color.Black;
            this.pbBlackPotez.Location = new System.Drawing.Point(533, 410);
            this.pbBlackPotez.Name = "pbBlackPotez";
            this.pbBlackPotez.Size = new System.Drawing.Size(329, 28);
            this.pbBlackPotez.TabIndex = 30;
            this.pbBlackPotez.TabStop = false;
            this.pbBlackPotez.Visible = false;
            // 
            // lblHit
            // 
            this.lblHit.AutoSize = true;
            this.lblHit.BackColor = System.Drawing.Color.Black;
            this.lblHit.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHit.ForeColor = System.Drawing.Color.White;
            this.lblHit.Location = new System.Drawing.Point(538, 412);
            this.lblHit.Name = "lblHit";
            this.lblHit.Size = new System.Drawing.Size(24, 22);
            this.lblHit.TabIndex = 31;
            this.lblHit.Text = "Hit:";
            this.lblHit.Visible = false;
            // 
            // lblStand
            // 
            this.lblStand.AutoSize = true;
            this.lblStand.BackColor = System.Drawing.Color.Black;
            this.lblStand.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStand.ForeColor = System.Drawing.Color.White;
            this.lblStand.Location = new System.Drawing.Point(686, 413);
            this.lblStand.Name = "lblStand";
            this.lblStand.Size = new System.Drawing.Size(40, 22);
            this.lblStand.TabIndex = 32;
            this.lblStand.Text = "Stand:";
            this.lblStand.Visible = false;
            // 
            // lblDoubleDown
            // 
            this.lblDoubleDown.AutoSize = true;
            this.lblDoubleDown.BackColor = System.Drawing.Color.Black;
            this.lblDoubleDown.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoubleDown.ForeColor = System.Drawing.Color.White;
            this.lblDoubleDown.Location = new System.Drawing.Point(586, 412);
            this.lblDoubleDown.Name = "lblDoubleDown";
            this.lblDoubleDown.Size = new System.Drawing.Size(76, 22);
            this.lblDoubleDown.TabIndex = 33;
            this.lblDoubleDown.Text = "Double down:";
            this.lblDoubleDown.Visible = false;
            // 
            // lblSplit
            // 
            this.lblSplit.AutoSize = true;
            this.lblSplit.BackColor = System.Drawing.Color.Black;
            this.lblSplit.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplit.ForeColor = System.Drawing.Color.White;
            this.lblSplit.Location = new System.Drawing.Point(749, 413);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(32, 22);
            this.lblSplit.TabIndex = 34;
            this.lblSplit.Text = "Split:";
            this.lblSplit.Visible = false;
            // 
            // tmrTranzicijaReverse
            // 
            this.tmrTranzicijaReverse.Interval = 42;
            this.tmrTranzicijaReverse.Tick += new System.EventHandler(this.tmrTranzicijaReverse_Tick);
            // 
            // tmrQuickplay
            // 
            this.tmrQuickplay.Interval = 1000;
            this.tmrQuickplay.Tick += new System.EventHandler(this.tmrQuickplay_Tick);
            // 
            // pbHit
            // 
            this.pbHit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHit.Image = ((System.Drawing.Image)(resources.GetObject("pbHit.Image")));
            this.pbHit.Location = new System.Drawing.Point(558, 413);
            this.pbHit.Name = "pbHit";
            this.pbHit.Size = new System.Drawing.Size(20, 20);
            this.pbHit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHit.TabIndex = 35;
            this.pbHit.TabStop = false;
            this.pbHit.Visible = false;
            // 
            // pbStand
            // 
            this.pbStand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbStand.Image = ((System.Drawing.Image)(resources.GetObject("pbStand.Image")));
            this.pbStand.Location = new System.Drawing.Point(721, 413);
            this.pbStand.Name = "pbStand";
            this.pbStand.Size = new System.Drawing.Size(20, 20);
            this.pbStand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStand.TabIndex = 36;
            this.pbStand.TabStop = false;
            this.pbStand.Visible = false;
            // 
            // pbDoubleDown
            // 
            this.pbDoubleDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDoubleDown.Image = ((System.Drawing.Image)(resources.GetObject("pbDoubleDown.Image")));
            this.pbDoubleDown.Location = new System.Drawing.Point(657, 413);
            this.pbDoubleDown.Name = "pbDoubleDown";
            this.pbDoubleDown.Size = new System.Drawing.Size(20, 20);
            this.pbDoubleDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDoubleDown.TabIndex = 37;
            this.pbDoubleDown.TabStop = false;
            this.pbDoubleDown.Visible = false;
            // 
            // pbSplit
            // 
            this.pbSplit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSplit.Image = ((System.Drawing.Image)(resources.GetObject("pbSplit.Image")));
            this.pbSplit.Location = new System.Drawing.Point(777, 413);
            this.pbSplit.Name = "pbSplit";
            this.pbSplit.Size = new System.Drawing.Size(20, 20);
            this.pbSplit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSplit.TabIndex = 38;
            this.pbSplit.TabStop = false;
            this.pbSplit.Visible = false;
            // 
            // tmrGotovaIgraQuickplay
            // 
            this.tmrGotovaIgraQuickplay.Interval = 2000;
            this.tmrGotovaIgraQuickplay.Tick += new System.EventHandler(this.tmrGotovaIgraQuickplay_Tick);
            // 
            // tmrGotovaIgraPlay
            // 
            this.tmrGotovaIgraPlay.Interval = 2000;
            this.tmrGotovaIgraPlay.Tick += new System.EventHandler(this.tmrGotovaIgraPlay_Tick_1);
            // 
            // pbSettings
            // 
            this.pbSettings.BackColor = System.Drawing.Color.Black;
            this.pbSettings.Location = new System.Drawing.Point(208, 30);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(396, 325);
            this.pbSettings.TabIndex = 39;
            this.pbSettings.TabStop = false;
            this.pbSettings.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Agency FB", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(340, 302);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 39);
            this.btnExit.TabIndex = 43;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Black;
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Agency FB", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Location = new System.Drawing.Point(340, 220);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(149, 37);
            this.btnMainMenu.TabIndex = 42;
            this.btnMainMenu.Text = "Main menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Visible = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnToggleQuickPlay
            // 
            this.btnToggleQuickPlay.BackColor = System.Drawing.Color.Black;
            this.btnToggleQuickPlay.FlatAppearance.BorderSize = 0;
            this.btnToggleQuickPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleQuickPlay.Font = new System.Drawing.Font("Agency FB", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleQuickPlay.ForeColor = System.Drawing.Color.White;
            this.btnToggleQuickPlay.Location = new System.Drawing.Point(340, 173);
            this.btnToggleQuickPlay.Name = "btnToggleQuickPlay";
            this.btnToggleQuickPlay.Size = new System.Drawing.Size(149, 39);
            this.btnToggleQuickPlay.TabIndex = 41;
            this.btnToggleQuickPlay.Text = "Toggle QuickPlay: Off";
            this.btnToggleQuickPlay.UseVisualStyleBackColor = false;
            this.btnToggleQuickPlay.Visible = false;
            this.btnToggleQuickPlay.Click += new System.EventHandler(this.btnToggleQuickPlay_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.BackColor = System.Drawing.Color.Black;
            this.lblSettings.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Location = new System.Drawing.Point(327, 57);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(184, 73);
            this.lblSettings.TabIndex = 40;
            this.lblSettings.Text = "Settings";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSettings.Visible = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(691, 130);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(50, 50);
            this.btnSettings.TabIndex = 44;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.button2_Click);
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnToggleQuickPlay);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.pbSettings);
            this.Controls.Add(this.pbSplit);
            this.Controls.Add(this.pbDoubleDown);
            this.Controls.Add(this.pbStand);
            this.Controls.Add(this.pbHit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSplit);
            this.Controls.Add(this.lblDoubleDown);
            this.Controls.Add(this.lblStand);
            this.Controls.Add(this.lblHit);
            this.Controls.Add(this.lblBalanceChange1);
            this.Controls.Add(this.lblAmmount);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.pbAdjustBetUpDown);
            this.Controls.Add(this.pbPlaceBetB);
            this.Controls.Add(this.lblAdjustBet);
            this.Controls.Add(this.lblPlaceBet);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnFriends);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbBlackPlaceBet);
            this.Controls.Add(this.pbBlackPotez);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Blackjack";
            this.Text = "   ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Blackjack_FormClosed);
            this.Load += new System.EventHandler(this.Blackjack_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Blackjack_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlackPlaceBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceBetB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdjustBetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlackPotez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoubleDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnFriends;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lblPlaceBet;
        private System.Windows.Forms.Label lblAdjustBet;
        private System.Windows.Forms.PictureBox pbBlackPlaceBet;
        private System.Windows.Forms.PictureBox pbPlaceBetB;
        private System.Windows.Forms.PictureBox pbAdjustBetUpDown;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblAmmount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrTranzicija;
        private System.Windows.Forms.Timer tmrBalanceChange1;
        private System.Windows.Forms.Label lblBalanceChange1;
        private System.Windows.Forms.PictureBox pbBlackPotez;
        private System.Windows.Forms.Label lblHit;
        private System.Windows.Forms.Label lblStand;
        private System.Windows.Forms.Label lblDoubleDown;
        private System.Windows.Forms.Label lblSplit;
        private System.Windows.Forms.Timer tmrTranzicijaReverse;
        private System.Windows.Forms.Timer tmrQuickplay;
        private System.Windows.Forms.PictureBox pbHit;
        private System.Windows.Forms.PictureBox pbStand;
        private System.Windows.Forms.PictureBox pbDoubleDown;
        private System.Windows.Forms.PictureBox pbSplit;
        private System.Windows.Forms.Timer tmrGotovaIgraQuickplay;
        private System.Windows.Forms.Timer tmrGotovaIgraPlay;
        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnToggleQuickPlay;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Button btnSettings;
    }
}