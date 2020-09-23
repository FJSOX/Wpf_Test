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

namespace Wpf_Test
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //new1.DataContext = new SetN() { };
            this.DataContext = new MainViewMode1();
        }

        private void click_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sb");
            
        }

        

        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }
    }

    public class SetN
    {
        private string Name { get; set; }
    }
}
