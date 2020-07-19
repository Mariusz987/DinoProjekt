using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Threading;

namespace DinoProject
{
    /// <summary>
    /// Klasa <c> DinoGra</c> definjująca mini-gierke
    /// </summary>
    public partial class DinoGra : Window
    {
        
		/// <summary>Zmienne <c>graczKw, podlozeKw, przeszkodaKw</c> posłużą
        /// do umieszczenia grafik i wykrywania kolizji .</summary>
		DispatcherTimer gameTimer = new DispatcherTimer();

        
        
		Rect graczKw;
        Rect podlozeKw;
        Rect przeszkodaKw;

        bool skok;
        // jak wysoko może skoczyć dinozaur
        int wysokosc = 20;
        // jak szybko będzie skakał
        int szybkosc = 5;
        Random rand = new Random();
        bool koniecGry = false;

        ImageBrush gracz2 = new ImageBrush();
        ImageBrush przeszkoda2 = new ImageBrush();
        ImageBrush pZdj= new ImageBrush();
        ImageBrush gZdj = new ImageBrush();

        // losowe pozycje dla przeszkody
        int[] przeszkodaPozycja = { 320, 310, 300, 305, 315 };

        int wynik = 0;
		
		/// <summary>Konstruktor <c>DinoGra</c> inicjalizuje elementy gry.</summary>
        public DinoGra()
        {
            InitializeComponent();
            Canvas.Focus();
            gameTimer.Tick += graLogika;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            GraStart();
        }
        /// <summary>
        /// Metoda <c> Canvas_KeyDown</c> ta wznawia grę po skuciu
        /// </summary>
        public void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && koniecGry)
            {
                GraStart();
            }

        }
        /// <summary>
        /// Metoda <c> Canvas_KeyUp</c> przechwytuje naciśnięcie klawisza spacji
        /// i tym samy umożliwia skok
        /// </summary>
        public void Canvas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space && !skok && Canvas.GetTop(gracz) > 260)
            {
                skok = true;
                wysokosc = 15;
                szybkosc = -12;
            }
        }
        /// <summary>
        /// Metoda  <c> GraStart</c> ustawia pozycje początkową gracza a także przeszkody
        /// ustawie skok na false - gracz nie sakcze
        /// </summary>
        public void GraStart()
        {
          
            Canvas.SetLeft(gracz, 110);
            Canvas.SetTop(gracz, 140);

            Canvas.SetLeft(przeszkoda, 950);
            Canvas.SetTop(przeszkoda, 310);
            przeszkoda2.ImageSource = new BitmapImage(new Uri("pack://application:,,,/obrazki/kamien.png"));
            przeszkoda.Fill = przeszkoda2;
            gracz2.ImageSource = new BitmapImage(new Uri("pack://application:,,,/obrazki/gracz.png"));
            gracz.Fill = gracz2;
            skok = false;
            koniecGry = false;
            wynik = 0;
            pktText.Content = "Punkty: " + wynik;

            gameTimer.Start();
        }
        /// <summary>
        /// Metoda  <c> graLogika</c> odpowiedzialna za logikę gry,
        /// sprawdza kolizję między graczem a przeszkodą
        /// ustawia parametry skoku
        /// </summary>
        public void graLogika(Object sender, EventArgs e)
        {

            Canvas.SetTop(gracz, Canvas.GetTop(gracz) + szybkosc);
            Canvas.SetLeft(przeszkoda, Canvas.GetLeft(przeszkoda) - 12);

            pktText.Content = "Punkty: " + wynik;

            graczKw = new Rect(Canvas.GetLeft(gracz), Canvas.GetTop(gracz), gracz.Width, gracz.Height);
            podlozeKw = new Rect(Canvas.GetLeft(ziemia), Canvas.GetTop(ziemia), ziemia.Width, ziemia.Height);
            przeszkodaKw = new Rect(Canvas.GetLeft(przeszkoda), Canvas.GetTop(przeszkoda), przeszkoda.Width, przeszkoda.Height);

            if (graczKw.IntersectsWith(podlozeKw))
            {
                szybkosc = 0;
                Canvas.SetTop(gracz, Canvas.GetTop(ziemia) - gracz.Height);
                skok = false;
            }

            if (graczKw.IntersectsWith(przeszkodaKw))
            {
                koniecGry = true;
                gameTimer.Stop();
            }
            if (skok)
            {
                szybkosc = -12;
                wysokosc--;
            }
            else
            {
                szybkosc = 12;
            }
            if (wysokosc < 0)
            {
                skok = false;
            }


            if (Canvas.GetLeft(przeszkoda) < -50)
            {
                Canvas.SetLeft(przeszkoda, 950);
                Canvas.SetTop(przeszkoda, przeszkodaPozycja[rand.Next(0, przeszkodaPozycja.Length)]);
                wynik += 1;
            }

            if (koniecGry)
            {
                MessageBox.Show("Koniec gry zdobyłeś " + pktText.Content + ". Wciśnij Enter, żeby zagrać jescze raz.");
            }
        }
        /// <summary>
        /// Metoda  <c> Button_Powrot </c> umożliwia przejście do okienka DinoGra.
        /// </summary>
        public void Button_Powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }
    }
}
