namespace Project2WorkshopTester
{
    partial class AdminRegistrationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonBACK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maskedTextBoxPASSWORD = new System.Windows.Forms.MaskedTextBox();
            this.textBoxUSERNAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPHONENO = new System.Windows.Forms.TextBox();
            this.textBoxEMAIL = new System.Windows.Forms.TextBox();
            this.textBoxADRESS = new System.Windows.Forms.TextBox();
            this.textBoxICNO = new System.Windows.Forms.TextBox();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.labelPHONENO = new System.Windows.Forms.Label();
            this.labelEMAIL = new System.Windows.Forms.Label();
            this.labelADRESS = new System.Windows.Forms.Label();
            this.labelICNO = new System.Windows.Forms.Label();
            this.labelNAME = new System.Windows.Forms.Label();
            this.labelAdminRegistration = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonADD);
            this.panel1.Controls.Add(this.buttonBACK);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxPHONENO);
            this.panel1.Controls.Add(this.textBoxEMAIL);
            this.panel1.Controls.Add(this.textBoxADRESS);
            this.panel1.Controls.Add(this.textBoxICNO);
            this.panel1.Controls.Add(this.textBoxNAME);
            this.panel1.Controls.Add(this.labelPHONENO);
            this.panel1.Controls.Add(this.labelEMAIL);
            this.panel1.Controls.Add(this.labelADRESS);
            this.panel1.Controls.Add(this.labelICNO);
            this.panel1.Controls.Add(this.labelNAME);
            this.panel1.Controls.Add(this.labelAdminRegistration);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 758);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonADD
            // 
            this.buttonADD.BackColor = System.Drawing.Color.Brown;
            this.buttonADD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADD.ForeColor = System.Drawing.Color.White;
            this.buttonADD.Location = new System.Drawing.Point(1045, 690);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(132, 45);
            this.buttonADD.TabIndex = 13;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonBACK
            // 
            this.buttonBACK.BackColor = System.Drawing.Color.Brown;
            this.buttonBACK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBACK.ForeColor = System.Drawing.Color.White;
            this.buttonBACK.Location = new System.Drawing.Point(907, 690);
            this.buttonBACK.Name = "buttonBACK";
            this.buttonBACK.Size = new System.Drawing.Size(132, 45);
            this.buttonBACK.TabIndex = 12;
            this.buttonBACK.Text = "BACK";
            this.buttonBACK.UseVisualStyleBackColor = false;
            this.buttonBACK.Click += new System.EventHandler(this.buttonBACK_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.maskedTextBoxPASSWORD);
            this.panel2.Controls.Add(this.textBoxUSERNAME);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(184, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 177);
            this.panel2.TabIndex = 11;
            // 
            // maskedTextBoxPASSWORD
            // 
            this.maskedTextBoxPASSWORD.Location = new System.Drawing.Point(323, 102);
            this.maskedTextBoxPASSWORD.Name = "maskedTextBoxPASSWORD";
            this.maskedTextBoxPASSWORD.Size = new System.Drawing.Size(237, 22);
            this.maskedTextBoxPASSWORD.TabIndex = 6;
            this.maskedTextBoxPASSWORD.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxPASSWORD_MaskInputRejected);
            // 
            // textBoxUSERNAME
            // 
            this.textBoxUSERNAME.Location = new System.Drawing.Point(323, 49);
            this.textBoxUSERNAME.Name = "textBoxUSERNAME";
            this.textBoxUSERNAME.Size = new System.Drawing.Size(237, 22);
            this.textBoxUSERNAME.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(189, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(189, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "USERNAME ";
            // 
            // textBoxPHONENO
            // 
            this.textBoxPHONENO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPHONENO.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPHONENO.Location = new System.Drawing.Point(377, 438);
            this.textBoxPHONENO.Name = "textBoxPHONENO";
            this.textBoxPHONENO.Size = new System.Drawing.Size(505, 22);
            this.textBoxPHONENO.TabIndex = 10;
            // 
            // textBoxEMAIL
            // 
            this.textBoxEMAIL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxEMAIL.BackColor = System.Drawing.Color.LightGray;
            this.textBoxEMAIL.Location = new System.Drawing.Point(377, 388);
            this.textBoxEMAIL.Name = "textBoxEMAIL";
            this.textBoxEMAIL.Size = new System.Drawing.Size(505, 22);
            this.textBoxEMAIL.TabIndex = 9;
            // 
            // textBoxADRESS
            // 
            this.textBoxADRESS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxADRESS.BackColor = System.Drawing.Color.LightGray;
            this.textBoxADRESS.Location = new System.Drawing.Point(377, 284);
            this.textBoxADRESS.Multiline = true;
            this.textBoxADRESS.Name = "textBoxADRESS";
            this.textBoxADRESS.Size = new System.Drawing.Size(505, 74);
            this.textBoxADRESS.TabIndex = 8;
            // 
            // textBoxICNO
            // 
            this.textBoxICNO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxICNO.BackColor = System.Drawing.Color.LightGray;
            this.textBoxICNO.Location = new System.Drawing.Point(377, 235);
            this.textBoxICNO.Name = "textBoxICNO";
            this.textBoxICNO.Size = new System.Drawing.Size(505, 22);
            this.textBoxICNO.TabIndex = 7;
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNAME.BackColor = System.Drawing.Color.LightGray;
            this.textBoxNAME.Location = new System.Drawing.Point(377, 182);
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(505, 22);
            this.textBoxNAME.TabIndex = 6;
            // 
            // labelPHONENO
            // 
            this.labelPHONENO.AutoSize = true;
            this.labelPHONENO.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPHONENO.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPHONENO.Location = new System.Drawing.Point(205, 439);
            this.labelPHONENO.Name = "labelPHONENO";
            this.labelPHONENO.Size = new System.Drawing.Size(109, 19);
            this.labelPHONENO.TabIndex = 5;
            this.labelPHONENO.Text = "PHONE NO :";
            // 
            // labelEMAIL
            // 
            this.labelEMAIL.AutoSize = true;
            this.labelEMAIL.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEMAIL.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEMAIL.Location = new System.Drawing.Point(205, 388);
            this.labelEMAIL.Name = "labelEMAIL";
            this.labelEMAIL.Size = new System.Drawing.Size(69, 19);
            this.labelEMAIL.TabIndex = 4;
            this.labelEMAIL.Text = "EMAIL :";
            // 
            // labelADRESS
            // 
            this.labelADRESS.AutoSize = true;
            this.labelADRESS.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelADRESS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelADRESS.Location = new System.Drawing.Point(205, 287);
            this.labelADRESS.Name = "labelADRESS";
            this.labelADRESS.Size = new System.Drawing.Size(105, 19);
            this.labelADRESS.TabIndex = 3;
            this.labelADRESS.Text = "ADDRESS : ";
            // 
            // labelICNO
            // 
            this.labelICNO.AutoSize = true;
            this.labelICNO.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelICNO.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelICNO.Location = new System.Drawing.Point(205, 236);
            this.labelICNO.Name = "labelICNO";
            this.labelICNO.Size = new System.Drawing.Size(61, 19);
            this.labelICNO.TabIndex = 2;
            this.labelICNO.Text = "ICNO :";
            // 
            // labelNAME
            // 
            this.labelNAME.AutoSize = true;
            this.labelNAME.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNAME.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelNAME.Location = new System.Drawing.Point(205, 183);
            this.labelNAME.Name = "labelNAME";
            this.labelNAME.Size = new System.Drawing.Size(72, 19);
            this.labelNAME.TabIndex = 1;
            this.labelNAME.Text = "NAME : ";
            // 
            // labelAdminRegistration
            // 
            this.labelAdminRegistration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAdminRegistration.AutoSize = true;
            this.labelAdminRegistration.BackColor = System.Drawing.Color.Brown;
            this.labelAdminRegistration.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminRegistration.ForeColor = System.Drawing.Color.White;
            this.labelAdminRegistration.Location = new System.Drawing.Point(433, 64);
            this.labelAdminRegistration.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.labelAdminRegistration.Name = "labelAdminRegistration";
            this.labelAdminRegistration.Padding = new System.Windows.Forms.Padding(20);
            this.labelAdminRegistration.Size = new System.Drawing.Size(429, 78);
            this.labelAdminRegistration.TabIndex = 0;
            this.labelAdminRegistration.Text = "ADMIN REGISTRATION ";
            this.labelAdminRegistration.Click += new System.EventHandler(this.labelAdminRegistration_Click);
            // 
            // AdminRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 758);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminRegistrationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminRegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAdminRegistration;
        private System.Windows.Forms.TextBox textBoxPHONENO;
        private System.Windows.Forms.TextBox textBoxEMAIL;
        private System.Windows.Forms.TextBox textBoxADRESS;
        private System.Windows.Forms.TextBox textBoxICNO;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.Label labelPHONENO;
        private System.Windows.Forms.Label labelEMAIL;
        private System.Windows.Forms.Label labelADRESS;
        private System.Windows.Forms.Label labelICNO;
        private System.Windows.Forms.Label labelNAME;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPASSWORD;
        private System.Windows.Forms.TextBox textBoxUSERNAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonBACK;
    }
}