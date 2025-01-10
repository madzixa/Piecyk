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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturaPokojuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTempWykres)).BeginInit();
            this.SuspendLayout();
            // 
            // temperaturaPokojuBar
            // 
            this.temperaturaPokojuBar.BackColor = System.Drawing.Color.Pink;
            this.temperaturaPokojuBar.LargeChange = 1;
            this.temperaturaPokojuBar.Location = new System.Drawing.Point(866, 15);
            this.temperaturaPokojuBar.Maximum = 40;
            this.temperaturaPokojuBar.Minimum = -10;
            this.temperaturaPokojuBar.Name = "temperaturaPokojuBar";
            this.temperaturaPokojuBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.temperaturaPokojuBar.Size = new System.Drawing.Size(45, 234);
            this.temperaturaPokojuBar.TabIndex = 0;
            this.temperaturaPokojuBar.Scroll += new System.EventHandler(this.temperaturaPokojuBar_Scroll);
            // 
            // tempPokText
            // 
            this.tempPokText.BackColor = System.Drawing.Color.Pink;
            this.tempPokText.Enabled = false;
            this.tempPokText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tempPokText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tempPokText.Location = new System.Drawing.Point(599, 15);
            this.tempPokText.Name = "tempPokText";
            this.tempPokText.Size = new System.Drawing.Size(167, 23);
            this.tempPokText.TabIndex = 1;
            this.tempPokText.Text = "Temperatura docelowa";
            this.tempPokText.TextChanged += new System.EventHandler(this.tempPokText_TextChanged);
            // 
            // aktualnaTempPok
            // 
            this.aktualnaTempPok.AutoSize = true;
            this.aktualnaTempPok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aktualnaTempPok.Location = new System.Drawing.Point(782, 22);
            this.aktualnaTempPok.Name = "aktualnaTempPok";
            this.aktualnaTempPok.Size = new System.Drawing.Size(30, 16);
            this.aktualnaTempPok.TabIndex = 4;
            this.aktualnaTempPok.Text = "0°C";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.richTextBox1.Location = new System.Drawing.Point(12, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(321, 475);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // tempZewText
            // 
            this.tempZewText.Enabled = false;
            this.tempZewText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempZewText.Location = new System.Drawing.Point(599, 69);
            this.tempZewText.Name = "tempZewText";
            this.tempZewText.Size = new System.Drawing.Size(167, 23);
            this.tempZewText.TabIndex = 14;
            this.tempZewText.Text = "Temperatura na zewnątrz:";
            // 
            // aktualnaTempZew
            // 
            this.aktualnaTempZew.AutoSize = true;
            this.aktualnaTempZew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aktualnaTempZew.Location = new System.Drawing.Point(782, 72);
            this.aktualnaTempZew.Name = "aktualnaTempZew";
            this.aktualnaTempZew.Size = new System.Drawing.Size(30, 16);
            this.aktualnaTempZew.TabIndex = 15;
            this.aktualnaTempZew.Text = "0°C";
            this.aktualnaTempZew.Click += new System.EventHandler(this.aktualnaTempZew_Click);
            // 
            // tempWewText
            // 
            this.tempWewText.Enabled = false;
            this.tempWewText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempWewText.Location = new System.Drawing.Point(599, 121);
            this.tempWewText.Name = "tempWewText";
            this.tempWewText.Size = new System.Drawing.Size(167, 23);
            this.tempWewText.TabIndex = 16;
            this.tempWewText.Text = "Temperatura wewnątrz:";
            // 
            // aktualnaTempWew
            // 
            this.aktualnaTempWew.AutoSize = true;
            this.aktualnaTempWew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aktualnaTempWew.Location = new System.Drawing.Point(782, 128);
            this.aktualnaTempWew.Name = "aktualnaTempWew";
            this.aktualnaTempWew.Size = new System.Drawing.Size(30, 16);
            this.aktualnaTempWew.TabIndex = 17;
            this.aktualnaTempWew.Text = "0°C";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightPink;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "WIOSNA",
            "LATO",
            "JESIEŃ",
            "ZIMA"});
            this.comboBox1.Location = new System.Drawing.Point(365, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Text = "   ";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_Pory);
            // 
            // aTempWykres
            // 
            this.aTempWykres.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            chartArea7.Name = "ChartArea1";
            this.aTempWykres.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.aTempWykres.Legends.Add(legend7);
            this.aTempWykres.Location = new System.Drawing.Point(353, 268);
            this.aTempWykres.Name = "aTempWykres";
            this.aTempWykres.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.aTempWykres.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Crimson};
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            series7.LabelAngle = 1;
            series7.Legend = "Legend1";
            series7.MarkerSize = 1;
            series7.Name = "TabelaWew";
            this.aTempWykres.Series.Add(series7);
            this.aTempWykres.Size = new System.Drawing.Size(558, 249);
            this.aTempWykres.TabIndex = 19;
            this.aTempWykres.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(367, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Wybierz porę roku:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(367, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Moc Grzania:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(367, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(367, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Brak";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Piecyk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(923, 529);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

