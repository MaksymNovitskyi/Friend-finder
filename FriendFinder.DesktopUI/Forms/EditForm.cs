using FriendFinder.Code;
using FriendFinder.Repositories;
using FriendFinder.Repositories.Helpers;
using FriendFinder.Repositories.Interfaces;
using FriendFinder.Repositories.Repositories;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FriendFinder.Forms
{
    public partial class EditForm : Form
    {
        private readonly IPersonRepository _personRepository;
        private readonly ITerritoryRepository _territoryRepository;
        private readonly IQuestionaryRepository _questionaryRepository;
        private readonly IUserRepository _userRepository;

        public EditForm()
        {
            _personRepository = new SqlPersonRepository(
                ConfigurationManager.ConnectionStrings["FriendFinderDB"].ConnectionString);
            _territoryRepository = new SqlTerritoryRepository(
                ConfigurationManager.ConnectionStrings["FriendFinderDB"].ConnectionString);
            _questionaryRepository = new SqlQuestionaryRepository(
                ConfigurationManager.ConnectionStrings["FriendFinderDB"].ConnectionString);
            _userRepository = new SqlUserRepository(
                ConfigurationManager.ConnectionStrings["FriendFinderDB"].ConnectionString);
            InitializeComponent();
        }

        private void Editing_Load(object sender, EventArgs e)
        {
            nameBox.Text = CurrentUser.GetPersonInfo().Name;
            surnameBox.Text = CurrentUser.GetPersonInfo().Surname;
            birthBox.Text = CurrentUser.GetPersonInfo().DateOfBirth.ToString("yyyy-MM-dd");
            if(CurrentUser.GetPersonInfo().Gender == 'M')
            {
                maleRadio.Checked = true;
            }
            else
            {
                femaleRadio.Checked = true;
            }
            educationCombo.SelectedItem = CurrentUser.GetQuestionaryInfo().Education;
            regionBox.Text = CurrentUser.GetTerritoryInfo().Region;
            cityBox.Text = CurrentUser.GetTerritoryInfo().City;
            emailBox.Text = CurrentUser.GetEmailAddress();
            musicCombo.SelectedItem = CurrentUser.GetQuestionaryInfo().FavoriteMusicGenre;
            movieCombo.SelectedItem = CurrentUser.GetQuestionaryInfo().FavoriteMovieGenre;
            politicalCombo.SelectedItem = CurrentUser.GetQuestionaryInfo().PoliticalViews;
            smokingCombo.SelectedItem = Helper.IntToViewsOn(CurrentUser.GetQuestionaryInfo().ViewsOnSmoking);
            alcoCombo.SelectedItem = Helper.IntToViewsOn(CurrentUser.GetQuestionaryInfo().ViewsOnAlcohol);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int response = 0;
            try
            {
                response = _personRepository.UpdatePerson(CurrentUser.GetId(), nameBox.Text, surnameBox.Text,
                    maleRadio.Checked ? 'M' : 'W', birthBox.Text);

                response = _territoryRepository.UpdateTerritory(CurrentUser.GetId(), regionBox.Text, cityBox.Text);

                response = _questionaryRepository.UpdateQuestionary(CurrentUser.GetId(),
                    (string)educationCombo.SelectedItem, (string)musicCombo.SelectedItem,
                    (string)movieCombo.SelectedItem, Helper.ViewsOnToInt((string)smokingCombo.SelectedItem), 
                    Helper.ViewsOnToInt((string)alcoCombo.SelectedItem), (string)politicalCombo.SelectedItem);

                response = _userRepository.UpdateEmailAddress(CurrentUser.GetId(), emailBox.Text);
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(response == -1)
            {
                MessageBox.Show("Profile wasn't edited.");
            }

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

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.ActiveForm.Refresh();
        }
    }
}
