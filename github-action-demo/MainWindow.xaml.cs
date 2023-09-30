using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace github_action_demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class People
    {
        private string nameValue;
        public string Name
        {
            get => nameValue; 
            set => nameValue = value;
        }
    }

    public partial class MainWindow : Window
    {

        People people = new People() { Name = "Larry" };

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = people;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lblShow.Dispatcher.Invoke(delegate
            {
                lblShow.Content = $"Hello, {people.Name}!";
            });
        }
    }
}
