using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UitleenApp.scan_classing;
using UitleenApp.visualisation_classes;

namespace UitleenApp
{
    
    public partial class Dashboard : Form
    {

        public TextBox BarcodeTextBox;
        public List<string> Catergories = new List<string>();
        private AddScreen addScreen;
        private product_classing.ProductService productService = new product_classing.ProductService();

        public Dashboard()
        {
            InitializeComponent();
            Init();
            FocusTextBox();
            AddCatergory();
            AddItems();
        }

        private void Init()
        {
            productService.GetAllProducts();
        }

        void AddItems()
        {
            foreach (var item in Catergories)
            {
                listBox1.Items.Add(item);
            }
        }

        void AddCatergory()
        {
            Catergories.Add("camera");
            Catergories.Add("lego");
            
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            MainGrid.DataSource = productService.GetAllProducts();
        }

        public void FocusTextBox()
        {
            TB_Search.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addScreen = new AddScreen();
            addScreen.ShowDialog();
            this.Close();
            
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            
        }
    }



}
