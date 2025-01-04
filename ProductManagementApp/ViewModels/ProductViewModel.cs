using CommunityToolkit.Mvvm.ComponentModel;
using ProductManagementApp.Models;
using System.Collections.ObjectModel;

namespace ProductManagementApp.ViewModels
{
    public class ProductViewModel : ObservableObject
    {
        private ObservableCollection<Product> _products;

        public ObservableCollection<Product> Products
        {
            get => _products;
            set => SetProperty(ref _products, value);
        }

        public ProductViewModel()
        {
            // La inițializare, produsele vor fi încărcate.
            LoadProducts();
        }

        public void LoadProducts()
        {
            // Logica pentru încărcarea produselor, de exemplu dintr-o bază de date
            using (var context = new ProductContext())
            {
                Products = new ObservableCollection<Product>(context.Products);
            }
        }
    }
}
