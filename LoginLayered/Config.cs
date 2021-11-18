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
			labelUser.Text = UserLoginCachecs.LoginName;
			labelFirstName.Text = UserLoginCachecs.FirstName;
			labelLastName.Text = UserLoginCachecs.LastName;
			labelEmail.Text = UserLoginCachecs.Email;
			labelPosition.Text = UserLoginCachecs.Position;

			textUsername.Text = UserLoginCachecs.LoginName;
			textPassword.Text = UserLoginCachecs.Password;
			textFirstName.Text = UserLoginCachecs.FirstName;
			textLastname.Text = UserLoginCachecs.LastName;
			textEmail.Text = UserLoginCachecs.Email;
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
				var userModel =new  UserModel(
					idUser:UserLoginCachecs.UserId,
					loginName:textUsername.Text,
					password:textPassword.Text,
					firsName:textFirstName.Text,
					lastName:textLastname.Text,
					position: UserLoginCachecs.Position,
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
	}
}
