using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lasf_Data_Processing_System
{
    public partial class Frm_Browser : Form
    {
        public Frm_Browser()
        {
            InitializeComponent();
        }

        private void Trv_Browser_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = Trv_Browser.SelectedNode;

            if (node.Name[0] == 'L')
            {
                //Line

            }
            else
            {
                //Map

            }


        }

        private void Tsb_DataImport_Click(object sender, EventArgs e)
        {



        }

        private void Tsb_DataExport_Click(object sender, EventArgs e)
        {

        }

        private void Tlp_Browser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
