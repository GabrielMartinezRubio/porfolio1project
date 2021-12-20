using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace LoginLayered
{
	public partial class Config : Form
	{
		public Config()
		{
			InitializeComponent();
		}

		private void Config_Load(object sender, EventArgs e)
		{
			LoadUserData();
		}
		private void LoadUserData()
		{
			labelUser.Text = UserLoginCache.LoginName;
			labelFirstName.Text = UserLoginCache.FirstName;
			labelLastName.Text = UserLoginCache.LastName;
			labelEmail.Text = UserLoginCache.Email;
			labelPosition.Text = UserLoginCache.Position;

			textUsername.Text = UserLoginCache.LoginName;
			textPassword.Text = UserLoginCache.Password;
			textFirstName.Text = UserLoginCache.FirstName;
			textLastname.Text = UserLoginCache.LastName;
			textEmail.Text = UserLoginCache.Email;
		}
		private void Reset()
		{
			LoadUserData();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			panel1.Visible = true;
			LoadUserData();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (textPassword.Text.Length >= 4)
			{
				var userModel = new UserModel(
					idUser:UserLoginCache.IdUser,
					loginName:textUsername.Text,
					password:textPassword.Text,
					firstName:textFirstName.Text,
					lastName:textLastname.Text,
					position: UserLoginCache.Position,
					email:textEmail.Text);
				var result = userModel.editUserProfile();
				MessageBox.Show(result);
				Reset();
				panel1.Visible = false;
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			panel1.Visible = false;
			Reset();
		}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
