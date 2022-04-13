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
            CategoryAddBox.Visible = false;
            LoadComboBox();
            
        }
        void LoadComboBox()
        {
            foreach (Category item in productService.GetAllCategories())
            {
                CateComboBox.Items.Add(item.catergory);
                Debug.Output(item.catergory);
            }
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
            if(CateComboBox.Visible != false)
            {
                newItem.Category.catergory = CateComboBox.Text;

            }
            else
            {
                newItem.Category.catergory = CategoryAddBox.Text;

            }

            newItem.ID = generator.GenerateIDFunc(newItem.Category.catergory, dashboard.catergories);

            newItem.Description = createProductDesc.Text;
            newItem.remark = createRemark.Text;

            productService.PostProduct(newItem);
            dashboard.LoadGrid(productService.GetAllProducts());
            
            this.Close();
            
        }

        private void createProductCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //CateComboBox.Visible.SwitchBool
            CateComboBox.Visible = !CateComboBox.Visible;


            CategoryAddBox.Visible = !CategoryAddBox.Visible;
        }
    }

}
