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

namespace WpfApp13
{
    /// <summary>
    /// Логика взаимодействия для WindowPerson.xaml
    /// </summary>
    public partial class WindowPerson : Window
    {
        public WindowPerson(Person p)
        {
            InitializeComponent();
            FIO.Text = p.fio;
            VOZR.Text = p.voz;
            Rost.Text = p.rost.ToString();
            Weight.Text = p.ves.ToString();

        }
        public WindowPerson()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        public string getFio()
        {
            return FIO.Text;
        }

        public string getVozr()
        {
            return VOZR.Text;
        }

        public int getRost()
        {
            return int.Parse(Rost.Text);
        }

        public int getWeight()
        {
            return int.Parse(Weight.Text);
        }
        public string getAmp()
        {
            return FIO.Text;
        }
    }
}
