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
        /// Umożliwia przejście do okienka Miesozerne.
        /// </summary>
        private void Drapizniki_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            DrapieznikiWindow drapiezniki = new DrapieznikiWindow();
            drapiezniki.Show();
        }
        /// <summary>
        /// Umożliwia przejście do okienka Roslinozerne.
        /// </summary>
        private void Roslinozerne_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            RoslinozerneWindow roslinozerne = new RoslinozerneWindow();
            roslinozerne.Show();
        }

        /// <summary>
        /// Umożliwia przejście do okienka StworzDino.
        /// </summary>
        private void Stworz_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            StworzDino stworzDino = new StworzDino();
            stworzDino.Show();
        }
    }
}
