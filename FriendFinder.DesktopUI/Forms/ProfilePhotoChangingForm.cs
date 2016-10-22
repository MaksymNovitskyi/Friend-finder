using FriendFinder.Code;
using FriendFinder.Repositories;
using FriendFinder.Repositories.Interfaces;
using System;
using System.Configuration;
using System.Globalization;
using System.Net;
using System.Windows.Forms;

namespace FriendFinder.Forms
{
    public partial class ProfilePhotoChangingForm : Form
    {
        private readonly IUserRepository _userRepository;

        public ProfilePhotoChangingForm()
        {
            _userRepository = new SqlUserRepository(
                    ConfigurationManager.ConnectionStrings["FriendFinderDB"].ConnectionString);
            InitializeComponent();
        }

        //REVIEW TK: Naming!
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(IsValidPhotoLink(textBox1.Text))
            {
                profilePic.ImageLocation = textBox1.Text;
            }
        }


        private bool IsValidPhotoLink(string photolink)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                return false;
            }
            //REVIEW TK: throws exception when http link is invalid!
            //Use some kind of regex to check it before creating!
            var req = (HttpWebRequest)HttpWebRequest.Create(photolink);
            req.Method = "HEAD";
            using (var resp = req.GetResponse())
            {
                return resp.ContentType.ToLower(CultureInfo.InvariantCulture)
                           .StartsWith("image/");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(IsValidPhotoLink(textBox1.Text))
            {
                _userRepository.UpdatePhotoLink(CurrentUser.GetId(), textBox1.Text);

                CurrentUser.Logout();

                var loginForm = new LoginForm();

                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var mainForm = new MainForm();
                mainForm.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Link is not valid.");
            }
        }

        //REVIEW TK: why do you even deny cancel button? it makes UI uncomfortable.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
