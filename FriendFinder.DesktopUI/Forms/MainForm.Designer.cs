namespace FriendFinder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.navBox = new System.Windows.Forms.GroupBox();
            this.luckyButton = new System.Windows.Forms.Button();
            this.findFriendButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.myProfileBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.changePhotoLink = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.general = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.educLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.regionLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.personal = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.musicLabel = new System.Windows.Forms.Label();
            this.movieLabel = new System.Windows.Forms.Label();
            this.politicalLabel = new System.Windows.Forms.Label();
            this.smokingLabel = new System.Windows.Forms.Label();
            this.alcoLabel = new System.Windows.Forms.Label();
            this.deleteLink = new System.Windows.Forms.LinkLabel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.navBox.SuspendLayout();
            this.myProfileBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.panel2.SuspendLayout();
            this.general.SuspendLayout();
            this.contact.SuspendLayout();
            this.personal.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.navBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.infoPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 484);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // navBox
            // 
            this.navBox.Controls.Add(this.luckyButton);
            this.navBox.Controls.Add(this.findFriendButton);
            this.navBox.Controls.Add(this.profileButton);
            this.navBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBox.Location = new System.Drawing.Point(3, 3);
            this.navBox.Name = "navBox";
            this.navBox.Size = new System.Drawing.Size(178, 478);
            this.navBox.TabIndex = 0;
            this.navBox.TabStop = false;
            // 
            // luckyButton
            // 
            this.luckyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.luckyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.luckyButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.luckyButton.Location = new System.Drawing.Point(3, 88);
            this.luckyButton.Name = "luckyButton";
            this.luckyButton.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.luckyButton.Size = new System.Drawing.Size(172, 36);
            this.luckyButton.TabIndex = 2;
            this.luckyButton.Text = "I\'m Lucky!";
            this.luckyButton.UseVisualStyleBackColor = true;
            this.luckyButton.Click += new System.EventHandler(this.luckyButton_Click);
            // 
            // findFriendButton
            // 
            this.findFriendButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.findFriendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findFriendButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findFriendButton.Location = new System.Drawing.Point(3, 52);
            this.findFriendButton.Name = "findFriendButton";
            this.findFriendButton.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.findFriendButton.Size = new System.Drawing.Size(172, 36);
            this.findFriendButton.TabIndex = 1;
            this.findFriendButton.Text = "Find friends";
            this.findFriendButton.UseVisualStyleBackColor = true;
            this.findFriendButton.Click += new System.EventHandler(this.findFriendButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileButton.Location = new System.Drawing.Point(3, 16);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(172, 36);
            this.profileButton.TabIndex = 0;
            this.profileButton.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.profileButton.Text = "Edit my profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // myProfileBox
            // 
            this.myProfileBox.Controls.Add(this.deleteLink);
            this.myProfileBox.Controls.Add(this.panel2);
            this.myProfileBox.Controls.Add(this.panel1);
            this.myProfileBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myProfileBox.Location = new System.Drawing.Point(0, 0);
            this.myProfileBox.Name = "myProfileBox";
            this.myProfileBox.Size = new System.Drawing.Size(732, 478);
            this.myProfileBox.TabIndex = 0;
            this.myProfileBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.changePhotoLink);
            this.panel1.Controls.Add(this.profilePic);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(492, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 285);
            this.panel1.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(54, 129, 197);
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(10, 235);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(101, 48);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name\r\nSurname";
            // 
            // profilePic
            // 
            this.profilePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePic.Image = ((System.Drawing.Image)(resources.GetObject("profilePic.Image")));
            this.profilePic.Location = new System.Drawing.Point(0, 0);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(228, 232);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePic.TabIndex = 1;
            this.profilePic.TabStop = false;
            // 
            // changePhotoLink
            // 
            this.changePhotoLink.ActiveLinkColor = System.Drawing.Color.Black;
            this.changePhotoLink.AutoSize = true;
            this.changePhotoLink.BackColor = System.Drawing.Color.Transparent;
            this.changePhotoLink.DisabledLinkColor = System.Drawing.Color.Silver;
            this.changePhotoLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePhotoLink.LinkColor = System.Drawing.Color.DimGray;
            this.changePhotoLink.Location = new System.Drawing.Point(10, 204);
            this.changePhotoLink.Name = "changePhotoLink";
            this.changePhotoLink.Size = new System.Drawing.Size(208, 21);
            this.changePhotoLink.TabIndex = 2;
            this.changePhotoLink.TabStop = true;
            this.changePhotoLink.Text = "CHANGE PROFILE PHOTO";
            this.changePhotoLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.changePhotoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changePhotoLink_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.personal);
            this.panel2.Controls.Add(this.contact);
            this.panel2.Controls.Add(this.general);
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 456);
            this.panel2.TabIndex = 2;
            // 
            // general
            // 
            this.general.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.general.Controls.Add(this.sexLabel);
            this.general.Controls.Add(this.educLabel);
            this.general.Controls.Add(this.birthLabel);
            this.general.Controls.Add(this.label3);
            this.general.Controls.Add(this.label9);
            this.general.Controls.Add(this.label2);
            this.general.Location = new System.Drawing.Point(3, 8);
            this.general.Name = "general";
            this.general.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.general.Size = new System.Drawing.Size(477, 114);
            this.general.TabIndex = 0;
            this.general.TabStop = false;
            this.general.Text = "GENERAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 0;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            this.label2.Text = "Birthday:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(7, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 21);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            this.label9.TabIndex = 6;
            this.label9.Text = "Education:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sex:";
            this.label3.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthLabel.Location = new System.Drawing.Point(192, 19);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(0, 21);
            this.birthLabel.TabIndex = 7;
            // 
            // educLabel
            // 
            this.educLabel.AutoSize = true;
            this.educLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.educLabel.Location = new System.Drawing.Point(191, 75);
            this.educLabel.Name = "educLabel";
            this.educLabel.Size = new System.Drawing.Size(0, 21);
            this.educLabel.TabIndex = 9;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.Location = new System.Drawing.Point(192, 46);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(0, 21);
            this.sexLabel.TabIndex = 8;
            // 
            // contact
            // 
            this.contact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contact.Controls.Add(this.emailLabel);
            this.contact.Controls.Add(this.regionLabel);
            this.contact.Controls.Add(this.label5);
            this.contact.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.contact.Controls.Add(this.label4);
            this.contact.Location = new System.Drawing.Point(3, 128);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(477, 86);
            this.contact.TabIndex = 1;
            this.contact.TabStop = false;
            this.contact.Text = "CONTACT INFO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Region/City:";
            this.label4.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email address:";
            this.label5.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regionLabel.Location = new System.Drawing.Point(182, 22);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(0, 21);
            this.regionLabel.TabIndex = 4;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(182, 51);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(0, 21);
            this.emailLabel.TabIndex = 5;
            // 
            // personal
            // 
            this.personal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personal.Controls.Add(this.alcoLabel);
            this.personal.Controls.Add(this.smokingLabel);
            this.personal.Controls.Add(this.politicalLabel);
            this.personal.Controls.Add(this.movieLabel);
            this.personal.Controls.Add(this.musicLabel);
            this.personal.Controls.Add(this.label11);
            this.personal.Controls.Add(this.label12);
            this.personal.Controls.Add(this.label8);
            this.personal.Controls.Add(this.label6);
            this.personal.Controls.Add(this.label7);
            this.personal.Location = new System.Drawing.Point(3, 220);
            this.personal.Name = "personal";
            this.personal.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.personal.Size = new System.Drawing.Size(477, 233);
            this.personal.TabIndex = 2;
            this.personal.TabStop = false;
            this.personal.Text = "PERSONAL VIEWS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Favorite music genre:";
            this.label7.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Favorite movie genre:";
            this.label6.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Political views:";
            this.label8.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(8, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 21);
            this.label12.TabIndex = 8;
            this.label12.Text = "Views on smoking:";
            this.label12.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "Views on alcohol:";
            this.label11.ForeColor = System.Drawing.Color.FromArgb(65, 193, 134);
            // 
            // musicLabel
            // 
            this.musicLabel.AutoSize = true;
            this.musicLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.musicLabel.Location = new System.Drawing.Point(192, 29);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(0, 21);
            this.musicLabel.TabIndex = 10;
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movieLabel.Location = new System.Drawing.Point(192, 65);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(0, 21);
            this.movieLabel.TabIndex = 11;
            // 
            // politicalLabel
            // 
            this.politicalLabel.AutoSize = true;
            this.politicalLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.politicalLabel.Location = new System.Drawing.Point(194, 99);
            this.politicalLabel.Name = "politicalLabel";
            this.politicalLabel.Size = new System.Drawing.Size(0, 21);
            this.politicalLabel.TabIndex = 12;
            // 
            // smokingLabel
            // 
            this.smokingLabel.AutoSize = true;
            this.smokingLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smokingLabel.Location = new System.Drawing.Point(194, 130);
            this.smokingLabel.Name = "smokingLabel";
            this.smokingLabel.Size = new System.Drawing.Size(0, 21);
            this.smokingLabel.TabIndex = 13;
            // 
            // alcoLabel
            // 
            this.alcoLabel.AutoSize = true;
            this.alcoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alcoLabel.Location = new System.Drawing.Point(194, 166);
            this.alcoLabel.Name = "alcoLabel";
            this.alcoLabel.Size = new System.Drawing.Size(0, 21);
            this.alcoLabel.TabIndex = 14;
            // 
            // deleteLink
            // 
            this.deleteLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteLink.AutoSize = true;
            this.deleteLink.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteLink.Location = new System.Drawing.Point(627, 453);
            this.deleteLink.Name = "deleteLink";
            this.deleteLink.Size = new System.Drawing.Size(93, 16);
            this.deleteLink.TabIndex = 3;
            this.deleteLink.TabStop = true;
            this.deleteLink.Text = "Delete account";
            this.deleteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deleteLink_LinkClicked);
            // 
            // infoPanel
            // 
            this.infoPanel.AutoScroll = true;
            this.infoPanel.Controls.Add(this.myProfileBox);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(187, 3);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(732, 478);
            this.infoPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ClientSize = new System.Drawing.Size(922, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 39);
            this.Name = "MainForm";
            this.Text = "FriendFinder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.navBox.ResumeLayout(false);
            this.myProfileBox.ResumeLayout(false);
            this.myProfileBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.general.ResumeLayout(false);
            this.general.PerformLayout();
            this.contact.ResumeLayout(false);
            this.contact.PerformLayout();
            this.personal.ResumeLayout(false);
            this.personal.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox navBox;
        private System.Windows.Forms.Button luckyButton;
        private System.Windows.Forms.Button findFriendButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.GroupBox myProfileBox;
        private System.Windows.Forms.LinkLabel deleteLink;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox personal;
        private System.Windows.Forms.Label alcoLabel;
        private System.Windows.Forms.Label smokingLabel;
        private System.Windows.Forms.Label politicalLabel;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.Label musicLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox contact;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox general;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label educLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel changePhotoLink;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Label nameLabel;
    }
}

