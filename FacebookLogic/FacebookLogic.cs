using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FacebookLogic
{
    public class FacebookLogic
    {
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
    }
}
