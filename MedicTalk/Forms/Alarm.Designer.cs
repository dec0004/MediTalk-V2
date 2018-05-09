namespace MedicTalk
{
	partial class Alarm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hour_Box = new System.Windows.Forms.ComboBox();
            this.Minute_Box = new System.Windows.Forms.ComboBox();
            this.AlarmsList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Youralarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmsList)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MedicTalk.Properties.Resources.Icon_Return;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 55);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MedicTalk.Properties.Resources.MediTalk_Heading;
            this.pictureBox1.Location = new System.Drawing.Point(210, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 27);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MedicTalk.Properties.Resources.Plain_Background;
            this.pictureBox2.Location = new System.Drawing.Point(89, 49);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(367, 239);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Set Alarm";
            // 
            // Hour_Box
            // 
            this.Hour_Box.FormattingEnabled = true;
            this.Hour_Box.Location = new System.Drawing.Point(179, 103);
            this.Hour_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Hour_Box.Name = "Hour_Box";
            this.Hour_Box.Size = new System.Drawing.Size(82, 21);
            this.Hour_Box.TabIndex = 17;
            this.Hour_Box.Text = "Hour";
            this.Hour_Box.SelectedIndexChanged += new System.EventHandler(this.Hour_Changed);
            // 
            // Minute_Box
            // 
            this.Minute_Box.FormattingEnabled = true;
            this.Minute_Box.Location = new System.Drawing.Point(281, 103);
            this.Minute_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Minute_Box.Name = "Minute_Box";
            this.Minute_Box.Size = new System.Drawing.Size(82, 21);
            this.Minute_Box.TabIndex = 18;
            this.Minute_Box.Text = "Minutes";
            this.Minute_Box.SelectedIndexChanged += new System.EventHandler(this.Minute_Changed);
            // 
            // AlarmsList
            // 
            this.AlarmsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlarmsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Youralarm,
            this.RemoveColumn});
            this.AlarmsList.Location = new System.Drawing.Point(150, 172);
            this.AlarmsList.Margin = new System.Windows.Forms.Padding(2);
            this.AlarmsList.Name = "AlarmsList";
            this.AlarmsList.RowTemplate.Height = 28;
            this.AlarmsList.Size = new System.Drawing.Size(248, 116);
            this.AlarmsList.TabIndex = 20;
            this.AlarmsList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Remove_Alarm);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Previous Alarms";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Image = global::MedicTalk.Properties.Resources.Icon_Request_Emergency;
            this.button7.Location = new System.Drawing.Point(427, 8);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 23);
            this.button7.TabIndex = 23;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Submit_Button
            // 
            this.Submit_Button.Image = global::MedicTalk.Properties.Resources.Icon_Submitted;
            this.Submit_Button.Location = new System.Drawing.Point(230, 131);
            this.Submit_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(88, 20);
            this.Submit_Button.TabIndex = 38;
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // Youralarm
            // 
            this.Youralarm.DataPropertyName = "TimeToComplete";
            this.Youralarm.HeaderText = "Your Alarms";
            this.Youralarm.Name = "Youralarm";
            // 
            // RemoveColumn
            // 
            this.RemoveColumn.HeaderText = "Remove alarm";
            this.RemoveColumn.Name = "RemoveColumn";
            this.RemoveColumn.Width = 88;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicTalk.Properties.Resources.Home_Background1;
            this.ClientSize = new System.Drawing.Size(541, 343);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlarmsList);
            this.Controls.Add(this.Minute_Box);
            this.Controls.Add(this.Hour_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Alarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Hour_Box;
		private System.Windows.Forms.ComboBox Minute_Box;
		private System.Windows.Forms.DataGridView AlarmsList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Youralarm;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveColumn;
    }
}