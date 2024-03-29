using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace EFPractica1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private MAGAZINEEntities context = new MAGAZINEEntities();
        public Window1()
        {
            InitializeComponent();
            CustomersDgr.ItemsSource = context.Customers.ToList();
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow OneWindow = new MainWindow();
            OneWindow.Show();
            Close();
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            Close();
        }
    }
}
