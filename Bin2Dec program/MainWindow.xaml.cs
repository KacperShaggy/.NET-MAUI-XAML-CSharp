using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace BinaryConverterWPF
{
    public partial class MainWindow : Window
    {
        private CheckBox[] checkBoxes;

        public MainWindow()
        {
            InitializeComponent();
            checkBoxes = new CheckBox[] { cb0, cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10, cb11, cb12, cb13, cb14, cb15 };
        }

        private void UpdateBinaryFromCheckBoxes()
        {
            string binaryValue = string.Join("", checkBoxes.Select(cb => cb.IsChecked == true ? "1" : "0"));
            txtBinary.Text = Convert.ToInt32(binaryValue, 2).ToString();
            ConvertNumber();
        }

        private void UpdateCheckBoxesFromBinary()
        {
            if (int.TryParse(txtBinary.Text, out int number))  //PROBA KONWERTOWANIA TEXTU NA INTA
            {
                string binaryString = Convert.ToString(number, 2).PadLeft(16, '0'); // STOWRZENIE STRINGA BEDACEGO PUNKTEM WYJSCIOWYM BINARNEJ WERSJI STRINGA



                for (int i = 0; i < checkBoxes.Length; i++)
                {
                    checkBoxes[i].IsChecked = binaryString[i] == '1'; // DO KAZDEGO ZAZNACZONEGO CHECKBOXA PRZYPISUJE SIE 1
                }
            }
            ConvertNumber();
        }

        private void ConvertNumber()
        {
            if (!int.TryParse(txtBinary.Text, out int number)) return; 
            //proba konwerji liczby na inta zeby moc ja przeksztalcic na binarny system, w przypadku niezadzialania tryparse program wywali
            string result = string.Empty;
            // stworzenie efektu tryparse, to znaczy stowrzenie zmiennej ktora bedzie je przechowywac

            switch (cmbConversion.SelectedIndex)
            // switch decydujacy o tym jai tryb comboboxa jest aktualnie wybrany
            {
                case 0: 
                    result = number.ToString();
                    //przypisanie zmiennej result do liczby ktora zostala wprowadzona zeby pozniej moc nia manipulowac
                    break;
                case 1: 
                    result = number.ToString("X");
                    //"X" to specyfikator formatu, który konwertuje liczbę dziesiętną na liczbę szesnastkową. (przypadek przekszalcenia na hex)
                    break;
                case 2: 
                    result = Convert.ToString(number, 16).ToUpper(); //KONWERSJA LICZBY NA SYSTEM SZESNASTKOWY!!!
                    break;
            }
            txtConverted.Text = result; //POLE TEXTBOX DRUGIE PRZYPISUJE SIE DO SKONWERTOWANEJ LICZBY!!!!
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            foreach (var cb in checkBoxes) //metoda przechodzac przez kazda wartosc zmienia jej wartosc bool (czy zaznaczona) na false, w efekcie kazda jest odznaczona
                cb.IsChecked = false;
            txtBinary.Clear();
            txtConverted.Clear(); // CZYSZCZONE SA ROWNIEZ OBA TEXTBOXY
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e) => UpdateBinaryFromCheckBoxes();
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e) => UpdateBinaryFromCheckBoxes();
        private void TxtBinary_TextChanged(object sender, TextChangedEventArgs e) => UpdateCheckBoxesFromBinary();
        private void CmbConversion_SelectionChanged(object sender, SelectionChangedEventArgs e) => ConvertNumber();

        // FUNKCJE ODPOWIADAJACE ZA DZIALANIE APLIKACJI
    }
}
