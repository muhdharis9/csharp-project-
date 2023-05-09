namespace Project2WorkshopTester
{
    partial class FormView
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
            this.buttonViewUsers = new System.Windows.Forms.Button();
            this.buttonViewBookingHistory = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonViewUsers
            // 
            this.buttonViewUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonViewUsers.BackColor = System.Drawing.Color.Brown;
            this.buttonViewUsers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewUsers.ForeColor = System.Drawing.Color.White;
            this.buttonViewUsers.Location = new System.Drawing.Point(425, 206);
            this.buttonViewUsers.Name = "buttonViewUsers";
            this.buttonViewUsers.Size = new System.Drawing.Size(354, 79);
            this.buttonViewUsers.TabIndex = 0;
            this.buttonViewUsers.Text = "VIEW USERS";
            this.buttonViewUsers.UseVisualStyleBackColor = false;
            // 
            // buttonViewBookingHistory
            // 
            this.buttonViewBookingHistory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonViewBookingHistory.BackColor = System.Drawing.Color.Brown;
            this.buttonViewBookingHistory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewBookingHistory.ForeColor = System.Drawing.Color.White;
            this.buttonViewBookingHistory.Location = new System.Drawing.Point(425, 315);
            this.buttonViewBookingHistory.Name = "buttonViewBookingHistory";
            this.buttonViewBookingHistory.Size = new System.Drawing.Size(354, 79);
            this.buttonViewBookingHistory.TabIndex = 1;
            this.buttonViewBookingHistory.Text = "VIEW BOOKING HISTORY";
            this.buttonViewBookingHistory.UseVisualStyleBackColor = false;
            // 
            // buttonback
            // 
            this.buttonback.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonback.BackColor = System.Drawing.Color.Brown;
            this.buttonback.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonback.ForeColor = System.Drawing.Color.White;
            this.buttonback.Location = new System.Drawing.Point(1007, 694);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(170, 52);
            this.buttonback.TabIndex = 2;
            this.buttonback.Text = "BACK";
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1189, 758);
            this.ControlBox = false;
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttonViewBookingHistory);
            this.Controls.Add(this.buttonViewUsers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonViewUsers;
        private System.Windows.Forms.Button buttonViewBookingHistory;
        private System.Windows.Forms.Button buttonback;
    }
}