using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UitleenApp.product_classing;

namespace UitleenApp.visualisation_classes
{
    public partial class AddScreen : Form
    {
        private string nullFilling = "-";
        private ProductService productService;
        private Dashboard dashboard;
        private GenerateID generator;
        public AddScreen(ProductService item, Dashboard dashboarditem)
        {
            productService = item;
            dashboard = dashboarditem;
            generator = new GenerateID(item);
            InitializeComponent();
        }

        private void AddScreen_Load(object sender, EventArgs e)
        {

        }

        private void createProductConfirmBtn_Click(object sender, EventArgs e)
        {
            Product newItem = new Product();
            if (createProductDesc.Text == "")
            {
                newItem.Description = nullFilling;
            }
            if (createRemark.Text == "")
            {
                newItem.remark = nullFilling;
            }
            newItem.Name = createProductName.Text;
            newItem.Status = createStatusList.Text;
            newItem.Category = createProductCategory.Text;
            newItem.ID = generator.GenerateIDFunc(newItem.Category, dashboard.catergories);

            newItem.Description = createProductDesc.Text;
            newItem.remark = createRemark.Text;

            productService.PostProduct(newItem);
            dashboard.LoadGrid(productService.GetAllProducts());
           
            this.Close();
            
        }

        
        
    }

}
