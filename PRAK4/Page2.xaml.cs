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

namespace PRAK4
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(TextBox1.Text, out int n)) MessageBox.Show("Поле только для чисел");
            switch (n)
            {
                case 20: TextBox2.Text += "Двадцать лет"; break;
                case 21: TextBox2.Text += "Двадцать один год,"; break;
                case 22: TextBox2.Text += "Двадцать два года"; break;
                case 23: TextBox2.Text += "Двадцать три года"; break;
                case 24: TextBox2.Text += "Двадцать четыре года"; break;
                case 25: TextBox2.Text += "Двадцать пять лет"; break;
                case 26: TextBox2.Text += "Двадцать шесть лет"; break;
                case 27: TextBox2.Text += "Двадцать семь лет"; break;
                case 28: TextBox2.Text += "Двадцать восемь лет"; break;
                case 29: TextBox2.Text += "Двадцать девять лет"; break;
                case 30: TextBox2.Text += "Тридцать лет"; break;
                case 31: TextBox2.Text += "Тридцать один год"; break;
                case 32: TextBox2.Text += "Тридцать два года"; break;
                case 33: TextBox2.Text += "Тридцать три года"; break;
                case 34: TextBox2.Text += "Тридцать четыре года"; break;
                case 35: TextBox2.Text += "Тридцать пять лет"; break;
                case 36: TextBox2.Text += "Тридцать шесть лет"; break;
                case 37: TextBox2.Text += "Тридцать семь лет"; break;
                case 38: TextBox2.Text += "Тридцать восемь лет"; break;
                case 39: TextBox2.Text += "Тридцать девять лет"; break;
                case 40: TextBox2.Text += "Сорок лет"; break;
                case 41: TextBox2.Text += "Сорок один год"; break;
                case 42: TextBox2.Text += "Сорок два года"; break;
                case 43: TextBox2.Text += "Сорок три года"; break;
                case 44: TextBox2.Text += "Сорок четыре года"; break;
                case 45: TextBox2.Text += "Сорок пять лет"; break;
                case 46: TextBox2.Text += "Сорок шесть лет"; break;
                case 47: TextBox2.Text += "Сорок семь лет"; break;
                case 48: TextBox2.Text += "Сорок восемь лет"; break;
                case 49: TextBox2.Text += "Сорок девять лет"; break;
                case 50: TextBox2.Text += "Пятьдесят лет"; break;
                case 51: TextBox2.Text += "Пятьдесят один год"; break;
                case 52: TextBox2.Text += "Пятьдесят два года"; break;
                case 53: TextBox2.Text += "Пятьдесят три года"; break;
                case 54: TextBox2.Text += "Пятьдесят четыре года"; break;
                case 55: TextBox2.Text += "Пятьдесят пять лет"; break;
                case 56: TextBox2.Text += "Пятьдесят шесть лет"; break;
                case 57: TextBox2.Text += "Пятьдесят семь лет"; break;
                case 58: TextBox2.Text += "Пятьдесят восемь лет"; break;
                case 59: TextBox2.Text += "Пятьдесят девять лет"; break;
                case 60: TextBox2.Text += "Шестьдесят лет"; break;
                case 61: TextBox2.Text += "Шестьдесят один год"; break;
                case 62: TextBox2.Text += "Шестьдесят два года"; break;
                case 63: TextBox2.Text += "Шестьдесят три года"; break;
                case 64: TextBox2.Text += "Шестьдесят четыре года"; break;
                case 65: TextBox2.Text += "Шестьдесят пять лет"; break;
                case 66: TextBox2.Text += "Шестьдесят шесть лет"; break;
                case 67: TextBox2.Text += "Шестьдесят семь лет"; break;
                case 68: TextBox2.Text += "Шестьдесят восемь лет"; break;
                case 69: TextBox2.Text += "Шестьдесят девять лет"; break;
                default: TextBox2.Text += "Неправильный возраст";
                    return;
            }
        }
    }
}
