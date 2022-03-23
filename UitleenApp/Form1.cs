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
        }
    }
}
