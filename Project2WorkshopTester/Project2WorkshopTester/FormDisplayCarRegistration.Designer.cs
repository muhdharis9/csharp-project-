namespace Project2WorkshopTester
{
    partial class FormDisplayCarRegistration
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
            this.panelformCarDisplay = new System.Windows.Forms.Panel();
            this.labelCarSuccessful = new System.Windows.Forms.Label();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.panelformCarDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelformCarDisplay
            // 
            this.panelformCarDisplay.Controls.Add(this.btnReturnMenu);
            this.panelformCarDisplay.Controls.Add(this.labelCarSuccessful);
            this.panelformCarDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelformCarDisplay.Location = new System.Drawing.Point(0, 0);
            this.panelformCarDisplay.Name = "panelformCarDisplay";
            this.panelformCarDisplay.Size = new System.Drawing.Size(1189, 758);
            this.panelformCarDisplay.TabIndex = 0;
            // 
            // labelCarSuccessful
            // 
            this.labelCarSuccessful.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCarSuccessful.AutoSize = true;
            this.labelCarSuccessful.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarSuccessful.Location = new System.Drawing.Point(328, 285);
            this.labelCarSuccessful.Name = "labelCarSuccessful";
            this.labelCarSuccessful.Size = new System.Drawing.Size(541, 35);
            this.labelCarSuccessful.TabIndex = 0;
            this.labelCarSuccessful.Text = "CAR SUCCESFULLY REGISTERED .. ";
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnMenu.BackColor = System.Drawing.Color.Brown;
            this.btnReturnMenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMenu.ForeColor = System.Drawing.Color.White;
            this.btnReturnMenu.Location = new System.Drawing.Point(963, 669);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(195, 57);
            this.btnReturnMenu.TabIndex = 1;
            this.btnReturnMenu.Text = "Return to menu";
            this.btnReturnMenu.UseVisualStyleBackColor = false;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // FormDisplayCarRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 758);
            this.ControlBox = false;
            this.Controls.Add(this.panelformCarDisplay);
            this.Name = "FormDisplayCarRegistration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDisplayCarRegistration";
            this.panelformCarDisplay.ResumeLayout(false);
            this.panelformCarDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelformCarDisplay;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Label labelCarSuccessful;
    }
}