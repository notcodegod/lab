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

namespace WPF_demo
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

        void initialise()
        {
            button01.FontSize = 40;

        }

        int counter = 0;
        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            label1.Content = $"you clicked {counter}times";
            listbox1.Items.Add($"you clicked {counter}times");




        }

        private void Button02_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Clear();

            counter = 0;
            label1.Content = null;
            
        }
    }
}
