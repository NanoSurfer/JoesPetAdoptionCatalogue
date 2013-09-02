namespace JoesPetShop
{
    partial class DogForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.grpBxDetails = new System.Windows.Forms.GroupBox();
            this.txtBxColor = new System.Windows.Forms.TextBox();
            this.chkBxPureBreed = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBxBreed = new System.Windows.Forms.ComboBox();
            this.cmBxCategory = new System.Windows.Forms.ComboBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtBxAge = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.btnAddToCatalog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBxDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(52, 58);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(42, 131);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(38, 13);
            this.lblBreed.TabIndex = 2;
            this.lblBreed.Text = "Breed:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(35, 158);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(42, 193);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 13);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Colour:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(29, 226);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category:";
            // 
            // grpBxDetails
            // 
            this.grpBxDetails.Controls.Add(this.txtBxColor);
            this.grpBxDetails.Controls.Add(this.chkBxPureBreed);
            this.grpBxDetails.Controls.Add(this.label1);
            this.grpBxDetails.Controls.Add(this.cmbBxBreed);
            this.grpBxDetails.Controls.Add(this.cmBxCategory);
            this.grpBxDetails.Controls.Add(this.rbFemale);
            this.grpBxDetails.Controls.Add(this.rbMale);
            this.grpBxDetails.Controls.Add(this.txtBxAge);
            this.grpBxDetails.Controls.Add(this.txtBxName);
            this.grpBxDetails.Controls.Add(this.lblName);
            this.grpBxDetails.Controls.Add(this.lblCategory);
            this.grpBxDetails.Controls.Add(this.lblAge);
            this.grpBxDetails.Controls.Add(this.lblColor);
            this.grpBxDetails.Controls.Add(this.lblBreed);
            this.grpBxDetails.Controls.Add(this.lblGender);
            this.grpBxDetails.Location = new System.Drawing.Point(12, 12);
            this.grpBxDetails.Name = "grpBxDetails";
            this.grpBxDetails.Size = new System.Drawing.Size(263, 258);
            this.grpBxDetails.TabIndex = 7;
            this.grpBxDetails.TabStop = false;
            this.grpBxDetails.Text = "Details";
            // 
            // txtBxColor
            // 
            this.txtBxColor.Location = new System.Drawing.Point(87, 190);
            this.txtBxColor.Name = "txtBxColor";
            this.txtBxColor.Size = new System.Drawing.Size(120, 20);
            this.txtBxColor.TabIndex = 22;
            // 
            // chkBxPureBreed
            // 
            this.chkBxPureBreed.AutoSize = true;
            this.chkBxPureBreed.Location = new System.Drawing.Point(85, 91);
            this.chkBxPureBreed.Name = "chkBxPureBreed";
            this.chkBxPureBreed.Size = new System.Drawing.Size(44, 17);
            this.chkBxPureBreed.TabIndex = 20;
            this.chkBxPureBreed.Text = "Yes";
            this.chkBxPureBreed.UseVisualStyleBackColor = true;
            this.chkBxPureBreed.CheckedChanged += new System.EventHandler(this.chkBxPureBreed_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pure Breed:";
            // 
            // cmbBxBreed
            // 
            this.cmbBxBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxBreed.Enabled = false;
            this.cmbBxBreed.FormattingEnabled = true;
            this.cmbBxBreed.Items.AddRange(new object[] {
            "Affenpinscher",
            "Afghan Hound",
            "Airedale Terrier",
            "Akita",
            "Alaskan Malamute",
            "American English Coonhound",
            "American Eskimo Dog",
            "American Foxhound",
            "American Staffordshire Terrier",
            "American Water Spaniel",
            "Anatolian Shepherd Dog",
            "Australian Cattle Dog",
            "Australian Shepherd",
            "Australian Terrier",
            "Basenji",
            "Basset Hound",
            "Beagle",
            "Bearded Collie",
            "Beauceron",
            "Bedlington Terrier",
            "Belgian Malinois",
            "Belgian Sheepdog",
            "Belgian Tervuren",
            "Bernese Mountain Dog",
            "Bichon Frise",
            "Black and Tan Coonhound",
            "Black Russian Terrier",
            "Bloodhound",
            "Bluetick Coonhound",
            "Border Collie",
            "Border Terrier",
            "Borzoi",
            "Boston Terrier",
            "Bouvier des Flandres",
            "Boxer",
            "Boykin Spaniel",
            "Briard",
            "Brittany",
            "Brussels Griffon",
            "Bull Terrier",
            "Bulldog",
            "Bullmastiff",
            "Cairn Terrier",
            "Canaan Dog",
            "Cane Corso",
            "Cardigan Welsh Corgi",
            "Cavalier King Charles Spaniel",
            "Cesky Terrier",
            "Chesapeake Bay Retriever",
            "Chihuahua",
            "Chinese Crested",
            "Chinese Shar-Pei",
            "Chinook",
            "Chow Chow",
            "Clumber Spaniel",
            "Cocker Spaniel",
            "Collie",
            "Curly-Coated Retriever",
            "Dachshund",
            "Dalmatian",
            "Dandie Dinmont Terrier",
            "Doberman Pinscher",
            "Dogue de Bordeaux",
            "English Cocker Spaniel",
            "English Foxhound",
            "English Setter",
            "English Springer Spaniel",
            "English Toy Spaniel",
            "Entlebucher Mountain Dog",
            "Field Spaniel",
            "Finnish Lapphund",
            "Finnish Spitz",
            "Flat-Coated Retriever",
            "French Bulldog",
            "German Pinscher",
            "German Shepherd Dog",
            "German Shorthaired Pointer",
            "German Wirehaired Pointer",
            "Giant Schnauzer",
            "Glen of Imaal Terrier",
            "Golden Retriever",
            "Gordon Setter",
            "Great Dane",
            "Great Pyrenees",
            "Greater Swiss Mountain Dog",
            "Greyhound",
            "Harrier",
            "Havanese",
            "Ibizan Hound",
            "Icelandic Sheepdog",
            "Irish Red and White Setter",
            "Irish Setter",
            "Irish Terrier",
            "Irish Water Spaniel",
            "Irish Wolfhound",
            "Italian Greyhound",
            "Japanese Chin",
            "Keeshond",
            "Kerry Blue Terrier",
            "Komondor",
            "Kuvasz",
            "Labrador Retriever",
            "Lakeland Terrier",
            "Leonberger",
            "Lhasa Apso",
            "Lowchen",
            "Maltese",
            "Manchester Terrier",
            "Mastiff",
            "Miniature Bull Terrier",
            "Miniature Pinscher",
            "Miniature Schnauzer",
            "Neapolitan Mastiff",
            "Newfoundland",
            "Norfolk Terrier",
            "Norwegian Buhund",
            "Norwegian Elkhound",
            "Norwegian Lundehund",
            "Norwich Terrier",
            "Nova Scotia Duck Tolling Retriever",
            "Old English Sheepdog",
            "Otterhound",
            "Papillon",
            "Parson Russell Terrier",
            "Pekingese",
            "Pembroke Welsh Corgi",
            "Petit Basset Griffon Vendeen",
            "Pharaoh Hound",
            "Plott",
            "Pointer",
            "Polish Lowland Sheepdog",
            "Pomeranian",
            "Poodle",
            "Portuguese Podengo Pequeno",
            "Portuguese Water Dog",
            "Pug",
            "Puli",
            "Pyrenean Shepherd",
            "Rat Terrier",
            "Redbone Coonhound",
            "Rhodesian Ridgeback",
            "Rottweiler",
            "Russell Terrier",
            "Saluki",
            "Samoyed",
            "Schipperke",
            "Scottish Deerhound",
            "Scottish Terrier",
            "Sealyham Terrier",
            "Shetland Sheepdog",
            "Shiba Inu",
            "Shih Tzu",
            "Siberian Husky",
            "Silky Terrier",
            "Skye Terrier",
            "Smooth Fox Terrier",
            "Soft Coated Wheaten Terrier",
            "Spinone Italiano",
            "St. Bernard",
            "Staffordshire Bull Terrier",
            "Standard Schnauzer",
            "Sussex Spaniel",
            "Swedish Vallhund",
            "Tibetan Mastiff",
            "Tibetan Spaniel",
            "Tibetan Terrier",
            "Toy Fox Terrier",
            "Treeing Walker Coonhound",
            "Vizsla",
            "Weimaraner",
            "Welsh Springer Spaniel",
            "Welsh Terrier",
            "West Highland White Terrier",
            "Whippet",
            "Wire Fox Terrier",
            "Wirehaired Pointing Griffon",
            "Xoloitzcuintli",
            "Yorkshire Terrier"});
            this.cmbBxBreed.Location = new System.Drawing.Point(87, 128);
            this.cmbBxBreed.Name = "cmbBxBreed";
            this.cmbBxBreed.Size = new System.Drawing.Size(165, 21);
            this.cmbBxBreed.Sorted = true;
            this.cmbBxBreed.TabIndex = 17;
            // 
            // cmBxCategory
            // 
            this.cmBxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxCategory.Enabled = false;
            this.cmBxCategory.FormattingEnabled = true;
            this.cmBxCategory.Items.AddRange(new object[] {
            "Herding Group",
            "Hound Group",
            "Non-Sporting Group",
            "Sporting Group",
            "Terrier Group",
            "Toy Group",
            "Working Group"});
            this.cmBxCategory.Location = new System.Drawing.Point(87, 223);
            this.cmBxCategory.Name = "cmBxCategory";
            this.cmBxCategory.Size = new System.Drawing.Size(120, 21);
            this.cmBxCategory.TabIndex = 16;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(152, 156);
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
            this.rbMale.Location = new System.Drawing.Point(87, 156);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 14;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtBxAge
            // 
            this.txtBxAge.Location = new System.Drawing.Point(87, 55);
            this.txtBxAge.Name = "txtBxAge";
            this.txtBxAge.Size = new System.Drawing.Size(49, 20);
            this.txtBxAge.TabIndex = 8;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(87, 25);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(120, 20);
            this.txtBxName.TabIndex = 7;
            // 
            // btnAddToCatalog
            // 
            this.btnAddToCatalog.Location = new System.Drawing.Point(68, 14);
            this.btnAddToCatalog.Name = "btnAddToCatalog";
            this.btnAddToCatalog.Size = new System.Drawing.Size(126, 23);
            this.btnAddToCatalog.TabIndex = 8;
            this.btnAddToCatalog.Text = "Add to Catalogue";
            this.btnAddToCatalog.UseVisualStyleBackColor = true;
            this.btnAddToCatalog.Click += new System.EventHandler(this.btnAddToCatalog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddToCatalog);
            this.groupBox1.Location = new System.Drawing.Point(12, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 42);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update";
            // 
            // DogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 330);
            this.Controls.Add(this.grpBxDetails);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dog Details";
            this.grpBxDetails.ResumeLayout(false);
            this.grpBxDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox grpBxDetails;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtBxAge;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.ComboBox cmbBxBreed;
        private System.Windows.Forms.ComboBox cmBxCategory;
        private System.Windows.Forms.CheckBox chkBxPureBreed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToCatalog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBxColor;
    }
}