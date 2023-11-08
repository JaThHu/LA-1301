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
using bulettenRurg;

namespace bulettenRurg
{
    /// <summary>
    /// Interaktionslogik für StartScreen.xaml
    /// </summary>
    public partial class StartScreen : Window
    {
        public StartScreen()
        {
            InitializeComponent();
            
            
            
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();   
            mainWindow.Show();
            this.Close();
        }

        private void TutorialButton_Click(object sender, RoutedEventArgs e)
        {
            Tutorial Tutorial = new Tutorial();
            Tutorial.Show();
            this.Close();

           
        }
    }
}
