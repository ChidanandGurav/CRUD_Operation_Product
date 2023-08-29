using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation_Product
{
    public class Program
    {
        static void Main(string[] args)
        {
            int No = 0;
            ProductCURD curd = new ProductCURD();

            do
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Product List");
                Console.WriteLine("2. Get Product By Id");
                Console.WriteLine("3. Add Product");
                Console.WriteLine("4. Update Product");
                Console.WriteLine("5. Delete Product");
                Console.WriteLine("Select your option");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                        case 1:
                        List<Product>list=curd.GetProducts();
                        Console.WriteLine("Id\t    Name\t    Price\t    Company\t");
                        foreach(Product pro in list)
                        {
                            Console.WriteLine($"{pro.Id}\t    {pro.Name}\t    {pro.Price}\t   {pro.Company}");
                        }
                        break;
//_____________________________________________________________________________________________________________________________


                        case 2:
                        Console.WriteLine("Enter the Product Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Product p = curd.GetProductById(id);
                        Console.WriteLine("Id\t    Name\t    Price\t    Company\t");
                        Console.WriteLine($"{p.Id}\t  {p.Name}\t  {p.Price}\t  {p.Company}");
                        break;
//_____________________________________________________________________________________________________________________________


                       case 3:
                        Product p1 = new Product();
                        Console.WriteLine("Enter Product_Id");
                        p1.Id =Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product_Name");
                        p1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Product_Price");
                        p1.Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product_Company");
                        p1.Company= Console.ReadLine();
                        curd.AddProduct(p1);
                        Console.WriteLine("Save Product");
                        break;
//_____________________________________________________________________________________________________________________________


                        case 4:
                        Product p2 = new Product();
                        Console.WriteLine("Enter Product_Id");
                        p2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product_Name");
                        p2.Name = Console.ReadLine();
                        Console.WriteLine("Enter Product_Price");
                        p2.Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product_Company");
                        p2.Company = Console.ReadLine();
                        curd.UpdateProduct(p2);
                        Console.WriteLine("Product Update");
                        break;
//_____________________________________________________________________________________________________________________________


                        case 5:
                        Console.WriteLine("Enter Product_Id");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        curd.DeleteProduct(id2);
                        Console.WriteLine($"{id2} Product Deleted..");
                        break;
                }

                Console.WriteLine("Press 1 for contine");
                No = Convert.ToInt32(Console.ReadLine());
            }
            while (No == 1);
        }
    }
}
