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
        public HashSet<string> catergories = new HashSet<string>();
        private AddScreen addScreen;
        private Information infoScreen;
        private product_classing.ProductService productService = new product_classing.ProductService();

        public Dashboard()
        {
            InitializeComponent();
            Init();
            FocusTextBox();

            LoadGrid(productService.GetAllProducts());
        }

        private void Init()
        {
            productService.IniDB();
        }

        void AddItems()
        {
            listBox1.Items.Clear();
            foreach (var item in productService.GetAllProducts())
            {
                catergories.Add(item.Category);
                
            }
            catergories.Distinct().ToList();
            
            foreach (var item in catergories)
            {
                listBox1.Items.Add(item);
            }
        }
        public void LoadGrid(List<product_classing.Product> list)
        {
            MainGrid.Rows.Clear();
            foreach (product_classing.Product item in list)
            {
                string[] additem = new[] { item.Name, item.ID, item.Status, item.Category, item.remark };
                MainGrid.Rows.Add(additem);



            }
            AddItems();
        }

     
        
        public void FocusTextBox()
        {
            TB_Search.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addScreen = new AddScreen(productService, this);
            addScreen.ShowDialog();
            
            
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
           
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem == null)
            {
                LoadGrid(productService.GetAllProducts());
                return;
            }
            var selectedItem = listBox1.SelectedItem.ToString();
            List<product_classing.Product> filteredList = new List<product_classing.Product>();
            filteredList = productService.GetProductsFiltered(selectedItem);

            Debug.Output($"filtered view, querr:{selectedItem}. items in list:{filteredList.Count}");
            LoadGrid(filteredList);
        }

        private void MainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            string GetID = MainGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            Debug.Output(GetID);
            product_classing.Product newProduct = productService.GetProductByID(GetID);
            infoScreen = new Information(newProduct, this, productService);
            infoScreen.ShowDialog();
            LoadGrid(productService.GetAllProducts());
        }

        private void pictureBox_add_Click(object sender, EventArgs e)
        {
            addScreen = new AddScreen(productService, this);
            addScreen.ShowDialog();
        }
    }



}
