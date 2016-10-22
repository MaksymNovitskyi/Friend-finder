using FriendFinder.Code;
using FriendFinder.Repositories.Interfaces;
using FriendFinder.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace FriendFinder.Forms
{
    public partial class FriendsForm : Form
    {
        private readonly IFinderRepository _finderRepository;

        public FriendsForm()
        {
            _finderRepository = new SqlFinderRepository(
                ConfigurationManager.ConnectionStrings["FriendFinderDB"].ConnectionString);

            InitializeComponent();
        }

        //REVIEW TK: Naming.
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            var ids = _finderRepository.GetIdsOfTheMostSuitablePersons(CurrentUser.GetId(), trackBar1.Value);
            UpdateListOfFriends(ids);
        }

        private void UpdateListOfFriends(IEnumerable<int> ids)
        {
            panel.Controls.Clear();

            int index = 0;

            foreach(var item in ids)
            {
                var frForm = new FriendItem(item, index+1) { Location = new Point(0, index * 100) };
                panel.Controls.Add(frForm);
                frForm.Show();
                index++;
            }
        }
    }
}
