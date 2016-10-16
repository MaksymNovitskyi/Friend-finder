namespace FriendFinder.Forms
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.singupButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.personal = new System.Windows.Forms.GroupBox();
            this.alcoCombo = new System.Windows.Forms.ComboBox();
            this.smokingCombo = new System.Windows.Forms.ComboBox();
            this.politicalCombo = new System.Windows.Forms.ComboBox();
            this.movieCombo = new System.Windows.Forms.ComboBox();
            this.musicCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.GroupBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.regionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.general = new System.Windows.Forms.GroupBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.educationCombo = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.birthBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.showpasswordButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.personal.SuspendLayout();
            this.contact.SuspendLayout();
            this.general.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // singupButton
            // 
            this.singupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singupButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singupButton.Location = new System.Drawing.Point(127, 599);
            this.singupButton.Name = "singupButton";
            this.singupButton.Size = new System.Drawing.Size(128, 40);
            this.singupButton.TabIndex = 10;
            this.singupButton.Text = "Sign up";
            this.singupButton.UseVisualStyleBackColor = true;
            this.singupButton.Click += new System.EventHandler(this.singupButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.personal);
            this.panel2.Controls.Add(this.contact);
            this.panel2.Controls.Add(this.general);
            this.panel2.Location = new System.Drawing.Point(16, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 563);
            this.panel2.TabIndex = 9;
            // 
            // personal
            // 
            this.personal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personal.Controls.Add(this.alcoCombo);
            this.personal.Controls.Add(this.smokingCombo);
            this.personal.Controls.Add(this.politicalCombo);
            this.personal.Controls.Add(this.movieCombo);
            this.personal.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.personal.Controls.Add(this.musicCombo);
            this.personal.Controls.Add(this.label11);
            this.personal.Controls.Add(this.label12);
            this.personal.Controls.Add(this.label8);
            this.personal.Controls.Add(this.label6);
            this.personal.Controls.Add(this.label7);
            this.personal.Location = new System.Drawing.Point(3, 352);
            this.personal.Name = "personal";
            this.personal.Size = new System.Drawing.Size(504, 200);
            this.personal.TabIndex = 2;
            this.personal.TabStop = false;
            this.personal.Text = "PERSONAL VIEWS";
            // 
            // alcoCombo
            // 
            this.alcoCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alcoCombo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alcoCombo.FormattingEnabled = true;
            this.alcoCombo.Items.AddRange(new object[] {
            "Negative",
            "Neutral",
            "Positive"});
            this.alcoCombo.Location = new System.Drawing.Point(215, 166);
            this.alcoCombo.Name = "alcoCombo";
            this.alcoCombo.Size = new System.Drawing.Size(186, 28);
            this.alcoCombo.TabIndex = 14;
            // 
            // smokingCombo
            // 
            this.smokingCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smokingCombo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smokingCombo.FormattingEnabled = true;
            this.smokingCombo.Items.AddRange(new object[] {
            "Negative",
            "Neutral",
            "Positive"});
            this.smokingCombo.Location = new System.Drawing.Point(215, 130);
            this.smokingCombo.Name = "smokingCombo";
            this.smokingCombo.Size = new System.Drawing.Size(186, 28);
            this.smokingCombo.TabIndex = 13;
            // 
            // politicalCombo
            // 
            this.politicalCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.politicalCombo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.politicalCombo.FormattingEnabled = true;
            this.politicalCombo.Items.AddRange(new object[] {
            "Communist",
            "Socialist",
            "Moderate",
            "Liberal",
            "Conservative"});
            this.politicalCombo.Location = new System.Drawing.Point(215, 92);
            this.politicalCombo.Name = "politicalCombo";
            this.politicalCombo.Size = new System.Drawing.Size(186, 28);
            this.politicalCombo.TabIndex = 12;
            // 
            // movieCombo
            // 
            this.movieCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieCombo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movieCombo.FormattingEnabled = true;
            this.movieCombo.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Comedy",
            "Crime",
            "Drama",
            "Fantasy",
            "Historical",
            "Historical fiction",
            "Horror"});
            this.movieCombo.Location = new System.Drawing.Point(215, 57);
            this.movieCombo.Name = "movieCombo";
            this.movieCombo.Size = new System.Drawing.Size(186, 28);
            this.movieCombo.TabIndex = 11;
            // 
            // musicCombo
            // 
            this.musicCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicCombo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.musicCombo.FormattingEnabled = true;
            this.musicCombo.Items.AddRange(new object[] {
            "Blues",
            "Classical",
            "Country",
            "Electronic",
            "Rap",
            "Jazz",
            "Opera",
            "Pop",
            "Reggae",
            "Rock"});
            this.musicCombo.Location = new System.Drawing.Point(215, 23);
            this.musicCombo.Name = "musicCombo";
            this.musicCombo.Size = new System.Drawing.Size(186, 28);
            this.musicCombo.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "Views on alcohol:";
            this.label11.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 21);
            this.label12.TabIndex = 8;
            this.label12.Text = "Views on smoking:";
            this.label12.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Political views:";
            this.label8.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Favorite movie genre:";
            this.label6.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Favorite music genre:";
            this.label7.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // contact
            // 
            this.contact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contact.Controls.Add(this.showpasswordButton);
            this.contact.Controls.Add(this.passwordBox);
            this.contact.Controls.Add(this.label14);
            this.contact.Controls.Add(this.emailBox);
            this.contact.Controls.Add(this.cityBox);
            this.contact.Controls.Add(this.regionBox);
            this.contact.Controls.Add(this.label1);
            this.contact.Controls.Add(this.label5);
            this.contact.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.contact.Controls.Add(this.label4);
            this.contact.Location = new System.Drawing.Point(3, 189);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(504, 157);
            this.contact.TabIndex = 1;
            this.contact.TabStop = false;
            this.contact.Text = "CONTACT INFO";
            // 
            // emailBox
            // 
            this.emailBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailBox.Location = new System.Drawing.Point(215, 83);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(220, 27);
            this.emailBox.TabIndex = 7;
            // 
            // cityBox
            // 
            this.cityBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityBox.Location = new System.Drawing.Point(215, 49);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(220, 27);
            this.cityBox.TabIndex = 6;
            // 
            // regionBox
            // 
            this.regionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regionBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regionBox.Location = new System.Drawing.Point(215, 16);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(220, 27);
            this.regionBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "City:";
            this.label1.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email address:";
            this.label5.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Region:";
            this.label4.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // general
            // 
            this.general.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.general.Controls.Add(this.surnameBox);
            this.general.Controls.Add(this.educationCombo);
            this.general.Controls.Add(this.nameBox);
            this.general.Controls.Add(this.label10);
            this.general.Controls.Add(this.panel1);
            this.general.Controls.Add(this.label13);
            this.general.Controls.Add(this.birthBox);
            this.general.Controls.Add(this.label3);
            this.general.Controls.Add(this.label9);
            this.general.Controls.Add(this.label2);
            this.general.Location = new System.Drawing.Point(3, 8);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(504, 175);
            this.general.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.general.TabIndex = 0;
            this.general.TabStop = false;
            this.general.Text = "GENERAL";
            // 
            // surnameBox
            // 
            this.surnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameBox.Location = new System.Drawing.Point(214, 43);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(220, 27);
            this.surnameBox.TabIndex = 11;
            // 
            // educationCombo
            // 
            this.educationCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.educationCombo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.educationCombo.FormattingEnabled = true;
            this.educationCombo.Items.AddRange(new object[] {
            "High School",
            "College",
            "University",
            "None"});
            this.educationCombo.Location = new System.Drawing.Point(214, 139);
            this.educationCombo.Name = "educationCombo";
            this.educationCombo.Size = new System.Drawing.Size(186, 28);
            this.educationCombo.TabIndex = 9;
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(214, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(220, 27);
            this.nameBox.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(9, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Surname";
            this.label10.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.femaleRadio);
            this.panel1.Controls.Add(this.maleRadio);
            this.panel1.Location = new System.Drawing.Point(207, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 26);
            this.panel1.TabIndex = 8;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.femaleRadio.Location = new System.Drawing.Point(90, 3);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(73, 21);
            this.femaleRadio.TabIndex = 10;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Checked = true;
            this.maleRadio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maleRadio.Location = new System.Drawing.Point(16, 3);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(57, 21);
            this.maleRadio.TabIndex = 9;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(9, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "Name:";
            this.label13.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // birthBox
            // 
            this.birthBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthBox.Location = new System.Drawing.Point(223, 78);
            this.birthBox.Mask = "0000-00-00";
            this.birthBox.Name = "birthBox";
            this.birthBox.Size = new System.Drawing.Size(148, 26);
            this.birthBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sex:";
            this.label3.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(9, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Education:";
            this.label9.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Birthday:";
            this.label2.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(273, 599);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(128, 40);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(197,157,133);
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(9, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 21);
            this.label14.TabIndex = 8;
            this.label14.Text = "Password:";
            this.label14.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.Location = new System.Drawing.Point(214, 119);
            this.passwordBox.MaxLength = 15;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(157, 27);
            this.passwordBox.TabIndex = 9;
            // 
            // showpasswordButton
            // 
            this.showpasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showpasswordButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showpasswordButton.Location = new System.Drawing.Point(398, 120);
            this.showpasswordButton.Name = "showpasswordButton";
            this.showpasswordButton.Size = new System.Drawing.Size(75, 26);
            this.showpasswordButton.TabIndex = 10;
            this.showpasswordButton.Text = "Show";
            this.showpasswordButton.UseVisualStyleBackColor = true;
            this.showpasswordButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showpasswordButton_MouseDown);
            this.showpasswordButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showpasswordButton_MouseUp);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ClientSize = new System.Drawing.Size(539, 651);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.singupButton);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.Text = "Sign Up!";
            this.panel2.ResumeLayout(false);
            this.personal.ResumeLayout(false);
            this.personal.PerformLayout();
            this.contact.ResumeLayout(false);
            this.contact.PerformLayout();
            this.general.ResumeLayout(false);
            this.general.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

            //
            // signupButton
            //
            this.singupButton.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
        }

        #endregion

        private System.Windows.Forms.Button singupButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox personal;
        private System.Windows.Forms.ComboBox alcoCombo;
        private System.Windows.Forms.ComboBox smokingCombo;
        private System.Windows.Forms.ComboBox politicalCombo;
        private System.Windows.Forms.ComboBox movieCombo;
        private System.Windows.Forms.ComboBox musicCombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox contact;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox regionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox general;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.ComboBox educationCombo;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox birthBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button showpasswordButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label14;
    }
}