using FriendFinder.Code;
using FriendFinder.Forms;
using FriendFinder.Repositories;
using FriendFinder.Repositories.Helpers;
using FriendFinder.Repositories.Interfaces;
using FriendFinder.Repositories.Repositories;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace FriendFinder
{

    public partial class MainForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IFinderRepository _finderRepository;

        public MainForm()
        {
            _userRepository = new SqlUserRepository(
                ConfigurationManager.ConnectionStrings["FriendFinderDB"].ConnectionString);
            _finderRepository = new SqlFinderRepository(
                ConfigurationManager.ConnectionStrings["FriendFinderDB"].ConnectionString);

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.GetPhotoLink() != string.Empty)
            {
                profilePic.ImageLocation = CurrentUser.GetPhotoLink();
            }

            nameLabel.Text = CurrentUser.GetPersonInfo().Name + '\n' + CurrentUser.GetPersonInfo().Surname;

            birthLabel.Text = CurrentUser.GetPersonInfo().DateOfBirth.ToShortDateString();
            sexLabel.Text = CurrentUser.GetPersonInfo().Gender == 'M' ? "Male" : "Female";
            educLabel.Text = CurrentUser.GetQuestionaryInfo().Education;

            regionLabel.Text = CurrentUser.GetTerritoryInfo().Region + "/" + CurrentUser.GetTerritoryInfo().City;
            emailLabel.Text = CurrentUser.GetEmailAddress();

            musicLabel.Text = CurrentUser.GetQuestionaryInfo().FavoriteMusicGenre;
            movieLabel.Text = CurrentUser.GetQuestionaryInfo().FavoriteMovieGenre;
            politicalLabel.Text = CurrentUser.GetQuestionaryInfo().PoliticalViews;
            smokingLabel.Text = Helper.IntToViewsOn(CurrentUser.GetQuestionaryInfo().ViewsOnSmoking);
            alcoLabel.Text = Helper.IntToViewsOn(CurrentUser.GetQuestionaryInfo().ViewsOnAlcohol);
        }


        private void profileButton_Click(object sender, EventArgs e)
        {
            var editForm = new EditForm();
            editForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void changePhotoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new ProfilePhotoChangingForm()).Show();
            this.Hide();
        }

        private void deleteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete your account?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
                //REVIEW TK: if you are returning here, then there is no use for 'ELSE'.
            }
            else
            {
                _userRepository.RemoveParticipant(CurrentUser.GetId());

                CurrentUser.Logout();

                var loginForm = new LoginForm();

                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var mainForm = new MainForm();
                mainForm.Show();

                this.Hide();
            }
        }

        private void findFriendButton_Click(object sender, EventArgs e)
        {
            var friends = new FriendsForm();
            friends.Show();
        }

        private void luckyButton_Click(object sender, EventArgs e)
        {
            int rndID = _finderRepository.GetRandomID(CurrentUser.GetId());
            var profileForm = new ProfileForm(rndID);
            profileForm.Show();
        }
    }
}
