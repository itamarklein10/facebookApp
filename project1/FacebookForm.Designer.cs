using System;

namespace project1
{
    public partial class FacebookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.FriendsButton = new System.Windows.Forms.Button();
            this.pageButton = new System.Windows.Forms.Button();
            this.birthdayButton = new System.Windows.Forms.Button();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.PagesListBox = new System.Windows.Forms.ListBox();
            this.BirthdaysListBox = new System.Windows.Forms.ListBox();
            this.eventsButton = new System.Windows.Forms.Button();
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.FriendsByStatusListBox = new System.Windows.Forms.ListBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.FriendPicture = new System.Windows.Forms.PictureBox();
            this.statusButton = new System.Windows.Forms.Button();
            this.FriendByStatusPictureBox = new System.Windows.Forms.PictureBox();
            this.PagePictureBox = new System.Windows.Forms.PictureBox();
            this.marriedFriendsButton = new System.Windows.Forms.RadioButton();
            this.singleFriendButton = new System.Windows.Forms.RadioButton();
            this.showFriendByStatusLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.FacebookLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.rememberMeButton = new System.Windows.Forms.CheckBox();
            this.fetchEverythingCheckBox = new System.Windows.Forms.CheckBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.declineButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendByStatusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(38, 12);
            this.loginButton.Name = "LoginButton";
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
            this.pageButton.Enabled = false;
            this.pageButton.Location = new System.Drawing.Point(268, 251);
            this.pageButton.Name = "PageButton";
            this.pageButton.Size = new System.Drawing.Size(75, 23);
            this.pageButton.TabIndex = 4;
            this.pageButton.Text = "Pages";
            this.pageButton.UseVisualStyleBackColor = true;
            this.pageButton.Click += new System.EventHandler(this.PageButton_Clicked);
            // 
            // BirthdayButton
            // 
            this.birthdayButton.Enabled = false;
            this.birthdayButton.Location = new System.Drawing.Point(520, 12);
            this.birthdayButton.Name = "BirthdayButton";
            this.birthdayButton.Size = new System.Drawing.Size(99, 23);
            this.birthdayButton.TabIndex = 6;
            this.birthdayButton.Text = "Today\'s Birthdays";
            this.birthdayButton.UseVisualStyleBackColor = true;
            this.birthdayButton.Click += new System.EventHandler(this.BirthdayButton_Click);
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
            this.eventsButton.Enabled = false;
            this.eventsButton.Location = new System.Drawing.Point(513, 250);
            this.eventsButton.Name = "EventsButton";
            this.eventsButton.Size = new System.Drawing.Size(75, 23);
            this.eventsButton.TabIndex = 11;
            this.eventsButton.Text = "Events";
            this.eventsButton.UseVisualStyleBackColor = true;
            this.eventsButton.Click += new System.EventHandler(this.EventsButton_Click);
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
            this.StatusTextBox.Location = new System.Drawing.Point(246, 98);
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
            this.statusButton.Enabled = false;
            this.statusButton.Location = new System.Drawing.Point(165, 96);
            this.statusButton.Name = "StatusButton";
            this.statusButton.Size = new System.Drawing.Size(75, 23);
            this.statusButton.TabIndex = 17;
            this.statusButton.Text = "Post Status";
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.StatusButton_Click);
            // 
            // FriendByStatusPictureBox
            // 
            this.FriendByStatusPictureBox.Location = new System.Drawing.Point(848, 303);
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
            this.marriedFriendsButton.AutoSize = true;
            this.marriedFriendsButton.Enabled = false;
            this.marriedFriendsButton.Location = new System.Drawing.Point(3, 35);
            this.marriedFriendsButton.Name = "MarriedFriendsButton";
            this.marriedFriendsButton.Size = new System.Drawing.Size(97, 17);
            this.marriedFriendsButton.TabIndex = 22;
            this.marriedFriendsButton.Text = "Married Friends";
            this.marriedFriendsButton.UseVisualStyleBackColor = true;
            this.marriedFriendsButton.CheckedChanged += new System.EventHandler(this.MarriedFriendsButton_CheckedChanged);
            // 
            // SingleFriendButton
            // 
            this.singleFriendButton.AutoSize = true;
            this.singleFriendButton.Checked = true;
            this.singleFriendButton.Enabled = false;
            this.singleFriendButton.Location = new System.Drawing.Point(3, 12);
            this.singleFriendButton.Name = "SingleFriendButton";
            this.singleFriendButton.Size = new System.Drawing.Size(91, 17);
            this.singleFriendButton.TabIndex = 23;
            this.singleFriendButton.TabStop = true;
            this.singleFriendButton.Text = "Single Friends";
            this.singleFriendButton.UseVisualStyleBackColor = true;
            this.singleFriendButton.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // ShowFriendByStatusLinkedLabel
            // 
            this.showFriendByStatusLinkedLabel.AutoSize = true;
            this.showFriendByStatusLinkedLabel.BackColor = System.Drawing.Color.LightCyan;
            this.showFriendByStatusLinkedLabel.Enabled = false;
            this.showFriendByStatusLinkedLabel.LinkColor = System.Drawing.Color.Navy;
            this.showFriendByStatusLinkedLabel.Location = new System.Drawing.Point(718, 185);
            this.showFriendByStatusLinkedLabel.Name = "ShowFriendByStatusLinkedLabel";
            this.showFriendByStatusLinkedLabel.Size = new System.Drawing.Size(113, 13);
            this.showFriendByStatusLinkedLabel.TabIndex = 26;
            this.showFriendByStatusLinkedLabel.TabStop = true;
            this.showFriendByStatusLinkedLabel.Text = "Show friends by status";
            this.showFriendByStatusLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowFriendByStatusLinkedLabel_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.singleFriendButton);
            this.panel1.Controls.Add(this.marriedFriendsButton);
            this.panel1.Location = new System.Drawing.Point(722, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 54);
            this.panel1.TabIndex = 24;
            // 
            // MaleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Checked = true;
            this.maleButton.Enabled = false;
            this.maleButton.Location = new System.Drawing.Point(722, 201);
            this.maleButton.Name = "MaleButton";
            this.maleButton.Size = new System.Drawing.Size(48, 17);
            this.maleButton.TabIndex = 24;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            this.maleButton.CheckedChanged += new System.EventHandler(this.MaleButton_CheckedChanged);
            // 
            // FemaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Enabled = false;
            this.femaleButton.Location = new System.Drawing.Point(772, 201);
            this.femaleButton.Name = "FemaleButton";
            this.femaleButton.Size = new System.Drawing.Size(59, 17);
            this.femaleButton.TabIndex = 27;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            this.femaleButton.CheckedChanged += new System.EventHandler(this.FemaleButton_CheckedChanged);
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
            // FacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(992, 473);
            this.Controls.Add(this.declineButton);
            this.Controls.Add(this.fetchEverythingCheckBox);
            this.Controls.Add(this.rememberMeButton);
            this.Controls.Add(this.FacebookLogoPictureBox);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showFriendByStatusLinkedLabel);
            this.Controls.Add(this.PagePictureBox);
            this.Controls.Add(this.FriendByStatusPictureBox);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.FriendPicture);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.FriendsByStatusListBox);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.EventsListBox);
            this.Controls.Add(this.eventsButton);
            this.Controls.Add(this.BirthdaysListBox);
            this.Controls.Add(this.PagesListBox);
            this.Controls.Add(this.FriendsListBox);
            this.Controls.Add(this.birthdayButton);
            this.Controls.Add(this.pageButton);
            this.Controls.Add(this.FriendsButton);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacebookForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FacebookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendByStatusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RememberMeButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Button loginButton;

        internal System.Windows.Forms.Button FriendsButton;
        internal System.Windows.Forms.Button pageButton;
        internal System.Windows.Forms.Button birthdayButton;
        internal System.Windows.Forms.ListBox FriendsListBox;
        internal System.Windows.Forms.ListBox PagesListBox;
        internal System.Windows.Forms.ListBox BirthdaysListBox;
        internal System.Windows.Forms.Button eventsButton;
        internal System.Windows.Forms.ListBox EventsListBox;
        internal System.Windows.Forms.PictureBox ProfilePicture;
        internal System.Windows.Forms.ListBox FriendsByStatusListBox;
        internal System.Windows.Forms.TextBox StatusTextBox;
        internal System.Windows.Forms.PictureBox FriendPicture;
        internal System.Windows.Forms.Button statusButton;
        internal System.Windows.Forms.PictureBox FriendByStatusPictureBox;
        internal System.Windows.Forms.PictureBox PagePictureBox;
        internal System.Windows.Forms.RadioButton marriedFriendsButton;
        internal System.Windows.Forms.RadioButton singleFriendButton;
        internal System.Windows.Forms.LinkLabel showFriendByStatusLinkedLabel;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.RadioButton maleButton;
        internal System.Windows.Forms.RadioButton femaleButton;
        internal System.Windows.Forms.PictureBox FacebookLogoPictureBox;
        private System.Windows.Forms.CheckBox rememberMeButton;
        private System.Windows.Forms.CheckBox fetchEverythingCheckBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button declineButton;
    }
}