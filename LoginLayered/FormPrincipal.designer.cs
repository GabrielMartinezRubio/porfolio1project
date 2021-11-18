
namespace LoginLayered
{
	partial class FormPrincipal
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
			this.labelPosition = new System.Windows.Forms.Label();
			this.buttonLogOut = new System.Windows.Forms.Button();
			this.labelName = new System.Windows.Forms.Label();
			this.labelEmail = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.PictureBox();
			this.buttonMinimize = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonPaylist = new System.Windows.Forms.Button();
			this.panelMediaSubMenu = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.buttonMenu = new System.Windows.Forms.Button();
			this.buttonConfig = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.buttonCreateUser = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.panelMediaSubPlaylist = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).BeginInit();
			this.panel2.SuspendLayout();
			this.panelMediaSubMenu.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.panelMediaSubPlaylist.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelPosition
			// 
			this.labelPosition.AutoSize = true;
			this.labelPosition.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPosition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelPosition.Location = new System.Drawing.Point(82, 17);
			this.labelPosition.Name = "labelPosition";
			this.labelPosition.Size = new System.Drawing.Size(71, 15);
			this.labelPosition.TabIndex = 10;
			this.labelPosition.Text = "Position";
			// 
			// buttonLogOut
			// 
			this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(190)))), ((int)(((byte)(93)))));
			this.buttonLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonLogOut.FlatAppearance.BorderSize = 0;
			this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLogOut.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonLogOut.Location = new System.Drawing.Point(0, 593);
			this.buttonLogOut.Name = "buttonLogOut";
			this.buttonLogOut.Size = new System.Drawing.Size(178, 40);
			this.buttonLogOut.TabIndex = 5;
			this.buttonLogOut.Text = "Cerrar Sesión";
			this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonLogOut.UseVisualStyleBackColor = false;
			this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Unispace", 7F, System.Drawing.FontStyle.Bold);
			this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelName.Location = new System.Drawing.Point(84, 32);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(29, 12);
			this.labelName.TabIndex = 12;
			this.labelName.Text = "Name";
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Font = new System.Drawing.Font("Unispace", 5F, System.Drawing.FontStyle.Bold);
			this.labelEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelEmail.Location = new System.Drawing.Point(83, 55);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(25, 9);
			this.labelEmail.TabIndex = 13;
			this.labelEmail.Text = "Email";
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(109)))));
			this.panel1.Controls.Add(this.buttonClose);
			this.panel1.Controls.Add(this.buttonMinimize);
			this.panel1.Location = new System.Drawing.Point(195, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(605, 29);
			this.panel1.TabIndex = 14;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
			// 
			// buttonClose
			// 
			this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
			this.buttonClose.Location = new System.Drawing.Point(581, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(20, 20);
			this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.buttonClose.TabIndex = 8;
			this.buttonClose.TabStop = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonMinimize
			// 
			this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
			this.buttonMinimize.Location = new System.Drawing.Point(555, 5);
			this.buttonMinimize.Name = "buttonMinimize";
			this.buttonMinimize.Size = new System.Drawing.Size(20, 20);
			this.buttonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.buttonMinimize.TabIndex = 9;
			this.buttonMinimize.TabStop = false;
			this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.BackColor = System.Drawing.Color.SandyBrown;
			this.panel2.Controls.Add(this.buttonCreateUser);
			this.panel2.Controls.Add(this.panelMediaSubPlaylist);
			this.panel2.Controls.Add(this.buttonPaylist);
			this.panel2.Controls.Add(this.panelMediaSubMenu);
			this.panel2.Controls.Add(this.buttonMenu);
			this.panel2.Controls.Add(this.buttonConfig);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.buttonLogOut);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(195, 500);
			this.panel2.TabIndex = 15;
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
			// 
			// buttonPaylist
			// 
			this.buttonPaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(190)))), ((int)(((byte)(93)))));
			this.buttonPaylist.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonPaylist.FlatAppearance.BorderSize = 0;
			this.buttonPaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPaylist.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
			this.buttonPaylist.Location = new System.Drawing.Point(0, 307);
			this.buttonPaylist.Name = "buttonPaylist";
			this.buttonPaylist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.buttonPaylist.Size = new System.Drawing.Size(178, 40);
			this.buttonPaylist.TabIndex = 2;
			this.buttonPaylist.Text = "Playlist";
			this.buttonPaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonPaylist.UseVisualStyleBackColor = false;
			this.buttonPaylist.Click += new System.EventHandler(this.buttonPaylist_Click);
			// 
			// panelMediaSubMenu
			// 
			this.panelMediaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
			this.panelMediaSubMenu.Controls.Add(this.button4);
			this.panelMediaSubMenu.Controls.Add(this.button3);
			this.panelMediaSubMenu.Controls.Add(this.button2);
			this.panelMediaSubMenu.Controls.Add(this.button1);
			this.panelMediaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelMediaSubMenu.Location = new System.Drawing.Point(0, 140);
			this.panelMediaSubMenu.Name = "panelMediaSubMenu";
			this.panelMediaSubMenu.Size = new System.Drawing.Size(178, 167);
			this.panelMediaSubMenu.TabIndex = 2;
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Top;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
			this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button4.Location = new System.Drawing.Point(0, 120);
			this.button4.Name = "button4";
			this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button4.Size = new System.Drawing.Size(178, 40);
			this.button4.TabIndex = 3;
			this.button4.Text = "button4";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Dock = System.Windows.Forms.DockStyle.Top;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
			this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.Location = new System.Drawing.Point(0, 80);
			this.button3.Name = "button3";
			this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button3.Size = new System.Drawing.Size(178, 40);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
			this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.Location = new System.Drawing.Point(0, 40);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button2.Size = new System.Drawing.Size(178, 40);
			this.button2.TabIndex = 3;
			this.button2.Text = "button2";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Top;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button1.Size = new System.Drawing.Size(178, 40);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonMenu
			// 
			this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(190)))), ((int)(((byte)(93)))));
			this.buttonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonMenu.FlatAppearance.BorderSize = 0;
			this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMenu.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMenu.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.buttonMenu.Location = new System.Drawing.Point(0, 100);
			this.buttonMenu.Name = "buttonMenu";
			this.buttonMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.buttonMenu.Size = new System.Drawing.Size(178, 40);
			this.buttonMenu.TabIndex = 1;
			this.buttonMenu.Text = "Menu";
			this.buttonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonMenu.UseVisualStyleBackColor = false;
			this.buttonMenu.Click += new System.EventHandler(this.buttonUser_Click);
			// 
			// buttonConfig
			// 
			this.buttonConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(190)))), ((int)(((byte)(93)))));
			this.buttonConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonConfig.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonConfig.FlatAppearance.BorderSize = 0;
			this.buttonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonConfig.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonConfig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonConfig.Location = new System.Drawing.Point(0, 553);
			this.buttonConfig.Name = "buttonConfig";
			this.buttonConfig.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.buttonConfig.Size = new System.Drawing.Size(178, 40);
			this.buttonConfig.TabIndex = 4;
			this.buttonConfig.Text = "Ajustes";
			this.buttonConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonConfig.UseVisualStyleBackColor = false;
			this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(156)))), ((int)(((byte)(96)))));
			this.panel3.Controls.Add(this.pictureBox4);
			this.panel3.Controls.Add(this.labelPosition);
			this.panel3.Controls.Add(this.labelName);
			this.panel3.Controls.Add(this.labelEmail);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(178, 100);
			this.panel3.TabIndex = 0;
			this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(12, 3);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(65, 84);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 16;
			this.pictureBox4.TabStop = false;
			// 
			// panelContenedor
			// 
			this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelContenedor.Location = new System.Drawing.Point(195, 29);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(605, 471);
			this.panelContenedor.TabIndex = 16;
			this.panelContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
			// 
			// buttonCreateUser
			// 
			this.buttonCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(190)))), ((int)(((byte)(93)))));
			this.buttonCreateUser.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonCreateUser.FlatAppearance.BorderSize = 0;
			this.buttonCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCreateUser.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
			this.buttonCreateUser.Location = new System.Drawing.Point(0, 513);
			this.buttonCreateUser.Name = "buttonCreateUser";
			this.buttonCreateUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.buttonCreateUser.Size = new System.Drawing.Size(178, 40);
			this.buttonCreateUser.TabIndex = 3;
			this.buttonCreateUser.Text = "Crear Usuario";
			this.buttonCreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonCreateUser.UseVisualStyleBackColor = false;
			this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
			// 
			// button6
			// 
			this.button6.Dock = System.Windows.Forms.DockStyle.Top;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
			this.button6.Location = new System.Drawing.Point(0, 0);
			this.button6.Name = "button6";
			this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button6.Size = new System.Drawing.Size(178, 40);
			this.button6.TabIndex = 0;
			this.button6.Text = "button6";
			this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Dock = System.Windows.Forms.DockStyle.Top;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
			this.button7.Location = new System.Drawing.Point(0, 40);
			this.button7.Name = "button7";
			this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button7.Size = new System.Drawing.Size(178, 40);
			this.button7.TabIndex = 1;
			this.button7.Text = "button7";
			this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Dock = System.Windows.Forms.DockStyle.Top;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
			this.button8.Location = new System.Drawing.Point(0, 80);
			this.button8.Name = "button8";
			this.button8.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button8.Size = new System.Drawing.Size(178, 40);
			this.button8.TabIndex = 2;
			this.button8.Text = "button8";
			this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Dock = System.Windows.Forms.DockStyle.Top;
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
			this.button9.Location = new System.Drawing.Point(0, 120);
			this.button9.Name = "button9";
			this.button9.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button9.Size = new System.Drawing.Size(178, 40);
			this.button9.TabIndex = 3;
			this.button9.Text = "button9";
			this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// panelMediaSubPlaylist
			// 
			this.panelMediaSubPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
			this.panelMediaSubPlaylist.Controls.Add(this.button9);
			this.panelMediaSubPlaylist.Controls.Add(this.button8);
			this.panelMediaSubPlaylist.Controls.Add(this.button7);
			this.panelMediaSubPlaylist.Controls.Add(this.button6);
			this.panelMediaSubPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelMediaSubPlaylist.Location = new System.Drawing.Point(0, 347);
			this.panelMediaSubPlaylist.Name = "panelMediaSubPlaylist";
			this.panelMediaSubPlaylist.Size = new System.Drawing.Size(178, 166);
			this.panelMediaSubPlaylist.TabIndex = 4;
			// 
			// FormPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(800, 500);
			this.Controls.Add(this.panelContenedor);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormPrincipal";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPrincipal_MouseDown);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panelMediaSubMenu.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.panelMediaSubPlaylist.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox buttonMinimize;
		private System.Windows.Forms.PictureBox buttonClose;
		private System.Windows.Forms.Label labelPosition;
		private System.Windows.Forms.Button buttonLogOut;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Button buttonConfig;
		private System.Windows.Forms.Button buttonMenu;
		private System.Windows.Forms.Panel panelContenedor;
		private System.Windows.Forms.Panel panelMediaSubMenu;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonPaylist;
		private System.Windows.Forms.Button buttonCreateUser;
		private System.Windows.Forms.Panel panelMediaSubPlaylist;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
	}
}

