namespace Client.UserControls.UCGrupa
{
    partial class UCRaspored
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvGrupe = new System.Windows.Forms.DataGridView();
            this.cbDan = new System.Windows.Forms.ComboBox();
            this.gbRaspored = new System.Windows.Forms.GroupBox();
            this.btnDodajRaspored = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).BeginInit();
            this.gbRaspored.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 29;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(469, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 22);
            this.textBox3.TabIndex = 31;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(469, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 22);
            this.textBox4.TabIndex = 33;
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
            // dgvGrupe
            // 
            this.dgvGrupe.AllowUserToAddRows = false;
            this.dgvGrupe.AllowUserToDeleteRows = false;
            this.dgvGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupe.Location = new System.Drawing.Point(14, 118);
            this.dgvGrupe.Name = "dgvGrupe";
            this.dgvGrupe.ReadOnly = true;
            this.dgvGrupe.RowHeadersWidth = 51;
            this.dgvGrupe.RowTemplate.Height = 24;
            this.dgvGrupe.Size = new System.Drawing.Size(700, 170);
            this.dgvGrupe.TabIndex = 34;
            // 
            // cbDan
            // 
            this.cbDan.FormattingEnabled = true;
            this.cbDan.Location = new System.Drawing.Point(131, 27);
            this.cbDan.Name = "cbDan";
            this.cbDan.Size = new System.Drawing.Size(121, 24);
            this.cbDan.TabIndex = 35;
            // 
            // gbRaspored
            // 
            this.gbRaspored.Controls.Add(this.btnDodajRaspored);
            this.gbRaspored.Controls.Add(this.textBox4);
            this.gbRaspored.Controls.Add(this.dgvGrupe);
            this.gbRaspored.Controls.Add(this.cbDan);
            this.gbRaspored.Controls.Add(this.label1);
            this.gbRaspored.Controls.Add(this.label3);
            this.gbRaspored.Controls.Add(this.textBox2);
            this.gbRaspored.Controls.Add(this.label5);
            this.gbRaspored.Controls.Add(this.label4);
            this.gbRaspored.Controls.Add(this.textBox3);
            this.gbRaspored.Location = new System.Drawing.Point(34, 263);
            this.gbRaspored.Name = "gbRaspored";
            this.gbRaspored.Size = new System.Drawing.Size(750, 342);
            this.gbRaspored.TabIndex = 37;
            this.gbRaspored.TabStop = false;
            this.gbRaspored.Text = "Raspored";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 170);
            this.dataGridView1.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "naziv grupe:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(154, 32);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(278, 22);
            this.txtPretraga.TabIndex = 40;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(457, 35);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 41;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // UCRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbRaspored);
            this.Name = "UCRaspored";
            this.Size = new System.Drawing.Size(962, 691);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).EndInit();
            this.gbRaspored.ResumeLayout(false);
            this.gbRaspored.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvGrupe;
        private System.Windows.Forms.ComboBox cbDan;
        private System.Windows.Forms.GroupBox gbRaspored;
        private System.Windows.Forms.Button btnDodajRaspored;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretrazi;
    }
}
