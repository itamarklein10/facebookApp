using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.ComponentModel;
using System.Threading;

namespace project1
{
    public partial class FacebookForm : Form
    {
        public User m_LoggedInUser { get; set; }

        public FacebookForm()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            AppSetting.Instance.LastWindowState = this.WindowState;
            AppSetting.Instance.LastWindowSize = this.Size;
            AppSetting.Instance.LastWindowLocation = this.Location;
            AppSetting.Instance.AutoLogin = this.rememberMeButton.Checked;
            AppSetting.Instance.Save();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Size = AppSetting.Instance.LastWindowSize;
            this.WindowState = AppSetting.Instance.LastWindowState;
            this.Location = AppSetting.Instance.LastWindowLocation;
            this.rememberMeButton.Checked = AppSetting.Instance.AutoLogin;

            if (AppSetting.Instance.AutoLogin)
            {
                new Thread(this.AutoLogin).Start();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void AutoLogin()
        {
            try
            {
                LoginResult result = FacebookService.Connect(AppSetting.Instance.AccessToken);
                m_LoggedInUser = result.LoggedInUser;
                FetchUserInfo();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("#190"))
                {
                    this.Invoke((Action)LoginUser);
                }
                else
                {
                    this.Invoke(new Action(() => MessageBox.Show("Could not connect to Facebook server. Please try again later..")));
                }
            }
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
            m_LoggedInUser = result.LoggedInUser;
            AppSetting.Instance.AccessToken = result.AccessToken;
            FetchUserInfo();
        }

        private void FetchUserInfo()
        {
            new Thread(() =>
            {
                var statuses = m_LoggedInUser.Statuses;
                if (m_LoggedInUser.Posts.Count > 0)
                {
                    StatusTextBox.Text = m_LoggedInUser.Posts[0].Message;
                }
                this.Invoke(new Action(() =>
                {
                    ProfilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
                  
                }));
            }).Start();
        }

        public User LoggedUser
        {
            get { return m_LoggedInUser; }
            set { m_LoggedInUser = value; }
        }

        //private void FetchUserInfo()
        //{
        //    ProfilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
        //    if (m_LoggedInUser.Posts.Count > 0)
        //    {
        //        StatusTextBox.Text = m_LoggedInUser.Posts[0].Message;
        //    }
        //}

        private void FriendsButton_Clicked(object sender, EventArgs e)
        {
         new Thread (DisplayFriends).Start();
        }

        public void DisplayFriends()
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
            private void FacebookForm_Load(object sender, EventArgs e)
        {
        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            FacebookFeatures.DisplayEvents(this, m_LoggedInUser);
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
            FacebookFeatures.DisplayPages(this, m_LoggedInUser);
        }

        private void BirthdayButton_Click(object sender, EventArgs e)
        {
            FacebookFeatures.DisplayTodaysBirthdays(m_LoggedInUser, this);
        }

        private void EventsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FriendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacebookFeatures.DisplayFriendPhoto(this);
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
            if (FriendsByStatusListBox.SelectedItems.Count == 1)
            {
                User selectedFriend = FriendsByStatusListBox.SelectedItem as User;
                FriendByStatusPictureBox.LoadAsync(selectedFriend.PictureNormalURL);
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
            FacebookFeatures.DisplayFriendByStatusAndGender(this, m_LoggedInUser);
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

        private void RememberMeButton_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
