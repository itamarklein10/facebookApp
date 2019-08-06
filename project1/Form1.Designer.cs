namespace project1
{
    public partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.friendsByStatusListBox = new System.Windows.Forms.ListBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.FriendPicture = new System.Windows.Forms.PictureBox();
            this.StatusButton = new System.Windows.Forms.Button();
            this.friendByStatusPictureBox = new System.Windows.Forms.PictureBox();
            this.PagePictureBox = new System.Windows.Forms.PictureBox();
            this.MarriedFriendsButton = new System.Windows.Forms.RadioButton();
            this.singleFriendButton = new System.Windows.Forms.RadioButton();
            this.showFriendByStatusLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.facebookLogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendByStatusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPictureBox)).BeginInit();
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
            this.LoginButton.Click += new System.EventHandler(this.Button1_Click);
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
            // friendsByStatusListBox
            // 
            this.friendsByStatusListBox.FormattingEnabled = true;
            this.friendsByStatusListBox.Location = new System.Drawing.Point(722, 281);
            this.friendsByStatusListBox.Name = "friendsByStatusListBox";
            this.friendsByStatusListBox.Size = new System.Drawing.Size(120, 173);
            this.friendsByStatusListBox.TabIndex = 14;
            this.friendsByStatusListBox.SelectedIndexChanged += new System.EventHandler(this.PhotosListBox_SelectedIndexChanged);
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
            // friendByStatusPictureBox
            // 
            this.friendByStatusPictureBox.Location = new System.Drawing.Point(848, 303);
            this.friendByStatusPictureBox.Name = "friendByStatusPictureBox";
            this.friendByStatusPictureBox.Size = new System.Drawing.Size(113, 112);
            this.friendByStatusPictureBox.TabIndex = 18;
            this.friendByStatusPictureBox.TabStop = false;
            this.friendByStatusPictureBox.Click += new System.EventHandler(this.FriendByStatus_Click);
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
            // singleFriendButton
            // 
            this.singleFriendButton.AutoSize = true;
            this.singleFriendButton.Checked = true;
            this.singleFriendButton.Location = new System.Drawing.Point(3, 12);
            this.singleFriendButton.Name = "singleFriendButton";
            this.singleFriendButton.Size = new System.Drawing.Size(91, 17);
            this.singleFriendButton.TabIndex = 23;
            this.singleFriendButton.Text = "Single Friends";
            this.singleFriendButton.UseVisualStyleBackColor = true;
            this.singleFriendButton.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // showFriendByStatusLinkedLabel
            // 
            this.showFriendByStatusLinkedLabel.AutoSize = true;
            this.showFriendByStatusLinkedLabel.Location = new System.Drawing.Point(718, 185);
            this.showFriendByStatusLinkedLabel.Name = "showFriendByStatusLinkedLabel";
            this.showFriendByStatusLinkedLabel.Size = new System.Drawing.Size(113, 13);
            this.showFriendByStatusLinkedLabel.TabIndex = 26;
            this.showFriendByStatusLinkedLabel.TabStop = true;
            this.showFriendByStatusLinkedLabel.Text = "Show friends by status";
            this.showFriendByStatusLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowFriendByStatusLinkedLabel_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.singleFriendButton);
            this.panel1.Controls.Add(this.MarriedFriendsButton);
            this.panel1.Location = new System.Drawing.Point(722, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 54);
            this.panel1.TabIndex = 24;
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Checked = true;
            this.maleButton.Location = new System.Drawing.Point(722, 201);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(48, 17);
            this.maleButton.TabIndex = 24;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            this.maleButton.CheckedChanged += new System.EventHandler(this.MaleButton_CheckedChanged);
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Location = new System.Drawing.Point(772, 201);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(59, 17);
            this.femaleButton.TabIndex = 27;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            this.femaleButton.CheckedChanged += new System.EventHandler(this.FemaleButton_CheckedChanged);
            // 
            // facebookLogoPictureBox
            // 
            this.facebookLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("facebookLogoPictureBox.Image")));
            this.facebookLogoPictureBox.Location = new System.Drawing.Point(708, 12);
            this.facebookLogoPictureBox.Name = "facebookLogoPictureBox";
            this.facebookLogoPictureBox.Size = new System.Drawing.Size(262, 92);
            this.facebookLogoPictureBox.TabIndex = 29;
            this.facebookLogoPictureBox.TabStop = false;
            this.facebookLogoPictureBox.Click += new System.EventHandler(this.FacebookLogoPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 475);
            this.Controls.Add(this.facebookLogoPictureBox);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showFriendByStatusLinkedLabel);
            this.Controls.Add(this.PagePictureBox);
            this.Controls.Add(this.friendByStatusPictureBox);
            this.Controls.Add(this.StatusButton);
            this.Controls.Add(this.FriendPicture);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.friendsByStatusListBox);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendByStatusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;

        private System.Windows.Forms.Button FriendsButton;
        private System.Windows.Forms.Button PageButton;
        private System.Windows.Forms.Button BirthdayButton;
        private System.Windows.Forms.ListBox FriendsListBox;
        private System.Windows.Forms.ListBox PagesListBox;
        private System.Windows.Forms.ListBox BirthdaysListBox;
        private System.Windows.Forms.Button EventsButton;
        private System.Windows.Forms.ListBox EventsListBox;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.ListBox friendsByStatusListBox;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.PictureBox FriendPicture;
        private System.Windows.Forms.Button StatusButton;
        private System.Windows.Forms.PictureBox friendByStatusPictureBox;
        private System.Windows.Forms.PictureBox PagePictureBox;
        private System.Windows.Forms.RadioButton MarriedFriendsButton;
        private System.Windows.Forms.RadioButton singleFriendButton;
        private System.Windows.Forms.LinkLabel showFriendByStatusLinkedLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.PictureBox facebookLogoPictureBox;
    }
}