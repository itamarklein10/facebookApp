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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookForm));
            this.LoginButton = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaleButton = new System.Windows.Forms.RadioButton();
            this.FemaleButton = new System.Windows.Forms.RadioButton();
            this.FacebookLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.rememberMeButton = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendByStatusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(57, 18);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(112, 35);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // FriendsButton
            // 
            this.FriendsButton.Location = new System.Drawing.Point(57, 388);
            this.FriendsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FriendsButton.Name = "FriendsButton";
            this.FriendsButton.Size = new System.Drawing.Size(112, 35);
            this.FriendsButton.TabIndex = 3;
            this.FriendsButton.Text = "Friends\r\n";
            this.FriendsButton.UseVisualStyleBackColor = true;
            this.FriendsButton.Click += new System.EventHandler(this.FriendsButton_Clicked);
            // 
            // PageButton
            // 
            this.PageButton.Location = new System.Drawing.Point(402, 386);
            this.PageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageButton.Name = "PageButton";
            this.PageButton.Size = new System.Drawing.Size(112, 35);
            this.PageButton.TabIndex = 4;
            this.PageButton.Text = "Pages";
            this.PageButton.UseVisualStyleBackColor = true;
            this.PageButton.Click += new System.EventHandler(this.PageButton_Clicked);
            // 
            // BirthdayButton
            // 
            this.BirthdayButton.Location = new System.Drawing.Point(780, 18);
            this.BirthdayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BirthdayButton.Name = "BirthdayButton";
            this.BirthdayButton.Size = new System.Drawing.Size(148, 35);
            this.BirthdayButton.TabIndex = 6;
            this.BirthdayButton.Text = "Today\'s Birthdays";
            this.BirthdayButton.UseVisualStyleBackColor = true;
            this.BirthdayButton.Click += new System.EventHandler(this.BirthdayButton_Click);
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
            // EventsButton
            // 
            this.EventsButton.Location = new System.Drawing.Point(813, 386);
            this.EventsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EventsButton.Name = "EventsButton";
            this.EventsButton.Size = new System.Drawing.Size(112, 35);
            this.EventsButton.TabIndex = 11;
            this.EventsButton.Text = "Events";
            this.EventsButton.UseVisualStyleBackColor = true;
            this.EventsButton.Click += new System.EventHandler(this.EventsButton_Click);
            // 
            // EventsListBox
            // 
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.ItemHeight = 20;
            this.EventsListBox.Location = new System.Drawing.Point(780, 432);
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
            this.StatusTextBox.Location = new System.Drawing.Point(369, 151);
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
            // 
            // StatusButton
            // 
            this.StatusButton.Location = new System.Drawing.Point(248, 148);
            this.StatusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StatusButton.Name = "StatusButton";
            this.StatusButton.Size = new System.Drawing.Size(112, 35);
            this.StatusButton.TabIndex = 17;
            this.StatusButton.Text = "Post Status";
            this.StatusButton.UseVisualStyleBackColor = true;
            this.StatusButton.Click += new System.EventHandler(this.StatusButton_Click);
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
            // MarriedFriendsButton
            // 
            this.MarriedFriendsButton.AutoSize = true;
            this.MarriedFriendsButton.Location = new System.Drawing.Point(4, 54);
            this.MarriedFriendsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MarriedFriendsButton.Name = "MarriedFriendsButton";
            this.MarriedFriendsButton.Size = new System.Drawing.Size(144, 24);
            this.MarriedFriendsButton.TabIndex = 22;
            this.MarriedFriendsButton.Text = "Married Friends";
            this.MarriedFriendsButton.UseVisualStyleBackColor = true;
            this.MarriedFriendsButton.CheckedChanged += new System.EventHandler(this.MarriedFriendsButton_CheckedChanged);
            // 
            // SingleFriendButton
            // 
            this.SingleFriendButton.AutoSize = true;
            this.SingleFriendButton.Checked = true;
            this.SingleFriendButton.Location = new System.Drawing.Point(4, 18);
            this.SingleFriendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SingleFriendButton.Name = "SingleFriendButton";
            this.SingleFriendButton.Size = new System.Drawing.Size(135, 24);
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
            this.ShowFriendByStatusLinkedLabel.LinkColor = System.Drawing.Color.Navy;
            this.ShowFriendByStatusLinkedLabel.Location = new System.Drawing.Point(1077, 285);
            this.ShowFriendByStatusLinkedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShowFriendByStatusLinkedLabel.Name = "ShowFriendByStatusLinkedLabel";
            this.ShowFriendByStatusLinkedLabel.Size = new System.Drawing.Size(169, 20);
            this.ShowFriendByStatusLinkedLabel.TabIndex = 26;
            this.ShowFriendByStatusLinkedLabel.TabStop = true;
            this.ShowFriendByStatusLinkedLabel.Text = "Show friends by status";
            this.ShowFriendByStatusLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowFriendByStatusLinkedLabel_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SingleFriendButton);
            this.panel1.Controls.Add(this.MarriedFriendsButton);
            this.panel1.Location = new System.Drawing.Point(1083, 340);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 83);
            this.panel1.TabIndex = 24;
            // 
            // MaleButton
            // 
            this.MaleButton.AutoSize = true;
            this.MaleButton.Checked = true;
            this.MaleButton.Location = new System.Drawing.Point(1083, 309);
            this.MaleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaleButton.Name = "MaleButton";
            this.MaleButton.Size = new System.Drawing.Size(68, 24);
            this.MaleButton.TabIndex = 24;
            this.MaleButton.TabStop = true;
            this.MaleButton.Text = "Male";
            this.MaleButton.UseVisualStyleBackColor = true;
            this.MaleButton.CheckedChanged += new System.EventHandler(this.MaleButton_CheckedChanged);
            // 
            // FemaleButton
            // 
            this.FemaleButton.AutoSize = true;
            this.FemaleButton.Location = new System.Drawing.Point(1158, 309);
            this.FemaleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FemaleButton.Name = "FemaleButton";
            this.FemaleButton.Size = new System.Drawing.Size(87, 24);
            this.FemaleButton.TabIndex = 27;
            this.FemaleButton.Text = "Female";
            this.FemaleButton.UseVisualStyleBackColor = true;
            this.FemaleButton.CheckedChanged += new System.EventHandler(this.FemaleButton_CheckedChanged);
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
            this.rememberMeButton.Location = new System.Drawing.Point(200, 28);
            this.rememberMeButton.Name = "rememberMeButton";
            this.rememberMeButton.Size = new System.Drawing.Size(140, 24);
            this.rememberMeButton.TabIndex = 30;
            this.rememberMeButton.Text = "Remember me";
            this.rememberMeButton.UseVisualStyleBackColor = true;
            this.rememberMeButton.CheckedChanged += new System.EventHandler(this.RememberMeButton_CheckedChanged);
            // 
            // FacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1474, 731);
            this.Controls.Add(this.rememberMeButton);
            this.Controls.Add(this.FacebookLogoPictureBox);
            this.Controls.Add(this.FemaleButton);
            this.Controls.Add(this.MaleButton);
            this.Controls.Add(this.panel1);
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
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacebookForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FacebookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendByStatusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RememberMeButton_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button LoginButton;

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
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.RadioButton MaleButton;
        internal System.Windows.Forms.RadioButton FemaleButton;
        internal System.Windows.Forms.PictureBox FacebookLogoPictureBox;
        private System.Windows.Forms.CheckBox rememberMeButton;
    }
}