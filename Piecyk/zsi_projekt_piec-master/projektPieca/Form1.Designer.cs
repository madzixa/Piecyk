namespace projektPieca
{
    partial class Piecyk
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.temperaturaPokojuBar = new System.Windows.Forms.TrackBar();
            this.tempPokText = new System.Windows.Forms.TextBox();
            this.aktualnaTempPok = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tempZewText = new System.Windows.Forms.TextBox();
            this.aktualnaTempZew = new System.Windows.Forms.Label();
            this.tempWewText = new System.Windows.Forms.TextBox();
            this.aktualnaTempWew = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.aTempWykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturaPokojuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTempWykres)).BeginInit();
            this.SuspendLayout();
            // 
            // temperaturaPokojuBar
            // 
            this.temperaturaPokojuBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.temperaturaPokojuBar.LargeChange = 1;
            this.temperaturaPokojuBar.Location = new System.Drawing.Point(855, 12);
            this.temperaturaPokojuBar.Maximum = 40;
            this.temperaturaPokojuBar.Minimum = -10;
            this.temperaturaPokojuBar.Name = "temperaturaPokojuBar";
            this.temperaturaPokojuBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.temperaturaPokojuBar.Size = new System.Drawing.Size(56, 234);
            this.temperaturaPokojuBar.TabIndex = 0;
            this.temperaturaPokojuBar.Scroll += new System.EventHandler(this.temperaturaPokojuBar_Scroll);
            // 
            // tempPokText
            // 
            this.tempPokText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tempPokText.Enabled = false;
            this.tempPokText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tempPokText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tempPokText.Location = new System.Drawing.Point(556, 15);
            this.tempPokText.Name = "tempPokText";
            this.tempPokText.Size = new System.Drawing.Size(167, 26);
            this.tempPokText.TabIndex = 1;
            this.tempPokText.Text = "Temperatura pokoju";
            // 
            // aktualnaTempPok
            // 
            this.aktualnaTempPok.AutoSize = true;
            this.aktualnaTempPok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.aktualnaTempPok.Location = new System.Drawing.Point(782, 18);
            this.aktualnaTempPok.Name = "aktualnaTempPok";
            this.aktualnaTempPok.Size = new System.Drawing.Size(37, 20);
            this.aktualnaTempPok.TabIndex = 4;
            this.aktualnaTempPok.Text = "0°C";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.richTextBox1.Location = new System.Drawing.Point(12, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(321, 260);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // tempZewText
            // 
            this.tempZewText.Enabled = false;
            this.tempZewText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempZewText.Location = new System.Drawing.Point(498, 289);
            this.tempZewText.Name = "tempZewText";
            this.tempZewText.Size = new System.Drawing.Size(167, 26);
            this.tempZewText.TabIndex = 14;
            this.tempZewText.Text = "Temperatura na zewnątrz:";
            // 
            // aktualnaTempZew
            // 
            this.aktualnaTempZew.AutoSize = true;
            this.aktualnaTempZew.Location = new System.Drawing.Point(696, 297);
            this.aktualnaTempZew.Name = "aktualnaTempZew";
            this.aktualnaTempZew.Size = new System.Drawing.Size(27, 15);
            this.aktualnaTempZew.TabIndex = 15;
            this.aktualnaTempZew.Text = "0°C";
            // 
            // tempWewText
            // 
            this.tempWewText.Enabled = false;
            this.tempWewText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempWewText.Location = new System.Drawing.Point(498, 363);
            this.tempWewText.Name = "tempWewText";
            this.tempWewText.Size = new System.Drawing.Size(167, 26);
            this.tempWewText.TabIndex = 16;
            this.tempWewText.Text = "Temperatura wewnątrz:";
            // 
            // aktualnaTempWew
            // 
            this.aktualnaTempWew.AutoSize = true;
            this.aktualnaTempWew.Location = new System.Drawing.Point(696, 371);
            this.aktualnaTempWew.Name = "aktualnaTempWew";
            this.aktualnaTempWew.Size = new System.Drawing.Size(27, 15);
            this.aktualnaTempWew.TabIndex = 17;
            this.aktualnaTempWew.Text = "0°C";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "WIOSNA",
            "LATO",
            "JESIEŃ",
            "ZIMA",
            "STAŁA"});
            this.comboBox1.Location = new System.Drawing.Point(565, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Text = "STAŁA";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_Pory);
            // 
            // aTempWykres
            // 
            this.aTempWykres.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            chartArea1.Name = "ChartArea1";
            this.aTempWykres.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.aTempWykres.Legends.Add(legend1);
            this.aTempWykres.Location = new System.Drawing.Point(12, 289);
            this.aTempWykres.Name = "aTempWykres";
            this.aTempWykres.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.aTempWykres.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Crimson};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            series1.LabelAngle = 1;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "TabelaWew";
            this.aTempWykres.Series.Add(series1);
            this.aTempWykres.Size = new System.Drawing.Size(444, 217);
            this.aTempWykres.TabIndex = 19;
            this.aTempWykres.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Piecyk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.aTempWykres);
            this.Controls.Add(this.aktualnaTempWew);
            this.Controls.Add(this.tempWewText);
            this.Controls.Add(this.aktualnaTempZew);
            this.Controls.Add(this.tempZewText);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.aktualnaTempPok);
            this.Controls.Add(this.tempPokText);
            this.Controls.Add(this.temperaturaPokojuBar);
            this.Name = "Piecyk";
            this.Text = "Piecyk";
            this.Load += new System.EventHandler(this.Piecyk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.temperaturaPokojuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTempWykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar temperaturaPokojuBar;
        private System.Windows.Forms.TextBox tempPokText;
        private System.Windows.Forms.Label aktualnaTempPok;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tempZewText;
        private System.Windows.Forms.Label aktualnaTempZew;
        private System.Windows.Forms.TextBox tempWewText;
        private System.Windows.Forms.Label aktualnaTempWew;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart aTempWykres;
        private System.Windows.Forms.Button button1;
    }
}

