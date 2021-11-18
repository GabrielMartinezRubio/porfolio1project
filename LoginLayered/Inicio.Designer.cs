
namespace LoginLayered
{
	partial class Inicio
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
			this.components = new System.ComponentModel.Container();
			this.labelWelcome = new System.Windows.Forms.Label();
			this.labelHour = new System.Windows.Forms.Label();
			this.labelDate = new System.Windows.Forms.Label();
			this.hourData = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// labelWelcome
			// 
			this.labelWelcome.AutoSize = true;
			this.labelWelcome.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelWelcome.ForeColor = System.Drawing.Color.DimGray;
			this.labelWelcome.Location = new System.Drawing.Point(23, 27);
			this.labelWelcome.Name = "labelWelcome";
			this.labelWelcome.Size = new System.Drawing.Size(155, 25);
			this.labelWelcome.TabIndex = 0;
			this.labelWelcome.Text = "Bienvenido,";
			// 
			// labelHour
			// 
			this.labelHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelHour.AutoSize = true;
			this.labelHour.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHour.ForeColor = System.Drawing.Color.DimGray;
			this.labelHour.Location = new System.Drawing.Point(450, 19);
			this.labelHour.Name = "labelHour";
			this.labelHour.Size = new System.Drawing.Size(143, 33);
			this.labelHour.TabIndex = 1;
			this.labelHour.Text = "00:00:00";
			this.labelHour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDate.ForeColor = System.Drawing.Color.DimGray;
			this.labelDate.Location = new System.Drawing.Point(25, 61);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(62, 16);
			this.labelDate.TabIndex = 2;
			this.labelDate.Text = "label1";
			this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// hourData
			// 
			this.hourData.Enabled = true;
			this.hourData.Tick += new System.EventHandler(this.hourData_Tick);
			// 
			// Inicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(605, 471);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.labelHour);
			this.Controls.Add(this.labelWelcome);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Inicio";
			this.Text = "Inicio";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelWelcome;
		private System.Windows.Forms.Label labelHour;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.Timer hourData;
	}
}