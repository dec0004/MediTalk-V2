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
            ((System.ComponentModel.ISupportInitialize)(this.RequestsList)).BeginInit();
            this.SuspendLayout();
            // 
            // RequestsList
            // 
            this.RequestsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestsList.Location = new System.Drawing.Point(43, 31);
            this.RequestsList.Name = "RequestsList";
            this.RequestsList.Size = new System.Drawing.Size(708, 368);
            this.RequestsList.TabIndex = 0;
            this.RequestsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RequestList_Click);
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
    }
}