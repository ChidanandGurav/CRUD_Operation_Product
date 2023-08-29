using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation_Product
{
    public class ProductCURD
    {
        private List<Product> products;

        public ProductCURD()
        {
            products = new List<Product>()
            {
                new Product { Id = 1, Name = "Laptop", Price = 35000, Company = "HP" },
                new Product { Id = 2, Name = "Laptop", Price = 40000, Company = "Dell" }
            };
        }

        public List<Product> GetProducts() // Display the List
        {
            return products;
        }

        public Product GetProductById(int Id) // Get single product
        {
            Product pro = new Product();
            foreach(Product p in products)
            {
                if(p.Id == Id)
                {
                    pro = p;
                    break;
                }
            }
            return pro;
        }

        public void AddProduct(Product p) // Add new Product
        {
            products.Add(p);
        }

        public void UpdateProduct(Product p) // Modify the Details(update)
        {
            foreach(Product item in products)
            {
                //item contains old product data
                if(item.Id == p.Id)
                {
                    item.Name = p.Name;
                    item.Price = p.Price;
                    item.Company = p.Company;
                    break;
                }
            }

        }

        public void DeleteProduct(int Id) // Remove Product(Delete)
        {
          foreach(Product item in products)
            {
                if(item.Id == Id)   
                {
                    products.Remove(item);
                    break;
                }
            }
        }
    }
}
