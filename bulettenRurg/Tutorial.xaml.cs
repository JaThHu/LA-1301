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

namespace bulettenRurg
{
    /// <summary>
    /// Interaktionslogik für Tutorial.xaml
    /// </summary>
    public partial class Tutorial : Window
    {
        public Tutorial()
        {
            InitializeComponent();
        }

        private void tutorialEnde_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow= new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
