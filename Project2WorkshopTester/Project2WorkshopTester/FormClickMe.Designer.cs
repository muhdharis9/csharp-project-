namespace Project2WorkshopTester
{
    partial class FormClickMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClickMe));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdminCM = new System.Windows.Forms.Button();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.label1);
            this.panelBackground.Controls.Add(this.btnAdminCM);
            this.panelBackground.Controls.Add(this.btnClickMe);
            this.panelBackground.Controls.Add(this.pictureBoxBackground);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1207, 805);
            this.panelBackground.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(334, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME TO CAR RENTAIL BOOKING SYSTEM ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdminCM
            // 
            this.btnAdminCM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdminCM.BackColor = System.Drawing.Color.Brown;
            this.btnAdminCM.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminCM.ForeColor = System.Drawing.Color.White;
            this.btnAdminCM.Location = new System.Drawing.Point(1080, 524);
            this.btnAdminCM.Name = "btnAdminCM";
            this.btnAdminCM.Size = new System.Drawing.Size(115, 42);
            this.btnAdminCM.TabIndex = 2;
            this.btnAdminCM.Text = "ADMIN";
            this.btnAdminCM.UseVisualStyleBackColor = false;
            this.btnAdminCM.Click += new System.EventHandler(this.btnAdminCM_Click);
            // 
            // btnClickMe
            // 
            this.btnClickMe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClickMe.BackColor = System.Drawing.Color.Brown;
            this.btnClickMe.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickMe.ForeColor = System.Drawing.Color.White;
            this.btnClickMe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClickMe.Location = new System.Drawing.Point(526, 302);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(248, 63);
            this.btnClickMe.TabIndex = 1;
            this.btnClickMe.Text = "CLICK ME!";
            this.btnClickMe.UseVisualStyleBackColor = false;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackground.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.ErrorImage")));
            this.pictureBoxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.Image")));
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(1207, 805);
            this.pictureBoxBackground.TabIndex = 0;
            this.pictureBoxBackground.TabStop = false;
            this.pictureBoxBackground.Click += new System.EventHandler(this.pictureBoxBackground_Click);
            // 
            // FormClickMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1207, 805);
            this.ControlBox = false;
            this.Controls.Add(this.panelBackground);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClickMe";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClickMe";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Button btnAdminCM;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label label1;
    }
}

