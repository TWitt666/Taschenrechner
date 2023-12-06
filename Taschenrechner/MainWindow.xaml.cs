using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Taschenrechner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, RoutedEventArgs e)
        {
           if(int.TryParse(txtboxOperand1.Text, out int Zahl1) &&
               int.TryParse(txtboxOperand2.Text, out int Zahl2)) 
            { 
                string AuswahlOperation = ((ComboBoxItem)comboRechenart.SelectedItem).Content.ToString();
                double result = 0;

                switch(AuswahlOperation) 
                {
                    case "Summieren":
                        result = Mathe.Summe(Zahl1,Zahl2);
                        break;
                    case "Subtrahieren":
                        result = Mathe.Subtraktion(Zahl1, Zahl2);
                        break;
                    case "Multiplizieren":
                        result = Mathe.Multiplikation(Zahl1, Zahl2);
                        break;
                    case "Dividieren":
                        result = Mathe.Division(Zahl1, Zahl2);
                        break;

                    
                }
                txtboxErgebnis.Text = result.ToString();
            }
        }
    }
}