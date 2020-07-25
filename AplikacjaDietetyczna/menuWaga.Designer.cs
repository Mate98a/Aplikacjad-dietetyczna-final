namespace AplikacjaDietetyczna
{
    partial class menuWaga
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textWaga2 = new System.Windows.Forms.TextBox();
            this.bazadanych = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bwagaDataSet = new AplikacjaDietetyczna.bwagaDataSet();
            this.bwagaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bwagaDataSet1 = new AplikacjaDietetyczna.bwagaDataSet1();
            this.bwagaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.menuPoradyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bazadanych)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bwagaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bwagaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bwagaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bwagaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPoradyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 50);
            this.panel1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Historia wagi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.usuwanie);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Wstaw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BWstaw);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(80, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Waga:";
            // 
            // textWaga2
            // 
            this.textWaga2.Location = new System.Drawing.Point(146, 105);
            this.textWaga2.Name = "textWaga2";
            this.textWaga2.Size = new System.Drawing.Size(106, 20);
            this.textWaga2.TabIndex = 26;
            // 
            // bazadanych
            // 
            this.bazadanych.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bazadanych.Location = new System.Drawing.Point(272, 56);
            this.bazadanych.Name = "bazadanych";
            this.bazadanych.Size = new System.Drawing.Size(357, 139);
            this.bazadanych.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(108, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Id:";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(146, 69);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(106, 20);
            this.textId.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "*przy usuwaniu wymagane Id";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.bwagaDataSet;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(21, 215);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Waga";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(608, 216);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // bwagaDataSet
            // 
            this.bwagaDataSet.DataSetName = "bwagaDataSet";
            this.bwagaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bwagaDataSetBindingSource
            // 
            this.bwagaDataSetBindingSource.DataSource = this.bwagaDataSet;
            this.bwagaDataSetBindingSource.Position = 0;
            // 
            // bwagaDataSet1
            // 
            this.bwagaDataSet1.DataSetName = "bwagaDataSet1";
            this.bwagaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bwagaDataSet1BindingSource
            // 
            this.bwagaDataSet1BindingSource.DataSource = this.bwagaDataSet1;
            this.bwagaDataSet1BindingSource.Position = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Załaduj wykres";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Zaladuj);
            // 
            // menuPoradyBindingSource
            // 
            this.menuPoradyBindingSource.DataSource = typeof(AplikacjaDietetyczna.menuPorady);
            // 
            // menuWaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bazadanych);
            this.Controls.Add(this.textWaga2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "menuWaga";
            this.Size = new System.Drawing.Size(648, 457);
            this.Load += new System.EventHandler(this.menuWaga_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bazadanych)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bwagaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bwagaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bwagaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bwagaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPoradyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textWaga2;
        private System.Windows.Forms.DataGridView bazadanych;
        private System.Windows.Forms.BindingSource menuPoradyBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource bwagaDataSetBindingSource;
        private bwagaDataSet bwagaDataSet;
        private System.Windows.Forms.BindingSource bwagaDataSet1BindingSource;
        private bwagaDataSet1 bwagaDataSet1;
        private System.Windows.Forms.Button button3;
    }
}
