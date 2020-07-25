namespace AplikacjaDietetyczna
{
    partial class menuLosuj
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuLosuj));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Losowanie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textwskazowka = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 50);
            this.panel1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Losowanie wskazówki";
            // 
            // Losowanie
            // 
            this.Losowanie.BackColor = System.Drawing.Color.Black;
            this.Losowanie.FlatAppearance.BorderSize = 0;
            this.Losowanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Losowanie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Losowanie.ForeColor = System.Drawing.Color.White;
            this.Losowanie.Image = ((System.Drawing.Image)(resources.GetObject("Losowanie.Image")));
            this.Losowanie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Losowanie.Location = new System.Drawing.Point(235, 56);
            this.Losowanie.Name = "Losowanie";
            this.Losowanie.Size = new System.Drawing.Size(184, 54);
            this.Losowanie.TabIndex = 21;
            this.Losowanie.Text = "  Kliknij i wylosuj!";
            this.Losowanie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Losowanie.UseVisualStyleBackColor = false;
            this.Losowanie.Click += new System.EventHandler(this.Losowaniewsk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(129, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Twoja losowa wskazówka na teraz to:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // textwskazowka
            // 
            this.textwskazowka.BackColor = System.Drawing.Color.Transparent;
            this.textwskazowka.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textwskazowka.ForeColor = System.Drawing.Color.White;
            this.textwskazowka.Location = new System.Drawing.Point(55, 374);
            this.textwskazowka.Name = "textwskazowka";
            this.textwskazowka.Size = new System.Drawing.Size(551, 28);
            this.textwskazowka.TabIndex = 24;
            this.textwskazowka.Text = "???";
            this.textwskazowka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuLosuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Controls.Add(this.textwskazowka);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Losowanie);
            this.Controls.Add(this.panel1);
            this.Name = "menuLosuj";
            this.Size = new System.Drawing.Size(648, 457);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Losowanie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textwskazowka;
    }
}
