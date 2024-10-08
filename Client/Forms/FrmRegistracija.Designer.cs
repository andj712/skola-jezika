using System.Windows.Forms;

namespace Client
{
    partial class FrmRegistracija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistracija));
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrujSe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKontaktTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mcBirthday = new System.Windows.Forms.MonthCalendar();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblGmail = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblKontaktTelefon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(285, 105);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(234, 22);
            this.txtPrezime.TabIndex = 8;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(285, 52);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(234, 22);
            this.txtIme.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(148, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(148, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // txtGmail
            // 
            this.txtGmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtGmail.Location = new System.Drawing.Point(285, 160);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(234, 22);
            this.txtGmail.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(148, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gmail";
            // 
            // btnRegistrujSe
            // 
            this.btnRegistrujSe.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegistrujSe.ForeColor = System.Drawing.Color.Sienna;
            this.btnRegistrujSe.Location = new System.Drawing.Point(285, 609);
            this.btnRegistrujSe.Name = "btnRegistrujSe";
            this.btnRegistrujSe.Size = new System.Drawing.Size(234, 40);
            this.btnRegistrujSe.TabIndex = 11;
            this.btnRegistrujSe.Text = "Registruj se";
            this.btnRegistrujSe.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(149, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Datum rodjenja";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(285, 270);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(234, 22);
            this.txtLozinka.TabIndex = 15;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(285, 217);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(234, 22);
            this.txtKorisnickoIme.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(149, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Lozinka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(149, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Korisnicko ime";
            // 
            // txtKontaktTelefon
            // 
            this.txtKontaktTelefon.Location = new System.Drawing.Point(285, 560);
            this.txtKontaktTelefon.Name = "txtKontaktTelefon";
            this.txtKontaktTelefon.Size = new System.Drawing.Size(234, 22);
            this.txtKontaktTelefon.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(149, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kontakt telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-267, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-267, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-267, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "LastName";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-267, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "FirstName";
            // 
            // mcBirthday
            // 
            this.mcBirthday.Location = new System.Drawing.Point(285, 332);
            this.mcBirthday.MaxSelectionCount = 1;
            this.mcBirthday.Name = "mcBirthday";
            this.mcBirthday.TabIndex = 25;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(-175, 256);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(127, 22);
            this.txtFirstName.TabIndex = 24;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblIme.ForeColor = System.Drawing.Color.Coral;
            this.lblIme.Location = new System.Drawing.Point(285, 86);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(51, 16);
            this.lblIme.TabIndex = 30;
            this.lblIme.Text = "label12";
            this.lblIme.Visible = false;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.ForeColor = System.Drawing.Color.Coral;
            this.lblPrezime.Location = new System.Drawing.Point(285, 141);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(51, 16);
            this.lblPrezime.TabIndex = 31;
            this.lblPrezime.Text = "label13";
            this.lblPrezime.Visible = false;
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.ForeColor = System.Drawing.Color.Coral;
            this.lblGmail.Location = new System.Drawing.Point(285, 198);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(51, 16);
            this.lblGmail.TabIndex = 32;
            this.lblGmail.Text = "label14";
            this.lblGmail.Visible = false;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.Coral;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(285, 251);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(51, 16);
            this.lblKorisnickoIme.TabIndex = 33;
            this.lblKorisnickoIme.Text = "label15";
            this.lblKorisnickoIme.Visible = false;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.ForeColor = System.Drawing.Color.Coral;
            this.lblLozinka.Location = new System.Drawing.Point(285, 307);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(51, 16);
            this.lblLozinka.TabIndex = 34;
            this.lblLozinka.Text = "label16";
            this.lblLozinka.Visible = false;
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.ForeColor = System.Drawing.Color.Coral;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(285, 541);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(51, 16);
            this.lblDatumRodjenja.TabIndex = 35;
            this.lblDatumRodjenja.Text = "label17";
            this.lblDatumRodjenja.Visible = false;
            // 
            // lblKontaktTelefon
            // 
            this.lblKontaktTelefon.AutoSize = true;
            this.lblKontaktTelefon.ForeColor = System.Drawing.Color.Coral;
            this.lblKontaktTelefon.Location = new System.Drawing.Point(285, 590);
            this.lblKontaktTelefon.Name = "lblKontaktTelefon";
            this.lblKontaktTelefon.Size = new System.Drawing.Size(51, 16);
            this.lblKontaktTelefon.TabIndex = 36;
            this.lblKontaktTelefon.Text = "label18";
            this.lblKontaktTelefon.Visible = false;
            // 
            // FrmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(714, 661);
            this.Controls.Add(this.lblKontaktTelefon);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.lblGmail);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mcBirthday);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtKontaktTelefon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrujSe);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrujSe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKontaktTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MonthCalendar mcBirthday;
        private System.Windows.Forms.TextBox txtFirstName;
        private Label lblIme;
        private Label lblPrezime;
        private Label lblGmail;
        private Label lblKorisnickoIme;
        private Label lblLozinka;
        private Label lblDatumRodjenja;
        private Label lblKontaktTelefon;

        public Button BtnRegistrujSe { get => btnRegistrujSe; set => btnRegistrujSe = value; }

        public TextBox TxtKontaktTelefon{ get => txtKontaktTelefon; set => txtKontaktTelefon = value; } 
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; } 
        public TextBox TxtIme { get => txtIme; set => txtIme = value; } 
        public TextBox TxtLozinka{ get => txtLozinka; set => txtLozinka = value; } 
        public TextBox TxtGmail{ get => txtGmail; set => txtGmail = value; } 
        public TextBox TxtKorisnickoIme { get => txtKorisnickoIme; set => txtKorisnickoIme = value; }

        public Label LblIme { get=>lblIme; set =>lblIme=value; }
        public Label LblPrezime{ get=>lblPrezime; set => lblPrezime = value; }
        public Label LblKorisnickoIme { get=>lblKorisnickoIme; set => lblKorisnickoIme = value; }
        public Label LblLozinka { get=>lblLozinka; set => lblLozinka = value; }
        public Label LblGmail { get=>lblGmail; set => lblGmail = value; }
        public Label LblKontaktTelefon { get=> lblKontaktTelefon; set => lblKontaktTelefon = value; }
        public Label LblDatumRodjenja { get=> lblDatumRodjenja; set => lblDatumRodjenja = value; }
        
        public MonthCalendar McBirthday { get => mcBirthday;set => mcBirthday = value; }

        }
}