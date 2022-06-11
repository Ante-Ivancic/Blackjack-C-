namespace FullApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblBlackjackFirstScreen = new System.Windows.Forms.Label();
            this.tbLoginUsername = new System.Windows.Forms.TextBox();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.tbRegisterName = new System.Windows.Forms.TextBox();
            this.tbRegisterSurname = new System.Windows.Forms.TextBox();
            this.tbRegisterUsername = new System.Windows.Forms.TextBox();
            this.tbRegisterPassword = new System.Windows.Forms.TextBox();
            this.lblRegisterName = new System.Windows.Forms.Label();
            this.lblRegisterSurname = new System.Windows.Forms.Label();
            this.lblRegisterUsername = new System.Windows.Forms.Label();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.btnRegisterConfirm = new System.Windows.Forms.Button();
            this.btnLoginConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(240, 280);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 60);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(240, 400);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 60);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblBlackjackFirstScreen
            // 
            this.lblBlackjackFirstScreen.AutoSize = true;
            this.lblBlackjackFirstScreen.BackColor = System.Drawing.Color.Transparent;
            this.lblBlackjackFirstScreen.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackjackFirstScreen.Location = new System.Drawing.Point(169, 69);
            this.lblBlackjackFirstScreen.Name = "lblBlackjackFirstScreen";
            this.lblBlackjackFirstScreen.Size = new System.Drawing.Size(266, 96);
            this.lblBlackjackFirstScreen.TabIndex = 2;
            this.lblBlackjackFirstScreen.Text = "Blackjack";
            // 
            // tbLoginUsername
            // 
            this.tbLoginUsername.BackColor = System.Drawing.Color.White;
            this.tbLoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLoginUsername.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginUsername.ForeColor = System.Drawing.Color.Black;
            this.tbLoginUsername.Location = new System.Drawing.Point(280, 296);
            this.tbLoginUsername.Name = "tbLoginUsername";
            this.tbLoginUsername.Size = new System.Drawing.Size(192, 47);
            this.tbLoginUsername.TabIndex = 3;
            this.tbLoginUsername.Visible = false;
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.BackColor = System.Drawing.Color.White;
            this.lblLoginUsername.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsername.Location = new System.Drawing.Point(136, 298);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(120, 40);
            this.lblLoginUsername.TabIndex = 4;
            this.lblLoginUsername.Text = "Username";
            this.lblLoginUsername.Visible = false;
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.BackColor = System.Drawing.Color.White;
            this.lblLoginPassword.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPassword.Location = new System.Drawing.Point(137, 383);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(120, 40);
            this.lblLoginPassword.TabIndex = 5;
            this.lblLoginPassword.Text = "Password";
            this.lblLoginPassword.Visible = false;
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.BackColor = System.Drawing.Color.White;
            this.tbLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLoginPassword.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginPassword.ForeColor = System.Drawing.Color.Black;
            this.tbLoginPassword.Location = new System.Drawing.Point(280, 383);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.PasswordChar = '*';
            this.tbLoginPassword.Size = new System.Drawing.Size(192, 47);
            this.tbLoginPassword.TabIndex = 6;
            this.tbLoginPassword.Visible = false;
            // 
            // tbRegisterName
            // 
            this.tbRegisterName.BackColor = System.Drawing.Color.White;
            this.tbRegisterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRegisterName.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterName.ForeColor = System.Drawing.Color.Black;
            this.tbRegisterName.Location = new System.Drawing.Point(280, 240);
            this.tbRegisterName.Name = "tbRegisterName";
            this.tbRegisterName.Size = new System.Drawing.Size(192, 47);
            this.tbRegisterName.TabIndex = 7;
            this.tbRegisterName.Visible = false;
            // 
            // tbRegisterSurname
            // 
            this.tbRegisterSurname.BackColor = System.Drawing.Color.White;
            this.tbRegisterSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRegisterSurname.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterSurname.ForeColor = System.Drawing.Color.Black;
            this.tbRegisterSurname.Location = new System.Drawing.Point(281, 302);
            this.tbRegisterSurname.Name = "tbRegisterSurname";
            this.tbRegisterSurname.Size = new System.Drawing.Size(192, 47);
            this.tbRegisterSurname.TabIndex = 8;
            this.tbRegisterSurname.Visible = false;
            // 
            // tbRegisterUsername
            // 
            this.tbRegisterUsername.BackColor = System.Drawing.Color.White;
            this.tbRegisterUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRegisterUsername.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterUsername.ForeColor = System.Drawing.Color.Black;
            this.tbRegisterUsername.Location = new System.Drawing.Point(280, 365);
            this.tbRegisterUsername.Name = "tbRegisterUsername";
            this.tbRegisterUsername.Size = new System.Drawing.Size(192, 47);
            this.tbRegisterUsername.TabIndex = 9;
            this.tbRegisterUsername.Visible = false;
            // 
            // tbRegisterPassword
            // 
            this.tbRegisterPassword.BackColor = System.Drawing.Color.White;
            this.tbRegisterPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRegisterPassword.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterPassword.ForeColor = System.Drawing.Color.Black;
            this.tbRegisterPassword.Location = new System.Drawing.Point(281, 429);
            this.tbRegisterPassword.Name = "tbRegisterPassword";
            this.tbRegisterPassword.Size = new System.Drawing.Size(192, 47);
            this.tbRegisterPassword.TabIndex = 10;
            this.tbRegisterPassword.Visible = false;
            // 
            // lblRegisterName
            // 
            this.lblRegisterName.AutoSize = true;
            this.lblRegisterName.BackColor = System.Drawing.Color.White;
            this.lblRegisterName.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterName.Location = new System.Drawing.Point(139, 241);
            this.lblRegisterName.Name = "lblRegisterName";
            this.lblRegisterName.Size = new System.Drawing.Size(74, 40);
            this.lblRegisterName.TabIndex = 11;
            this.lblRegisterName.Text = "Name";
            this.lblRegisterName.Visible = false;
            // 
            // lblRegisterSurname
            // 
            this.lblRegisterSurname.AutoSize = true;
            this.lblRegisterSurname.BackColor = System.Drawing.Color.White;
            this.lblRegisterSurname.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterSurname.Location = new System.Drawing.Point(140, 304);
            this.lblRegisterSurname.Name = "lblRegisterSurname";
            this.lblRegisterSurname.Size = new System.Drawing.Size(108, 40);
            this.lblRegisterSurname.TabIndex = 12;
            this.lblRegisterSurname.Text = "Surname";
            this.lblRegisterSurname.Visible = false;
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.AutoSize = true;
            this.lblRegisterUsername.BackColor = System.Drawing.Color.White;
            this.lblRegisterUsername.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterUsername.Location = new System.Drawing.Point(139, 366);
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(120, 40);
            this.lblRegisterUsername.TabIndex = 13;
            this.lblRegisterUsername.Text = "Username";
            this.lblRegisterUsername.Visible = false;
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.BackColor = System.Drawing.Color.White;
            this.lblRegisterPassword.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPassword.Location = new System.Drawing.Point(141, 434);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(120, 40);
            this.lblRegisterPassword.TabIndex = 14;
            this.lblRegisterPassword.Text = "Password";
            this.lblRegisterPassword.Visible = false;
            // 
            // btnRegisterConfirm
            // 
            this.btnRegisterConfirm.BackColor = System.Drawing.Color.White;
            this.btnRegisterConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegisterConfirm.FlatAppearance.BorderSize = 0;
            this.btnRegisterConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRegisterConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegisterConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterConfirm.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterConfirm.Location = new System.Drawing.Point(393, 591);
            this.btnRegisterConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegisterConfirm.Name = "btnRegisterConfirm";
            this.btnRegisterConfirm.Size = new System.Drawing.Size(120, 60);
            this.btnRegisterConfirm.TabIndex = 15;
            this.btnRegisterConfirm.Text = "Confirm";
            this.btnRegisterConfirm.UseVisualStyleBackColor = false;
            this.btnRegisterConfirm.Visible = false;
            this.btnRegisterConfirm.Click += new System.EventHandler(this.btnRegisterConfirm_Click);
            // 
            // btnLoginConfirm
            // 
            this.btnLoginConfirm.BackColor = System.Drawing.Color.White;
            this.btnLoginConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoginConfirm.FlatAppearance.BorderSize = 0;
            this.btnLoginConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLoginConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoginConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginConfirm.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginConfirm.Location = new System.Drawing.Point(114, 584);
            this.btnLoginConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoginConfirm.Name = "btnLoginConfirm";
            this.btnLoginConfirm.Size = new System.Drawing.Size(120, 60);
            this.btnLoginConfirm.TabIndex = 16;
            this.btnLoginConfirm.Text = "Confirm";
            this.btnLoginConfirm.UseVisualStyleBackColor = false;
            this.btnLoginConfirm.Visible = false;
            this.btnLoginConfirm.Click += new System.EventHandler(this.btnLoginConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.btnLoginConfirm);
            this.Controls.Add(this.btnRegisterConfirm);
            this.Controls.Add(this.lblRegisterPassword);
            this.Controls.Add(this.lblRegisterUsername);
            this.Controls.Add(this.lblRegisterSurname);
            this.Controls.Add(this.lblRegisterName);
            this.Controls.Add(this.tbRegisterPassword);
            this.Controls.Add(this.tbRegisterUsername);
            this.Controls.Add(this.tbRegisterSurname);
            this.Controls.Add(this.tbRegisterName);
            this.Controls.Add(this.tbLoginPassword);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginUsername);
            this.Controls.Add(this.tbLoginUsername);
            this.Controls.Add(this.lblBlackjackFirstScreen);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblBlackjackFirstScreen;
        private System.Windows.Forms.TextBox tbLoginUsername;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.TextBox tbRegisterName;
        private System.Windows.Forms.TextBox tbRegisterSurname;
        private System.Windows.Forms.TextBox tbRegisterUsername;
        private System.Windows.Forms.TextBox tbRegisterPassword;
        private System.Windows.Forms.Label lblRegisterName;
        private System.Windows.Forms.Label lblRegisterSurname;
        private System.Windows.Forms.Label lblRegisterUsername;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Button btnRegisterConfirm;
        private System.Windows.Forms.Button btnLoginConfirm;
    }
}

