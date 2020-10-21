using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eShop.DataStore.HardCoded
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products;

        public ProductRepository()
        {
            products = new List<Product>
            {
                new Product { Id = 2, Type = "Streamshare", Name = "Premium HD Video Streamshare", Price= 5.99, Description= "Netflix is a streaming service that offers a wide variety of award-winning TV programmes, films, anime, documentaries and more – on thousands of internet-connected devices.You can watch as much as you want, whenever you want, without a single advert – all for one low monthly price. There’s always something new to discover, and new TV programmes and films are added every week!", ImageLink="https://go5050.co.uk/wp-content/uploads/2020/07/gfffavicon-min.png"},
                new Product { Id = 3, Type = "Streamshare", Name = "Sport Pass Cinema Pass", Price= 5.99, Description= "Watch the latest movies, tv shows, live sports and kids entertainment live and on demand.", ImageLink="https://go5050.co.uk/wp-content/uploads/2020/08/ces-prod.png"}

            };
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetProducts(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter)) return products;

            return products.Where(x => x.Name.ToLower().Contains(filter.ToLower()));
        }
    }
}
