using FriendFinder.Entities;
using FriendFinder.Repositories;
using FriendFinder.Repositories.Helpers;
using FriendFinder.Repositories.Interfaces;
using System.Configuration;
using System.Windows.Forms;

namespace FriendFinder.Forms
{
    public partial class ProfileForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly User _user;

        public ProfileForm(int userID)
        {
            InitializeComponent();

            _userRepository = new SqlUserRepository(
                            ConfigurationManager.ConnectionStrings["FriendFinderDB"].ConnectionString);
            _user = _userRepository.GetParticipant(userID);
        }

        //REVIEW TK: Naming. 
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (_user.PhotoLink != string.Empty)
            {
                profilePic.ImageLocation = _user.PhotoLink;
            }

            nameLabel.Text = _user.Person.Name + '\n' + _user.Person.Surname;

            birthLabel.Text = _user.Person.DateOfBirth.ToShortDateString();
            sexLabel.Text = _user.Person.Gender == 'M' ? "Male" : "Female";
            educLabel.Text = _user.Questionary.Education;

            regionLabel.Text = _user.Territory.Region + "/" + _user.Territory.City;
            emailLabel.Text = _user.EmailAddress;

            musicLabel.Text = _user.Questionary.FavoriteMusicGenre;
            movieLabel.Text = _user.Questionary.FavoriteMovieGenre;
            politicalLabel.Text = _user.Questionary.PoliticalViews;
            smokingLabel.Text = Helper.IntToViewsOn(_user.Questionary.ViewsOnSmoking);
            alcoLabel.Text = Helper.IntToViewsOn(_user.Questionary.ViewsOnAlcohol);

            this.Text = _user.Person.Name + '\n' + _user.Person.Surname;
        }
    }
}
