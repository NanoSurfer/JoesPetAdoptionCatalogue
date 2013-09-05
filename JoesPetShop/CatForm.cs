using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace JoesPetShop
{
    public partial class CatForm : Form
    {
        //Variable for the gender
        private string gender = "";

        //Variable for the ArrayList cat object
        public ArrayList catList = new ArrayList();

        const String filename = "Animal.dat";

        public CatForm()
        {
            InitializeComponent();

            // Create the ToolTip for the colour box
            ToolTip myTip = new ToolTip();

            // Set up the delays for the ToolTip.
            myTip.AutoPopDelay = 7000;
            myTip.InitialDelay = 50;
            myTip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            myTip.ShowAlways = true;

            // Set up the ToolTip for the txtBxColor control.
            myTip.IsBalloon = true;
            myTip.SetToolTip(this.txtBxColor, "Please enter a color which best\n matches the discription of the Cat.\n\n" +
                "eg: Brown, grey, brownish grey etc...");
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
                FileStream filStream = new FileStream(filename, FileMode.Append);
                BinaryWriter binWriter = new BinaryWriter(filStream);

                binWriter.Write(aCat.Name);
                binWriter.Write(aCat.Age);
                binWriter.Write(aCat.Gender);
                binWriter.Write(aCat.Color);

                if (aCat.Breed == null)
                {
                    aCat.Breed = "Mix breed";
                    binWriter.Write(aCat.Breed);
                }
                else
                {
                    binWriter.Write(aCat.Breed);
                }

                binWriter.Close(); // Close the writer
                filStream.Close(); //Close the reader

                //Write immediately to the text files for the reports
                if (!File.Exists("catReport.txt"))
                {
                    StreamWriter file = new StreamWriter("catReport.txt");

                    ////Add items to the arrayList while im at it
                    catList.Add(aCat.Name);
                    catList.Add(aCat.Age);
                    catList.Add(aCat.Gender);
                    catList.Add(aCat.Color);
                    catList.Add(aCat.Breed);

                    file.WriteLine(aCat.ToString());

                    //close the file
                    file.Close();
                }

                using (StreamWriter sw = File.AppendText("catReport.txt"))
                {
                    ////Add items to the arrayList while im at it
                    catList.Add(aCat.Name);
                    catList.Add(aCat.Age);
                    catList.Add(aCat.Gender);
                    catList.Add(aCat.Color);
                    catList.Add(aCat.Breed);

                    sw.WriteLine(aCat.ToString());

                    //close the file
                    sw.Close();
                }
            }

            //If an error arises, catch it
            catch (IOException io)
            {
                MessageBox.Show("There was an error writing to the file \n\nThe error is " + io.Message);
                this.Close();
            }

            //Success!
            DialogResult dialogResult = MessageBox.Show("\tSaved succesfully!\n\nWould you like to save another?", "Saved Successfuly", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Just get rid of it by clicking the button
            }
            else if (dialogResult == DialogResult.No)
            {
                ArrayList catData = new ArrayList();

                // Serialize the arraylist to a binary file 
                var serializer = new BinaryFormatter();
                try
                {
                    using (var stream = File.OpenRead("catData.dat"))
                    {
                        catData = (ArrayList)serializer.Deserialize(stream);
                        
                    }

                    using (var stream = File.OpenWrite("catData.dat"))
                    {
                        serializer.Serialize(stream, catList);
                    }

                }
                catch (FileNotFoundException)
                {
                    using (var stream = File.OpenWrite("catData.dat"))
                    {
                        serializer.Serialize(stream, catList);
                    }
                }
        
                this.Hide();
            }

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
