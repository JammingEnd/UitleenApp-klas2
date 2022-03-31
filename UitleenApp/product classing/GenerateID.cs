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
        public string GenerateIDFunc(string filteritem)
        {
            Debug.Output(filteritem);
            string lastItemID = _productService.GetProductsFiltered(filteritem).Last().ID;
            Debug.Output($"{lastItemID} ");
            string lastItemintString = lastItemID.Substring(5, lastItemID.Length);
            int lastItemint = Int32.Parse(lastItemintString);

            lastItemID = new string[] { $"{lastItemID.Substring(0, lastItemintString.Length)}{lastItemint++}" }.First();

            return lastItemID;
        }



    }
}
