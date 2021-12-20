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
	public partial class CreateUser : Form
	{
		public CreateUser()
		{
			InitializeComponent();
		}

		private void CreateUser_Load(object sender, EventArgs e)
		{
			//LoadUserData();
		}
		private void LoadUserData()
		{
			labelUser.Text = "";
			labelFirstName.Text = "";
			labelLastName.Text = "";
			labelEmail.Text = "";
			labelPosition.Text = "";

			textUsername.Text = "";
			textPassword.Text = "";
			textFirstName.Text = "";
			textLastname.Text = "";
			cbPosition.Text = "";
			textEmail.Text = "";
		}
		private void Reset()
		{
			LoadUserData();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (textPassword.Text.Length >= 4)
			{
				var userModel = new UserModel(
					idUser: UserLoginCache.IdUser,
					loginName: textUsername.Text,
					password: textPassword.Text,
					firstName: textFirstName.Text,
					lastName: textLastname.Text,
					position: cbPosition.Text,
					email: textEmail.Text);
				var result = userModel.CreateUser();
				MessageBox.Show(result);
				Reset();
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Reset();
		}
	}
}
