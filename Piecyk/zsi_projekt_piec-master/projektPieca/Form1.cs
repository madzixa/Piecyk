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

        //public async Task GeneratorTemp_Zima()
        //{
        //    int wczytaj;
        //    bool TemperaturaBool;
        //    int[] tablicaTemperatur = File.ReadLines(@"Zima.txt")
        //        .Select(n =>
        //        {
        //            TemperaturaBool = int.TryParse(n,out wczytaj);
        //            return new { wczytaj, TemperaturaBool };
        //        })
        //        .Where(x => x.TemperaturaBool)
        //        .Select(x => x.wczytaj).ToArray();
        //    for (int i = 1; i < tabSize; i++)
        //    {

        //        if (aktualnaPoraRoku != "ZIMA")
        //            return;


        //        await Task.Delay(delay);
        //        aktualnaTempZew.Text = tablicaTemperatur[i].ToString();
        //        Rozmycie();
              
        //    }
        //}






      
        /// ////////////////////////////////////////////////////////////////////////////
     /*

        int wczytaj;
        bool TemperaturaBool;
        int[] tablicaTemperatur = File.ReadLines(@"Zima.txt")
            .Select(n =>
            {
                TemperaturaBool = int.TryParse(n, out wczytaj);
                return new { wczytaj, TemperaturaBool };
            })
            .Where(x => x.TemperaturaBool)
            .Select(x => x.wczytaj).ToArray();








            await Task.Delay(delay);
            aktualnaTempZew.Text = tablicaTemperatur[i].ToString();
            Rozmycie();
        */








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






        



        






        /// /////////////////////////////////////////////////////////////////













        //public async Task GeneratorTemp_Wiosna()
        //{
        //    int wczytaj;
        //    bool TemperaturaBool;
        //    int[] tablicaTemperatur = File.ReadLines(@"Wiosna.txt")
        //        .Select(n =>
        //        {
        //            TemperaturaBool = int.TryParse(n, out wczytaj);
        //            return new { wczytaj, TemperaturaBool };
        //        })
        //        .Where(x => x.TemperaturaBool)
        //        .Select(x => x.wczytaj).ToArray();
        //    for (int i = 1; i < tabSize; i++)
        //    {

        //        if (aktualnaPoraRoku != "WIOSNA")
        //            return;

        //        await Task.Delay(delay);
        //        aktualnaTempZew.Text = tablicaTemperatur[i].ToString();
        //        Rozmycie();
              
        //    }
        //}

        //public async Task GeneratorTemp_Lato()
        //{
        //    int wczytaj;
        //    bool TemperaturaBool;
        //    int[] tablicaTemperatur = File.ReadLines(@"Lato.txt")
        //        .Select(n =>
        //        {
        //            TemperaturaBool = int.TryParse(n, out wczytaj);
        //            return new { wczytaj, TemperaturaBool };
        //        })
        //        .Where(x => x.TemperaturaBool)
        //        .Select(x => x.wczytaj).ToArray();
        //    for (int i = 1; i < tabSize; i++)
        //    {


        //        if (aktualnaPoraRoku != "LATO")
        //            return;


        //        await Task.Delay(delay);
        //        aktualnaTempZew.Text = tablicaTemperatur[i].ToString();
        //        Rozmycie();
        //    }
        //}

        //public async Task GeneratorTemp_Jesien()
        //{
        //    int wczytaj;
        //    bool TemperaturaBool;
        //    int[] tablicaTemperatur = File.ReadLines(@"Jesien.txt")
        //        .Select(n =>
        //        {
        //            TemperaturaBool = int.TryParse(n, out wczytaj);
        //            return new { wczytaj, TemperaturaBool };
        //        })
        //        .Where(x => x.TemperaturaBool)
        //        .Select(x => x.wczytaj).ToArray();
        //    for (int i = 1; i < tabSize; i++)
        //    {

        //        if (aktualnaPoraRoku != "JESIEŃ")
        //            return;



        //        await Task.Delay(delay);
        //        aktualnaTempZew.Text = tablicaTemperatur[i].ToString();
        //        Rozmycie();
        //    }
        //}

        //public async Task GeneratorTemp_Stala()
        //{
        //    int tablicaTemperatur = 20;
            
        //    for (int i = 1; i < 100; i++)
        //    {
        //        if (aktualnaPoraRoku != "STAŁA")
        //            return;


        //        await Task.Delay(delay);
        //        aktualnaTempZew.Text = tablicaTemperatur.ToString();
        //        Rozmycie();
               
        //    }
        //}

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

            float SWu = 0.00f;
            float sW = 0.00f;

            float A = System.Math.Min(uBDuza, DanaTemp);
            float B = System.Math.Min(uDuza, DanaTemp);
            float C = System.Math.Min(uSrednia, DanaTemp);
            float D = System.Math.Min(uMala, DanaTemp);


            SWu = uBDuza * A + uDuza * B + uSrednia * C + uMala  * D ;
            sW = A + B + C + D + 0.01f; /////
            //Wyostrzenie

            float wyostrzenie = 0.00f;
            wyostrzenie = (SWu / sW);

            Grzanie(wyostrzenie, DanaTemp);
            oziebianie(Wyjscie, TemZew);
            WykresTwew(); 
        }
        public void oziebianie(float Wyjscie, int TemZew)
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

        public void Grzanie(float wyostrzenie, float DanaTemp)
        {
            wyostrzenie = wyostrzenie / 100f;
            float value = 0f;
           
                value = DanaTemp - wyostrzenie;
                Wyjscie += value / 10f;
            
            //else
            //{
            //    wyostrzenie = (Wyjscie - DanaTemp) - wyostrzenie;
            //    Wyjscie -= (wyostrzenie +0.01f)/ 10f;
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
                aTempZewWykres.Series["TabelaZew"].Points.AddXY(y, x2);
            }
        }

        //------------------------------------------------------------------- CheckBox'y


        //private async void ComboBox1_Pory(object sender, EventArgs e)
        //{

        //    string wybranaOpcja = comboBox1.SelectedItem.ToString();


        //    if (wybranaOpcja == aktualnaPoraRoku)
        //        return;

        //    // Zaktualizuj aktualnie działającą metodę
        //    aktualnaPoraRoku = wybranaOpcja;



        //    switch (wybranaOpcja)
        //    {
        //        case "WIOSNA":
        //           await GeneratorTemp_Wiosna();
        //            break;
        //        case "LATO":
        //            await GeneratorTemp_Lato();
        //            break;
        //        case "JESIEŃ":
        //            await GeneratorTemp_Jesien();
        //            break;
        //        case "ZIMA":
        //            await GeneratorTemp_Zima();
        //            break;
        //        case "STAŁA":
        //            await GeneratorTemp_Stala();
        //            break;
        //        default:
        //            await GeneratorTemp_Stala();
        //            break;
        //    }



        //    aktualnaPoraRoku = null;

        //}







        private void Piecyk_Load(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------

    }
}

