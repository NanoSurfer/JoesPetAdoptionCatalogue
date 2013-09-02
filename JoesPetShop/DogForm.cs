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
    public partial class DogForm : Form
    {
        public DogForm()
        {
            InitializeComponent();
        }

        private void chkBxPureBreed_CheckedChanged(object sender, EventArgs e)
        {
            //if the box is ticked
            if (chkBxPureBreed.Checked == true)
            {
                //then the combo box is enabled
                cmbBxBreed.Enabled = true;
                cmBxCategory.Enabled = true;
            }
            else
            {
                //else they remain inaccesabile
                cmbBxBreed.Enabled = false;
                cmBxCategory.Enabled = false;
            }
        }

        private void btnAddToCatalog_Click(object sender, EventArgs e)
        {
            //Variable for the gender
            string gender = "";

            //Check to see which radio button was pressed
            if(rbFemale.Checked == true)
            {
                gender = "Female";
            }

            if(rbMale.Checked == true)
            {
                gender = "Male";
            }

            //Create the object only if all fields all filled in
            try
            {
                if (chkBxPureBreed.Checked == true)
                {
                    Dog myDog = new Dog(txtBxName.Text.ToString(), cmbBxBreed.SelectedItem.ToString(), int.Parse(txtBxAge.Text.ToString()),
                        gender, txtBxColor.Text.ToString(), cmBxCategory.SelectedItem.ToString());
                }
                
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please fill out all fields before continuing");
            }
        }
    }
}
