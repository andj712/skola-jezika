using System.Windows.Forms;

namespace Client.UserControls.UCKurs
{
    partial class UCPretraziKurseve
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.lbKursevi = new System.Windows.Forms.ListBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrojCasova = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJezik = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.dgvKursevi = new System.Windows.Forms.DataGridView();
            this.gbDetalji = new System.Windows.Forms.GroupBox();
            this.btnIzmeniGrupu = new System.Windows.Forms.Button();
            this.lblGrupeZaKurs = new System.Windows.Forms.Label();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.dgvGrupe = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).BeginInit();
            this.gbDetalji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraživanje kursa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(68, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "naziv kursa:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.BackColor = System.Drawing.Color.White;
            this.txtPretraga.Location = new System.Drawing.Point(170, 83);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(278, 22);
            this.txtPretraga.TabIndex = 3;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.ForeColor = System.Drawing.Color.Sienna;
            this.btnPretrazi.Location = new System.Drawing.Point(481, 73);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(109, 36);
            this.btnPretrazi.TabIndex = 4;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Visible = false;
            // 
            // btnDetalji
            // 
            this.btnDetalji.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetalji.ForeColor = System.Drawing.Color.Sienna;
            this.btnDetalji.Location = new System.Drawing.Point(65, 292);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(111, 43);
            this.btnDetalji.TabIndex = 5;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Visible = false;
            // 
            // lbKursevi
            // 
            this.lbKursevi.FormattingEnabled = true;
            this.lbKursevi.ItemHeight = 16;
            this.lbKursevi.Location = new System.Drawing.Point(182, 132);
            this.lbKursevi.Name = "lbKursevi";
            this.lbKursevi.Size = new System.Drawing.Size(225, 164);
            this.lbKursevi.TabIndex = 6;
            this.lbKursevi.Visible = false;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmeni.ForeColor = System.Drawing.Color.Sienna;
            this.btnIzmeni.Location = new System.Drawing.Point(72, 292);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(101, 43);
            this.btnIzmeni.TabIndex = 7;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.Color.White;
            this.txtNaziv.Enabled = false;
            this.txtNaziv.Location = new System.Drawing.Point(160, 82);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(278, 27);
            this.txtNaziv.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(58, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "naziv kursa:";
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.BackColor = System.Drawing.Color.White;
            this.txtTrajanje.Enabled = false;
            this.txtTrajanje.Location = new System.Drawing.Point(160, 123);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(278, 27);
            this.txtTrajanje.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(58, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "trajanje:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(58, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "opis:";
            // 
            // txtBrojCasova
            // 
            this.txtBrojCasova.BackColor = System.Drawing.Color.White;
            this.txtBrojCasova.Enabled = false;
            this.txtBrojCasova.Location = new System.Drawing.Point(160, 222);
            this.txtBrojCasova.Name = "txtBrojCasova";
            this.txtBrojCasova.Size = new System.Drawing.Size(278, 27);
            this.txtBrojCasova.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(58, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "broj casova:";
            // 
            // txtJezik
            // 
            this.txtJezik.BackColor = System.Drawing.Color.White;
            this.txtJezik.Enabled = false;
            this.txtJezik.Location = new System.Drawing.Point(160, 269);
            this.txtJezik.Name = "txtJezik";
            this.txtJezik.Size = new System.Drawing.Size(278, 27);
            this.txtJezik.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(58, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "jezik:";
            // 
            // rtbOpis
            // 
            this.rtbOpis.BackColor = System.Drawing.Color.White;
            this.rtbOpis.Enabled = false;
            this.rtbOpis.Location = new System.Drawing.Point(160, 167);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(278, 43);
            this.rtbOpis.TabIndex = 19;
            this.rtbOpis.Text = "";
            // 
            // dgvKursevi
            // 
            this.dgvKursevi.AllowUserToAddRows = false;
            this.dgvKursevi.AllowUserToDeleteRows = false;
            this.dgvKursevi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvKursevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKursevi.GridColor = System.Drawing.Color.Sienna;
            this.dgvKursevi.Location = new System.Drawing.Point(72, 120);
            this.dgvKursevi.MultiSelect = false;
            this.dgvKursevi.Name = "dgvKursevi";
            this.dgvKursevi.ReadOnly = true;
            this.dgvKursevi.RowHeadersWidth = 51;
            this.dgvKursevi.RowTemplate.Height = 24;
            this.dgvKursevi.Size = new System.Drawing.Size(715, 166);
            this.dgvKursevi.TabIndex = 20;
            // 
            // gbDetalji
            // 
            this.gbDetalji.Controls.Add(this.btnIzmeniGrupu);
            this.gbDetalji.Controls.Add(this.lblGrupeZaKurs);
            this.gbDetalji.Controls.Add(this.btnPrijaviSe);
            this.gbDetalji.Controls.Add(this.dgvGrupe);
            this.gbDetalji.Controls.Add(this.txtNaziv);
            this.gbDetalji.Controls.Add(this.rtbOpis);
            this.gbDetalji.Controls.Add(this.label4);
            this.gbDetalji.Controls.Add(this.txtJezik);
            this.gbDetalji.Controls.Add(this.label5);
            this.gbDetalji.Controls.Add(this.label8);
            this.gbDetalji.Controls.Add(this.txtTrajanje);
            this.gbDetalji.Controls.Add(this.txtBrojCasova);
            this.gbDetalji.Controls.Add(this.label6);
            this.gbDetalji.Controls.Add(this.label7);
            this.gbDetalji.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbDetalji.Location = new System.Drawing.Point(33, 341);
            this.gbDetalji.Name = "gbDetalji";
            this.gbDetalji.Size = new System.Drawing.Size(847, 348);
            this.gbDetalji.TabIndex = 21;
            this.gbDetalji.TabStop = false;
            this.gbDetalji.Text = "Detalji kursa";
            this.gbDetalji.Visible = false;
            // 
            // btnIzmeniGrupu
            // 
            this.btnIzmeniGrupu.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmeniGrupu.ForeColor = System.Drawing.Color.Sienna;
            this.btnIzmeniGrupu.Location = new System.Drawing.Point(696, 227);
            this.btnIzmeniGrupu.Name = "btnIzmeniGrupu";
            this.btnIzmeniGrupu.Size = new System.Drawing.Size(128, 42);
            this.btnIzmeniGrupu.TabIndex = 25;
            this.btnIzmeniGrupu.Text = "Izmeni grupu\r\n";
            this.btnIzmeniGrupu.UseVisualStyleBackColor = true;
            this.btnIzmeniGrupu.Visible = false;
            // 
            // lblGrupeZaKurs
            // 
            this.lblGrupeZaKurs.AutoSize = true;
            this.lblGrupeZaKurs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGrupeZaKurs.Location = new System.Drawing.Point(491, 18);
            this.lblGrupeZaKurs.Name = "lblGrupeZaKurs";
            this.lblGrupeZaKurs.Size = new System.Drawing.Size(102, 19);
            this.lblGrupeZaKurs.TabIndex = 24;
            this.lblGrupeZaKurs.Text = "Grupe za kurs";
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijaviSe.ForeColor = System.Drawing.Color.Sienna;
            this.btnPrijaviSe.Location = new System.Drawing.Point(686, 260);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(138, 58);
            this.btnPrijaviSe.TabIndex = 23;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            this.btnPrijaviSe.Visible = false;
            // 
            // dgvGrupe
            // 
            this.dgvGrupe.AllowUserToAddRows = false;
            this.dgvGrupe.AllowUserToDeleteRows = false;
            this.dgvGrupe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupe.GridColor = System.Drawing.Color.BurlyWood;
            this.dgvGrupe.Location = new System.Drawing.Point(485, 50);
            this.dgvGrupe.MultiSelect = false;
            this.dgvGrupe.Name = "dgvGrupe";
            this.dgvGrupe.ReadOnly = true;
            this.dgvGrupe.RowHeadersWidth = 51;
            this.dgvGrupe.RowTemplate.Height = 24;
            this.dgvGrupe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupe.Size = new System.Drawing.Size(339, 170);
            this.dgvGrupe.TabIndex = 21;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.ForeColor = System.Drawing.Color.Sienna;
            this.btnObrisi.Location = new System.Drawing.Point(70, 292);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(103, 43);
            this.btnObrisi.TabIndex = 22;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Visible = false;
            // 
            // UCPretraziKurseve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.gbDetalji);
            this.Controls.Add(this.dgvKursevi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.lbKursevi);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(880, 360);
            this.Name = "UCPretraziKurseve";
            this.Size = new System.Drawing.Size(883, 692);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).EndInit();
            this.gbDetalji.ResumeLayout(false);
            this.gbDetalji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.ListBox lbKursevi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBrojCasova;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJezik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private DataGridView dgvKursevi;
        private GroupBox gbDetalji;
        private Button btnObrisi;
        private Button btnPrijaviSe;
        private DataGridView dgvGrupe;
        private Label lblGrupeZaKurs;
        private Button btnIzmeniGrupu;

        public ListBox LbKursevi { get => lbKursevi; set => lbKursevi = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public Button BtnDetalji { get => btnDetalji; set => btnDetalji = value; }
        public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public DataGridView DgvKursevi { get => dgvKursevi; set => dgvKursevi = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public GroupBox GbDetalji { get => gbDetalji; set => gbDetalji = value; }
        public Button BtnPrijaviSe { get => btnPrijaviSe; set => btnPrijaviSe = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public TextBox TxtTrajanje { get => txtTrajanje; set => txtTrajanje = value; }
        public TextBox TxtBrojCasova { get => txtBrojCasova; set => txtBrojCasova = value; }
        public TextBox TxtJezik { get => txtJezik; set => txtJezik = value; }
        public RichTextBox RtbOpis { get => rtbOpis; set => rtbOpis = value; }
        public DataGridView DgvGrupe { get => dgvGrupe; set => dgvGrupe = value; }
        public Button BtnIzmeniGrupu { get => btnIzmeniGrupu; set => btnIzmeniGrupu = value; }
    }

}
