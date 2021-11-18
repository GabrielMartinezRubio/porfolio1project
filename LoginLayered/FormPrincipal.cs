using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //Libreria que uso para que se pueda arrastrar la app por pantalla
using Domain;
using Common.Cache;

namespace LoginLayered
{
	public partial class FormPrincipal : Form
	{
		#region DLLs_para_que_la_App_se_pueda_arrastrar
		//Para poder arrastrar la app por la pantalla
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
		#endregion
		public FormPrincipal()
		{
			InitializeComponent();
			LogUserData();
			AbrirForm(new Inicio());
			CustomizeDesing();
			if (UserLoginCachecs.Position == Positions.Usuario)
			{
				//buttonConfig.Enabled = false;
				//buttonConfig.Visible = false;
				buttonCreateUser.Enabled = false;
				buttonCreateUser.Visible = false;
			}
			if (UserLoginCachecs.Position == Positions.Administrador)
			{
				//Todo disponible
			}
		}

		private void LogUserData()
		{
			labelPosition.Text = UserLoginCachecs.Position;
			labelName.Text = UserLoginCachecs.FirstName + ",\n" + UserLoginCachecs.LastName;
			labelEmail.Text = UserLoginCachecs.Email;
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void buttonLogOut_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Estas a punto de cerrar sesion", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void FormPrincipal_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		private void AbrirForm(object formChildren)
		{
			if (this.panelContenedor.Controls.Count > 0)
			{
				this.panelContenedor.Controls.RemoveAt(0);
			}
			Form fc = formChildren as Form;
			fc.TopLevel = false;
			fc.Dock = DockStyle.Fill;
			this.panelContenedor.Controls.Add(fc);
			this.panelContenedor.Tag = fc;
			fc.Show();
		}
		

		private void buttonConfig_Click(object sender, EventArgs e)
		{
			AbrirForm(new Config());
		}

		private void panel3_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		private void CustomizeDesing()
		{
			panelMediaSubMenu.Visible = false;
			panelMediaSubPlaylist.Visible = false;
		}
		private void OcultarSubMenus()
		{
			if (panelMediaSubMenu.Visible == true)
			{
				panelMediaSubMenu.Visible = false;
			}
			if (panelMediaSubPlaylist.Visible == true)
			{
				panelMediaSubPlaylist.Visible = false;
			}
		}
		private void MostrarSubMenus(Panel subMenu)
		{
			if (subMenu.Visible == false)
			{
				OcultarSubMenus();
				subMenu.Visible = true;
			}
			else
			{
				subMenu.Visible = false;
			}
		}
		#region User
		private void buttonUser_Click(object sender, EventArgs e)
		{
			AbrirForm(new Inicio());
			MostrarSubMenus(panelMediaSubMenu);
		}
		private void button1_Click(object sender, EventArgs e)
		{
			OcultarSubMenus();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			OcultarSubMenus();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			OcultarSubMenus();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			OcultarSubMenus();
		}
		#endregion
		#region Playlist
		private void buttonPaylist_Click(object sender, EventArgs e)
		{
			AbrirForm(new Playlist());
			MostrarSubMenus(panelMediaSubPlaylist);
		}
		private void button6_Click(object sender, EventArgs e)
		{
			OcultarSubMenus();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			OcultarSubMenus();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			OcultarSubMenus();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			OcultarSubMenus();
		}
		#endregion

		private void buttonCreateUser_Click(object sender, EventArgs e)
		{
			OcultarSubMenus();
			AbrirForm(new CreateUser());
		}
	}
}
