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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button btn1 = new Button();
            btn1.Height = 100;
            btn1.Width = 100;
            btn1.Content = "VbButton";
            
            this.grid1.Children.Add(btn1);
            btn1.Click += btn_Click;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            btn.Content = "I changed";
        }
    }
}