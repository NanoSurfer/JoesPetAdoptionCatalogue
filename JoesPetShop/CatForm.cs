using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
                cmbBxBreed.Enabled = true;
            }
            else
            {
                //else they remain inaccesabile
                cmbBxBreed.Enabled = false;
            }
        }

        private void btnAddToCatalog_Click(object sender, EventArgs e)
        {
            //Variable for the gender
            string gender = "";

            //Check to see if the age is below 0
            try
            {
                if (double.Parse(txtBxAge.Text.ToString()) < 0)
                {
                    MessageBox.Show("Age cannot be less than 0");
                    txtBxAge.Text = ""; //Reset the box
                }
            }
            catch (FormatException)
            {
            }

            //Check to see which radio button was pressed
            if (rbFemale.Checked == true)
            {
                gender = "Female"; //Assign a value to gender
            }

            if (rbMale.Checked == true)
            {
                gender = "Male";
            }

            //Create pure breed object only if all fields all filled in
            if (chkBxPureBreed.Checked == true && txtBxName.Text != "" && txtBxAge.Text != ""
                     && txtBxColor.Text != "" && cmbBxBreed.Text != String.Empty && (this.rbFemale.Checked ||
                     this.rbMale.Checked))
            {
                try
                {
                    //Create the pure breed cat object
                    Cat pureCat = new Cat(txtBxName.Text.ToString(), cmbBxBreed.SelectedItem.ToString(), double.Parse(txtBxAge.Text.ToString()),
                        gender, txtBxColor.Text.ToString());
                    saveToFile(pureCat);
                }
                catch (NullReferenceException ne)
                {
                    MessageBox.Show("An error occured!!! \n\n" + ne.Message + "\n\nPerhaps you did not select a property in the drop down box?");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter in a number for the 'Age' field \n Eg: 0.3 (3 months) or 2 (as in 2 Years)");
                    txtBxAge.Clear();
                }
            }

            else if (txtBxName.Text != "" && txtBxAge.Text != ""
                     && txtBxColor.Text != "" && chkBxPureBreed.Checked == false && (this.rbFemale.Checked ||
                    this.rbMale.Checked))
            {
                //Create the non pure breed cat object
                try
                {
                    Cat mixCat = new Cat(txtBxName.Text.ToString(), double.Parse(txtBxAge.Text.ToString()),
                        gender, txtBxColor.Text.ToString());
                    saveToFile(mixCat);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter in a number for the 'Age' field \n Eg: 0.3 (3 months) or 2 (as in 2 Years)");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields before clicking 'Add to Catalogue'");
            }
        }

        //Method for saving the object to the file
        private void saveToFile(Cat aCat)
        {
            try
            {
                FileStream filStream = new FileStream("Animal.bin", FileMode.Append);
                BinaryWriter binWriter = new BinaryWriter(filStream);

                binWriter.Write("002" + aCat.ToString());
                binWriter.Close();
                filStream.Close();
            }

            //If an error arises, catch it
            catch (IOException io)
            {
                MessageBox.Show("There was an error writing to the file \n\nThe error is " + io.Message);
                this.Close();
            }

            MessageBox.Show("Saved succesfully");

            //Reset form
            txtBxName.Text = "";
            txtBxAge.Text = "";
            txtBxColor.Text = "";
            cmbBxBreed.SelectedIndex = -1;
            rbFemale.Checked = false;
            rbMale.Checked = false;
            chkBxPureBreed.Checked = false;
        }
    }
}
