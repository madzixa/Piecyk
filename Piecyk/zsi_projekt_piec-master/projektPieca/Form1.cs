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
            float temp_in = TempBar - Wyjscie;

            float uZimno = 0.00f;
            float uLetnio = 0.00f;
            float uCieplo = 0.00f;
            float uGoraco = 0.00f;
            float DanaTemp = temperaturaPokojuBar.Value;

            // Zimno 
            if (temp_in >= -10 && temp_in <= 5)
                uZimno =  1;

            else
             if (temp_in > 5 && temp_in < 15)
                uZimno =  (15 - temp_in) / 10;
            else
                uZimno = 0;



            // Letnio 
            if (temp_in >= 5 && temp_in <= 15)
                uLetnio =  (temp_in - 5) / 10;
            else
            if (temp_in >= 15 && temp_in <= 25)
                uLetnio =  (25 - temp_in) / 10;
            else
                uLetnio =  0;




            // Cieplo 
            if (temp_in >= 15 && temp_in <= 25)
                uCieplo = (temp_in - 15) / 10;
            else
           if (temp_in >= 25 && temp_in <= 35)
                uCieplo =  (35 - temp_in) / 10;
            else
                uCieplo =  0;



            // Goraco 
            if (temp_in >= 25 && temp_in <= 35)
                uGoraco =  (temp_in - 25) / 10;
            else
                  if (temp_in >= 35 && temp_in <= 40)
                uGoraco = 1;
            else
                uGoraco =  0;

            System.Console.WriteLine("uZimno: " + uZimno + "; uLetnio :" + uLetnio + "; uCieplo :" + uCieplo + "; uGoraco :" + uGoraco);

            // Wnioskowanie

            float SWu = 0.00f;
            float sW = 0.00f;

            float A = System.Math.Min(uZimno, DanaTemp);
            float B = System.Math.Min(uLetnio, DanaTemp);
            float C = System.Math.Min(uCieplo, DanaTemp);
            float D = System.Math.Min(uGoraco, DanaTemp);


            SWu = uZimno * A + uLetnio * B + uCieplo * C + uGoraco  * D ;
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

