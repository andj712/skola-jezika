using System.Windows.Forms;

namespace Client.UserControls.UCKursevi
{
    partial class UCKurs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojCasova = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbJezici = new System.Windows.Forms.ComboBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblBrojCasova = new System.Windows.Forms.Label();
            this.lblJezik = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(125, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv ";
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.Color.White;
            this.txtNaziv.Location = new System.Drawing.Point(219, 140);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(242, 22);
            this.txtNaziv.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.BackColor = System.Drawing.Color.White;
            this.txtTrajanje.Location = new System.Drawing.Point(219, 199);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(242, 22);
            this.txtTrajanje.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(125, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trajanje";
            // 
            // txtOpis
            // 
            this.txtOpis.BackColor = System.Drawing.Color.White;
            this.txtOpis.Location = new System.Drawing.Point(219, 257);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(242, 22);
            this.txtOpis.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(125, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opis ";
            // 
            // txtBrojCasova
            // 
            this.txtBrojCasova.BackColor = System.Drawing.Color.White;
            this.txtBrojCasova.Location = new System.Drawing.Point(219, 316);
            this.txtBrojCasova.Name = "txtBrojCasova";
            this.txtBrojCasova.Size = new System.Drawing.Size(242, 22);
            this.txtBrojCasova.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(125, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Broj casova";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(125, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Jezik";
            // 
            // cbJezici
            // 
            this.cbJezici.BackColor = System.Drawing.Color.White;
            this.cbJezici.FormattingEnabled = true;
            this.cbJezici.Location = new System.Drawing.Point(219, 376);
            this.cbJezici.Name = "cbJezici";
            this.cbJezici.Size = new System.Drawing.Size(242, 24);
            this.cbJezici.TabIndex = 11;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(364, 428);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(97, 37);
            this.btnKreiraj.TabIndex = 12;
            this.btnKreiraj.Text = "Kreiraj kurs";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmeni.ForeColor = System.Drawing.Color.Sienna;
            this.btnIzmeni.Location = new System.Drawing.Point(342, 428);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(119, 52);
            this.btnIzmeni.TabIndex = 13;
            this.btnIzmeni.Text = "Sacuvaj";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.ForeColor = System.Drawing.Color.Coral;
            this.lblNaziv.Location = new System.Drawing.Point(216, 165);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 16);
            this.lblNaziv.TabIndex = 14;
            this.lblNaziv.Text = "label7";
            this.lblNaziv.Visible = false;
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.ForeColor = System.Drawing.Color.Coral;
            this.lblTrajanje.Location = new System.Drawing.Point(216, 224);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(44, 16);
            this.lblTrajanje.TabIndex = 15;
            this.lblTrajanje.Text = "label8";
            this.lblTrajanje.Visible = false;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.ForeColor = System.Drawing.Color.Coral;
            this.lblOpis.Location = new System.Drawing.Point(216, 288);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(44, 16);
            this.lblOpis.TabIndex = 16;
            this.lblOpis.Text = "label9";
            this.lblOpis.Visible = false;
            // 
            // lblBrojCasova
            // 
            this.lblBrojCasova.AutoSize = true;
            this.lblBrojCasova.ForeColor = System.Drawing.Color.Coral;
            this.lblBrojCasova.Location = new System.Drawing.Point(216, 341);
            this.lblBrojCasova.Name = "lblBrojCasova";
            this.lblBrojCasova.Size = new System.Drawing.Size(51, 16);
            this.lblBrojCasova.TabIndex = 17;
            this.lblBrojCasova.Text = "label10";
            this.lblBrojCasova.Visible = false;
            // 
            // lblJezik
            // 
            this.lblJezik.AutoSize = true;
            this.lblJezik.ForeColor = System.Drawing.Color.Coral;
            this.lblJezik.Location = new System.Drawing.Point(216, 403);
            this.lblJezik.Name = "lblJezik";
            this.lblJezik.Size = new System.Drawing.Size(51, 16);
            this.lblJezik.TabIndex = 18;
            this.lblJezik.Text = "label11";
            this.lblJezik.Visible = false;
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNazad.ForeColor = System.Drawing.Color.Sienna;
            this.btnNazad.Location = new System.Drawing.Point(129, 428);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(119, 52);
            this.btnNazad.TabIndex = 19;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Visible = false;
            // 
            // UCKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.lblJezik);
            this.Controls.Add(this.lblBrojCasova);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblTrajanje);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.cbJezici);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBrojCasova);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "UCKurs";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrojCasova;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbJezici;
        private System.Windows.Forms.Button btnKreiraj;
        private Button btnIzmeni;
        private Label lblNaziv;
        private Label lblTrajanje;
        private Label lblOpis;
        private Label lblBrojCasova;
        private Label lblJezik;
        private Button btnNazad;

        public System.Windows.Forms.Button BtnKreiraj { get=>btnKreiraj; set=>btnKreiraj=value; }
        public ComboBox CbJezici { get=>cbJezici; set=>cbJezici=value; }
        public TextBox TxtOpis { get => txtOpis; set => txtOpis = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public TextBox TxtTrajanje { get => txtTrajanje; set => txtTrajanje = value; }
        public TextBox TxtBrojCasova { get => txtBrojCasova; set => txtBrojCasova = value; }
        public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
        public Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public Label LblTrajanje { get => lblTrajanje; set => lblTrajanje = value; }
        public Label LblOpis { get => lblOpis; set => lblOpis = value; }
        public Label LblBrojCasova { get => lblBrojCasova; set => lblBrojCasova = value; }
        public Label LblJezik { get => lblJezik; set => lblJezik = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
    }
}
