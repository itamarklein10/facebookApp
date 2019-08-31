using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace project1
{
    public partial class FormLoggedInUserProxy : Form
    {
       private FormFacebook m_FacebookForm;

        public FormLoggedInUserProxy(FormFacebook i_facebookForm)
        {
            InitializeComponent();
            m_FacebookForm = i_facebookForm;
            ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void EnterSentence_Click(object sender, EventArgs e)
        {
            if (sentenceTextBox.Text == "EWERB" || sentenceTextBox.Text == "ewerb")
            {
                m_FacebookForm.LoginUser();
                Close();
            }
            else
            {
                MessageBox.Show("incorrect input");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void LoggedInUserProxy_Load(object sender, EventArgs e)
        {
        }
    }
}
