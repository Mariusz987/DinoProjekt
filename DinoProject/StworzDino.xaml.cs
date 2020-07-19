using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DinoProject
{
    /// <summary>
    /// Klasa  <c> StwórzDino</c> umożliwiająca użytkownikowi stworzenie Dinozaura
    /// </summary>
    public partial class StworzDino : Window
    {
        
        public StworzDino()
        {
            InitializeComponent();

            /// <summary>Zmienna <c>nazwyDino</c> przechowuje nazwy
            ///  dinozaurów i dodaje je do listy rozwijanej.</summary>
            List<string> nazwyDino = new List<string>();
            /// <summary>Zmienna <c>plikiNazwy</c> przechowuje ścieżke 
            ///  do plików tekstowych.</summary>
            List<string> plikiNazwy = Directory.GetFiles("D:/Projekty/DinoProject/DinoProject/text/detale/m").ToList<string>();

            

            for (int i = 0; i < plikiNazwy.Count; i++)
            {
                nazwyDino.Add(File.ReadAllLines(plikiNazwy.ElementAt(i)).Skip(0).Take(1).First());

            }
            lista.ItemsSource = nazwyDino;
        }
        /// <summary>
        /// Ta metoda  <c>Button_Click</c> obsługuje zdarzenie, które poprzez
        /// kliknięcie, tworzy nowego dinozaura.
        /// </summary>
        public void Button_Click(object sender, RoutedEventArgs e)
        {

            string dl = dlugosc.Text;
            string wg = waga.Text;
            Dinozaur.sprawdzZnaki(ref dl);
            dlugosc.Text = dl;
            Dinozaur.sprawdzZnaki(ref wg);
            waga.Text = wg;
            string im = imie.Text;
            if (im == "")
                imie.Text = "Dino";

            string miesozerny = "miesożerny";
            string roslinozerny = "roslinożerny";

            pokaz.Text = "Twój Dinozaur ma na imie " + imie.Text + "\n" +
                         "jego gatunek to " + lista.SelectedValue + "\n" +
                         "ma " + dlugosc.Text + " metrów długości" + "\n" +
                         "i waży " + waga.Text + " ton." + "\n" +
                         "Jest ";


            switch (lista.SelectedIndex)
            {
                case 0:
                    dino.Source = new BitmapImage(new Uri("pack://application:,,,/obrazki/ouranosaurus.png"));
                    pokaz.Text += roslinozerny.ToUpper();
                    break;
                case 1:
                    dino.Source = new BitmapImage(new Uri("pack://application:,,,/obrazki/guanlong.png"));
                    pokaz.Text += miesozerny.ToUpper();
                    break;
                case 2:
                    dino.Source = new BitmapImage(new Uri("pack://application:,,,/obrazki/pterosaurus.png"));
                    pokaz.Text += miesozerny.ToUpper();
                    break;
                case 3:
                    dino.Source = new BitmapImage(new Uri("pack://application:,,,/obrazki/spinosaurus.png"));
                    pokaz.Text += miesozerny.ToUpper();
                    break;
                case 4:
                    dino.Source = new BitmapImage(new Uri("pack://application:,,,/obrazki/tRex.png"));
                    pokaz.Text += miesozerny.ToUpper();
                    break;
                case 5:
                    dino.Source = new BitmapImage(new Uri("pack://application:,,,/obrazki/velociraptorV.png"));
                    pokaz.Text += miesozerny.ToUpper();
                    break;
                case 6:
                    dino.Source = new BitmapImage(new Uri("pack://application:,,,/obrazki/brachiosaurus.png"));
                    pokaz.Text += roslinozerny.ToUpper();
                    break;
                case 7:
                    dino.Source = new BitmapImage(new Uri("pack://application:,,,/obrazki/triceratops.png"));
                    pokaz.Text += roslinozerny.ToUpper();
                    break;
                case 8:
                    dino.Source = new BitmapImage(new Uri("pack://application:,,,/obrazki/parasaurolophusV.png"));
                    pokaz.Text += roslinozerny.ToUpper();
                    break;
                default:
                    pokaz.Text += "Brak danych";
                    break;
            }


        }
        /// <summary>
        /// Metoda <param><c>Button_Click</c></param> Umożliwia przejście do okienka głownego.
        /// </summary>
        public void Button_Powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
