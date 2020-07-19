using System;
using System.Collections.Generic;
using System.IO;
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

namespace DinoProject
{
    /// <summary>
    /// W klasie znajduje się logika obsługi zdarzeń
    /// a także wypełnienie pól dla klasy Roslinozerne
    /// </summary>
    public partial class RoslinozerneWindow : Window
    {
        
        Dinozaur[] tabRoslinnych = new Dinozaur[4];
		
		/// <summary>
        /// Konstruktor <c> RoslinnozerneWindow</c> inicjalizuje
		/// pola klasy Miesozerca danymi z plików tekstowych
        /// </summary>
      
        public RoslinozerneWindow()
        {
            InitializeComponent();
           
            for (int i = 0; i < tabRoslinnych.Length; i++)
            {
                tabRoslinnych[i] = new Roslinnozerne(File.ReadLines((Roslinnozerne.plikDetaleR.ElementAt(i))).Skip(0).Take(1).First(),
                                                    File.ReadLines((Roslinnozerne.plikDetaleR.ElementAt(i))).Skip(1).Take(1).First(),
                                                    File.ReadLines((Roslinnozerne.plikDetaleR.ElementAt(i))).Skip(2).Take(1).First(),
                                                    File.ReadLines((Roslinnozerne.plikDetaleR.ElementAt(i))).Skip(3).Take(1).First(),
                                                    File.ReadLines((Roslinnozerne.plikDetaleR.ElementAt(i))).Skip(4).Take(1).First(),
                                                    File.ReadLines((Roslinnozerne.plikDetaleR.ElementAt(i))).Skip(5).Take(1).First());

            }

        }
         /// <summary>
        /// Metoda <c>Brachiosaurus_MouseEnter</c> wywołuje statyczną metodę z klasy Dinozaur,
		/// która wyświetl informacje o dinozaurze
        /// </summary>
        public void Brachiosaurus_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(0, detaleBrachiosaurus, opisBrachiosaurus, borderBrachiosaurus, tabRoslinnych);
        }
		/// <summary>
        /// Metoda <c>Parasaurolophus_MouseEnter</c> wywołuje statyczną metodę z klasy Dinozaur,
		/// która wyświetl informacje o dinozaurze
        /// </summary>

        public void Parasaurolophus_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(2, detaleParasaurolophus, opisParasaurolophus, borderParasaurolophus, tabRoslinnych);
        }
		/// <summary>
        /// Metoda <c>Triceratops_MouseEnter</c> wywołuje statyczną metodę z klasy Dinozaur,
		/// która wyświetl informacje o dinozaurze
        /// </summary>
        public void Triceratops_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(1, detaleTriceratops, opisTriceratops, borderTriceratops, tabRoslinnych);
        }
		/// <summary>
        /// Metoda <c>Ouranosaurus_MouseEnter</c> wywołuje statyczną metodę z klasy Dinozaur,
		/// która wyświetl informacje o dinozaurze
        /// </summary>
        public void Ouranosaurus_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(3, detaleOuranosaurus, opisOuranosaurus, borderOuranosaurus, tabRoslinnych);
        }

         /// <summary>
		/// Metoda <c>BorderBrachiosaurus_MouseLeave</c> ukrywa informacje o Dinozaurze
		/// po wyjechaniu kursorem poza ramkę
        /// </summary>
        public void BorderBrachiosaurus_MouseLeave(object sender, MouseEventArgs e)
        {
            borderBrachiosaurus.Visibility = Visibility.Hidden;
        }
		/// <summary>
		/// Metoda <c>BorderTriceratops_MouseLeave</c> ukrywa informacje o Dinozaurze
		/// po wyjechaniu kursorem poza ramkę
        /// </summary>
        public void BorderTriceratops_MouseLeave(object sender, MouseEventArgs e)
        {
            borderTriceratops.Visibility = Visibility.Hidden;
        }
		/// <summary>
		/// Metoda <c>BorderParasaurolophus_MouseLeave</c> ukrywa informacje o Dinozaurze
		/// po wyjechaniu kursorem poza ramkę
        /// </summary>
        public void BorderParasaurolophus_MouseLeave(object sender, MouseEventArgs e)
        {
            borderParasaurolophus.Visibility = Visibility.Hidden;
        }
		/// <summary>
		/// Metoda <c>BorderOuranosaurus_MouseLeave</c> ukrywa informacje o Dinozaurze
		/// po wyjechaniu kursorem poza ramkę
        /// </summary>
        public void BorderOuranosaurus_MouseLeave(object sender, MouseEventArgs e)
        {
            borderOuranosaurus.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// Umożliwia przejście do okienka głownego.
        /// </summary>
		
        /// <summary>
        /// Metoda <c> Button_Powrot</c> Umożliwia przejście do okienka głownego.
        /// </summary>
        public void Button_Powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
