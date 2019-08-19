namespace project1
{
    partial class LoggedInUserProxy
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
            this.sentencePictureBox = new System.Windows.Forms.PictureBox();
            this.sentenceLabel = new System.Windows.Forms.Label();
            this.sentenceTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sentencePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sentencePictureBox
            // 
            this.sentencePictureBox.Location = new System.Drawing.Point(22, 56);
            this.sentencePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.sentencePictureBox.Name = "sentencePictureBox";
            this.sentencePictureBox.Size = new System.Drawing.Size(288, 69);
            this.sentencePictureBox.TabIndex = 0;
            this.sentencePictureBox.TabStop = false;
            this.sentencePictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sentenceLabel
            // 
            this.sentenceLabel.AutoSize = true;
            this.sentenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentenceLabel.Location = new System.Drawing.Point(79, 26);
            this.sentenceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sentenceLabel.Name = "sentenceLabel";
            this.sentenceLabel.Size = new System.Drawing.Size(188, 17);
            this.sentenceLabel.TabIndex = 1;
            this.sentenceLabel.Text = "Please write this word below ";
            this.sentenceLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // sentenceTextBox
            // 
            this.sentenceTextBox.Location = new System.Drawing.Point(120, 142);
            this.sentenceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.sentenceTextBox.Name = "sentenceTextBox";
            this.sentenceTextBox.Size = new System.Drawing.Size(147, 20);
            this.sentenceTextBox.TabIndex = 2;
            this.sentenceTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(35, 142);
            this.enterButton.Margin = new System.Windows.Forms.Padding(2);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(60, 21);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoggedInUserProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 226);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.sentenceTextBox);
            this.Controls.Add(this.sentenceLabel);
            this.Controls.Add(this.sentencePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoggedInUserProxy";
            this.Text = "LoggedInUserProxy";
            this.Load += new System.EventHandler(this.LoggedInUserProxy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sentencePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sentencePictureBox;
        private System.Windows.Forms.Label sentenceLabel;
        private System.Windows.Forms.TextBox sentenceTextBox;
        private System.Windows.Forms.Button enterButton;
    }
}