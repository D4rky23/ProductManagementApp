using System.Windows;
using ProductManagementApp.ViewModels;

namespace ProductManagementApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ProductViewModel();
        }
    }
}
