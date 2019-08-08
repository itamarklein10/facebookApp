using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;


namespace project1
{
    public partial class Form1 : Form
    {
        private User m_LoggedInUser;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void LoginUser()
        {
            LoginResult result = FacebookService.Login("2287651948215911",
                    "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts"
                                );

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                FetchUserInfo();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void FetchUserInfo()
        {
            ProfilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            if (m_LoggedInUser.Posts.Count > 0)
            {
                StatusTextBox.Text = m_LoggedInUser.Posts[0].Message;
            }
        }

        private void FriendsButton_Clicked(object sender, EventArgs e)
        {
            DisplayFriends();
        }

        private void DisplayFriends()
        {
            FriendsListBox.Items.Clear();
            FriendsListBox.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                FriendsListBox.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            DisplayEvents();
        }

        private void DisplayEvents()
        {
            EventsListBox.Items.Clear();
            EventsListBox.DisplayMember = "Name";
            foreach (Event facebookEvent in m_LoggedInUser.Events)
            {
                EventsListBox.Items.Add(facebookEvent);
            }

            if (m_LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to retrieve ");
            }
        }

        private void StatusButton_Click(object sender, EventArgs e)
        {
            Status postedStatus = m_LoggedInUser.PostStatus(StatusTextBox.Text);
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
        }

        private void LikesLabel_Click(object sender, EventArgs e)
        {
        }

        private void PageButton_Clicked(object sender, EventArgs e)
        {
            DisplayPages();
        }

        private void DisplayPages()
        {
            PagesListBox.Items.Clear();
            PagesListBox.DisplayMember = "Name";

            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                PagesListBox.Items.Add(page);
            }

            if (m_LoggedInUser.LikedPages.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve ");
            }
        }

        private void BirthdayButton_Click(object sender, EventArgs e)
        {
            DisplayTodaysBirthdays();
        }

        private void DisplayTodaysBirthdays()
        {
            string birthday;
            BirthdaysListBox.Items.Clear();
            BirthdaysListBox.DisplayMember = "Name";
            DateTime now = DateTime.Now;
            int day = now.Day;
            int month = now.Month;

            foreach (User user in m_LoggedInUser.Friends)
            {
                birthday = user.Birthday;
                string subMonthString = birthday.Substring(0, 2);
                string subDayString = birthday.Substring(3, 2);
                int dayUser = int.Parse(subDayString);
                int monthUser = int.Parse(subMonthString);

                if (day == dayUser && month == monthUser)
                {
                    BirthdaysListBox.Items.Add(user);
                }
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No friends to retrieve ");
            }
            if (BirthdaysListBox.Items.Count == 0)
            {
                MessageBox.Show("No friends have birthday today");
            }

        }

        private void EventsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FriendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayFriendPhoto();
        }

        private void DisplayFriendPhoto()
        {
            if (FriendsListBox.SelectedItems.Count == 1)
            {
                User selectedFriend = FriendsListBox.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    FriendPicture.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    ProfilePicture.Image = ProfilePicture.ErrorImage;
                }
            }
        }

        private void StatusTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {
        }

        private void FriendByStatus_Click(object sender, EventArgs e)
        {
        }

        private void BirthdaysListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = BirthdaysListBox.SelectedItem as User;
            Status happyBirthdayStatus = m_LoggedInUser.PostStatus("Happy birthday {0}!", selectedUser.Name);
        }

        private void PhotosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (friendsByStatusListBox.SelectedItems.Count == 1)
            {
                User selectedFriend = friendsByStatusListBox.SelectedItem as User;
                friendByStatusPictureBox.LoadAsync(selectedFriend.PictureNormalURL);
            }
        }

        private void PagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PagesListBox.SelectedItems.Count == 1)
            {
                Page selectedPage = PagesListBox.SelectedItem as Page;
                PagePictureBox.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void ShowFriendByStatusLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisplayFriendByStatusAndGender();
        }

        private void DisplayFriendByStatusAndGender()
        {
            friendsByStatusListBox.Items.Clear();
            friendsByStatusListBox.DisplayMember = "Name";

            bool isMale = maleButton.Checked == true;
            bool isMarried = MarriedFriendsButton.Checked == true;
            bool isSingle = singleFriendButton.Checked == true;
            User.eRelationshipStatus e_UserStatus;
            User.eGender e_UserGender;

            foreach (User friend in m_LoggedInUser.Friends)
            {
                e_UserGender = (User.eGender)friend.Gender;
                e_UserStatus = (User.eRelationshipStatus)friend.RelationshipStatus;

                bool checkIfAddToTheList =
                    (isMale && isSingle && e_UserGender == User.eGender.male && e_UserStatus == User.eRelationshipStatus.Single) ||
                    (isMale && isMarried && e_UserGender == User.eGender.male && e_UserStatus == User.eRelationshipStatus.Married) ||
                    (!isMale && isSingle && e_UserGender == User.eGender.female && e_UserStatus == User.eRelationshipStatus.Single) ||
                    (!isMale && isMarried && e_UserGender == User.eGender.female && e_UserStatus == User.eRelationshipStatus.Married);

                if (checkIfAddToTheList)
                {
                    friendsByStatusListBox.Items.Add(friend);
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve ");
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void MaleButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void FemaleButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void MarriedFriendsButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void FacebookLogoPictureBox_Click(object sender, EventArgs e)
        {
        }
    }
}
