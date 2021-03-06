﻿using System;
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
    public partial class DogForm : Form
    {
        //Variable for the ArrayList dog object
        public ArrayList dogList = new ArrayList();

        //variable for the binary animal file
        const String filename = "Animal.dat";

        public DogForm()
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
            myTip.SetToolTip(this.txtBxColor, "Please enter a color which best matches the discription of the Dog.\n\n" +
                "eg: White, grey, brownish grey etc...");
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
                gender = "Female";
            }

            if (rbMale.Checked == true)
            {
                gender = "Male";
            }

            //Create the object only if all fields all filled in
            if (chkBxPureBreed.Checked == true && txtBxName.Text != "" && txtBxAge.Text != ""
                 && txtBxColor.Text != "" && cmbBxBreed.Text != String.Empty && cmBxCategory.Text != String.Empty
                && (this.rbFemale.Checked || this.rbMale.Checked))
            {
                try
                {
                    //Create the pure breed dog object
                    Dog pureDog = new Dog(txtBxName.Text.ToString(), cmbBxBreed.SelectedItem.ToString(), double.Parse(txtBxAge.Text.ToString()),
                        gender, txtBxColor.Text.ToString(), cmBxCategory.SelectedItem.ToString());
                    saveToFile(pureDog);
                }
                catch (NullReferenceException ne)
                {
                    MessageBox.Show("An error occured!!! \n\n" + ne.Message + "\n\nPerhaps you did not select a property in the drop down box?");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter in a number for the 'Age' field \n\n Eg: 0.3 (3 months) or 2 (as in 2 Years)");
                    txtBxAge.Clear();
                }
            }

            else if (txtBxName.Text != "" && txtBxAge.Text != ""
                     && txtBxColor.Text != "" && chkBxPureBreed.Checked == false && (this.rbFemale.Checked ||
                    this.rbMale.Checked))
            {
                //Create the non pure breed dog object
                try
                {
                    Dog mixDog = new Dog(txtBxName.Text.ToString(), double.Parse(txtBxAge.Text.ToString()),
                        gender, txtBxColor.Text.ToString());
                    saveToFile(mixDog);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter in a number for the 'Age' field \n\n Eg: 0.3 (3 months) or 2 (as in 2 Years)");
                }
            }
      
            else
            {
                MessageBox.Show("Please fill out all fields before clicking 'Add to Catalogue'");
            }    
        }

        private void saveToFile(Dog aDog)
        {
            try
            {
                FileStream filStream = new FileStream(filename, FileMode.Append);
                BinaryWriter binWriter = new BinaryWriter(filStream);

                binWriter.Write(aDog.Name);
                binWriter.Write(aDog.Age);
                binWriter.Write(aDog.Gender);
                binWriter.Write(aDog.Color);

                if (aDog.Breed == null)
                {
                    aDog.Breed = "Mix breed";
                    binWriter.Write(aDog.Breed);
                    aDog.DogCatagory = "None";
                    binWriter.Write(aDog.DogCatagory);
                }
                else
                {
                    binWriter.Write(aDog.Breed);
                }

                binWriter.Close(); // Close the writer
                filStream.Close(); //Close the reader

                ////Add items to the arrayList
                dogList.Add(aDog.Name);
                dogList.Add(aDog.Age);
                dogList.Add(aDog.Gender);
                dogList.Add(aDog.Color);
                dogList.Add(aDog.Breed);
                dogList.Add(aDog.DogCatagory);
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
                ArrayList dogData = new ArrayList();

                // Serialize the arraylist to a binary file 
                var serializer = new BinaryFormatter();
                try
                {
                    using (var stream = File.OpenRead("dogData.dat"))
                    {
                        dogData = (ArrayList)serializer.Deserialize(stream);
                        dogList.Add(dogData);
                    }

                    using (var stream = File.OpenWrite("dogData.dat"))
                    {
                        serializer.Serialize(stream, dogList);
                    }
                }
                catch (FileNotFoundException)
                {
                    using (var stream = File.OpenWrite("dogData.dat"))
                    {
                        serializer.Serialize(stream, dogList);
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
