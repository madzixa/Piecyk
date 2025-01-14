﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektPieca
{
    public partial class Piecyk : Form
    {
        float Wyjscie = 20.0f;
        private bool isRunning = false;
        private string currentRunningSeason = null;
        float mocGrz = 0.00f;

        int delay = 1000;

        public Piecyk()
        {
            InitializeComponent();
            button1.Click += new EventHandler (button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void temperaturaPokojuBar_Scroll(object sender, EventArgs e)
        {
            aktualnaTempPok.Text = "" + temperaturaPokojuBar.Value + "°C";
        }

        private async void ComboBox1_Pory(object sender, EventArgs e)
        {
            string wybranaOpcja = comboBox1.SelectedItem.ToString();

            if (currentRunningSeason == wybranaOpcja)
                return;

            currentRunningSeason = wybranaOpcja;

            int wczytaj;
            bool TemperaturaBool;
            int[] tablicaTemperatur = File.ReadLines(@"PORY.txt")
                .Select(n =>
                {
                    TemperaturaBool = int.TryParse(n, out wczytaj);
                    return new { wczytaj, TemperaturaBool };
                })
                .Where(x => x.TemperaturaBool)
                .Select(x => x.wczytaj).ToArray();

            int pora = 1;
            int pora_koniec = 100;

                switch (wybranaOpcja)
                {
                    case "WIOSNA":
                        pora = 1;
                        pora_koniec = 100;
                        break;
                    case "LATO":
                        pora = 112;
                        pora_koniec = 212;
                        break;
                    case "JESIEŃ":
                        pora = 224;
                        pora_koniec = 324;
                        break;
                    case "ZIMA":
                        pora = 336;
                        pora_koniec = 436;
                        break;
                    default:
                        pora = 1;
                        pora_koniec = 100;
                        break;
                }
            isRunning = true;

            for (int i = pora; i <= pora_koniec; i++)
            {
                if (currentRunningSeason != wybranaOpcja)
                {
                    Console.WriteLine("Zatrzymano pętlę dla " + wybranaOpcja);
                    isRunning = false;
                    return; 
                }

                aktualnaTempZew.Text = tablicaTemperatur[i].ToString();
                Rozmycie();

                await Task.Delay(delay);
            }
            isRunning = false;
        }

        public void Rozmycie()
        {
            int TemZew = Convert.ToInt32(aktualnaTempZew.Text);

            int TempBar = Convert.ToInt32(temperaturaPokojuBar.Value);
            float Roznica = TempBar - Wyjscie;

            float uBDuza = 0.00f;
            float uDuza = 0.00f;
            float uSrednia = 0.00f;
            float uMala = 0.00f;
            float uBMala = 0.00f;
            float DanaTemp = temperaturaPokojuBar.Value;

            // Bardzo Mała 
            if (Roznica <= 0)
                uBMala =  1;
            else
             if (Roznica > 0 && Roznica < 2)
                uBMala =  (2 - Roznica) / 2;
            else
                uBMala = 0;

            // Mała 
            if (Roznica >= 1 && Roznica <= 3)
                uMala =  (Roznica - 1) / 2;
            else
            if (Roznica >= 3 && Roznica <= 4)
                uMala = 1;
            else 
            if(Roznica >= 4 && Roznica <= 6)
                uMala = (6 - Roznica) / 2;
            else
                uMala =  0;

            // Srednia 
            if (Roznica >= 5 && Roznica <= 7)
                uSrednia = (Roznica - 5) / 2;
            else
            if (Roznica >= 7 && Roznica <= 8)
                uSrednia = 1;
            else
            if (Roznica >= 8 && Roznica <= 10)
                uSrednia = (10 - Roznica) / 2;
            else
                uSrednia = 0;

            // Duża 
            if (Roznica >= 9 && Roznica <= 11)
                uDuza =  (Roznica - 9) / 2;
            else
                if (Roznica >= 11 && Roznica <= 12)
                uDuza = 1;
            else
            if (Roznica >= 12 && Roznica <= 14)
                uDuza = (14 - Roznica) / 2;
            else
                uDuza =  0;

            // Bardzo  Duża 
            if (Roznica >= 13 && Roznica <= 15)
                uBDuza = (Roznica - 13) / 2;
            else
                if (Roznica >= 15)
                uBDuza = 1;
            else
                uBDuza = 0;

                 
            float A = uBDuza;
            float B = uDuza;
            float C = uSrednia;
            float D = uMala;
            float E = uBMala;

            float maks = System.Math.Max(System.Math.Max(System.Math.Max(A, B), System.Math.Max(C, D)),E);

            if (A == maks)
            { mocGrz = 1f; }
            else if (B == maks)
            { mocGrz = 0.75f; }
            else if (C == maks)
            { mocGrz = 0.5f; }
            else if (D == maks)
            { mocGrz = 0.25f; }
            else if (E == maks)
            { mocGrz = 0f; }

            Grzanie(mocGrz);
            Przenikanie(Wyjscie, TemZew);
            WykresTwew();
            WyswietlMocGrzania();
        }

        public void Grzanie(float MmocGrz)
        {
            float value = (1500 * MmocGrz * 600) / (61.25f * 1005);
            Wyjscie += value;           
        }

        public void Przenikanie(float tWew, int tZew)
        {
            float wspolczynnikPrzewodzenia = 0.1f;
            float deltaTemperatura = tWew - tZew;
            float Q = wspolczynnikPrzewodzenia * 12.5f * deltaTemperatura * 600;
            float dT = Q / (61.25f*1005);
            tWew -= dT;
            Wyjscie = tWew;

            aktualnaTempWew.Text = Wyjscie.ToString();
            richTextBox1.AppendText("Temperatura pokoju: " + Wyjscie + "\n");
        }

        public void WykresTwew()
        {
            float x = float.Parse(aktualnaTempWew.Text);
            float x2 = float.Parse(aktualnaTempZew.Text);
            int y = 0;
            if (50 > x)
            {
                aTempWykres.Series["TabelaWew"].Points.AddXY(y, x);
            }
        } 

        public void WyswietlMocGrzania()
        {
            string grz;

            switch (mocGrz)
            {
                case 1f:
                    grz = "Max";
                    break;
                case 0.75f:
                    grz = "Duża";
                    break;
                case 0.5f:
                    grz = "Średnia";
                    break;
                case 0.25f:
                    grz = "Mała";
                    break;
                case 0f:
                    grz = "Brak";
                    break;
                default:
                    grz = "Brak";
                    break;
            }
            label4.Text = grz;
        }
        private void Piecyk_Load(object sender, EventArgs e)
        {

        }

        private void tempPokText_TextChanged(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void aktualnaTempZew_Click(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------

    }
}

