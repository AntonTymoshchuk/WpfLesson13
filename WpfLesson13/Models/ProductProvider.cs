using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLesson13.Models
{
    public class ProductProvider
    {
        public ObservableCollection<Product> GetProducts()
        {
            ObservableCollection<Product> products = new ObservableCollection<Product>()
            {
                new Product() { Id=0, Name="Apple", Price = 12.99 },
                new Product() { Id=1, Name="Pineapple", Price = 19.99 },
                new Product() { Id=2, Name="Dounut", Price = 10.99 }
            };
            return products;
        }
    }
}
