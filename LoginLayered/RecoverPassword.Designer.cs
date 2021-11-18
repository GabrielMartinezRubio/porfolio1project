
namespace LoginLayered
{
	partial class RecoverPassword
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoverPassword));
			this.textUserRequest = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonSender = new System.Windows.Forms.Button();
			this.labelResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textUserRequest
			// 
			this.textUserRequest.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold);
			this.textUserRequest.Location = new System.Drawing.Point(22, 42);
			this.textUserRequest.Name = "textUserRequest";
			this.textUserRequest.Size = new System.Drawing.Size(342, 23);
			this.textUserRequest.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.DimGray;
			this.label1.Location = new System.Drawing.Point(19, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(323, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ponga su nombre de usuario o email:";
			// 
			// buttonSender
			// 
			this.buttonSender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.buttonSender.Cursor = System.Windows.Forms.Cursors.Default;
			this.buttonSender.FlatAppearance.BorderSize = 0;
			this.buttonSender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.buttonSender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonSender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSender.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold);
			this.buttonSender.ForeColor = System.Drawing.Color.DimGray;
			this.buttonSender.Location = new System.Drawing.Point(370, 42);
			this.buttonSender.Name = "buttonSender";
			this.buttonSender.Size = new System.Drawing.Size(75, 23);
			this.buttonSender.TabIndex = 2;
			this.buttonSender.Text = "Mandar";
			this.buttonSender.UseVisualStyleBackColor = false;
			this.buttonSender.Click += new System.EventHandler(this.buttonSender_Click);
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold);
			this.labelResult.ForeColor = System.Drawing.Color.DimGray;
			this.labelResult.Location = new System.Drawing.Point(19, 68);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(89, 16);
			this.labelResult.TabIndex = 3;
			this.labelResult.Text = "Resultado";
			// 
			// RecoverPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(470, 216);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.buttonSender);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textUserRequest);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "RecoverPassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RecoverPassword";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textUserRequest;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonSender;
		private System.Windows.Forms.Label labelResult;
	}
}