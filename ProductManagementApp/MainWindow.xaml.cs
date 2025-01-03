using ProductManagementApp.Models;
using System.Linq;
using System.Windows;

namespace ProductManagementApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TestDatabaseConnection();
        }

        private void TestDatabaseConnection()
        {
            using (var context = new ProductContext())
            {
                // Citim produsele din baza de date
                               var products = context.Products.ToList();

                // Afișăm un mesaj cu numărul de produse găsite
                MessageBox.Show($"Found {products.Count} products in the database.");
            }
        }
    }
}
