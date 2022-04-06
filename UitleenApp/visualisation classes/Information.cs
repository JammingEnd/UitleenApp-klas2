using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UitleenApp.product_classing;

namespace UitleenApp.visualisation_classes
{
    public partial class Information : Form
    {
        private string nullFilling = "-";
        private Dashboard dashboard;
        private ProductService productService;
        private Product product;

        public Information(Product item, Dashboard _dashboard, ProductService service)
        {
            InitializeComponent();
            product = item;
            dashboard = _dashboard;
            productService = service;
            EditProductName.Text = item.Name;
            editProductCategory.Text = item.Category;
            EditStatusList.Text = item.Status;
            editProductDesc.Text = item.Description;
            editRemark.Text = item.remark;
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            Image img = b.Encode(BarcodeLib.TYPE.CODE128, item.ID, Color.Black, Color.White, barcodeBox.Width, barcodeBox.Height);
            barcodeBox.Image = img;
        }

        private void createProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Product newItem = product;
            if (editProductDesc.Text == "")
            {
                newItem.Description = nullFilling;
            }
            if (editRemark.Text == "")
            {
                newItem.remark = nullFilling;
            }
            newItem.Name = EditProductName.Text;
            newItem.Status = EditStatusList.Text;
            newItem.Category = editProductCategory.Text;
            newItem.Description = editProductDesc.Text;
            newItem.remark = editRemark.Text;
            productService.UpdateProduct(newItem);
            dashboard.LoadGrid(productService.GetAllProducts());
            this.Close();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void barcodeBox_Click(object sender, EventArgs e)
        {

            Debug.SaveImageCapture(barcodeBox.Image);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            System.Drawing.Printing.PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }

        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(barcodeBox.Width, barcodeBox.Height);
            barcodeBox.DrawToBitmap(bm, new Rectangle(0, 0, barcodeBox.Width, barcodeBox.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void createProductCancelBtn_Click(object sender, EventArgs e)
        {
            productService.Deleteproduct(product.ID);
        }
    }
}