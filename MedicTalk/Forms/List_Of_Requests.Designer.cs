namespace MedicTalk
{
    partial class List_Of_Requests
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
            this.RequestsList = new System.Windows.Forms.DataGridView();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeRequested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsList)).BeginInit();
            this.SuspendLayout();
            // 
            // RequestsList
            // 
            this.RequestsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UID,
            this.TimeRequested,
            this.Room,
            this.Section,
            this.Requested});
            this.RequestsList.Location = new System.Drawing.Point(43, 31);
            this.RequestsList.Name = "RequestsList";
            this.RequestsList.Size = new System.Drawing.Size(706, 380);
            this.RequestsList.TabIndex = 0;
            this.RequestsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RequestList_Click);
            // 
            // UID
            // 
            this.UID.DataPropertyName = "UID";
            this.UID.HeaderText = "User ID";
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            // 
            // TimeRequested
            // 
            this.TimeRequested.HeaderText = "Time Requested";
            this.TimeRequested.Name = "TimeRequested";
            this.TimeRequested.ReadOnly = true;
            // 
            // Room
            // 
            this.Room.HeaderText = "Room";
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            // 
            // Section
            // 
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // Requested
            // 
            this.Requested.HeaderText = "Requested";
            this.Requested.Name = "Requested";
            this.Requested.ReadOnly = true;
            // 
            // List_Of_Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RequestsList);
            this.Name = "List_Of_Requests";
            this.Text = "List_Of_Requests";
            this.Load += new System.EventHandler(this.List_Of_Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RequestsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RequestsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeRequested;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requested;
    }
}