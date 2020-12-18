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

namespace WpfApp13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public struct Person
    {
        public string fio;
        public string voz;
        public string amp;
        public int rost;
        public int ves;
    }
    public partial class MainWindow : Window
    {
        Person[] persons;
        int i = 0;
        int count;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(i==0)
            {
                try
                {
                    count = int.Parse(Count.Text);
                    persons = new Person[count];
                    AddPerson();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                AddPerson();
            }
            if(i==count)
            {
                Add.IsEnabled = false;
            }
        }
        public void AddPerson()
        {
            if (i < count)
            {
                WindowPerson window = new WindowPerson();
                if (window.ShowDialog() == true)
                {
                    Person p = new Person();
                    p.fio = window.getFio();
                    p.voz = window.getVozr();
                    p.amp = window.getAmp();
                    p.rost = window.getRost();
                    p.ves = window.getWeight();
                    persons[i] = p;
                    Persons.Items.Add(p.fio);
                }
                i++;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Add.IsEnabled = false;
        }

        private void Count_TextChanged(object sender, TextChangedEventArgs e)
        {
            Add.IsEnabled = true;
        }

        private void Persons_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string f = Persons.SelectedItems[0].ToString();
            Person p;
            for(int i=0;i<count;i++)
            {
                if(persons[i].fio.Equals(f))
                {
                    p = persons[i];
                    WindowPerson w = new WindowPerson(p);
                    w.Show();
                    break;
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            { 
                
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                    {

                        if (persons[i].ves < persons[j].ves)
                        {
                             Person p = new Person();
                            p = persons[i];
                             persons[i] = persons[j];
                              persons[j] = p;
                        }
                    }
                }
            }
                Persons.Items.Clear();

            for (int i = 0; i < count; i++)
            {
                
                
                    if (persons[i].rost > 5)
                    {
                        Persons.Items.Add(persons[i].fio);
                    }
                 
            }

        }
    }
}
