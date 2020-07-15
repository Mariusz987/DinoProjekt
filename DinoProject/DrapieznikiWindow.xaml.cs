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
    /// W klasie znajduje się logika obsługi zdarzeń
    /// a także wypełnienie pól dla klasy Miesozerne
    /// </summary>
    

public partial class DrapieznikiWindow : Window
    {

        Miesozerne [] tabDrapieznikow = new Miesozerne[5];
        
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
        /// Ta metody obsługują zdarzenie, które poprzez
        /// wskazanie kursorem myszki pokazuje informacje
        /// o wskazanym obiekcie.
        /// </summary>
        private void TRex_MouseEnter(object sender, MouseEventArgs e)
        {
        
            Dinozaur.PokazInformacje(3, detaleTrex, opisTrex, borderTrex, tabDrapieznikow);     
        }

        private void Spinosaurus_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(2, detaleSpinosaurus, opisSpinosaurus, borderSpinosaurus, tabDrapieznikow);
        }

        private void Guanlong_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(0, detaleGuanlong, opisGuanlong, borderGuanlong, tabDrapieznikow);
        }

        private void Pterosaurus_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(1, detalePterosaurus, opisPterosaurus, borderPterosaurus,tabDrapieznikow);
        }

        private void Velociraptor_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(4, detaleVelociraptor, opisVelociraptor, borderVelociraptor, tabDrapieznikow);
        }

        /// <summary>
        /// Ta metoda obsługuje zdarzenie, które powoduje
        /// ukrycie wcześniej pokazanych informacji
        /// </summary>
        private void BorderTRex_MouseLeave(object sender, MouseEventArgs e)
        {
            borderTrex.Visibility = Visibility.Hidden;
          
        }

        private void BorderVelociraptor_MouseLeave(object sender, MouseEventArgs e)
        {
            borderVelociraptor.Visibility = Visibility.Hidden;
        }

        private void BorderGuanlong_MouseLeave(object sender, MouseEventArgs e)
        {
            borderGuanlong.Visibility = Visibility.Hidden;
        }

        private void BorderSpinosaurus_MouseLeave(object sender, MouseEventArgs e)
        {
            borderSpinosaurus.Visibility = Visibility.Hidden;
        }

        private void BorderPterosaurus_MouseLeave(object sender, MouseEventArgs e)
        {
            borderPterosaurus.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Umożliwia przejście do okienka głownego.
        /// </summary>
        private void Button_Powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow oknoGlowne = new MainWindow();
            oknoGlowne.Show();
        }
    }

}
