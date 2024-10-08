namespace Client
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.prijavaNaKursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajNoviKursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaKursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeKursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(602, 523);
            this.pnlMain.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 223);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Škola stranih jezika ,,Svet\"";
            // 
            // mnMain
            // 
            this.mnMain.BackColor = System.Drawing.Color.BurlyWood;
            this.mnMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijavaNaKursToolStripMenuItem,
            this.kursToolStripMenuItem,
            this.grupaToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(602, 30);
            this.mnMain.TabIndex = 3;
            this.mnMain.Text = "menuStrip1";
            // 
            // prijavaNaKursToolStripMenuItem
            // 
            this.prijavaNaKursToolStripMenuItem.Name = "prijavaNaKursToolStripMenuItem";
            this.prijavaNaKursToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.prijavaNaKursToolStripMenuItem.Text = "Prijava";
            // 
            // kursToolStripMenuItem
            // 
            this.kursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajNoviKursToolStripMenuItem,
            this.izmenaKursaToolStripMenuItem,
            this.brisanjeKursaToolStripMenuItem});
            this.kursToolStripMenuItem.Name = "kursToolStripMenuItem";
            this.kursToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.kursToolStripMenuItem.Text = "Kurs";
            this.kursToolStripMenuItem.Visible = false;
            // 
            // kreirajNoviKursToolStripMenuItem
            // 
            this.kreirajNoviKursToolStripMenuItem.Name = "kreirajNoviKursToolStripMenuItem";
            this.kreirajNoviKursToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.kreirajNoviKursToolStripMenuItem.Text = "Kreiraj novi kurs";
            // 
            // izmenaKursaToolStripMenuItem
            // 
            this.izmenaKursaToolStripMenuItem.Name = "izmenaKursaToolStripMenuItem";
            this.izmenaKursaToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.izmenaKursaToolStripMenuItem.Text = "Izmena kursa";
            // 
            // brisanjeKursaToolStripMenuItem
            // 
            this.brisanjeKursaToolStripMenuItem.Name = "brisanjeKursaToolStripMenuItem";
            this.brisanjeKursaToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.brisanjeKursaToolStripMenuItem.Text = "Brisanje kursa";
            // 
            // grupaToolStripMenuItem
            // 
            this.grupaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajGrupuToolStripMenuItem,
            this.izmeniGrupuToolStripMenuItem});
            this.grupaToolStripMenuItem.Name = "grupaToolStripMenuItem";
            this.grupaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.grupaToolStripMenuItem.Text = "Grupa";
            this.grupaToolStripMenuItem.Visible = false;
            // 
            // dodajGrupuToolStripMenuItem
            // 
            this.dodajGrupuToolStripMenuItem.Name = "dodajGrupuToolStripMenuItem";
            this.dodajGrupuToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.dodajGrupuToolStripMenuItem.Text = "Dodaj grupu";
            // 
            // izmeniGrupuToolStripMenuItem
            // 
            this.izmeniGrupuToolStripMenuItem.Name = "izmeniGrupuToolStripMenuItem";
            this.izmeniGrupuToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.izmeniGrupuToolStripMenuItem.Text = "Izmeni grupu";
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 553);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.mnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Škola jezika ,,Svet\"";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem kursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajNoviKursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaKursaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeKursaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijavaNaKursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajGrupuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniGrupuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}