using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace bulettenRurg
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int geld = 0;
        int wette=0;
        int rouletteZahl;

        
        int guessedNumber;

        public MainWindow()
        {

            InitializeComponent();
            GeldFrage.Visibility = Visibility.Visible;
            WieVieleGelder.Visibility = Visibility.Visible;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {


        }
        
        
        private void WieVieleGelder_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.Enter)
            {
                    try
                    {
                    
                        geld = Convert.ToInt32(WieVieleGelder.Text);
                        Geld.Text = Convert.ToString("Chips: " + geld);
                        WieVieleGelder.Visibility = Visibility.Hidden;
                        GeldFrage.Visibility = Visibility.Hidden;  
                    }
                    catch
                    {
                        MessageBox.Show("Bitte schreibe nur zahlen");
                        WieVieleGelder.Clear();     
                        
                    }
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool tryCatch = false;
            


            try
            {
                wette = Convert.ToInt32(Wette.Text);
                rouletteZahl = Convert.ToInt32(GerateneZahl.Text);
                
                    geld -= wette;
                    Geld.Text = Convert.ToString("Chips: " + geld);
                    tryCatch = true;
                    
            }

            catch
            {
                MessageBox.Show("Bitte schreibe nur Zahlen in die Wette und Wettzahl.");
                Wette.Clear();
                GerateneZahl.Clear();

            }
            while (tryCatch == true)
            {
                

                if (rouletteZahl >36| rouletteZahl < 0)
                {
                    MessageBox.Show("Man kann nur auf zahlen zwischen 1 und 36 wetten");
                    GerateneZahl.Clear();

                    
                    tryCatch = false;
                    

                }

                while (tryCatch == true)
                {
                    tryCatch = false;
                    int nummer = new Random().Next(0, 37);
                    if (nummer == rouletteZahl)
                    {

                        MessageBox.Show("Wow, du bist ein Gewinner, dein Gewinn beläuft sich auf sage und schreibe "+wette*36+" Chips.");
                        geld = geld + wette * 36;
                        Geld.Text = Convert.ToString("Chips: " + geld);



                    }
                    else
                    {
                        MessageBox.Show("Das war wohl kein Gewinn, denn es war die Nummer: " + nummer);
                        if (geld - wette < 0)
                        {
                            MessageBox.Show("Da hast du wohl alles verspielt, das wars dann wohl.");
                            Environment.Exit(0);
                        }


                    }
                }
            }
        
        }

        private void Wette_KeyDown(object sender, KeyEventArgs e)     {
            
        }
    }
}
