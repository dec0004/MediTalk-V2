namespace MediTalk
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
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.Forgot_UserName = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Login = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Cooper Black", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(335, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(339, 126);
			this.label1.TabIndex = 0;
			this.label1.Text = "MediTalk";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.Forgot_UserName);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.Login);
			this.groupBox1.Location = new System.Drawing.Point(323, 182);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(341, 337);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(86, 276);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(162, 31);
			this.button2.TabIndex = 4;
			this.button2.Text = "Forgot Password";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Forgot_UserName
			// 
			this.Forgot_UserName.Location = new System.Drawing.Point(86, 223);
			this.Forgot_UserName.Name = "Forgot_UserName";
			this.Forgot_UserName.Size = new System.Drawing.Size(162, 31);
			this.Forgot_UserName.TabIndex = 3;
			this.Forgot_UserName.Text = "Forgot Username";
			this.Forgot_UserName.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(80, 157);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(175, 26);
			this.textBox2.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(80, 106);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(175, 26);
			this.textBox1.TabIndex = 1;
			// 
			// Login
			// 
			this.Login.AutoSize = true;
			this.Login.Location = new System.Drawing.Point(143, 55);
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(48, 20);
			this.Login.TabIndex = 0;
			this.Login.Text = "Login";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = global::MediTalk.Properties.Resources.Login_Page_Background;
			this.ClientSize = new System.Drawing.Size(971, 621);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "MediTalk";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label Login;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button Forgot_UserName;
		private System.Windows.Forms.Button button2;
	}
}

