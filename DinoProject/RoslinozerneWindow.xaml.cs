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
        /// Ta metody obsługują zdarzenie, które poprzez
        /// wskazanie kursorem myszki pokazuje informacje
        /// o wskazanym obiekcie.
        /// </summary>
        private void Brachiosaurus_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(0, detaleBrachiosaurus, opisBrachiosaurus, borderBrachiosaurus, tabRoslinnych);
        }

        private void Parasaurolophus_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(2, detaleParasaurolophus, opisParasaurolophus, borderParasaurolophus, tabRoslinnych);
        }

        private void Triceratops_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(1, detaleTriceratops, opisTriceratops, borderTriceratops, tabRoslinnych);
        }

        private void Ouranosaurus_MouseEnter(object sender, MouseEventArgs e)
        {
            Dinozaur.PokazInformacje(3, detaleOuranosaurus, opisOuranosaurus, borderOuranosaurus, tabRoslinnych);
        }

        /// <summary>
        /// Ta metoda obsługuje zdarzenie, które powoduje
        /// ukrycie wcześniej pokazanych informacji
        /// </summary>
        private void BorderBrachiosaurus_MouseLeave(object sender, MouseEventArgs e)
        {
            borderBrachiosaurus.Visibility = Visibility.Hidden;
        }

        private void BorderTriceratops_MouseLeave(object sender, MouseEventArgs e)
        {
            borderTriceratops.Visibility = Visibility.Hidden;
        }

        private void BorderParasaurolophus_MouseLeave(object sender, MouseEventArgs e)
        {
            borderParasaurolophus.Visibility = Visibility.Hidden;
        }

        private void BorderOuranosaurus_MouseLeave(object sender, MouseEventArgs e)
        {
            borderOuranosaurus.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// Umożliwia przejście do okienka głownego.
        /// </summary>
        private void Button_Powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
