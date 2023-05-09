namespace Project2WorkshopTester
{
    partial class FormDisplayAdminRegistration
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
            this.panelDisplayAdminRegister = new System.Windows.Forms.Panel();
            this.labeldisplayadmin = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.panelDisplayAdminRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDisplayAdminRegister
            // 
            this.panelDisplayAdminRegister.Controls.Add(this.buttonContinue);
            this.panelDisplayAdminRegister.Controls.Add(this.labeldisplayadmin);
            this.panelDisplayAdminRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplayAdminRegister.Location = new System.Drawing.Point(0, 0);
            this.panelDisplayAdminRegister.Name = "panelDisplayAdminRegister";
            this.panelDisplayAdminRegister.Size = new System.Drawing.Size(1189, 758);
            this.panelDisplayAdminRegister.TabIndex = 0;
            // 
            // labeldisplayadmin
            // 
            this.labeldisplayadmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeldisplayadmin.AutoSize = true;
            this.labeldisplayadmin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldisplayadmin.Location = new System.Drawing.Point(338, 275);
            this.labeldisplayadmin.Name = "labeldisplayadmin";
            this.labeldisplayadmin.Size = new System.Drawing.Size(520, 35);
            this.labeldisplayadmin.TabIndex = 0;
            this.labeldisplayadmin.Text = "Your account has been registered ..";
            // 
            // buttonContinue
            // 
            this.buttonContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonContinue.BackColor = System.Drawing.Color.Brown;
            this.buttonContinue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.Color.White;
            this.buttonContinue.Location = new System.Drawing.Point(1020, 698);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(157, 48);
            this.buttonContinue.TabIndex = 1;
            this.buttonContinue.Text = "CONTINUE";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // FormDisplayAdminRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1189, 758);
            this.ControlBox = false;
            this.Controls.Add(this.panelDisplayAdminRegister);
            this.Name = "FormDisplayAdminRegistration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDisplayAdminRegistration";
            this.panelDisplayAdminRegister.ResumeLayout(false);
            this.panelDisplayAdminRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDisplayAdminRegister;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label labeldisplayadmin;
    }
}