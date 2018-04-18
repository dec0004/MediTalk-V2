namespace MedicTalk
{
	partial class Forgot_Password
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
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new System.Drawing.Point(339, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 24);
			this.label2.TabIndex = 12;
			this.label2.Text = "Enter Email";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(269, 217);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(272, 26);
			this.textBox1.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label3.Location = new System.Drawing.Point(324, 259);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(164, 24);
			this.label3.TabIndex = 14;
			this.label3.Text = "Enter User Name";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(269, 310);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(272, 26);
			this.textBox2.TabIndex = 15;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::MedicTalk.Properties.Resources.MediTalk_Heading;
			this.pictureBox1.Location = new System.Drawing.Point(319, 60);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(171, 41);
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.Image = global::MedicTalk.Properties.Resources.Icon_Submitted;
			this.button2.Location = new System.Drawing.Point(343, 393);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(132, 31);
			this.button2.TabIndex = 18;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Forgot_Password
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MedicTalk.Properties.Resources.Login_Page_Background;
			this.ClientSize = new System.Drawing.Size(811, 527);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Name = "Forgot_Password";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button2;
	}
}