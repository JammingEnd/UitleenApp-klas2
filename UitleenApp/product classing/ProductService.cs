using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UitleenApp.product_classing
{
    public class ProductService
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            products = DummyDB.productsFromDB;

            return products;

        }

        public List<Product> GetProductsFiltered(string catergory)
        {
            List<Product> products = new List<Product>();

            products = DummyDB.productsFromDB;
            products = products.AsEnumerable().Where(product => product.Category.Contains(catergory)).ToList();


            return products;
        }

        public void UpdateProduct(Product product)
        {

           

        }
        public Product GetProductByID(string ID)
        {
            Product GetItem = DummyDB.productsFromDB.AsEnumerable().Where(product => product.ID.Contains(ID)).FirstOrDefault();
            
            GetItem.remark = "boi boi boi";
            
            
            return GetItem;
        }
        public void PostProduct(Product item)
        {
            DummyDB.productsFromDB.Add(item);
        }

        public void IniDB()
        {
            DummyDB dummy = new DummyDB();
            dummy.IniDummyBD();
        }
    }

    internal class DummyDB
    {
       public static List<Product> productsFromDB = new List<Product>();


       private string[] names = new[] { "Camera", "Lego Mindstorms", "Serverkast", "Beeldscherm" };
       private string[] IDs = new[] { "101i_", "202i_", "303i_", "404i_" };
       private string[] Catergies = new[] { "cam", "lego", "server", "screen" };
       private string nullFilling = "-";

        private int[] productIndexing = new[] {0,0,0,0 };
        public void IniDummyBD()
        {
       
           Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                Product newItem = new Product();
                int itemindex = random.Next(names.Length);
                AssingIndexing(itemindex);
                newItem.Name = names[itemindex];
                AssignProduct(newItem, itemindex);
                productsFromDB.Add(newItem);
            }
            Debug.Output($"{productsFromDB.Count} product in the dummy database");

        }
        void AssingIndexing(int index)
        {
            if(index == 0)
            {
                productIndexing[index]++;
                return;
            }
            if (index == 1)
            {
                productIndexing[index]++;
                return;
            }
            if (index == 2)
            {
                productIndexing[index]++;
                return;
            }
            if (index == 3)
            {
                productIndexing[index]++;
                return;
            }

        }
        void AssignProduct(Product item, int Index)
        {
            item.Category = Catergies[Index];

            item.ID = $"{IDs[Index]}{productIndexing[Index]}";
            item.Description = nullFilling;
            item.Status = nullFilling;
            item.remark = nullFilling;
        }
    }
}
