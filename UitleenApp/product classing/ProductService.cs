﻿using System;
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

            //api call of zaoiets


            return products;
        }

        public void UpdateProduct(Product item)
        {


            //api call update

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

        public void IniDummyBD()
        {
       
        Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                Product newItem = new Product();
                int itemindex = random.Next(names.Length);
                newItem.Name = names[itemindex];
                AssignProduct(newItem, itemindex);
                productsFromDB.Add(newItem);
            }
            Debug.Output($"{productsFromDB.Count} product in the dummy database");

        }
        void AssignProduct(Product item, int Index)
        {
            item.Category = Catergies[Index];
            item.ID = IDs[Index];
            item.Description = nullFilling;
            item.Status = nullFilling;
        }
    }
}