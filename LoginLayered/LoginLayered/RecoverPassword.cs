using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace LoginLayered
{
	public partial class RecoverPassword : Form
	{
		public RecoverPassword()
		{
			InitializeComponent();
		}

		private void buttonSender_Click(object sender, EventArgs e)
		{
			var user = new UserModel();
			var result = user.RecoverPassword(textUserRequest.Text);
			labelResult.Text = result;
		}
	}
}
