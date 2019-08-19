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
            this.LoginButton.Location = new System.Drawing.Point(38, 12);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // FriendsButton
            // 
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
            this.EventsButton.Location = new System.Drawing.Point(542, 251);
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
            this.EventsListBox.Location = new System.Drawing.Point(520, 281);
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
            this.StatusButton.Location = new System.Drawing.Point(165, 96);
            this.StatusButton.Name = "StatusButton";
            this.StatusButton.Size = new System.Drawing.Size(75, 23);
            this.StatusButton.TabIndex = 17;
            this.StatusButton.Text = "Post Status";
            this.StatusButton.UseVisualStyleBackColor = true;
            this.StatusButton.Click += new System.EventHandler(this.StatusButton_Click);
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
            this.MarriedFriendsButton.AutoSize = true;
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
            this.ShowFriendByStatusLinkedLabel.LinkColor = System.Drawing.Color.Navy;
            this.ShowFriendByStatusLinkedLabel.Location = new System.Drawing.Point(718, 185);
            this.ShowFriendByStatusLinkedLabel.Name = "ShowFriendByStatusLinkedLabel";
            this.ShowFriendByStatusLinkedLabel.Size = new System.Drawing.Size(113, 13);
            this.ShowFriendByStatusLinkedLabel.TabIndex = 26;
            this.ShowFriendByStatusLinkedLabel.TabStop = true;
            this.ShowFriendByStatusLinkedLabel.Text = "Show friends by status";
            this.ShowFriendByStatusLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowFriendByStatusLinkedLabel_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SingleFriendButton);
            this.panel1.Controls.Add(this.MarriedFriendsButton);
            this.panel1.Location = new System.Drawing.Point(722, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 54);
            this.panel1.TabIndex = 24;
            // 
            // MaleButton
            // 
            this.MaleButton.AutoSize = true;
            this.MaleButton.Checked = true;
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
            this.rememberMeButton.Location = new System.Drawing.Point(133, 18);
            this.rememberMeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rememberMeButton.Name = "rememberMeButton";
            this.rememberMeButton.Size = new System.Drawing.Size(94, 17);
            this.rememberMeButton.TabIndex = 30;
            this.rememberMeButton.Text = "Remember me";
            this.rememberMeButton.UseVisualStyleBackColor = true;
            this.rememberMeButton.CheckedChanged += new System.EventHandler(this.RememberMeButton_CheckedChanged);
            // 
            // FacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(992, 473);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RememberMeButton_CheckedChanged(object sender, EventArgs e)
        {
            
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