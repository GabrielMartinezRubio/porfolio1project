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

namespace LoginLayered
{
	public partial class FormLogin : Form
	{
		#region DLLs_para_que_la_App_se_pueda_arrastrar
		//Para poder arrastrar la app por la pantalla
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg,int wparam, int lparam);
		#endregion

		public FormLogin()
		{
			InitializeComponent();
		}

		private void textUsername_Enter(object sender, EventArgs e) //Para cuando el usuario haga click para escribir su nombre
		{
			if (textUsername.Text == "Usuario")
			{
				textUsername.Text = "";
				textUsername.ForeColor = Color.LightGray;
			}
		}

		private void textUsername_Leave(object sender, EventArgs e)  //Para cuando el usuario salga del apartado del Username
		{
			if (textUsername.Text == "")
			{
				textUsername.Text = "Usuario";
				textUsername.ForeColor = Color.DimGray;
			}
		}

		private void textPassword_Enter(object sender, EventArgs e) //Para cuando el usuario haga click para escribir su contraseña
		{
			if (textPassword.Text == "Contraseña")
			{
				textPassword.Text = "";
				textPassword.ForeColor = Color.LightGray;
				textPassword.UseSystemPasswordChar = true;
			}
		}

		private void textPassword_Leave(object sender, EventArgs e)  //Para cuando el usuario salga del apartado de contraseña
		{
			if (textPassword.Text == "")
			{
				textPassword.Text = "Contraseña";
				textPassword.ForeColor = Color.DimGray;
				textPassword.UseSystemPasswordChar = false;
			}
		}

		private void buttonClose_Click(object sender, EventArgs e) //Para que el boton de "X" cierra la app
		{
			Application.Exit();
		}

		private void buttonMinimize_Click(object sender, EventArgs e) //Para que el boton de "_" minimize la app
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e) //Para poder desplazar la form por el escritorio
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e) //Para poder desplazar el panel por el escritorio
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			if (textUsername.Text!="Usuario")
			{
				errorProvider1.SetError(textUsername, "");
				if (textPassword.Text !="Contraseña")
				{
					errorProvider1.SetError(textPassword, "");
					UserModel user = new UserModel();
					var validLogin = user.LoginUser(textUsername.Text, textPassword.Text);
					if (validLogin == true)
					{
						FormPrincipal mainMenu = new FormPrincipal();
						mainMenu.Show();
						mainMenu.FormClosed += Loguot;
						this.Hide();
					}
					else
					{
						errorProvider1.SetError(textPassword, "Nombre de Usuario o Contraseña incorrectos.\nPor favor intentelo de nuevo.");
						textPassword.UseSystemPasswordChar = false;
						textPassword.Text = "Contraseña";
						textUsername.Focus();
					}
				}
				else
				{
					errorProvider1.SetError(textPassword, "Debes introducir un nombre de Usuario para continuar.");
				}
			}
			else
			{
				errorProvider1.SetError(textUsername, "Debes introducir un nombre de Usuario para continuar.");
			}
		}

		private void Loguot(object sender, FormClosedEventArgs e)
		{
			errorProvider1.SetError(textUsername, "");
			textUsername.Text = "Usuario";
			textPassword.UseSystemPasswordChar = false;
			errorProvider1.SetError(textPassword, "");
			textPassword.Text = "Contraseña";

			this.Show();
		}

		private void linkPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var recoverPassword = new RecoverPassword();
			recoverPassword.ShowDialog();
		}
	}
}
