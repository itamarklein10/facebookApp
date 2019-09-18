using System;

namespace project1
{
    public partial class FormFacebook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacebook));
            this.loginButton = new System.Windows.Forms.Button();
            this.FriendsButton = new System.Windows.Forms.Button();
            this.PageButton = new System.Windows.Forms.Button();
            this.BirthdayButton = new System.Windows.Forms.Button();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.PagesListBox = new System.Windows.Forms.ListBox();
            this.BirthdaysListBox = new System.Windows.Forms.ListBox();
            this.EventsButton = new System.Windows.Forms.Button();
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.FriendsByStatusListBox = new System.Windows.Forms.ListBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.FriendPicture = new System.Windows.Forms.PictureBox();
            this.StatusButton = new System.Windows.Forms.Button();
            this.FriendByStatusPictureBox = new System.Windows.Forms.PictureBox();
            this.PagePictureBox = new System.Windows.Forms.PictureBox();
            this.MarriedFriendsButton = new System.Windows.Forms.RadioButton();
            this.SingleFriendButton = new System.Windows.Forms.RadioButton();
            this.ShowFriendByStatusLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.MaleButton = new System.Windows.Forms.RadioButton();
            this.FemaleButton = new System.Windows.Forms.RadioButton();
            this.FacebookLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.rememberMeButton = new System.Windows.Forms.CheckBox();
            this.fetchEverythingCheckBox = new System.Windows.Forms.CheckBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.declineButton = new System.Windows.Forms.Button();
            this.SaveProfilePicturebutton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ShowRandomPhotolinkLabel = new System.Windows.Forms.LinkLabel();
            this.RandomPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.ChangeStatebutton = new System.Windows.Forms.Button();
            this.UpdateFriendButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendByStatusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagePictureBox)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(38, 12);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // FriendsButton
            // 
            this.FriendsButton.Enabled = false;
            this.FriendsButton.Location = new System.Drawing.Point(38, 252);
            this.FriendsButton.Name = "FriendsButton";
            this.FriendsButton.Size = new System.Drawing.Size(75, 23);
            this.FriendsButton.TabIndex = 3;
            this.FriendsButton.Text = "Friends\r\n";
            this.FriendsButton.UseVisualStyleBackColor = true;
            this.FriendsButton.Click += new System.EventHandler(this.FriendsButton_Clicked);
            // 
            // PageButton
            // 
            this.PageButton.Enabled = false;
            this.PageButton.Location = new System.Drawing.Point(268, 251);
            this.PageButton.Name = "PageButton";
            this.PageButton.Size = new System.Drawing.Size(75, 23);
            this.PageButton.TabIndex = 4;
            this.PageButton.Text = "Pages";
            this.PageButton.UseVisualStyleBackColor = true;
            this.PageButton.Click += new System.EventHandler(this.PageButton_Clicked);
            // 
            // BirthdayButton
            // 
            this.BirthdayButton.Enabled = false;
            this.BirthdayButton.Location = new System.Drawing.Point(520, 12);
            this.BirthdayButton.Name = "BirthdayButton";
            this.BirthdayButton.Size = new System.Drawing.Size(99, 23);
            this.BirthdayButton.TabIndex = 6;
            this.BirthdayButton.Text = "Today\'s Birthdays";
            this.BirthdayButton.UseVisualStyleBackColor = true;
            this.BirthdayButton.Click += new System.EventHandler(this.BirthdayButton_Click);
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.Location = new System.Drawing.Point(21, 281);
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(118, 173);
            this.FriendsListBox.TabIndex = 8;
            this.FriendsListBox.SelectedIndexChanged += new System.EventHandler(this.FriendsListBox_SelectedIndexChanged);
            // 
            // PagesListBox
            // 
            this.PagesListBox.FormattingEnabled = true;
            this.PagesListBox.Location = new System.Drawing.Point(246, 281);
            this.PagesListBox.Name = "PagesListBox";
            this.PagesListBox.Size = new System.Drawing.Size(131, 173);
            this.PagesListBox.TabIndex = 9;
            this.PagesListBox.SelectedIndexChanged += new System.EventHandler(this.PagesListBox_SelectedIndexChanged);
            // 
            // BirthdaysListBox
            // 
            this.BirthdaysListBox.FormattingEnabled = true;
            this.BirthdaysListBox.Location = new System.Drawing.Point(513, 41);
            this.BirthdaysListBox.Name = "BirthdaysListBox";
            this.BirthdaysListBox.Size = new System.Drawing.Size(132, 160);
            this.BirthdaysListBox.TabIndex = 10;
            this.BirthdaysListBox.SelectedIndexChanged += new System.EventHandler(this.BirthdaysListBox_SelectedIndexChanged);
            // 
            // EventsButton
            // 
            this.EventsButton.Enabled = false;
            this.EventsButton.Location = new System.Drawing.Point(513, 250);
            this.EventsButton.Name = "EventsButton";
            this.EventsButton.Size = new System.Drawing.Size(75, 23);
            this.EventsButton.TabIndex = 11;
            this.EventsButton.Text = "Events";
            this.EventsButton.UseVisualStyleBackColor = true;
            this.EventsButton.Click += new System.EventHandler(this.EventsButton_Click);
            // 
            // EventsListBox
            // 
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.Location = new System.Drawing.Point(494, 281);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.Size = new System.Drawing.Size(125, 173);
            this.EventsListBox.TabIndex = 12;
            this.EventsListBox.SelectedIndexChanged += new System.EventHandler(this.EventsListBox_SelectedIndexChanged);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.Location = new System.Drawing.Point(22, 60);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(117, 120);
            this.ProfilePicture.TabIndex = 13;
            this.ProfilePicture.TabStop = false;
            this.ProfilePicture.Click += new System.EventHandler(this.ProfilePicture_Click);
            // 
            // FriendsByStatusListBox
            // 
            this.FriendsByStatusListBox.FormattingEnabled = true;
            this.FriendsByStatusListBox.Location = new System.Drawing.Point(722, 281);
            this.FriendsByStatusListBox.Name = "FriendsByStatusListBox";
            this.FriendsByStatusListBox.Size = new System.Drawing.Size(120, 173);
            this.FriendsByStatusListBox.TabIndex = 14;
            this.FriendsByStatusListBox.SelectedIndexChanged += new System.EventHandler(this.PhotosListBox_SelectedIndexChanged);
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Enabled = false;
            this.StatusTextBox.Location = new System.Drawing.Point(342, 60);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(165, 20);
            this.StatusTextBox.TabIndex = 15;
            this.StatusTextBox.TextChanged += new System.EventHandler(this.StatusTextBox_TextChanged);
            // 
            // FriendPicture
            // 
            this.FriendPicture.Location = new System.Drawing.Point(145, 320);
            this.FriendPicture.Name = "FriendPicture";
            this.FriendPicture.Size = new System.Drawing.Size(81, 95);
            this.FriendPicture.TabIndex = 16;
            this.FriendPicture.TabStop = false;
            this.FriendPicture.Click += new System.EventHandler(this.FriendPicture_Click);
            // 
            // StatusButton
            // 
            this.StatusButton.Enabled = false;
            this.StatusButton.Location = new System.Drawing.Point(385, 34);
            this.StatusButton.Name = "StatusButton";
            this.StatusButton.Size = new System.Drawing.Size(75, 23);
            this.StatusButton.TabIndex = 17;
            this.StatusButton.Text = "Post Status";
            this.StatusButton.UseVisualStyleBackColor = true;
            this.StatusButton.Click += new System.EventHandler(this.StatusButton_Click);
            // 
            // FriendByStatusPictureBox
            // 
            this.FriendByStatusPictureBox.Location = new System.Drawing.Point(848, 342);
            this.FriendByStatusPictureBox.Name = "FriendByStatusPictureBox";
            this.FriendByStatusPictureBox.Size = new System.Drawing.Size(113, 112);
            this.FriendByStatusPictureBox.TabIndex = 18;
            this.FriendByStatusPictureBox.TabStop = false;
            this.FriendByStatusPictureBox.Click += new System.EventHandler(this.FriendByStatus_Click);
            // 
            // PagePictureBox
            // 
            this.PagePictureBox.Location = new System.Drawing.Point(385, 320);
            this.PagePictureBox.Name = "PagePictureBox";
            this.PagePictureBox.Size = new System.Drawing.Size(81, 95);
            this.PagePictureBox.TabIndex = 20;
            this.PagePictureBox.TabStop = false;
            // 
            // MarriedFriendsButton
            // 
            this.MarriedFriendsButton.AutoSize = true;
            this.MarriedFriendsButton.Enabled = false;
            this.MarriedFriendsButton.Location = new System.Drawing.Point(3, 35);
            this.MarriedFriendsButton.Name = "MarriedFriendsButton";
            this.MarriedFriendsButton.Size = new System.Drawing.Size(97, 17);
            this.MarriedFriendsButton.TabIndex = 22;
            this.MarriedFriendsButton.Text = "Married Friends";
            this.MarriedFriendsButton.UseVisualStyleBackColor = true;
            this.MarriedFriendsButton.CheckedChanged += new System.EventHandler(this.MarriedFriendsButton_CheckedChanged);
            // 
            // SingleFriendButton
            // 
            this.SingleFriendButton.AutoSize = true;
            this.SingleFriendButton.Checked = true;
            this.SingleFriendButton.Enabled = false;
            this.SingleFriendButton.Location = new System.Drawing.Point(3, 12);
            this.SingleFriendButton.Name = "SingleFriendButton";
            this.SingleFriendButton.Size = new System.Drawing.Size(91, 17);
            this.SingleFriendButton.TabIndex = 23;
            this.SingleFriendButton.TabStop = true;
            this.SingleFriendButton.Text = "Single Friends";
            this.SingleFriendButton.UseVisualStyleBackColor = true;
            this.SingleFriendButton.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // ShowFriendByStatusLinkedLabel
            // 
            this.ShowFriendByStatusLinkedLabel.AutoSize = true;
            this.ShowFriendByStatusLinkedLabel.BackColor = System.Drawing.Color.LightCyan;
            this.ShowFriendByStatusLinkedLabel.Enabled = false;
            this.ShowFriendByStatusLinkedLabel.LinkColor = System.Drawing.Color.Navy;
            this.ShowFriendByStatusLinkedLabel.Location = new System.Drawing.Point(719, 185);
            this.ShowFriendByStatusLinkedLabel.Name = "ShowFriendByStatusLinkedLabel";
            this.ShowFriendByStatusLinkedLabel.Size = new System.Drawing.Size(113, 13);
            this.ShowFriendByStatusLinkedLabel.TabIndex = 26;
            this.ShowFriendByStatusLinkedLabel.TabStop = true;
            this.ShowFriendByStatusLinkedLabel.Text = "Show friends by status";
            this.ShowFriendByStatusLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowFriendByStatusLinkedLabel_LinkClicked);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.SingleFriendButton);
            this.Panel1.Controls.Add(this.MarriedFriendsButton);
            this.Panel1.Location = new System.Drawing.Point(722, 221);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(109, 54);
            this.Panel1.TabIndex = 24;
            // 
            // MaleButton
            // 
            this.MaleButton.AutoSize = true;
            this.MaleButton.Checked = true;
            this.MaleButton.Enabled = false;
            this.MaleButton.Location = new System.Drawing.Point(722, 201);
            this.MaleButton.Name = "MaleButton";
            this.MaleButton.Size = new System.Drawing.Size(48, 17);
            this.MaleButton.TabIndex = 24;
            this.MaleButton.TabStop = true;
            this.MaleButton.Text = "Male";
            this.MaleButton.UseVisualStyleBackColor = true;
            this.MaleButton.CheckedChanged += new System.EventHandler(this.MaleButton_CheckedChanged);
            // 
            // FemaleButton
            // 
            this.FemaleButton.AutoSize = true;
            this.FemaleButton.Enabled = false;
            this.FemaleButton.Location = new System.Drawing.Point(772, 201);
            this.FemaleButton.Name = "FemaleButton";
            this.FemaleButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleButton.TabIndex = 27;
            this.FemaleButton.Text = "Female";
            this.FemaleButton.UseVisualStyleBackColor = true;
            this.FemaleButton.CheckedChanged += new System.EventHandler(this.FemaleButton_CheckedChanged);
            // 
            // FacebookLogoPictureBox
            // 
            this.FacebookLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FacebookLogoPictureBox.Image")));
            this.FacebookLogoPictureBox.Location = new System.Drawing.Point(708, 12);
            this.FacebookLogoPictureBox.Name = "FacebookLogoPictureBox";
            this.FacebookLogoPictureBox.Size = new System.Drawing.Size(262, 92);
            this.FacebookLogoPictureBox.TabIndex = 29;
            this.FacebookLogoPictureBox.TabStop = false;
            this.FacebookLogoPictureBox.Click += new System.EventHandler(this.FacebookLogoPictureBox_Click);
            // 
            // rememberMeButton
            // 
            this.rememberMeButton.AutoSize = true;
            this.rememberMeButton.Location = new System.Drawing.Point(146, 16);
            this.rememberMeButton.Margin = new System.Windows.Forms.Padding(2);
            this.rememberMeButton.Name = "rememberMeButton";
            this.rememberMeButton.Size = new System.Drawing.Size(94, 17);
            this.rememberMeButton.TabIndex = 30;
            this.rememberMeButton.Text = "Remember me";
            this.rememberMeButton.UseVisualStyleBackColor = true;
            this.rememberMeButton.CheckedChanged += new System.EventHandler(this.RememberMeButton_CheckedChanged);
            // 
            // fetchEverythingCheckBox
            // 
            this.fetchEverythingCheckBox.AutoSize = true;
            this.fetchEverythingCheckBox.Location = new System.Drawing.Point(146, 38);
            this.fetchEverythingCheckBox.Name = "fetchEverythingCheckBox";
            this.fetchEverythingCheckBox.Size = new System.Drawing.Size(105, 17);
            this.fetchEverythingCheckBox.TabIndex = 31;
            this.fetchEverythingCheckBox.Text = "Fetch everything";
            this.fetchEverythingCheckBox.UseVisualStyleBackColor = true;
            this.fetchEverythingCheckBox.CheckedChanged += new System.EventHandler(this.FetchEverythingCheckBox_CheckedChanged);
            // 
            // declineButton
            // 
            this.declineButton.Enabled = false;
            this.declineButton.Location = new System.Drawing.Point(625, 320);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(80, 47);
            this.declineButton.TabIndex = 32;
            this.declineButton.Text = "Decline and remove event";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Click += new System.EventHandler(this.RemoveEvent_Click);
            // 
            // SaveProfilePicturebutton
            // 
            this.SaveProfilePicturebutton.Enabled = false;
            this.SaveProfilePicturebutton.Location = new System.Drawing.Point(38, 186);
            this.SaveProfilePicturebutton.Name = "SaveProfilePicturebutton";
            this.SaveProfilePicturebutton.Size = new System.Drawing.Size(75, 23);
            this.SaveProfilePicturebutton.TabIndex = 0;
            this.SaveProfilePicturebutton.Text = "Save image";
            this.SaveProfilePicturebutton.UseVisualStyleBackColor = true;
            this.SaveProfilePicturebutton.Click += new System.EventHandler(this.SaveProfielPictureButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "fetch friends",
            "fetch events",
            "fetch today birthdays",
            "post status",
            "show friends by status",
            "fetch pages",
            "show a random photo"});
            this.checkedListBox1.Location = new System.Drawing.Point(146, 111);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(218, 109);
            this.checkedListBox1.TabIndex = 33;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(156, 78);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 26);
            this.Label1.TabIndex = 34;
            this.Label1.Text = "please choose what\r\nFeatures do you want \r\n";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ShowRandomPhotolinkLabel
            // 
            this.ShowRandomPhotolinkLabel.AutoSize = true;
            this.ShowRandomPhotolinkLabel.BackColor = System.Drawing.Color.LightCyan;
            this.ShowRandomPhotolinkLabel.Enabled = false;
            this.ShowRandomPhotolinkLabel.LinkColor = System.Drawing.Color.Navy;
            this.ShowRandomPhotolinkLabel.Location = new System.Drawing.Point(850, 115);
            this.ShowRandomPhotolinkLabel.Name = "ShowRandomPhotolinkLabel";
            this.ShowRandomPhotolinkLabel.Size = new System.Drawing.Size(111, 26);
            this.ShowRandomPhotolinkLabel.TabIndex = 35;
            this.ShowRandomPhotolinkLabel.TabStop = true;
            this.ShowRandomPhotolinkLabel.Text = "Show a random photo\r\nfrom my albums";
            this.ShowRandomPhotolinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowRandomPhotolinkLabel_LinkClicked);
            // 
            // RandomPhotoPictureBox
            // 
            this.RandomPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RandomPhotoPictureBox.Location = new System.Drawing.Point(853, 144);
            this.RandomPhotoPictureBox.Name = "RandomPhotoPictureBox";
            this.RandomPhotoPictureBox.Size = new System.Drawing.Size(138, 131);
            this.RandomPhotoPictureBox.TabIndex = 36;
            this.RandomPhotoPictureBox.TabStop = false;
            this.RandomPhotoPictureBox.Click += new System.EventHandler(this.RandomPhotoPictureBox_Click);
            // 
            // ChangeStatebutton
            // 
            this.ChangeStatebutton.Enabled = false;
            this.ChangeStatebutton.Location = new System.Drawing.Point(853, 118);
            this.ChangeStatebutton.Name = "ChangeStatebutton";
            this.ChangeStatebutton.Size = new System.Drawing.Size(75, 23);
            this.ChangeStatebutton.TabIndex = 37;
            this.ChangeStatebutton.Text = "Stop";
            this.ChangeStatebutton.UseVisualStyleBackColor = true;
            this.ChangeStatebutton.Visible = false;
            this.ChangeStatebutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // UpdateFriendButton
            // 
            this.UpdateFriendButton.Enabled = false;
            this.UpdateFriendButton.Location = new System.Drawing.Point(146, 421);
            this.UpdateFriendButton.Name = "UpdateFriendButton";
            this.UpdateFriendButton.Size = new System.Drawing.Size(80, 33);
            this.UpdateFriendButton.TabIndex = 38;
            this.UpdateFriendButton.Text = "Update friend";
            this.UpdateFriendButton.UseVisualStyleBackColor = true;
            this.UpdateFriendButton.Click += new System.EventHandler(this.UpdadeFriendButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Enabled = false;
            this.MessageTextBox.Location = new System.Drawing.Point(21, 494);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(311, 20);
            this.MessageTextBox.TabIndex = 39;
            this.MessageTextBox.TextChanged += new System.EventHandler(this.MessageTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Send a message to your important friends:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // SendButton
            // 
            this.SendButton.Enabled = false;
            this.SendButton.Location = new System.Drawing.Point(338, 494);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(48, 20);
            this.SendButton.TabIndex = 41;
            this.SendButton.Text = "send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // FormFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1003, 537);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.UpdateFriendButton);
            this.Controls.Add(this.ChangeStatebutton);
            this.Controls.Add(this.RandomPhotoPictureBox);
            this.Controls.Add(this.ShowRandomPhotolinkLabel);
            this.Controls.Add(this.declineButton);
            this.Controls.Add(this.fetchEverythingCheckBox);
            this.Controls.Add(this.rememberMeButton);
            this.Controls.Add(this.FacebookLogoPictureBox);
            this.Controls.Add(this.FemaleButton);
            this.Controls.Add(this.MaleButton);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.ShowFriendByStatusLinkedLabel);
            this.Controls.Add(this.PagePictureBox);
            this.Controls.Add(this.FriendByStatusPictureBox);
            this.Controls.Add(this.StatusButton);
            this.Controls.Add(this.FriendPicture);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.FriendsByStatusListBox);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.EventsListBox);
            this.Controls.Add(this.EventsButton);
            this.Controls.Add(this.BirthdaysListBox);
            this.Controls.Add(this.PagesListBox);
            this.Controls.Add(this.FriendsListBox);
            this.Controls.Add(this.BirthdayButton);
            this.Controls.Add(this.PageButton);
            this.Controls.Add(this.FriendsButton);
            this.Controls.Add(this.SaveProfilePicturebutton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFacebook";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FacebookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendByStatusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagePictureBox)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RememberMeButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Button loginButton;

        internal System.Windows.Forms.Button FriendsButton;
        internal System.Windows.Forms.Button PageButton;
        internal System.Windows.Forms.Button BirthdayButton;
        internal System.Windows.Forms.ListBox FriendsListBox;
        internal System.Windows.Forms.ListBox PagesListBox;
        internal System.Windows.Forms.ListBox BirthdaysListBox;
        internal System.Windows.Forms.Button EventsButton;
        internal System.Windows.Forms.ListBox EventsListBox;
        internal System.Windows.Forms.PictureBox ProfilePicture;
        internal System.Windows.Forms.ListBox FriendsByStatusListBox;
        internal System.Windows.Forms.TextBox StatusTextBox;
        internal System.Windows.Forms.PictureBox FriendPicture;
        internal System.Windows.Forms.Button StatusButton;
        internal System.Windows.Forms.PictureBox FriendByStatusPictureBox;
        internal System.Windows.Forms.PictureBox PagePictureBox;
        internal System.Windows.Forms.RadioButton MarriedFriendsButton;
        internal System.Windows.Forms.RadioButton SingleFriendButton;
        internal System.Windows.Forms.LinkLabel ShowFriendByStatusLinkedLabel;
        private System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.RadioButton MaleButton;
        internal System.Windows.Forms.RadioButton FemaleButton;
        internal System.Windows.Forms.PictureBox FacebookLogoPictureBox;
        private System.Windows.Forms.CheckBox rememberMeButton;
        private System.Windows.Forms.CheckBox fetchEverythingCheckBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button SaveProfilePicturebutton;
        internal System.Windows.Forms.LinkLabel ShowRandomPhotolinkLabel;
        internal System.Windows.Forms.PictureBox RandomPhotoPictureBox;
        internal System.Windows.Forms.Button ChangeStatebutton;
        internal System.Windows.Forms.Button UpdateFriendButton;
        internal System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button SendButton;
    }
}