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
<<<<<<< Updated upstream

        private ScanInteractor _scanInteractor;

        public Dashboard()
        {
            InitializeComponent();

            _scanInteractor = new ScanInteractor();
        }



        //dummy method
        void OnEnter_button()
        {
            string codeFromTextBox = "00090000";
            _scanInteractor.GetScan(codeFromTextBox);
=======
        private bool IsCollapsed;
        public TextBox BarcodeTextBox;
        public List<string> Catergories = new List<string>();
        public Dashboard()
        {
            InitializeComponent();
            FocusTextBox();
        }
        void AddCatergory()
        {
            Catergories.Add("camera");
            Catergories.Add("lego");
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed)
            {
                panel1.Height += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    IsCollapsed = false;


                }
            }
            else
            {
                panel1.Height -= 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    IsCollapsed = true;


                }
            }
        }
        public void FocusTextBox()
        {
            TB_Search.Focus();
        }

        private void test_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void TB_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            button1.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

>>>>>>> Stashed changes
        }
    }



}
