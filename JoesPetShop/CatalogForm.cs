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
    public partial class CatalogForm : Form
    {
        ArrayList catData = new ArrayList();
        ArrayList dogData = new ArrayList();

        int catCount = 5;
        int dogCount = 6;

        public CatalogForm()
        {
            InitializeComponent();
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnNext2.Enabled = true;
            try
            {
                // Deserialize the lists from the file and build my arrayList object
                var serializer = new BinaryFormatter();
                using (var stream = File.OpenRead("catData.dat"))
                {
                    catData = (ArrayList)serializer.Deserialize(stream);
                }

                using (var stream = File.OpenRead("dogData.dat"))
                {
                    dogData = (ArrayList)serializer.Deserialize(stream);
                }

                txtBxCatName.Text = catData[0].ToString();
                txtBxCatAge.Text = catData[1].ToString();
                txtBxCatGender.Text = catData[2].ToString();
                txtBxCatColor.Text = catData[3].ToString();
                txtBxCatBreed.Text = catData[4].ToString();

                txtBxDogName.Text = dogData[0].ToString();
                txtBxDogAge.Text = dogData[1].ToString();
                txtBxDogGender.Text = dogData[2].ToString();
                txtBxDogColor.Text = dogData[3].ToString();
                txtBxDogBreed.Text = dogData[4].ToString();
                txtBxDogCatagory.Text = dogData[5].ToString();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("There is no data");
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show("Invalid file format. (" + ex.Message + ")");
            }
            catch (EndOfStreamException ex)
            {
                MessageBox.Show("Unexpected end of file. (" + ex.Message + ")");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Unknwon error. (" + ex.Message + ")");
            }
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            btnBack2.Enabled = true;
            if (catCount == catData.Count)
            {
                catCount = 0;
            }
            try
            {
                addCatDetails();

                if (catCount >= catData.Count)
                {
                    MessageBox.Show("No more records");
                    btnNext2.Enabled = false;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("There is no data to display");
            }
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            btnNext2.Enabled = true;

            catCount = catCount - 10;
            if (catCount < 0)
            {
                MessageBox.Show("No more records");
                btnBack2.Enabled = false;
                catCount = 0;
            }
            try
            {
                addCatDetails();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("There is no data to display");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnBack2.Enabled = true;

            if (dogCount == dogData.Count)
            {
                dogCount = 0;
            }

            try
            {
                btnBack.Enabled = true;

                addDogDetails();

                if (dogCount >= dogData.Count)
                {
                    MessageBox.Show("No more records");
                    btnNext.Enabled = false;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("There is no data to display");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;

            dogCount = dogCount - 12;
            if (dogCount < 0)
            {
                MessageBox.Show("No more records");
                btnBack.Enabled = false;
                dogCount = 0;
            }
            try
            {
                addDogDetails();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("There is no data to display");
            }
        }

        private void addDogDetails()
        {
            //Dog
            txtBxDogName.Text = dogData[dogCount].ToString();
            dogCount++;
            txtBxDogAge.Text = dogData[dogCount].ToString();
            dogCount++;
            txtBxDogGender.Text = dogData[dogCount].ToString();
            dogCount++;
            txtBxDogColor.Text = dogData[dogCount].ToString();
            dogCount++;
            txtBxDogBreed.Text = dogData[dogCount].ToString();
            dogCount++;
            txtBxDogCatagory.Text = dogData[dogCount].ToString();
            dogCount++;
        }

        private void addCatDetails()
        {
            //Cat
            txtBxCatName.Text = catData[catCount].ToString();
            catCount++;
            txtBxCatAge.Text = catData[catCount].ToString();
            catCount++;
            txtBxCatGender.Text = catData[catCount].ToString();
            catCount++;
            txtBxCatColor.Text = catData[catCount].ToString();
            catCount++;
            txtBxCatBreed.Text = catData[catCount].ToString();
            catCount++;
        }
    }
}
