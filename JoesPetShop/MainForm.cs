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
        CatForm formCat = new CatForm();
        DogForm formDog = new DogForm();
        CatalogForm formCatalog = new CatalogForm();

        public MainForm()
        {
            InitializeComponent();

        }

        private void btnDog_Click(object sender, EventArgs e)
        {        
            formDog.ShowDialog();
        }

        private void btnCat_Click(object sender, EventArgs e)
        {           
            formCat.ShowDialog();
        }

        private void exitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnViewCatalog_Click(object sender, EventArgs e)
        {
            formCatalog.ShowDialog();
        }

        private void btnDogs_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCats_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "catReport.txt");
        }
    }
}
