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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DinoProject
{
    /// <summary>
    /// Okienko główne aplikacji.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
       
        /// <summary>
        /// Metoda <c> Drapizniki_MouseRightButtonDown</c> Umożliwia przejście do Drapieżniki.
        /// </summary>
        public void Drapizniki_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            DrapieznikiWindow drapiezniki = new DrapieznikiWindow();
            drapiezniki.Show();
        }
		/// <summary>
        /// Metoda <c> Roslinozerne_MouseRightButtonDown</c> Umożliwia przejście do Roślinożerne.
        /// </summary>
        public void Roslinozerne_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            RoslinozerneWindow roslinozerne = new RoslinozerneWindow();
            roslinozerne.Show();
        }

        /// <summary>
        /// Metoda <c> Stworz_MouseLeftButtonDown</c> Umożliwia przejście do Tworzenie Dinozaura.
        /// </summary>
        public void Stworz_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            StworzDino stworzDino = new StworzDino();
            stworzDino.Show();
        }
		
		 /// <summary>
        /// Metoda <c> Zagraj_MouseLeftButtonDown</c> Umożliwia przejście do mini-gierki.
        /// </summary>
		public void Zagraj_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            DinoGra dinoGra = new DinoGra();
            dinoGra.Show();
        }
    }
}
