using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DinoProject
{
    /// <summary>Klasa <c>Dinozaur</c> umożliwia utworzenie obiektu Dinozaur.
    /// </summary>
    public class Dinozaur
    {
        /// <value>Właściwość <c>Nazwa</c> przechowuje nazwe dinozaura.</value>
       public string Nazwa { get; set; }
        /// <value>Właściwość <c>NazwaNaukowa</c> przechowuje nazwe naukowa dinozaura.</value>
       public string NazwaNaukowa { get; set; }
        /// <value>Właściwość <c>Masa</c> przechowuje mase dinozaura.</value>
       public string Masa { get; set; }
        /// <value>Właściwość <c>Wzrost</c> przechowuje wzrost dinozaura.</value>
        public string Wzrost { get; set; }
        /// <value>Właściwość <c>Dlugosc</c> przechowuje długość dinozaura.</value>
        public string Dlugosc { get; set; }
        /// <value>Właściwość <c>Rzad</c> przechowuje rzad, do którego należy dinozaur.</value>
        public string Rzad { get; set; }

        /// <summary>Konstruktor inicjalizuje obiekt Dinozaur parametrami
        ///    (<paramref name="nazwa"/>,<paramref name="nazwanaukowa"/>,<paramref name="masa"/>,
        ///     <paramref name="wzrost"/>),<paramref name="dlugosc"/>,<paramref name="rzad"/>.</summary>
     
        public Dinozaur(string nazwa, string nazwanaukowa, string masa,string wzrost, string dlugosc, string rzad)
        {
            this.Nazwa = nazwa;
            this.NazwaNaukowa = nazwanaukowa;
            this.Masa = masa;
            this.Wzrost = wzrost;
            this.Dlugosc = dlugosc;
            this.Rzad = rzad;

        }
        public Dinozaur() { }

        ///<summary>Ta metoda służy do wyświetlania informacji o obiekcie.</summary>
        /// <param><c>nrDrapiznika</c> służy do poprawnego dodania obiektu do tablicy.</param>
        /// <param><c>textDetale</c> przechwytuje informacje, które będą później wyświetlone.</param>
        /// <param><c>textOpis</c> przyjmuję informacje na temat opisu.</param>
        /// <param><c>border</c> ustawia element border, jako widoczny.</param>
        /// <param><c>tabDino</c>przechowuje obiekty typu Dinozaur.</param>
        static public void PokazInformacje(int nrDrapiznika, TextBlock textDetale, TextBlock textOpis, Border border, Dinozaur [] tabDino)
        {
            textDetale.Text = "Nazwa: " + tabDino[nrDrapiznika].Nazwa + "\n" +
                              "Nazwa Naukowa: " + tabDino[nrDrapiznika].NazwaNaukowa + "\n" +
                              "Masa: " + tabDino[nrDrapiznika].Masa + "\n" +
                              "Wielkość: " + tabDino[nrDrapiznika].Wzrost + "\n" +
                              "Długość: " + tabDino[nrDrapiznika].Dlugosc + "\n" +
                              "Rząd: " + tabDino[nrDrapiznika].Rzad;

            for (int i = 0; i < tabDino.Length; i++)
            {
                if (tabDino[i] is Miesozerne)
                    textOpis.Text = File.ReadAllText(Miesozerne.plikOpisM.ElementAt(nrDrapiznika));
                else
                    textOpis.Text = File.ReadAllText(Roslinnozerne.plikOpisR.ElementAt(nrDrapiznika)); ;
            }
            border.Visibility = Visibility.Visible;
        }
        /// <summary>Metoda sprawdza, czy przesłany parametr jest liczbą
        /// jeśli nie ustawia wartość domyślną
        /// <example>Na przykład:
        /// <code>
        ///    string znak = "4o4";
        ///    Dinozaur.sprawdzZnaki(znak);
        /// </code>
        /// Wynik <c>znak</c> będzie miał wartoś domyślną 50.
        /// </example>
        /// </summary>
        static public void sprawdzZnaki(ref string znaki)
        {
            if (znaki == "")
                znaki = "50";
            else
            {
                for (int i = 0; i < znaki.Length; i++)
                {
                    if (!Char.IsDigit(znaki[i]))
                    {
                        znaki = "50";
                    }

                }
            }
        }
    }
}
