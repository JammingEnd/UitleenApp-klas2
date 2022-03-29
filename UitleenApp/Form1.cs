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

namespace UitleenApp
{
    
    public partial class Dashboard : Form
    {

        public TextBox BarcodeTextBox;
        public List<string> Catergories = new List<string>();

        public Dashboard()
        {
            InitializeComponent();
            FocusTextBox();
            AddCatergory();
            AddItems();
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

        }

        public void FocusTextBox()
        {
            TB_Search.Focus();
        }

      
        
    }



}
