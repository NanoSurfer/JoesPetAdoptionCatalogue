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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            DogForm formDog = new DogForm();
            formDog.ShowDialog();
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            CatForm formCat = new CatForm();
            formCat.ShowDialog();
        }

        private void exitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnViewCatalog_Click(object sender, EventArgs e)
        {
            CatalogForm formCatalog = new CatalogForm();
            formCatalog.ShowDialog();
        }
    }
}
