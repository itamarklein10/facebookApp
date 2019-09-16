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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendByStatusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(57, 18);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(112, 35);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // FriendsButton
            // 
            this.FriendsButton.Enabled = false;
            this.FriendsButton.Location = new System.Drawing.Point(57, 388);
            this.FriendsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FriendsButton.Name = "FriendsButton";
            this.FriendsButton.Size = new System.Drawing.Size(112, 35);
            this.FriendsButton.TabIndex = 3;
            this.FriendsButton.Text = "Friends\r\n";
            this.FriendsButton.UseVisualStyleBackColor = true;
            this.FriendsButton.Click += new System.EventHandler(this.FriendsButton_Clicked);
            // 
            // pageButton
            // 
            this.pageButton.Enabled = false;
            this.pageButton.Location = new System.Drawing.Point(402, 386);
            this.pageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageButton.Name = "pageButton";
            this.pageButton.Size = new System.Drawing.Size(112, 35);
            this.pageButton.TabIndex = 4;
            this.pageButton.Text = "Pages";
            this.pageButton.UseVisualStyleBackColor = true;
            this.pageButton.Click += new System.EventHandler(this.PageButton_Clicked);
            // 
            // birthdayButton
            // 
            this.birthdayButton.Enabled = false;
            this.birthdayButton.Location = new System.Drawing.Point(780, 18);
            this.birthdayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.birthdayButton.Name = "birthdayButton";
            this.birthdayButton.Size = new System.Drawing.Size(148, 35);
            this.birthdayButton.TabIndex = 6;
            this.birthdayButton.Text = "Today\'s Birthdays";
            this.birthdayButton.UseVisualStyleBackColor = true;
            this.birthdayButton.Click += new System.EventHandler(this.BirthdayButton_Click);
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.ItemHeight = 20;
            this.FriendsListBox.Location = new System.Drawing.Point(32, 432);
            this.FriendsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(175, 264);
            this.FriendsListBox.TabIndex = 8;
            this.FriendsListBox.SelectedIndexChanged += new System.EventHandler(this.FriendsListBox_SelectedIndexChanged);
            // 
            // PagesListBox
            // 
            this.PagesListBox.FormattingEnabled = true;
            this.PagesListBox.ItemHeight = 20;
            this.PagesListBox.Location = new System.Drawing.Point(369, 432);
            this.PagesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PagesListBox.Name = "PagesListBox";
            this.PagesListBox.Size = new System.Drawing.Size(194, 264);
            this.PagesListBox.TabIndex = 9;
            this.PagesListBox.SelectedIndexChanged += new System.EventHandler(this.PagesListBox_SelectedIndexChanged);
            // 
            // BirthdaysListBox
            // 
            this.BirthdaysListBox.FormattingEnabled = true;
            this.BirthdaysListBox.ItemHeight = 20;
            this.BirthdaysListBox.Location = new System.Drawing.Point(770, 63);
            this.BirthdaysListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BirthdaysListBox.Name = "BirthdaysListBox";
            this.BirthdaysListBox.Size = new System.Drawing.Size(196, 244);
            this.BirthdaysListBox.TabIndex = 10;
            this.BirthdaysListBox.SelectedIndexChanged += new System.EventHandler(this.BirthdaysListBox_SelectedIndexChanged);
            // 
            // eventsButton
            // 
            this.eventsButton.Enabled = false;
            this.eventsButton.Location = new System.Drawing.Point(770, 385);
            this.eventsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eventsButton.Name = "eventsButton";
            this.eventsButton.Size = new System.Drawing.Size(112, 35);
            this.eventsButton.TabIndex = 11;
            this.eventsButton.Text = "Events";
            this.eventsButton.UseVisualStyleBackColor = true;
            this.eventsButton.Click += new System.EventHandler(this.EventsButton_Click);
            // 
            // EventsListBox
            // 
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.ItemHeight = 20;
            this.EventsListBox.Location = new System.Drawing.Point(741, 432);
            this.EventsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.Size = new System.Drawing.Size(186, 264);
            this.EventsListBox.TabIndex = 12;
            this.EventsListBox.SelectedIndexChanged += new System.EventHandler(this.EventsListBox_SelectedIndexChanged);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Location = new System.Drawing.Point(33, 92);
            this.ProfilePicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(176, 185);
            this.ProfilePicture.TabIndex = 13;
            this.ProfilePicture.TabStop = false;
            this.ProfilePicture.Click += new System.EventHandler(this.ProfilePicture_Click);
            // 
            // FriendsByStatusListBox
            // 
            this.FriendsByStatusListBox.FormattingEnabled = true;
            this.FriendsByStatusListBox.ItemHeight = 20;
            this.FriendsByStatusListBox.Location = new System.Drawing.Point(1083, 432);
            this.FriendsByStatusListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FriendsByStatusListBox.Name = "FriendsByStatusListBox";
            this.FriendsByStatusListBox.Size = new System.Drawing.Size(178, 264);
            this.FriendsByStatusListBox.TabIndex = 14;
            this.FriendsByStatusListBox.SelectedIndexChanged += new System.EventHandler(this.PhotosListBox_SelectedIndexChanged);
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(492, 251);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(246, 26);
            this.StatusTextBox.TabIndex = 15;
            this.StatusTextBox.TextChanged += new System.EventHandler(this.StatusTextBox_TextChanged);
            // 
            // FriendPicture
            // 
            this.FriendPicture.Location = new System.Drawing.Point(218, 492);
            this.FriendPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FriendPicture.Name = "FriendPicture";
            this.FriendPicture.Size = new System.Drawing.Size(122, 146);
            this.FriendPicture.TabIndex = 16;
            this.FriendPicture.TabStop = false;
            this.FriendPicture.Click += new System.EventHandler(this.FriendPicture_Click);
            // 
            // statusButton
            // 
            this.statusButton.Enabled = false;
            this.statusButton.Location = new System.Drawing.Point(545, 206);
            this.statusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(112, 35);
            this.statusButton.TabIndex = 17;
            this.statusButton.Text = "Post Status";
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.StatusButton_Click);
            // 
            // FriendByStatusPictureBox
            // 
            this.FriendByStatusPictureBox.Location = new System.Drawing.Point(1272, 466);
            this.FriendByStatusPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FriendByStatusPictureBox.Name = "FriendByStatusPictureBox";
            this.FriendByStatusPictureBox.Size = new System.Drawing.Size(170, 172);
            this.FriendByStatusPictureBox.TabIndex = 18;
            this.FriendByStatusPictureBox.TabStop = false;
            this.FriendByStatusPictureBox.Click += new System.EventHandler(this.FriendByStatus_Click);
            // 
            // PagePictureBox
            // 
            this.PagePictureBox.Location = new System.Drawing.Point(578, 492);
            this.PagePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PagePictureBox.Name = "PagePictureBox";
            this.PagePictureBox.Size = new System.Drawing.Size(122, 146);
            this.PagePictureBox.TabIndex = 20;
            this.PagePictureBox.TabStop = false;
            // 
            // marriedFriendsButton
            // 
            this.marriedFriendsButton.AutoSize = true;
            this.marriedFriendsButton.Enabled = false;
            this.marriedFriendsButton.Location = new System.Drawing.Point(4, 54);
            this.marriedFriendsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.marriedFriendsButton.Name = "marriedFriendsButton";
            this.marriedFriendsButton.Size = new System.Drawing.Size(144, 24);
            this.marriedFriendsButton.TabIndex = 22;
            this.marriedFriendsButton.Text = "Married Friends";
            this.marriedFriendsButton.UseVisualStyleBackColor = true;
            this.marriedFriendsButton.CheckedChanged += new System.EventHandler(this.MarriedFriendsButton_CheckedChanged);
            // 
            // singleFriendButton
            // 
            this.singleFriendButton.AutoSize = true;
            this.singleFriendButton.Checked = true;
            this.singleFriendButton.Enabled = false;
            this.singleFriendButton.Location = new System.Drawing.Point(4, 18);
            this.singleFriendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.singleFriendButton.Name = "singleFriendButton";
            this.singleFriendButton.Size = new System.Drawing.Size(135, 24);
            this.singleFriendButton.TabIndex = 23;
            this.singleFriendButton.TabStop = true;
            this.singleFriendButton.Text = "Single Friends";
            this.singleFriendButton.UseVisualStyleBackColor = true;
            this.singleFriendButton.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // showFriendByStatusLinkedLabel
            // 
            this.showFriendByStatusLinkedLabel.AutoSize = true;
            this.showFriendByStatusLinkedLabel.BackColor = System.Drawing.Color.LightCyan;
            this.showFriendByStatusLinkedLabel.Enabled = false;
            this.showFriendByStatusLinkedLabel.LinkColor = System.Drawing.Color.Navy;
            this.showFriendByStatusLinkedLabel.Location = new System.Drawing.Point(1078, 285);
            this.showFriendByStatusLinkedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showFriendByStatusLinkedLabel.Name = "showFriendByStatusLinkedLabel";
            this.showFriendByStatusLinkedLabel.Size = new System.Drawing.Size(169, 20);
            this.showFriendByStatusLinkedLabel.TabIndex = 26;
            this.showFriendByStatusLinkedLabel.TabStop = true;
            this.showFriendByStatusLinkedLabel.Text = "Show friends by status";
            this.showFriendByStatusLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowFriendByStatusLinkedLabel_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.singleFriendButton);
            this.panel1.Controls.Add(this.marriedFriendsButton);
            this.panel1.Location = new System.Drawing.Point(1083, 340);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 83);
            this.panel1.TabIndex = 24;
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Checked = true;
            this.maleButton.Enabled = false;
            this.maleButton.Location = new System.Drawing.Point(1083, 309);
            this.maleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(68, 24);
            this.maleButton.TabIndex = 24;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            this.maleButton.CheckedChanged += new System.EventHandler(this.MaleButton_CheckedChanged);
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Enabled = false;
            this.femaleButton.Location = new System.Drawing.Point(1158, 309);
            this.femaleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(87, 24);
            this.femaleButton.TabIndex = 27;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            this.femaleButton.CheckedChanged += new System.EventHandler(this.FemaleButton_CheckedChanged);
            // 
            // FacebookLogoPictureBox
            // 
            this.FacebookLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FacebookLogoPictureBox.Image")));
            this.FacebookLogoPictureBox.Location = new System.Drawing.Point(1062, 18);
            this.FacebookLogoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FacebookLogoPictureBox.Name = "FacebookLogoPictureBox";
            this.FacebookLogoPictureBox.Size = new System.Drawing.Size(393, 142);
            this.FacebookLogoPictureBox.TabIndex = 29;
            this.FacebookLogoPictureBox.TabStop = false;
            this.FacebookLogoPictureBox.Click += new System.EventHandler(this.FacebookLogoPictureBox_Click);
            // 
            // rememberMeButton
            // 
            this.rememberMeButton.AutoSize = true;
            this.rememberMeButton.Location = new System.Drawing.Point(219, 25);
            this.rememberMeButton.Name = "rememberMeButton";
            this.rememberMeButton.Size = new System.Drawing.Size(140, 24);
            this.rememberMeButton.TabIndex = 30;
            this.rememberMeButton.Text = "Remember me";
            this.rememberMeButton.UseVisualStyleBackColor = true;
            this.rememberMeButton.CheckedChanged += new System.EventHandler(this.RememberMeButton_CheckedChanged);
            // 
            // fetchEverythingCheckBox
            // 
            this.fetchEverythingCheckBox.AutoSize = true;
            this.fetchEverythingCheckBox.Location = new System.Drawing.Point(219, 58);
            this.fetchEverythingCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fetchEverythingCheckBox.Name = "fetchEverythingCheckBox";
            this.fetchEverythingCheckBox.Size = new System.Drawing.Size(152, 24);
            this.fetchEverythingCheckBox.TabIndex = 31;
            this.fetchEverythingCheckBox.Text = "Fetch everything";
            this.fetchEverythingCheckBox.UseVisualStyleBackColor = true;
            this.fetchEverythingCheckBox.CheckedChanged += new System.EventHandler(this.FetchEverythingCheckBox_CheckedChanged);
            // 
            // declineButton
            // 
            this.declineButton.Enabled = false;
            this.declineButton.Location = new System.Drawing.Point(938, 492);
            this.declineButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(120, 72);
            this.declineButton.TabIndex = 32;
            this.declineButton.Text = "Decline and remove event";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Click += new System.EventHandler(this.RemoveEvent_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "fetch friends",
            "fetch events",
            "fetch today birthdays",
            "post status",
            "show friends by status",
            "fetch events",
            "fetch pages"});
            this.checkedListBox1.Location = new System.Drawing.Point(238, 158);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(218, 151);
            this.checkedListBox1.TabIndex = 33;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 40);
            this.label1.TabIndex = 34;
            this.label1.Text = "please choose what features\r\n do you want upon login";
            // 
            // FormFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1488, 728);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
    }
}