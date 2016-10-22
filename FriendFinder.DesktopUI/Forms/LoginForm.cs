using FriendFinder.Code;
using FriendFinder.Entities;
using FriendFinder.Repositories;
using FriendFinder.Repositories.Interfaces;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FriendFinder.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IUserRepository _userRepository;

        public LoginForm()
        {
            _userRepository = new SqlUserRepository(
               ConfigurationManager.ConnectionStrings["FriendFinderDB"].ConnectionString);
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            User loggedUser = null;

            try
            {
                loggedUser = _userRepository.GetUserByEmail(email, password);
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (loggedUser != null)
            {
                CurrentUser.Initialize(loggedUser);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Wrong name or password", "Authorization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //REVIEW TK: NAMING! Why caps?
        private void buttonSIGNUP_Click(object sender, EventArgs e)
        {
            (new SignUpForm()).Show();
        }
    }
}
