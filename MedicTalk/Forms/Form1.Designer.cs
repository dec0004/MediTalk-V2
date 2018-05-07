namespace MedicTalk
{
	partial class Form1
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
            this.Username_Textbox = new System.Windows.Forms.TextBox();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ForgotPassword = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ForgotUsername = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username_Textbox
            // 
            this.Username_Textbox.Location = new System.Drawing.Point(179, 128);
            this.Username_Textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Username_Textbox.Name = "Username_Textbox";
            this.Username_Textbox.Size = new System.Drawing.Size(183, 20);
            this.Username_Textbox.TabIndex = 1;
            this.Username_Textbox.TextChanged += new System.EventHandler(this.Username_Textbox_TextChanged);
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Location = new System.Drawing.Point(179, 175);
            this.Password_Textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(183, 20);
            this.Password_Textbox.TabIndex = 2;
            this.Password_Textbox.TextChanged += new System.EventHandler(this.Password_Textbox_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(217, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(220, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter Password";
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ForgotPassword.Location = new System.Drawing.Point(199, 289);
            this.ForgotPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(128, 24);
            this.ForgotPassword.TabIndex = 7;
            this.ForgotPassword.Text = "Forgot Password";
            this.ForgotPassword.UseVisualStyleBackColor = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ForgotUsername
            // 
            this.ForgotUsername.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ForgotUsername.Location = new System.Drawing.Point(199, 253);
            this.ForgotUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ForgotUsername.Name = "ForgotUsername";
            this.ForgotUsername.Size = new System.Drawing.Size(128, 24);
            this.ForgotUsername.TabIndex = 9;
            this.ForgotUsername.Text = "Forgot Username";
            this.ForgotUsername.UseVisualStyleBackColor = false;
            this.ForgotUsername.Click += new System.EventHandler(this.Forgot_UserName_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Login.Location = new System.Drawing.Point(231, 205);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(73, 24);
            this.Login.TabIndex = 10;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Info;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Bernard MT Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(204, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.label9.Size = new System.Drawing.Size(140, 40);
            this.label9.TabIndex = 37;
            this.label9.Text = "MediTalk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::MedicTalk.Properties.Resources.Login_Page_Background;
            this.ClientSize = new System.Drawing.Size(541, 351);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.ForgotUsername);
            this.Controls.Add(this.ForgotPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.Username_Textbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Forgot_Password;
		private System.Windows.Forms.Button Forgot_UserName;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox Username_Textbox;
		private System.Windows.Forms.TextBox Password_Textbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button ForgotPassword;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Button ForgotUsername;
		private System.Windows.Forms.Button Login;
		private System.Windows.Forms.Label label9;
	}
}

