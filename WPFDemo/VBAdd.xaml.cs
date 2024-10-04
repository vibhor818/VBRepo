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

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for VBAdd.xaml
    /// </summary>
    public partial class VBAdd : UserControl
    {
        public VBAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            txtSum.Text=(Convert.ToInt32(txtFirst.Text)+Convert.ToInt32(txtSecond.Text)).ToString();
        }
    }
}
