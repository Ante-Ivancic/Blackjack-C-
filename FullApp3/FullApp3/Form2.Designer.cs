namespace FullApp3
{
    partial class SendMoney
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
            this.lblDavatelj = new System.Windows.Forms.Label();
            this.lblPrimatelj = new System.Windows.Forms.Label();
            this.tbDavatelj = new System.Windows.Forms.TextBox();
            this.tbPrimatelj = new System.Windows.Forms.TextBox();
            this.lblIznos = new System.Windows.Forms.Label();
            this.tbIznos = new System.Windows.Forms.TextBox();
            this.btnUplati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDavatelj
            // 
            this.lblDavatelj.AutoSize = true;
            this.lblDavatelj.Location = new System.Drawing.Point(12, 12);
            this.lblDavatelj.Name = "lblDavatelj";
            this.lblDavatelj.Size = new System.Drawing.Size(59, 17);
            this.lblDavatelj.TabIndex = 0;
            this.lblDavatelj.Text = "Davatelj";
            // 
            // lblPrimatelj
            // 
            this.lblPrimatelj.AutoSize = true;
            this.lblPrimatelj.Location = new System.Drawing.Point(9, 40);
            this.lblPrimatelj.Name = "lblPrimatelj";
            this.lblPrimatelj.Size = new System.Drawing.Size(62, 17);
            this.lblPrimatelj.TabIndex = 1;
            this.lblPrimatelj.Text = "Primatelj";
            // 
            // tbDavatelj
            // 
            this.tbDavatelj.Location = new System.Drawing.Point(77, 9);
            this.tbDavatelj.Name = "tbDavatelj";
            this.tbDavatelj.ReadOnly = true;
            this.tbDavatelj.Size = new System.Drawing.Size(123, 22);
            this.tbDavatelj.TabIndex = 2;
            // 
            // tbPrimatelj
            // 
            this.tbPrimatelj.Location = new System.Drawing.Point(77, 37);
            this.tbPrimatelj.Name = "tbPrimatelj";
            this.tbPrimatelj.Size = new System.Drawing.Size(123, 22);
            this.tbPrimatelj.TabIndex = 3;
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(30, 104);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(41, 17);
            this.lblIznos.TabIndex = 4;
            this.lblIznos.Text = "Iznos";
            // 
            // tbIznos
            // 
            this.tbIznos.Location = new System.Drawing.Point(77, 101);
            this.tbIznos.Name = "tbIznos";
            this.tbIznos.Size = new System.Drawing.Size(123, 22);
            this.tbIznos.TabIndex = 5;
            // 
            // btnUplati
            // 
            this.btnUplati.Location = new System.Drawing.Point(77, 144);
            this.btnUplati.Name = "btnUplati";
            this.btnUplati.Size = new System.Drawing.Size(75, 27);
            this.btnUplati.TabIndex = 7;
            this.btnUplati.Text = "Uplati";
            this.btnUplati.UseVisualStyleBackColor = true;
            this.btnUplati.Click += new System.EventHandler(this.btnUplati_Click);
            // 
            // SendMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 186);
            this.Controls.Add(this.btnUplati);
            this.Controls.Add(this.tbIznos);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.tbPrimatelj);
            this.Controls.Add(this.tbDavatelj);
            this.Controls.Add(this.lblPrimatelj);
            this.Controls.Add(this.lblDavatelj);
            this.Name = "SendMoney";
            this.Text = "Money transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDavatelj;
        private System.Windows.Forms.Label lblPrimatelj;
        private System.Windows.Forms.TextBox tbDavatelj;
        private System.Windows.Forms.TextBox tbPrimatelj;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.TextBox tbIznos;
        private System.Windows.Forms.Button btnUplati;
    }
}