namespace JoesPetShop
{
    partial class CatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBxDetails = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtBxAge = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddToCatalog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBxPureBreed = new System.Windows.Forms.CheckBox();
            this.cmboBxBreed = new System.Windows.Forms.ComboBox();
            this.lblBreed = new System.Windows.Forms.Label();
            this.txtBxColor = new System.Windows.Forms.TextBox();
            this.grpBxDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxDetails
            // 
            this.grpBxDetails.Controls.Add(this.txtBxColor);
            this.grpBxDetails.Controls.Add(this.chkBxPureBreed);
            this.grpBxDetails.Controls.Add(this.label1);
            this.grpBxDetails.Controls.Add(this.cmboBxBreed);
            this.grpBxDetails.Controls.Add(this.rbFemale);
            this.grpBxDetails.Controls.Add(this.rbMale);
            this.grpBxDetails.Controls.Add(this.txtBxAge);
            this.grpBxDetails.Controls.Add(this.txtBxName);
            this.grpBxDetails.Controls.Add(this.lblName);
            this.grpBxDetails.Controls.Add(this.lblAge);
            this.grpBxDetails.Controls.Add(this.lblColor);
            this.grpBxDetails.Controls.Add(this.lblBreed);
            this.grpBxDetails.Controls.Add(this.lblGender);
            this.grpBxDetails.Location = new System.Drawing.Point(12, 11);
            this.grpBxDetails.Name = "grpBxDetails";
            this.grpBxDetails.Size = new System.Drawing.Size(244, 233);
            this.grpBxDetails.TabIndex = 10;
            this.grpBxDetails.TabStop = false;
            this.grpBxDetails.Text = "Details";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(156, 161);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 15;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(91, 161);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 14;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtBxAge
            // 
            this.txtBxAge.Location = new System.Drawing.Point(91, 60);
            this.txtBxAge.Name = "txtBxAge";
            this.txtBxAge.Size = new System.Drawing.Size(49, 20);
            this.txtBxAge.TabIndex = 8;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(91, 30);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(120, 20);
            this.txtBxName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(46, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(56, 63);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(46, 198);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 13);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Colour:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(39, 163);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddToCatalog);
            this.groupBox1.Location = new System.Drawing.Point(3, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 42);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update";
            // 
            // btnAddToCatalog
            // 
            this.btnAddToCatalog.Location = new System.Drawing.Point(68, 14);
            this.btnAddToCatalog.Name = "btnAddToCatalog";
            this.btnAddToCatalog.Size = new System.Drawing.Size(126, 23);
            this.btnAddToCatalog.TabIndex = 8;
            this.btnAddToCatalog.Text = "Add to Catalogue";
            this.btnAddToCatalog.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pure Breed:";
            // 
            // chkBxPureBreed
            // 
            this.chkBxPureBreed.AutoSize = true;
            this.chkBxPureBreed.Location = new System.Drawing.Point(89, 96);
            this.chkBxPureBreed.Name = "chkBxPureBreed";
            this.chkBxPureBreed.Size = new System.Drawing.Size(44, 17);
            this.chkBxPureBreed.TabIndex = 20;
            this.chkBxPureBreed.Text = "Yes";
            this.chkBxPureBreed.UseVisualStyleBackColor = true;
            this.chkBxPureBreed.CheckedChanged += new System.EventHandler(this.chkBxPureBreed_CheckedChanged);
            // 
            // cmboBxBreed
            // 
            this.cmboBxBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBxBreed.Enabled = false;
            this.cmboBxBreed.FormattingEnabled = true;
            this.cmboBxBreed.Items.AddRange(new object[] {
            "Abyssinian",
            "American Bobtail",
            "American Curl",
            "American Shorthair",
            "American Wirehair",
            "Balinese",
            "Bengal",
            "Birman",
            "Bombay",
            "British Shorthair",
            "Burmese",
            "California Spangled Cat",
            "Chantilly/Tiffany",
            "Chartreux",
            "Color point shorthair",
            "Cornish Rex",
            "Cymric",
            "Devon Rex",
            "Domestic Longhair",
            "Domestic Shorthair",
            "Egyptian Mau",
            "European Burmese",
            "Exotic",
            "Havana Brown",
            "Himalayan",
            "Japanese Bobtail",
            "Javanese",
            "Korat",
            "LaPerm",
            "Maine Coon",
            "Manx",
            "Munchkin",
            "Nebelung",
            "Norwegian Forest Cat",
            "Ocicat",
            "Oriental",
            "Persian",
            "Pixie-bob",
            "Ragamuffin",
            "Ragdoll",
            "Russian Blue",
            "Scottish Fold",
            "Selkirk Rex",
            "Siamese",
            "Siberian",
            "Singapura",
            "Snowshoe",
            "Somali",
            "Sphynx",
            "Tonkinese",
            "Turkish Angora",
            "Turkish Van "});
            this.cmboBxBreed.Location = new System.Drawing.Point(91, 133);
            this.cmboBxBreed.Name = "cmboBxBreed";
            this.cmboBxBreed.Size = new System.Drawing.Size(139, 21);
            this.cmboBxBreed.TabIndex = 17;
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(46, 136);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(38, 13);
            this.lblBreed.TabIndex = 2;
            this.lblBreed.Text = "Breed:";
            // 
            // txtBxColor
            // 
            this.txtBxColor.Location = new System.Drawing.Point(89, 195);
            this.txtBxColor.Name = "txtBxColor";
            this.txtBxColor.Size = new System.Drawing.Size(120, 20);
            this.txtBxColor.TabIndex = 21;
            // 
            // CatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 302);
            this.Controls.Add(this.grpBxDetails);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cat Details";
            this.Load += new System.EventHandler(this.CatForm_Load);
            this.grpBxDetails.ResumeLayout(false);
            this.grpBxDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxDetails;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtBxAge;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddToCatalog;
        private System.Windows.Forms.CheckBox chkBxPureBreed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboBxBreed;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.TextBox txtBxColor;
    }
}