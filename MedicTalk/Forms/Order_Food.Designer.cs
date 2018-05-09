namespace MedicTalk
{
	partial class Order_Food
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ColdCheckbox = new System.Windows.Forms.CheckBox();
            this.WarmCheckbox = new System.Windows.Forms.CheckBox();
            this.HotCheckbox = new System.Windows.Forms.CheckBox();
            this.MealType_Header = new System.Windows.Forms.Label();
            this.OtherRequests_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MealSelection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MedicTalk.Properties.Resources.Icon_Return;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 55);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::MedicTalk.Properties.Resources.Icon_Submitted;
            this.button2.Location = new System.Drawing.Point(233, 302);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 20);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Submit_Clicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MedicTalk.Properties.Resources.Plain_Background;
            this.pictureBox2.Location = new System.Drawing.Point(89, 49);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(367, 239);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // ColdCheckbox
            // 
            this.ColdCheckbox.AutoSize = true;
            this.ColdCheckbox.Location = new System.Drawing.Point(149, 109);
            this.ColdCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.ColdCheckbox.Name = "ColdCheckbox";
            this.ColdCheckbox.Size = new System.Drawing.Size(47, 17);
            this.ColdCheckbox.TabIndex = 12;
            this.ColdCheckbox.Text = "Cold";
            this.ColdCheckbox.UseVisualStyleBackColor = true;
            this.ColdCheckbox.CheckedChanged += new System.EventHandler(this.ColdCheckbox_Checked);
            // 
            // WarmCheckbox
            // 
            this.WarmCheckbox.AutoSize = true;
            this.WarmCheckbox.Location = new System.Drawing.Point(241, 109);
            this.WarmCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.WarmCheckbox.Name = "WarmCheckbox";
            this.WarmCheckbox.Size = new System.Drawing.Size(54, 17);
            this.WarmCheckbox.TabIndex = 13;
            this.WarmCheckbox.Text = "Warm";
            this.WarmCheckbox.UseVisualStyleBackColor = true;
            this.WarmCheckbox.CheckedChanged += new System.EventHandler(this.WarmCheckbox_Checked);
            // 
            // HotCheckbox
            // 
            this.HotCheckbox.AutoSize = true;
            this.HotCheckbox.Location = new System.Drawing.Point(338, 109);
            this.HotCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.HotCheckbox.Name = "HotCheckbox";
            this.HotCheckbox.Size = new System.Drawing.Size(43, 17);
            this.HotCheckbox.TabIndex = 14;
            this.HotCheckbox.Text = "Hot";
            this.HotCheckbox.UseVisualStyleBackColor = true;
            this.HotCheckbox.CheckedChanged += new System.EventHandler(this.HotCheckBoxChecked);
            // 
            // MealType_Header
            // 
            this.MealType_Header.AutoSize = true;
            this.MealType_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealType_Header.Location = new System.Drawing.Point(214, 55);
            this.MealType_Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MealType_Header.Name = "MealType_Header";
            this.MealType_Header.Size = new System.Drawing.Size(130, 31);
            this.MealType_Header.TabIndex = 15;
            this.MealType_Header.Text = "Breakfast";
            // 
            // OtherRequests_TextBox
            // 
            this.OtherRequests_TextBox.Location = new System.Drawing.Point(328, 172);
            this.OtherRequests_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.OtherRequests_TextBox.Multiline = true;
            this.OtherRequests_TextBox.Name = "OtherRequests_TextBox";
            this.OtherRequests_TextBox.Size = new System.Drawing.Size(98, 101);
            this.OtherRequests_TextBox.TabIndex = 17;
            this.OtherRequests_TextBox.TextChanged += new System.EventHandler(this.Requests_Text_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Other requests?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MealSelection
            // 
            this.MealSelection.FormattingEnabled = true;
            this.MealSelection.Location = new System.Drawing.Point(113, 172);
            this.MealSelection.Margin = new System.Windows.Forms.Padding(2);
            this.MealSelection.Name = "MealSelection";
            this.MealSelection.Size = new System.Drawing.Size(198, 21);
            this.MealSelection.TabIndex = 19;
            this.MealSelection.Text = "Make your choice";
            this.MealSelection.SelectedIndexChanged += new System.EventHandler(this.MealSelectionBox_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Todays options";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Image = global::MedicTalk.Properties.Resources.Icon_Request_Emergency;
            this.button7.Location = new System.Drawing.Point(427, 8);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 23);
            this.button7.TabIndex = 21;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Info;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Bernard MT Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(204, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.label9.Size = new System.Drawing.Size(140, 40);
            this.label9.TabIndex = 36;
            this.label9.Text = "MediTalk";
            // 
            // Order_Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicTalk.Properties.Resources.Home_Background1;
            this.ClientSize = new System.Drawing.Size(541, 343);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MealSelection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OtherRequests_TextBox);
            this.Controls.Add(this.MealType_Header);
            this.Controls.Add(this.HotCheckbox);
            this.Controls.Add(this.WarmCheckbox);
            this.Controls.Add(this.ColdCheckbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Order_Food";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.CheckBox ColdCheckbox;
		private System.Windows.Forms.CheckBox WarmCheckbox;
		private System.Windows.Forms.CheckBox HotCheckbox;
		private System.Windows.Forms.Label MealType_Header;
		private System.Windows.Forms.TextBox OtherRequests_TextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox MealSelection;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label9;
    }
}