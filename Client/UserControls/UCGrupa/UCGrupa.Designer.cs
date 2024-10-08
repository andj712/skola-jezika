using System.Windows.Forms;

namespace Client.UserControls.UCGrupa
{
    partial class UCGrupa
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
            this.btnDodajGrupu = new System.Windows.Forms.Button();
            this.mcDatumPocetka = new System.Windows.Forms.MonthCalendar();
            this.lbKursevi = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNazivGrupe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbRaspored = new System.Windows.Forms.GroupBox();
            this.lblVremePocetka = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.lblDan = new System.Windows.Forms.Label();
            this.btnIzmeniRaspored = new System.Windows.Forms.Button();
            this.dgvRaspored = new System.Windows.Forms.DataGridView();
            this.btnIzbrisiRaspored = new System.Windows.Forms.Button();
            this.btnDodajRaspored = new System.Windows.Forms.Button();
            this.txtVremePocetka = new System.Windows.Forms.TextBox();
            this.cbDan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.btnIzmeniGrupu = new System.Windows.Forms.Button();
            this.lblNazivGrupe = new System.Windows.Forms.Label();
            this.lblDatumPocetka = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.gbRaspored.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajGrupu
            // 
            this.btnDodajGrupu.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajGrupu.ForeColor = System.Drawing.Color.Sienna;
            this.btnDodajGrupu.Location = new System.Drawing.Point(813, 534);
            this.btnDodajGrupu.Name = "btnDodajGrupu";
            this.btnDodajGrupu.Size = new System.Drawing.Size(125, 61);
            this.btnDodajGrupu.TabIndex = 50;
            this.btnDodajGrupu.Text = "Dodaj grupu";
            this.btnDodajGrupu.UseVisualStyleBackColor = true;
            // 
            // mcDatumPocetka
            // 
            this.mcDatumPocetka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mcDatumPocetka.Location = new System.Drawing.Point(532, 42);
            this.mcDatumPocetka.MaxSelectionCount = 1;
            this.mcDatumPocetka.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.mcDatumPocetka.Name = "mcDatumPocetka";
            this.mcDatumPocetka.TabIndex = 49;
            // 
            // lbKursevi
            // 
            this.lbKursevi.BackColor = System.Drawing.Color.White;
            this.lbKursevi.FormattingEnabled = true;
            this.lbKursevi.ItemHeight = 16;
            this.lbKursevi.Location = new System.Drawing.Point(156, 86);
            this.lbKursevi.Name = "lbKursevi";
            this.lbKursevi.Size = new System.Drawing.Size(225, 132);
            this.lbKursevi.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(54, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 47;
            this.label7.Text = "naziv kursa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(409, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Datum pocetka";
            // 
            // txtNazivGrupe
            // 
            this.txtNazivGrupe.BackColor = System.Drawing.Color.White;
            this.txtNazivGrupe.Location = new System.Drawing.Point(156, 42);
            this.txtNazivGrupe.Name = "txtNazivGrupe";
            this.txtNazivGrupe.Size = new System.Drawing.Size(225, 22);
            this.txtNazivGrupe.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(54, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "naziv grupe:";
            // 
            // gbRaspored
            // 
            this.gbRaspored.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbRaspored.Controls.Add(this.lblVremePocetka);
            this.gbRaspored.Controls.Add(this.lblSala);
            this.gbRaspored.Controls.Add(this.lblTrajanje);
            this.gbRaspored.Controls.Add(this.lblDan);
            this.gbRaspored.Controls.Add(this.btnIzmeniRaspored);
            this.gbRaspored.Controls.Add(this.dgvRaspored);
            this.gbRaspored.Controls.Add(this.btnIzbrisiRaspored);
            this.gbRaspored.Controls.Add(this.btnDodajRaspored);
            this.gbRaspored.Controls.Add(this.txtVremePocetka);
            this.gbRaspored.Controls.Add(this.cbDan);
            this.gbRaspored.Controls.Add(this.label1);
            this.gbRaspored.Controls.Add(this.label3);
            this.gbRaspored.Controls.Add(this.txtSala);
            this.gbRaspored.Controls.Add(this.label5);
            this.gbRaspored.Controls.Add(this.label4);
            this.gbRaspored.Controls.Add(this.txtTrajanje);
            this.gbRaspored.ForeColor = System.Drawing.Color.Black;
            this.gbRaspored.Location = new System.Drawing.Point(57, 248);
            this.gbRaspored.Name = "gbRaspored";
            this.gbRaspored.Size = new System.Drawing.Size(750, 353);
            this.gbRaspored.TabIndex = 51;
            this.gbRaspored.TabStop = false;
            this.gbRaspored.Text = "Raspored";
            // 
            // lblVremePocetka
            // 
            this.lblVremePocetka.AutoSize = true;
            this.lblVremePocetka.ForeColor = System.Drawing.Color.Coral;
            this.lblVremePocetka.Location = new System.Drawing.Point(393, 105);
            this.lblVremePocetka.Name = "lblVremePocetka";
            this.lblVremePocetka.Size = new System.Drawing.Size(51, 16);
            this.lblVremePocetka.TabIndex = 57;
            this.lblVremePocetka.Text = "label11";
            this.lblVremePocetka.Visible = false;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.ForeColor = System.Drawing.Color.Coral;
            this.lblSala.Location = new System.Drawing.Point(131, 103);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(51, 16);
            this.lblSala.TabIndex = 56;
            this.lblSala.Text = "label10";
            this.lblSala.Visible = false;
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.ForeColor = System.Drawing.Color.Coral;
            this.lblTrajanje.Location = new System.Drawing.Point(395, 54);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(44, 16);
            this.lblTrajanje.TabIndex = 55;
            this.lblTrajanje.Text = "label9";
            this.lblTrajanje.Visible = false;
            // 
            // lblDan
            // 
            this.lblDan.AutoSize = true;
            this.lblDan.ForeColor = System.Drawing.Color.Coral;
            this.lblDan.Location = new System.Drawing.Point(131, 54);
            this.lblDan.Name = "lblDan";
            this.lblDan.Size = new System.Drawing.Size(44, 16);
            this.lblDan.TabIndex = 54;
            this.lblDan.Text = "label8";
            this.lblDan.Visible = false;
            // 
            // btnIzmeniRaspored
            // 
            this.btnIzmeniRaspored.BackColor = System.Drawing.Color.Transparent;
            this.btnIzmeniRaspored.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmeniRaspored.ForeColor = System.Drawing.Color.Sienna;
            this.btnIzmeniRaspored.Location = new System.Drawing.Point(469, 305);
            this.btnIzmeniRaspored.Name = "btnIzmeniRaspored";
            this.btnIzmeniRaspored.Size = new System.Drawing.Size(125, 42);
            this.btnIzmeniRaspored.TabIndex = 53;
            this.btnIzmeniRaspored.Text = "Izmeni raspored";
            this.btnIzmeniRaspored.UseVisualStyleBackColor = false;
            // 
            // dgvRaspored
            // 
            this.dgvRaspored.AllowUserToAddRows = false;
            this.dgvRaspored.AllowUserToDeleteRows = false;
            this.dgvRaspored.BackgroundColor = System.Drawing.Color.White;
            this.dgvRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspored.Location = new System.Drawing.Point(68, 130);
            this.dgvRaspored.MultiSelect = false;
            this.dgvRaspored.Name = "dgvRaspored";
            this.dgvRaspored.ReadOnly = true;
            this.dgvRaspored.RowHeadersWidth = 51;
            this.dgvRaspored.RowTemplate.Height = 24;
            this.dgvRaspored.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRaspored.Size = new System.Drawing.Size(614, 150);
            this.dgvRaspored.TabIndex = 38;
            // 
            // btnIzbrisiRaspored
            // 
            this.btnIzbrisiRaspored.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiRaspored.ForeColor = System.Drawing.Color.Sienna;
            this.btnIzbrisiRaspored.Location = new System.Drawing.Point(605, 305);
            this.btnIzbrisiRaspored.Name = "btnIzbrisiRaspored";
            this.btnIzbrisiRaspored.Size = new System.Drawing.Size(125, 42);
            this.btnIzbrisiRaspored.TabIndex = 37;
            this.btnIzbrisiRaspored.Text = "Izbrisi raspored";
            this.btnIzbrisiRaspored.UseVisualStyleBackColor = true;
            // 
            // btnDodajRaspored
            // 
            this.btnDodajRaspored.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDodajRaspored.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajRaspored.ForeColor = System.Drawing.Color.Sienna;
            this.btnDodajRaspored.Location = new System.Drawing.Point(619, 13);
            this.btnDodajRaspored.Name = "btnDodajRaspored";
            this.btnDodajRaspored.Size = new System.Drawing.Size(125, 42);
            this.btnDodajRaspored.TabIndex = 36;
            this.btnDodajRaspored.Text = "Dodaj raspored";
            this.btnDodajRaspored.UseVisualStyleBackColor = true;
            // 
            // txtVremePocetka
            // 
            this.txtVremePocetka.BackColor = System.Drawing.Color.White;
            this.txtVremePocetka.Location = new System.Drawing.Point(392, 81);
            this.txtVremePocetka.Name = "txtVremePocetka";
            this.txtVremePocetka.Size = new System.Drawing.Size(116, 22);
            this.txtVremePocetka.TabIndex = 33;
            this.txtVremePocetka.Text = "HH:MM";
            // 
            // cbDan
            // 
            this.cbDan.BackColor = System.Drawing.Color.White;
            this.cbDan.FormattingEnabled = true;
            this.cbDan.Location = new System.Drawing.Point(131, 27);
            this.cbDan.Name = "cbDan";
            this.cbDan.Size = new System.Drawing.Size(121, 24);
            this.cbDan.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Dan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(29, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Sala";
            // 
            // txtSala
            // 
            this.txtSala.BackColor = System.Drawing.Color.White;
            this.txtSala.Location = new System.Drawing.Point(131, 78);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(121, 22);
            this.txtSala.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(275, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Vreme pocetka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(275, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Trajanje";
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.BackColor = System.Drawing.Color.White;
            this.txtTrajanje.Location = new System.Drawing.Point(392, 24);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(116, 22);
            this.txtTrajanje.TabIndex = 31;
            this.txtTrajanje.Text = "HH:MM";
            // 
            // btnIzmeniGrupu
            // 
            this.btnIzmeniGrupu.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmeniGrupu.ForeColor = System.Drawing.Color.Sienna;
            this.btnIzmeniGrupu.Location = new System.Drawing.Point(816, 536);
            this.btnIzmeniGrupu.Name = "btnIzmeniGrupu";
            this.btnIzmeniGrupu.Size = new System.Drawing.Size(125, 59);
            this.btnIzmeniGrupu.TabIndex = 52;
            this.btnIzmeniGrupu.Text = "Izmeni grupu";
            this.btnIzmeniGrupu.UseVisualStyleBackColor = true;
            this.btnIzmeniGrupu.Visible = false;
            // 
            // lblNazivGrupe
            // 
            this.lblNazivGrupe.AutoSize = true;
            this.lblNazivGrupe.ForeColor = System.Drawing.Color.Coral;
            this.lblNazivGrupe.Location = new System.Drawing.Point(153, 67);
            this.lblNazivGrupe.Name = "lblNazivGrupe";
            this.lblNazivGrupe.Size = new System.Drawing.Size(44, 16);
            this.lblNazivGrupe.TabIndex = 58;
            this.lblNazivGrupe.Text = "label8";
            this.lblNazivGrupe.Visible = false;
            // 
            // lblDatumPocetka
            // 
            this.lblDatumPocetka.AutoSize = true;
            this.lblDatumPocetka.ForeColor = System.Drawing.Color.Coral;
            this.lblDatumPocetka.Location = new System.Drawing.Point(428, 67);
            this.lblDatumPocetka.Name = "lblDatumPocetka";
            this.lblDatumPocetka.Size = new System.Drawing.Size(44, 16);
            this.lblDatumPocetka.TabIndex = 59;
            this.lblDatumPocetka.Text = "label9";
            this.lblDatumPocetka.Visible = false;
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNazad.ForeColor = System.Drawing.Color.Sienna;
            this.btnNazad.Location = new System.Drawing.Point(813, 469);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(125, 59);
            this.btnNazad.TabIndex = 60;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Visible = false;
            // 
            // UCGrupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.lblDatumPocetka);
            this.Controls.Add(this.lblNazivGrupe);
            this.Controls.Add(this.btnIzmeniGrupu);
            this.Controls.Add(this.gbRaspored);
            this.Controls.Add(this.btnDodajGrupu);
            this.Controls.Add(this.mcDatumPocetka);
            this.Controls.Add(this.lbKursevi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNazivGrupe);
            this.Controls.Add(this.label2);
            this.Name = "UCGrupa";
            this.Size = new System.Drawing.Size(944, 604);
            this.gbRaspored.ResumeLayout(false);
            this.gbRaspored.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajGrupu;
        private System.Windows.Forms.MonthCalendar mcDatumPocetka;
        private System.Windows.Forms.ListBox lbKursevi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNazivGrupe;
        private System.Windows.Forms.Label label2;
        private GroupBox gbRaspored;
        private Button btnIzbrisiRaspored;
        private Button btnDodajRaspored;
        private TextBox txtVremePocetka;
        private ComboBox cbDan;
        private Label label1;
        private Label label3;
        private TextBox txtSala;
        private Label label5;
        private Label label4;
        private TextBox txtTrajanje;
        private DataGridView dgvRaspored;
        private Button btnIzmeniGrupu;
        private Button btnIzmeniRaspored;
        private Label lblVremePocetka;
        private Label lblSala;
        private Label lblTrajanje;
        private Label lblDan;
        private Label lblNazivGrupe;
        private Label lblDatumPocetka;
        private Button btnNazad;

        public Button BtnDodajGrupu { get => btnDodajGrupu; set => btnDodajGrupu = value; }
        public TextBox TxtNazivGrupe { get => txtNazivGrupe; set => txtNazivGrupe = value; }
        public MonthCalendar McDatumPocetka { get => mcDatumPocetka; set => mcDatumPocetka = value; }
        public ListBox LbKursevi { get => lbKursevi; set => lbKursevi = value; }
        public DataGridView DgvRaspored { get => dgvRaspored; set => dgvRaspored = value; }
        public Button BtnDodajRaspored { get => btnDodajRaspored; set => btnDodajRaspored = value; }
        public GroupBox GbRaspored { get => gbRaspored; set => gbRaspored = value; }
        public ComboBox CbDan { get => cbDan; set => cbDan = value; }
        public TextBox TxtTrajanje { get => txtTrajanje; set => txtTrajanje = value; }
        public TextBox TxtSala { get => txtSala; set => txtSala = value; }
        public TextBox TxtVremePocetka { get => txtVremePocetka; set => txtVremePocetka = value; }
        public Button BtnIzbrisiRaspored { get => btnIzbrisiRaspored; set => btnIzbrisiRaspored = value; }
        public Button BtnIzmeniGrupu { get => btnIzmeniGrupu; set => btnIzmeniGrupu = value; }
        public Button BtnIzmeniRaspored { get => btnIzmeniRaspored; set => btnIzmeniRaspored = value; }
        public Label LblVremePocetka { get => lblVremePocetka; set => lblVremePocetka = value; }
        public Label LblSala { get => lblSala; set => lblSala = value; }
        public Label LblTrajanje { get => lblTrajanje; set => lblTrajanje = value; }
        public Label LblDan { get => lblDan; set => lblDan = value; }
        public Label LblNazivGrupe { get => lblNazivGrupe; set => lblNazivGrupe = value; }
        public Label LblDatumPocetka { get => lblDatumPocetka; set => lblDatumPocetka = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
    }
}
