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
using System.Threading;
using System.IO;
using System.Windows.Media.Animation;

namespace DinoProject
{
    /// <summary>
    /// W klasie  <c>DrapieznikiWindow</c> znajduje się logika obsługi zdarzeń
    /// a także wypełnienie pól dla klasy Miesozerne
    /// </summary>
    

public partial class DrapieznikiWindow : Window
    {

        Miesozerne [] tabDrapieznikow = new Miesozerne[5];
		
		/// <summary>
        /// Konstruktor <c> DrapieznikiWindow</c> inicjalizuje
		/// pola klasy Miesozerca danymi z plików tekstowych
        /// </summary>
        
        public DrapieznikiWindow()
        {
            InitializeComponent();
           

            for (int i = 0; i < tabDrapieznikow.Length; i++)
            {
                tabDrapieznikow[i] = new Miesozerne(File.ReadLines((Miesozerne.plikDetaleM.ElementAt(i))).Skip(0).Take(1).First(),
                                                    File.ReadLines((Miesozerne.plikDetaleM.ElementAt(i))).Skip(1).Take(1).First(),
                                                    File.ReadLines((Miesozerne.plikDetaleM.ElementAt(i))).Skip(2).Take(1).First(),
                                                    File.ReadLines((Miesozerne.plikDetaleM.ElementAt(i))).Skip(3).Take(1).First(),
                                                    File.ReadLines((Miesozerne.plikDetaleM.ElementAt(i))).Skip(4).Take(1).First(),
                                                    File.ReadLines((Miesozerne.plikDetaleM.ElementAt(i))).Skip(5).Take(1).First());
               
            }
           

        }
        /// <summary>
        /// Metoda <c>TRex_MouseEnter</c> wywołuje statyczną metodę z klasy Dinozaur,
		/// która wyświetl informacje o dinozaurze
        /// </summary>
        public void TRex_MouseEnter(object sender, MouseEventArgs e)
        {
        
            Dinozaur.PokazInformacje(3, detaleTrex, opisTrex, borderTrex, tabDrapieznikow);     
        }
		/// <summary>
        /// Metoda <c>Spinosaurus_MouseEnter</c> wywołuje statyczną metodę z klasy Dinozaur,
		/// która wyświetl informacje o dinozaurze
        /// </summary>
        public void Spinosaurus_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(2, detaleSpinosaurus, opisSpinosaurus, borderSpinosaurus, tabDrapieznikow);
        }
		/// <summary>
        /// Metoda <c>Guanlong_MouseEnter</c> wywołuje statyczną metodę z klasy Dinozaur,
		/// która wyświetl informacje o dinozaurze
        /// </summary>
        public void Guanlong_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(0, detaleGuanlong, opisGuanlong, borderGuanlong, tabDrapieznikow);
        }
		/// <summary>
        /// Metoda <c>Pterosaurus_MouseEnter</c> wywołuje statyczną metodę z klasy Dinozaur,
		/// która wyświetl informacje o dinozaurze
        /// </summary>
        public void Pterosaurus_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(1, detalePterosaurus, opisPterosaurus, borderPterosaurus,tabDrapieznikow);
        }
		/// <summary>
        /// Metoda <c>Velociraptor_MouseEnter</c> wywołuje statyczną metodę z klasy Dinozaur,
		/// która wyświetl informacje o dinozaurze
        /// </summary>
        public void Velociraptor_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(4, detaleVelociraptor, opisVelociraptor, borderVelociraptor, tabDrapieznikow);
        }

        /// <summary>
		/// Metoda <c>BorderTRex_MouseLeave</c> ukrywa informacje o Dinozaurze
		/// po wyjechaniu kursorem poza ramkę
        /// </summary>
        public void BorderTRex_MouseLeave(object sender, MouseEventArgs e)
        {
            borderTrex.Visibility = Visibility.Hidden;
          
        }
		/// <summary>
		/// Metoda <c>BorderVelociraptor</c> ukrywa informacje o Dinozaurze
		/// po wyjechaniu kursorem poza ramkę
        /// </summary>
        public void BorderVelociraptor_MouseLeave(object sender, MouseEventArgs e)
        {
            borderVelociraptor.Visibility = Visibility.Hidden;
        }
		/// <summary>
		/// Metoda <cBorderGuanlong_MouseLeave</c> ukrywa informacje o Dinozaurze
		/// po wyjechaniu kursorem poza ramkę
        /// </summary>
        public void BorderGuanlong_MouseLeave(object sender, MouseEventArgs e)
        {
            borderGuanlong.Visibility = Visibility.Hidden;
        }
		/// <summary>
		/// Metoda <c>BorderSpinosaurus_MouseLeave</c> ukrywa informacje o Dinozaurze
		/// po wyjechaniu kursorem poza ramkę
        /// </summary>
        public void BorderSpinosaurus_MouseLeave(object sender, MouseEventArgs e)
        {
            borderSpinosaurus.Visibility = Visibility.Hidden;
        }
		/// <summary>
		/// Metoda <c>BorderPterosaurus_MouseLeave</c> ukrywa informacje o Dinozaurze
		/// po wyjechaniu kursorem poza ramkę
        /// </summary>
        public void BorderPterosaurus_MouseLeave(object sender, MouseEventArgs e)
        {
            borderPterosaurus.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Metoda <c> Button_Powrot</c> Umożliwia przejście do okienka głownego.
        /// </summary>
        public void Button_Powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow oknoGlowne = new MainWindow();
            oknoGlowne.Show();
        }
    }

}
