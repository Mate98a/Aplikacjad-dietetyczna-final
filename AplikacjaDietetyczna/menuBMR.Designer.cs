namespace AplikacjaDietetyczna
{
    partial class menuBMR
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.textWynik = new System.Windows.Forms.TextBox();
            this.textWzrost = new System.Windows.Forms.TextBox();
            this.textWaga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wiek = new System.Windows.Forms.Label();
            this.textWiek = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.plecK = new System.Windows.Forms.RadioButton();
            this.plecM = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "(w cm)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 50);
            this.panel1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(410, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Podstawowa przemiana materii (BMR)";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(218, 370);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(61, 38);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.reset);
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOblicz.Location = new System.Drawing.Point(285, 370);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.Size = new System.Drawing.Size(201, 38);
            this.buttonOblicz.TabIndex = 16;
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.UseVisualStyleBackColor = true;
            this.buttonOblicz.Click += new System.EventHandler(this.Oblicz);
            // 
            // textWynik
            // 
            this.textWynik.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textWynik.Location = new System.Drawing.Point(218, 275);
            this.textWynik.Multiline = true;
            this.textWynik.Name = "textWynik";
            this.textWynik.ReadOnly = true;
            this.textWynik.Size = new System.Drawing.Size(268, 79);
            this.textWynik.TabIndex = 15;
            // 
            // textWzrost
            // 
            this.textWzrost.Location = new System.Drawing.Point(306, 114);
            this.textWzrost.Name = "textWzrost";
            this.textWzrost.Size = new System.Drawing.Size(180, 20);
            this.textWzrost.TabIndex = 14;
            // 
            // textWaga
            // 
            this.textWaga.Location = new System.Drawing.Point(306, 78);
            this.textWaga.Name = "textWaga";
            this.textWaga.Size = new System.Drawing.Size(180, 20);
            this.textWaga.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(329, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Wynik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(214, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Wzrost:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(214, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Waga:";
            // 
            // wiek
            // 
            this.wiek.AutoSize = true;
            this.wiek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wiek.Location = new System.Drawing.Point(214, 154);
            this.wiek.Name = "wiek";
            this.wiek.Size = new System.Drawing.Size(48, 20);
            this.wiek.TabIndex = 20;
            this.wiek.Text = "Wiek:";
            // 
            // textWiek
            // 
            this.textWiek.Location = new System.Drawing.Point(306, 154);
            this.textWiek.Name = "textWiek";
            this.textWiek.Size = new System.Drawing.Size(180, 20);
            this.textWiek.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(214, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Płeć:";
            // 
            // plecK
            // 
            this.plecK.AutoSize = true;
            this.plecK.Location = new System.Drawing.Point(401, 202);
            this.plecK.Name = "plecK";
            this.plecK.Size = new System.Drawing.Size(61, 17);
            this.plecK.TabIndex = 24;
            this.plecK.TabStop = true;
            this.plecK.Text = "Kobieta";
            this.plecK.UseVisualStyleBackColor = true;
            // 
            // plecM
            // 
            this.plecM.AutoSize = true;
            this.plecM.Checked = true;
            this.plecM.Location = new System.Drawing.Point(306, 202);
            this.plecM.Name = "plecM";
            this.plecM.Size = new System.Drawing.Size(78, 17);
            this.plecM.TabIndex = 23;
            this.plecM.TabStop = true;
            this.plecM.Text = "Mężczyzna";
            this.plecM.UseVisualStyleBackColor = true;
            // 
            // menuBMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.plecK);
            this.Controls.Add(this.plecM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textWiek);
            this.Controls.Add(this.wiek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.textWynik);
            this.Controls.Add(this.textWzrost);
            this.Controls.Add(this.textWaga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "menuBMR";
            this.Size = new System.Drawing.Size(648, 457);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.TextBox textWynik;
        private System.Windows.Forms.TextBox textWzrost;
        private System.Windows.Forms.TextBox textWaga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wiek;
        private System.Windows.Forms.TextBox textWiek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton plecK;
        private System.Windows.Forms.RadioButton plecM;
    }
}
