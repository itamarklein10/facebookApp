﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace project1
{
    public class FacebookFeatures
    {
        //public static void DisplayFriends(FacebookForm i_FacebookForm, User i_LoggedInUser)
        //{
        //    i_FacebookForm.FriendsListBox.Items.Clear();
        //    i_FacebookForm.FriendsListBox.DisplayMember = "Name";
        //    foreach (User friend in i_LoggedInUser.Friends)
        //    {
        //        i_FacebookForm.FriendsListBox.Items.Add(friend);
        //        friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
        //    }

        //    if (i_LoggedInUser.Friends.Count == 0)
        //    {
        //        MessageBox.Show("No Friends to retrieve");
        //    }
        //}

        public static void DisplayEvents(FacebookForm i_FacebookForm, User i_LoggedInUser)
        {
            i_FacebookForm.EventsListBox.Items.Clear();
            i_FacebookForm.EventsListBox.DisplayMember = "Name";
            try
            {
                foreach (Event facebookEvent in i_LoggedInUser.Events)
                {
                    
                    i_FacebookForm.EventsListBox.Items.Add(facebookEvent);
                }

                if (i_LoggedInUser.Events.Count == 0)
                {
                    MessageBox.Show("No Events to retrieve ");
                }
            }
            catch (Facebook.FacebookOAuthException)
            {
                MessageBox.Show("feature unavailable because of facebook");
            }
        }

        public static void DisplayPages(FacebookForm i_FacebookForm, User i_LoggedInUser)
        {
            i_FacebookForm.PagesListBox.Items.Clear();
            i_FacebookForm.PagesListBox.DisplayMember = "Name";
            try
            {
                foreach (Page page in i_LoggedInUser.LikedPages)
                {
                    i_FacebookForm.PagesListBox.Items.Add(page);
                }

                if (i_LoggedInUser.LikedPages.Count == 0)
                {
                    MessageBox.Show("No liked pages to retrieve ");
                }
            }
            catch (Facebook.FacebookOAuthException)
            {
                MessageBox.Show("feature unavailable because of facebook");
            }

        }

        public static void DisplayFriendPhoto(FacebookForm i_FacebookForm)
        {
            if (i_FacebookForm.FriendsListBox.SelectedItems.Count == 1)
            {
                User selectedFriend = i_FacebookForm.FriendsListBox.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    i_FacebookForm.FriendPicture.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    i_FacebookForm.ProfilePicture.Image = i_FacebookForm.ProfilePicture.ErrorImage;
                }
            }
        }

        public static void DisplayTodaysBirthdays(User i_LoggedInUser, FacebookForm i_FacebookForm)
        {
            string birthday;
            i_FacebookForm.BirthdaysListBox.Items.Clear();
            i_FacebookForm.BirthdaysListBox.DisplayMember = "Name";
            DateTime now = DateTime.Now;
            int day = now.Day;
            int month = now.Month;

            foreach (User user in i_LoggedInUser.Friends)
            {
                birthday = user.Birthday;
                string subMonthString = birthday.Substring(0, 2);
                string subDayString = birthday.Substring(3, 2);
                int dayUser = int.Parse(subDayString);
                int monthUser = int.Parse(subMonthString);

                if (day == dayUser && month == monthUser)
                {
                    i_FacebookForm.BirthdaysListBox.Items.Add(user);
                }
            }

            if (i_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No friends to retrieve ");
            }

            if (i_FacebookForm.BirthdaysListBox.Items.Count == 0)
            {
                MessageBox.Show("No friends have birthday today");
            }
        }

        public static void DisplayFriendByStatusAndGender(FacebookForm i_FacebookForm, User i_LoggedInUser)
        {
            i_FacebookForm.FriendsByStatusListBox.Items.Clear();
            i_FacebookForm.FriendsByStatusListBox.DisplayMember = "Name";

            bool isMale = i_FacebookForm.maleButton.Checked == true;
            bool isMarried = i_FacebookForm.marriedFriendsButton.Checked == true;
            bool isSingle = i_FacebookForm.singleFriendButton.Checked == true;
            User.eRelationshipStatus e_UserStatus;
            User.eGender e_UserGender;
            try
            {
                foreach (User friend in i_LoggedInUser.Friends)
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
                        if (i_FacebookForm.FriendsByStatusListBox.Items.Count > 0)
                        {
                            UserPrototype friendPrototype = (UserPrototype)i_FacebookForm.FriendsByStatusListBox.Items[0];
                            UserPrototype newUserPrototype = friendPrototype.ShalowClone();
                            newUserPrototype.m_Name = friend.Name;
                            newUserPrototype.PictureNormalURL = friend.PictureNormalURL;
                            i_FacebookForm.FriendsByStatusListBox.Items.Add(newUserPrototype);
                        }
                        else
                        {//first user add to the list box
                            UserPrototype firstUserPrototype = new UserPrototype();
                            firstUserPrototype.m_Name = friend.Name;
                            firstUserPrototype.e_Gender = (eGender)friend.Gender;
                            firstUserPrototype.e_UserStatus = (eRelationshipStatus)friend.RelationshipStatus;
                            firstUserPrototype.PictureNormalURL = friend.PictureNormalURL;
                            i_FacebookForm.FriendsByStatusListBox.Items.Add(firstUserPrototype);
                        }
                        i_FacebookForm.FriendsByStatusListBox.Items.Add(friend);
                        friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                    }

                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("feature unavailable because of facebook");
            }

            if (i_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve ");
            }
        }
    }
}
