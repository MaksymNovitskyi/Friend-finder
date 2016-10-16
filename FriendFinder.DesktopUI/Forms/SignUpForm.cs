using FriendFinder.Code;
using FriendFinder.Repositories;
using FriendFinder.Repositories.Helpers;
using FriendFinder.Repositories.Interfaces;
using FriendFinder.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendFinder.Forms
{
    public partial class SignUpForm : Form
    {
        private IUserRepository _userRepository;

        public SignUpForm()
        {
            _userRepository = new SqlUserRepository(
                ConfigurationManager.ConnectionStrings["FriendFinderDB"].ConnectionString);
            InitializeComponent();
        }

        private void showpasswordButton_MouseDown(object sender, MouseEventArgs e)
        {
            passwordBox.PasswordChar = '\0';
        }

        private void showpasswordButton_MouseUp(object sender, MouseEventArgs e)
        {
            passwordBox.PasswordChar = '*';
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void singupButton_Click(object sender, EventArgs e)
        {
            var encryptedPassword = (new Encryptor()).Encrypt(passwordBox.Text);

            var response = _userRepository.AddParticipant(nameBox.Text, surnameBox.Text,
                maleRadio.Checked ? 'M' : 'W', birthBox.Text, regionBox.Text, cityBox.Text,
                (string)educationCombo.SelectedItem, (string)musicCombo.SelectedItem, (string)movieCombo.SelectedItem,
                Helper.ViewsOnToInt((string)smokingCombo.SelectedItem), Helper.ViewsOnToInt((string)alcoCombo.SelectedItem),
                (string)politicalCombo.SelectedItem, null, emailBox.Text, encryptedPassword, string.Empty);

            if(response == 0)
            {
                MessageBox.Show("Some fields are filled incorrectly or this email-address has been registered already");
            }
            else
            {
                this.Close();
            }

        }
    }
}
