namespace FriendFinder.Forms
{
    partial class FriendItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendItem));
            this.friendPhotoBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profileButton = new System.Windows.Forms.Button();
            this.indexLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.friendPhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // friendPhotoBox
            // 
            this.friendPhotoBox.Image = ((System.Drawing.Image)(resources.GetObject("friendPhotoBox.Image")));
            this.friendPhotoBox.Location = new System.Drawing.Point(57, 3);
            this.friendPhotoBox.Name = "friendPhotoBox";
            this.friendPhotoBox.Size = new System.Drawing.Size(100, 94);
            this.friendPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.friendPhotoBox.TabIndex = 0;
            this.friendPhotoBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(129)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(165, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name Surname";
            // 
            // profileButton
            // 
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.profileButton.Location = new System.Drawing.Point(170, 57);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(180, 36);
            this.profileButton.TabIndex = 3;
            this.profileButton.Text = "Open profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.indexLabel.Location = new System.Drawing.Point(14, 38);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(22, 24);
            this.indexLabel.TabIndex = 4;
            this.indexLabel.Text = "1";
            // 
            // FriendItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.indexLabel);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.friendPhotoBox);
            this.Name = "FriendItem";
            this.Size = new System.Drawing.Size(500, 100);
            this.Load += new System.EventHandler(this.FriendItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.friendPhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox friendPhotoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Label indexLabel;
    }
}
