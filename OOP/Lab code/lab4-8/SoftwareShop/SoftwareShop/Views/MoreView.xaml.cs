using SoftwareShop.Models;
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

namespace SoftwareShop.Views
{
    /// <summary>
    /// Логика взаимодействия для MoreView.xaml
    /// </summary>
    public partial class MoreView : Window
    {
        public MoreView(Product product)
        {
            InitializeComponent();
            DataContext = product;
        }
    }
}
