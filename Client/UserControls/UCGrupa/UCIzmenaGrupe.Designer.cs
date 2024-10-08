namespace Client.UserControls.UCGrupa
{
    partial class UCIzmenaGrupe
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
            this.gbRaspored = new System.Windows.Forms.GroupBox();
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
            this.btnDodajGrupu = new System.Windows.Forms.Button();
            this.mcDatumPocetka = new System.Windows.Forms.MonthCalendar();
            this.lbKursevi = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNazivGrupe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbRaspored.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRaspored
            // 
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
            this.gbRaspored.Location = new System.Drawing.Point(37, 224);
            this.gbRaspored.Name = "gbRaspored";
            this.gbRaspored.Size = new System.Drawing.Size(750, 353);
            this.gbRaspored.TabIndex = 59;
            this.gbRaspored.TabStop = false;
            this.gbRaspored.Text = "Raspored";
            // 
            // dgvRaspored
            // 
            this.dgvRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspored.Location = new System.Drawing.Point(68, 130);
            this.dgvRaspored.Name = "dgvRaspored";
            this.dgvRaspored.RowHeadersWidth = 51;
            this.dgvRaspored.RowTemplate.Height = 24;
            this.dgvRaspored.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRaspored.Size = new System.Drawing.Size(662, 150);
            this.dgvRaspored.TabIndex = 38;
            // 
            // btnIzbrisiRaspored
            // 
            this.btnIzbrisiRaspored.Location = new System.Drawing.Point(605, 305);
            this.btnIzbrisiRaspored.Name = "btnIzbrisiRaspored";
            this.btnIzbrisiRaspored.Size = new System.Drawing.Size(125, 42);
            this.btnIzbrisiRaspored.TabIndex = 37;
            this.btnIzbrisiRaspored.Text = "Izbrisi raspored";
            this.btnIzbrisiRaspored.UseVisualStyleBackColor = true;
            // 
            // btnDodajRaspored
            // 
            this.btnDodajRaspored.Location = new System.Drawing.Point(605, 48);
            this.btnDodajRaspored.Name = "btnDodajRaspored";
            this.btnDodajRaspored.Size = new System.Drawing.Size(125, 42);
            this.btnDodajRaspored.TabIndex = 36;
            this.btnDodajRaspored.Text = "Dodaj raspored";
            this.btnDodajRaspored.UseVisualStyleBackColor = true;
            // 
            // txtVremePocetka
            // 
            this.txtVremePocetka.Location = new System.Drawing.Point(469, 68);
            this.txtVremePocetka.Name = "txtVremePocetka";
            this.txtVremePocetka.Size = new System.Drawing.Size(116, 22);
            this.txtVremePocetka.TabIndex = 33;
            // 
            // cbDan
            // 
            this.cbDan.FormattingEnabled = true;
            this.cbDan.Location = new System.Drawing.Point(131, 27);
            this.cbDan.Name = "cbDan";
            this.cbDan.Size = new System.Drawing.Size(121, 24);
            this.cbDan.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Dan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Sala";
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(130, 65);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(121, 22);
            this.txtSala.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Vreme pocetka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Trajanje";
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(469, 24);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(116, 22);
            this.txtTrajanje.TabIndex = 31;
            // 
            // btnDodajGrupu
            // 
            this.btnDodajGrupu.Location = new System.Drawing.Point(817, 526);
            this.btnDodajGrupu.Name = "btnDodajGrupu";
            this.btnDodajGrupu.Size = new System.Drawing.Size(125, 42);
            this.btnDodajGrupu.TabIndex = 58;
            this.btnDodajGrupu.Text = "Dodaj grupu";
            this.btnDodajGrupu.UseVisualStyleBackColor = true;
            // 
            // mcDatumPocetka
            // 
            this.mcDatumPocetka.Location = new System.Drawing.Point(708, 11);
            this.mcDatumPocetka.Name = "mcDatumPocetka";
            this.mcDatumPocetka.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2024, 2, 1, 0, 0, 0, 0), new System.DateTime(2024, 2, 7, 0, 0, 0, 0));
            this.mcDatumPocetka.TabIndex = 57;
            // 
            // lbKursevi
            // 
            this.lbKursevi.FormattingEnabled = true;
            this.lbKursevi.ItemHeight = 16;
            this.lbKursevi.Location = new System.Drawing.Point(368, 67);
            this.lbKursevi.Name = "lbKursevi";
            this.lbKursevi.Size = new System.Drawing.Size(225, 132);
            this.lbKursevi.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "naziv kursa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Datum pocetka";
            // 
            // txtNazivGrupe
            // 
            this.txtNazivGrupe.Location = new System.Drawing.Point(368, 26);
            this.txtNazivGrupe.Name = "txtNazivGrupe";
            this.txtNazivGrupe.Size = new System.Drawing.Size(225, 22);
            this.txtNazivGrupe.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "naziv grupe:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(37, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 164);
            this.listBox1.TabIndex = 60;
            // 
            // UCIzmenaGrupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gbRaspored);
            this.Controls.Add(this.btnDodajGrupu);
            this.Controls.Add(this.mcDatumPocetka);
            this.Controls.Add(this.lbKursevi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNazivGrupe);
            this.Controls.Add(this.label2);
            this.Name = "UCIzmenaGrupe";
            this.Size = new System.Drawing.Size(989, 595);
            this.gbRaspored.ResumeLayout(false);
            this.gbRaspored.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRaspored;
        private System.Windows.Forms.DataGridView dgvRaspored;
        private System.Windows.Forms.Button btnIzbrisiRaspored;
        private System.Windows.Forms.Button btnDodajRaspored;
        private System.Windows.Forms.TextBox txtVremePocetka;
        private System.Windows.Forms.ComboBox cbDan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.Button btnDodajGrupu;
        private System.Windows.Forms.MonthCalendar mcDatumPocetka;
        private System.Windows.Forms.ListBox lbKursevi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNazivGrupe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}
