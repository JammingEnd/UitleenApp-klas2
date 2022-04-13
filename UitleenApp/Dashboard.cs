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
            GetEnter();
            LoadGrid(productService.GetAllProducts());
            listBox2.ScrollAlwaysVisible = false;
           
            listBox2.Items.Add("Toon alles");
            

          
         
        }
        void GetEnter()
        {
            this.TB_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);

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
                catergories.Add(item.Category.catergory);
               

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
            catergories.Clear();
            foreach (product_classing.Product item in list)
            {
                string[] additem = new[] { item.Name, item.ID, item.Status, item.Category.catergory, item.remark };
                MainGrid.Rows.Add(additem);



            }
            AddItems();
        }



        public void FocusTextBox()
        {
            TB_Search.Focus();
        }

        private void pictureBox_add_Click(object sender, EventArgs e)
        {
            addScreen = new AddScreen(productService, this);
            addScreen.ShowDialog();


        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem.ToString();
            listBox2.ForeColor = Color.Black;
            List<product_classing.Product> filteredList = new List<product_classing.Product>();
            filteredList = productService.GetProductsFiltered(selectedItem);

            Debug.Output($"filtered view, querr:{selectedItem}. items in list:{filteredList.Count}");
            LoadGrid(filteredList);
        }

        private void MainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            string GetID = MainGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            Debug.Output(GetID);
            SearchResult<Product> searchResult = new SearchResult<Product>();

            searchResult = productService.GetProductByID(GetID);
            infoScreen = new Information(searchResult.Result, this, productService);
            infoScreen.ShowDialog();
            LoadGrid(productService.GetAllProducts());
        }

        private void TB_Search_TextChanged(object sender, EventArgs e)
        {
        }
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                if (TB_Search.Text != "" || TB_Search.Text != null)
                {

                    SearchResult<Product> searchResult = new SearchResult<Product>();

                    searchResult = productService.GetProductByID(TB_Search.Text);
                    if (searchResult.error == "")
                    {
                        //error message
                        Debug.Output(searchResult.error);
                        TB_Search.Text = "";
                        return;
                    }
                    TB_Search.Text = "";

                    infoScreen = new Information(searchResult.Result, this, productService);
                    infoScreen.ShowDialog();
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem.ToString() == "Toon alles")
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

        private void TB_Search_TextChanged_1(object sender, EventArgs e)
        {

        }
    }



}