using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JoesPetShop
{
    public partial class CatForm : Form
    {
        public CatForm()
        {
            InitializeComponent();
        }

        private void CatForm_Load(object sender, EventArgs e)
        {

        }

        private void chkBxPureBreed_CheckedChanged(object sender, EventArgs e)
        {
            //if the box is ticked
            if (chkBxPureBreed.Checked == true)
            {
                //then the combo box is enabled
                cmboBxBreed.Enabled = true;
            }
            else
            {
                //else they remain inaccesabile
                cmboBxBreed.Enabled = false;
            }
        }
    }
}
