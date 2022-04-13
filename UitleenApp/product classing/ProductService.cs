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

        public List<Product> GetProductsFiltered(string categoryRes)
        {
            List<Product> products = new List<Product>();

            products = DummyDB.productsFromDB;
            products = products.AsEnumerable().Where(product => product.Category.catergory.Contains(categoryRes)).ToList();
            return products;
        }


        public void UpdateProduct(Product product)
        {
            Debug.Output(product.ID);
            Product updateItem = DummyDB.productsFromDB.AsEnumerable().Where(Qproduct => Qproduct.ID.Contains(product.ID)).FirstOrDefault();
            updateItem.Name = product.Name;
            updateItem.Status = product.Status;
            updateItem.Category = product.Category;
            updateItem.Description = product.Description;
            updateItem.remark = product.remark;
            updateItem.ID = product.ID;
            Debug.Output($"updated item with ID:{updateItem.ID}");
        }
        public SearchResult<Product> GetProductByID(string ID)
        {
            SearchResult<Product> searchResult = new SearchResult<Product>();

            Product GetItem = DummyDB.productsFromDB.AsEnumerable().Where(product => product.ID.Contains(ID)).FirstOrDefault();
            Debug.Output($"found item with the name:{GetItem.Name}");
            if(GetItem == null)
            {
                searchResult.error = $"no item found with ID: {ID}";
                searchResult.Result = null;
                return searchResult;
            }
            searchResult.Result = GetItem;
            searchResult.error = "no error, item found";

            return searchResult;
        }
        public void PostProduct(Product item)
        {
            DummyDB.productsFromDB.Add(item);
        }

        public void Deleteproduct(string ID)
        {
            DummyDB.productsFromDB.Remove(DummyDB.productsFromDB.AsEnumerable().Where(product => product.ID.Contains(ID)).FirstOrDefault());
           

        }


        //---------------------------------------------------------------


        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();


            return categories;
        }
        public Category GetCategoryById(int Id)
        {
            Category category = new Category();

            return category;
        }

        public void PostCategory(string Category)
        {
            //post C 


        }

        public void UpdateCategory(int Id)
        {
            //update C
        }

        public void DeleteCategory()
        {
            //delete C
        }

        //---------------------------------------------------------------

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
            Category cat = new Category();
            cat.catergory = Catergies[Index];
            item.Category = cat;

            item.ID = $"{IDs[Index]}{productIndexing[Index]}";
            item.Description = nullFilling;
            item.Status = nullFilling;
            item.remark = nullFilling;
        }
    }
}
