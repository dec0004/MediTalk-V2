﻿namespace MedicTalk
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
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(269, 192);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(272, 26);
			this.textBox3.TabIndex = 1;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(269, 263);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(272, 26);
			this.textBox4.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(325, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(156, 24);
			this.label4.TabIndex = 4;
			this.label4.Text = "Enter Username";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(330, 236);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(151, 24);
			this.label5.TabIndex = 5;
			this.label5.Text = "Enter Password";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button3.Location = new System.Drawing.Point(298, 433);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(192, 36);
			this.button3.TabIndex = 7;
			this.button3.Text = "Forgot Password";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Location = new System.Drawing.Point(298, 380);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(192, 36);
			this.button1.TabIndex = 9;
			this.button1.Text = "Forgot Username";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Forgot_UserName_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button2.Location = new System.Drawing.Point(346, 308);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 36);
			this.button2.TabIndex = 10;
			this.button2.Text = "Login";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.SystemColors.Info;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Bernard MT Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(306, 10);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
			this.label9.Size = new System.Drawing.Size(203, 58);
			this.label9.TabIndex = 37;
			this.label9.Text = "MediTalk";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackgroundImage = global::MedicTalk.Properties.Resources.Login_Page_Background;
			this.ClientSize = new System.Drawing.Size(811, 527);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
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
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label9;
	}
}

