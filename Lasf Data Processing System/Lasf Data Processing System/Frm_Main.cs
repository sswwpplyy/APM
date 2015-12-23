using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lasf_Data_Processing_System
{
    public partial class Frm_Main : Form
    {
        public static Frm_Main Instance;


        public Frm_Main()
        {
            InitializeComponent();
        }


        public static Frm_Main GetInstance()
        {
            return Frm_Main.Instance;
        }

        private void Mnu_MainDataBrowser_Click(object sender, EventArgs e)
        {
            Frm_Browser browser = new Frm_Browser();
            browser.Show();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
