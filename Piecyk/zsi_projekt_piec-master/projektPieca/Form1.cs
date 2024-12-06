using System;
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
        int tabSize = 100;
        float Wyjscie;
        //   float WartoscOziebiania;
        private string aktualnaPoraRoku = null;
        private bool isRunning = false;
        private string currentRunningSeason = null;

        int delay = 2000;

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

            // Jeśli wybrana pora roku jest taka sama, nie rób nic
            if (currentRunningSeason == wybranaOpcja)
                return;

            // Zaktualizuj aktualną porę roku
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
         //  int i = pora;

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
                    case "STAŁA":
                        ///////
                        break;
                    default:
                        pora = 1;
                        pora_koniec = 100;
                        break;
                }




            // Rozpocznij nowe zadanie
            isRunning = true;

            // Uruchom nowe zadanie
            for (int i = pora; i <= pora_koniec; i++)
            {
                // Sprawdź, czy zmieniono porę roku
                if (currentRunningSeason != wybranaOpcja)
                {
                    Console.WriteLine("Zatrzymano pętlę dla " + wybranaOpcja);
                    isRunning = false;
                    return; // Zatrzymaj pętlę
                }




                aktualnaTempZew.Text = tablicaTemperatur[i].ToString();
                Rozmycie();


                await Task.Delay(2000);
                // pora++;


                // Resetuj aktualną porę roku po zakończeniu
                //currentRunningSeason = null;




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
            if (Roznica >= 1 && Roznica <= 2)
                uMala =  (Roznica - 1) / 1;
            else
            if (Roznica >= 2 && Roznica <= 3)
                uMala = 1;
            else 
            if(Roznica >= 3 && Roznica <= 4)
                uMala = (4 - Roznica) / 1;
            else
                uMala =  0;




            // Srednia 
            if (Roznica >= 3 && Roznica <= 4)
                uSrednia = (Roznica - 3) / 1;
            else
            if (Roznica >= 4 && Roznica <= 5)
                uSrednia = 1;
            else
            if (Roznica >= 5 && Roznica <= 6)
                uSrednia = (6 - Roznica) / 1;
            else
                uSrednia = 0;




            // Duża 
            if (Roznica >= 5 && Roznica <= 10)
                uDuza =  (Roznica - 5) / 5;
            else
                if (Roznica >= 10 && Roznica <= 13)
                uDuza = 1;
            else
            if (Roznica >= 13 && Roznica <= 17)
                uDuza = (17 - Roznica) / 4;
            else
                uDuza =  0;



            // Bardzo  Duża 
            if (Roznica >= 13 && Roznica <= 17)
                uBDuza = (Roznica - 13) / 4;
            else
                if (Roznica >= 17)
                uBDuza = 1;
            else
                uBDuza = 0;





            System.Console.WriteLine("uBDuza: " + uBDuza + "; uDuza :" + uDuza + "; uSrednia :" + uSrednia + "; uMala :" + uMala + "; uBMala :" + uBMala);

            // Wnioskowanie
            float mocGrz = 0.00f;
         
            float A = System.Math.Min(uBDuza, DanaTemp);
            float B = System.Math.Min(uDuza, DanaTemp);
            float C = System.Math.Min(uSrednia, DanaTemp);
            float D = System.Math.Min(uMala, DanaTemp);
            float E = System.Math.Min(uBMala, DanaTemp);


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



            // SWu = uBDuza * A + uDuza * B + uSrednia * C + uMala  * D + uBMala * E ;
            //  sW = A + B + C + D + E + 0.01f; /////
            //Wyostrzenie





            Grzanie(mocGrz, DanaTemp);
            PrzewCiep(Wyjscie, TemZew);
            WykresTwew(); 
        }
        public void PrzewCiep(float Wyjscie, int TemZew)
        {


            // Współczynnik przewodzenia ciepła (regulowany na podstawie izolacji)
            float wspolczynnikPrzewodzenia = 0.1f; // Można dostosować np. dla ocieplanych i nieocieplanych pomieszczeń

            // Różnica temperatur między wnętrzem a zewnętrzem
            float deltaTemperatura = Wyjscie - TemZew;

            // Ilość ciepła przenikającego przez ściany
            float Q = wspolczynnikPrzewodzenia * deltaTemperatura;

            // Aktualizacja temperatury wewnętrznej na podstawie przenikania ciepła
            Wyjscie -= Q;


            aktualnaTempWew.Text = Wyjscie.ToString();
            System.Console.WriteLine("Temp: " + aktualnaTempWew.Text);
            richTextBox1.AppendText("Temperatura pokoju: " + Wyjscie + "\n");
        }

        public void Grzanie(float mocGrz, float DanaTemp)
        {
            mocGrz = mocGrz / 100f;
            float value = 0f;
           
                value = DanaTemp - mocGrz;
                Wyjscie += value / 10f;
            
            //else
            //{
            //    mocGrz = (Wyjscie - DanaTemp) - mocGrz;
            //    Wyjscie -= (mocGrz +0.01f)/ 10f;
            //}
            
        }

        public void WykresTwew()
        {
            float x = float.Parse(aktualnaTempWew.Text); 
            float x2 = float.Parse(aktualnaTempZew.Text);
            int y =0;
            if (50 > x)
            {
                
                aTempWykres.Series["TabelaWew"].Points.AddXY(y, x);
        }



        private void Piecyk_Load(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------

    }
}

