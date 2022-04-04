using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UitleenApp.product_classing
{
    public class GenerateID
    {
        private ProductService _productService;
        public GenerateID(ProductService productService)
        {
            _productService = productService;
        }
        public string GenerateIDFunc(string filteritem, HashSet<string> categories)
        {
            Debug.Output(filteritem);
            if (_productService.GetProductsFiltered(filteritem).Count == 0)
            {
                 Debug.Output(categories.Count.ToString());
                return NewIdGroup(categories);

            }
            else
            {
                string lastItemID = _productService.GetProductsFiltered(filteritem).Last().ID;
                Debug.Output($"{lastItemID} ");
                string lastItemintString = lastItemID.Substring(5, lastItemID.Length - 5);
                Debug.Output(lastItemintString);
                int lastItemint = Int32.Parse(lastItemintString);
                int newitemInt = lastItemint + 1;
                string newItemID = $"{lastItemID.Substring(0, lastItemID.Length - lastItemintString.Length)}{newitemInt}";
                Debug.Output(lastItemint.ToString());
                Debug.Output(newItemID);
                return newItemID;
            }
            
        }

        private string NewIdGroup(HashSet<string> categories)
        {
            string newId = $"{categories.Count + 1}0{categories.Count + 1}i_1";

            return newId;
        }

    }
}
