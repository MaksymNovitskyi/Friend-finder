using System;
using System.Windows.Forms;
using FriendFinder.Repositories.Interfaces;
using FriendFinder.Repositories;
using System.Configuration;
using FriendFinder.Entities;

namespace FriendFinder.Forms
{
    public partial class FriendItem : UserControl
    {
        private readonly IUserRepository _userRepository;

        private readonly User _user;
        private readonly int _index;

        public FriendItem(int userID, int index)
        {
            _userRepository = new SqlUserRepository(
                            ConfigurationManager.ConnectionStrings["FriendFinderDB"].ConnectionString);
            _user = _userRepository.GetParticipant(userID);
            _index = index;

            InitializeComponent();
        }

        private void FriendItem_Load(object sender, EventArgs e)
        {
            if (!(_user.PhotoLink == null))
            {
                friendPhotoBox.ImageLocation = _user.PhotoLink;
            }

            label1.Text = _user.Person.Name + "  " + _user.Person.Surname;
            indexLabel.Text = _index.ToString();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            var profileForm = new ProfileForm(_user.Id);
            profileForm.Show();
        }
    }
}
