namespace Project2WorkshopTester
{
    partial class MenuForm
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
            this.panelMENU = new System.Windows.Forms.Panel();
            this.buttonBACK = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonCreateBooking = new System.Windows.Forms.Button();
            this.buttonCustomerUpdate = new System.Windows.Forms.Button();
            this.buttonCarRegistration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMENU
            // 
            this.panelMENU.Controls.Add(this.buttonBACK);
            this.panelMENU.Controls.Add(this.buttonView);
            this.panelMENU.Controls.Add(this.buttonCreateBooking);
            this.panelMENU.Controls.Add(this.buttonCustomerUpdate);
            this.panelMENU.Controls.Add(this.buttonCarRegistration);
            this.panelMENU.Controls.Add(this.label1);
            this.panelMENU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMENU.Location = new System.Drawing.Point(0, 0);
            this.panelMENU.Name = "panelMENU";
            this.panelMENU.Size = new System.Drawing.Size(1189, 758);
            this.panelMENU.TabIndex = 0;
            // 
            // buttonBACK
            // 
            this.buttonBACK.BackColor = System.Drawing.Color.Brown;
            this.buttonBACK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBACK.ForeColor = System.Drawing.Color.White;
            this.buttonBACK.Location = new System.Drawing.Point(1024, 684);
            this.buttonBACK.Name = "buttonBACK";
            this.buttonBACK.Size = new System.Drawing.Size(139, 51);
            this.buttonBACK.TabIndex = 5;
            this.buttonBACK.Text = "BACK";
            this.buttonBACK.UseVisualStyleBackColor = false;
            this.buttonBACK.Click += new System.EventHandler(this.buttonBACK_Click);
            // 
            // buttonView
            // 
            this.buttonView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonView.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.Location = new System.Drawing.Point(431, 440);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(311, 69);
            this.buttonView.TabIndex = 4;
            this.buttonView.Text = "VIEW";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonCreateBooking
            // 
            this.buttonCreateBooking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCreateBooking.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateBooking.Location = new System.Drawing.Point(431, 343);
            this.buttonCreateBooking.Name = "buttonCreateBooking";
            this.buttonCreateBooking.Size = new System.Drawing.Size(311, 69);
            this.buttonCreateBooking.TabIndex = 3;
            this.buttonCreateBooking.Text = "CREATE BOOKING";
            this.buttonCreateBooking.UseVisualStyleBackColor = true;
            this.buttonCreateBooking.Click += new System.EventHandler(this.buttonCreateBooking_Click);
            // 
            // buttonCustomerUpdate
            // 
            this.buttonCustomerUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCustomerUpdate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomerUpdate.Location = new System.Drawing.Point(431, 252);
            this.buttonCustomerUpdate.Name = "buttonCustomerUpdate";
            this.buttonCustomerUpdate.Size = new System.Drawing.Size(311, 69);
            this.buttonCustomerUpdate.TabIndex = 2;
            this.buttonCustomerUpdate.Text = "CUSTOMER UPDATE";
            this.buttonCustomerUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonCarRegistration
            // 
            this.buttonCarRegistration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCarRegistration.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCarRegistration.Location = new System.Drawing.Point(431, 161);
            this.buttonCarRegistration.Name = "buttonCarRegistration";
            this.buttonCarRegistration.Size = new System.Drawing.Size(311, 69);
            this.buttonCarRegistration.TabIndex = 1;
            this.buttonCarRegistration.Text = "CAR REGISTRATION";
            this.buttonCarRegistration.UseVisualStyleBackColor = true;
            this.buttonCarRegistration.Click += new System.EventHandler(this.buttonCarRegistration_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(533, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1189, 758);
            this.ControlBox = false;
            this.Controls.Add(this.panelMENU);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panelMENU.ResumeLayout(false);
            this.panelMENU.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMENU;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonCreateBooking;
        private System.Windows.Forms.Button buttonCustomerUpdate;
        private System.Windows.Forms.Button buttonCarRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBACK;
    }
}