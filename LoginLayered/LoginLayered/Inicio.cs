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

namespace LoginLayered
{
	public partial class Inicio : Form
	{
		public Inicio()
		{
			InitializeComponent();
			labelWelcome.Text += " " + UserLoginCache.FirstName;
		}

		private void hourData_Tick(object sender, EventArgs e)
		{
			labelHour.Text = DateTime.Now.ToString("HH:mm:ss");
			//labelHour.Text = DateTime.Now.ToString("hh:mm:ss");
			labelDate.Text = DateTime.Now.ToLongDateString();
		}
	}
}
