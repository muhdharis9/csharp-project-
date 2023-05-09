namespace Project2WorkshopTester
{
    partial class CarRegistrationForm
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
            this.panelCarRegistration = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.tableLayoutPanelPHOTO = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxPHOTOCar = new System.Windows.Forms.PictureBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.comboBoxAvailability = new System.Windows.Forms.ComboBox();
            this.comboBoxTYPECar = new System.Windows.Forms.ComboBox();
            this.textBoxMODEL = new System.Windows.Forms.TextBox();
            this.textBoxPLATENO = new System.Windows.Forms.TextBox();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.labelPHOTO = new System.Windows.Forms.Label();
            this.labelAVAILABILITY = new System.Windows.Forms.Label();
            this.labelTYPE = new System.Windows.Forms.Label();
            this.labelMODEL = new System.Windows.Forms.Label();
            this.labelPLATENO = new System.Windows.Forms.Label();
            this.labelNAME = new System.Windows.Forms.Label();
            this.labelCarRegistration = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelCarRegistration.SuspendLayout();
            this.tableLayoutPanelPHOTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPHOTOCar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCarRegistration
            // 
            this.panelCarRegistration.Controls.Add(this.btnBack);
            this.panelCarRegistration.Controls.Add(this.btnDELETE);
            this.panelCarRegistration.Controls.Add(this.buttonADD);
            this.panelCarRegistration.Controls.Add(this.tableLayoutPanelPHOTO);
            this.panelCarRegistration.Controls.Add(this.comboBoxAvailability);
            this.panelCarRegistration.Controls.Add(this.comboBoxTYPECar);
            this.panelCarRegistration.Controls.Add(this.textBoxMODEL);
            this.panelCarRegistration.Controls.Add(this.textBoxPLATENO);
            this.panelCarRegistration.Controls.Add(this.textBoxNAME);
            this.panelCarRegistration.Controls.Add(this.labelPHOTO);
            this.panelCarRegistration.Controls.Add(this.labelAVAILABILITY);
            this.panelCarRegistration.Controls.Add(this.labelTYPE);
            this.panelCarRegistration.Controls.Add(this.labelMODEL);
            this.panelCarRegistration.Controls.Add(this.labelPLATENO);
            this.panelCarRegistration.Controls.Add(this.labelNAME);
            this.panelCarRegistration.Controls.Add(this.labelCarRegistration);
            this.panelCarRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCarRegistration.Location = new System.Drawing.Point(0, 0);
            this.panelCarRegistration.Name = "panelCarRegistration";
            this.panelCarRegistration.Size = new System.Drawing.Size(1189, 758);
            this.panelCarRegistration.TabIndex = 0;
            this.panelCarRegistration.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCarRegistration_Paint);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Brown;
            this.btnBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1037, 692);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 54);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.Color.Brown;
            this.btnDELETE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.ForeColor = System.Drawing.Color.White;
            this.btnDELETE.Location = new System.Drawing.Point(591, 529);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(182, 48);
            this.btnDELETE.TabIndex = 14;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.BackColor = System.Drawing.Color.Brown;
            this.buttonADD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADD.ForeColor = System.Drawing.Color.White;
            this.buttonADD.Location = new System.Drawing.Point(385, 529);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(183, 48);
            this.buttonADD.TabIndex = 13;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // tableLayoutPanelPHOTO
            // 
            this.tableLayoutPanelPHOTO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPHOTO.ColumnCount = 1;
            this.tableLayoutPanelPHOTO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPHOTO.Controls.Add(this.pictureBoxPHOTOCar, 0, 0);
            this.tableLayoutPanelPHOTO.Controls.Add(this.buttonUpload, 0, 1);
            this.tableLayoutPanelPHOTO.Location = new System.Drawing.Point(768, 189);
            this.tableLayoutPanelPHOTO.Name = "tableLayoutPanelPHOTO";
            this.tableLayoutPanelPHOTO.RowCount = 2;
            this.tableLayoutPanelPHOTO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPHOTO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanelPHOTO.Size = new System.Drawing.Size(329, 324);
            this.tableLayoutPanelPHOTO.TabIndex = 12;
            // 
            // pictureBoxPHOTOCar
            // 
            this.pictureBoxPHOTOCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxPHOTOCar.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPHOTOCar.Name = "pictureBoxPHOTOCar";
            this.pictureBoxPHOTOCar.Size = new System.Drawing.Size(323, 259);
            this.pictureBoxPHOTOCar.TabIndex = 0;
            this.pictureBoxPHOTOCar.TabStop = false;
            this.pictureBoxPHOTOCar.Click += new System.EventHandler(this.pictureBoxPHOTOCar_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpload.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonUpload.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.Location = new System.Drawing.Point(110, 276);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(108, 39);
            this.buttonUpload.TabIndex = 1;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // comboBoxAvailability
            // 
            this.comboBoxAvailability.FormattingEnabled = true;
            this.comboBoxAvailability.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.comboBoxAvailability.Location = new System.Drawing.Point(227, 414);
            this.comboBoxAvailability.Name = "comboBoxAvailability";
            this.comboBoxAvailability.Size = new System.Drawing.Size(95, 24);
            this.comboBoxAvailability.TabIndex = 11;
            // 
            // comboBoxTYPECar
            // 
            this.comboBoxTYPECar.FormattingEnabled = true;
            this.comboBoxTYPECar.Items.AddRange(new object[] {
            "MPV",
            "SUV",
            "SEDAN",
            "EXOTIC"});
            this.comboBoxTYPECar.Location = new System.Drawing.Point(227, 352);
            this.comboBoxTYPECar.Name = "comboBoxTYPECar";
            this.comboBoxTYPECar.Size = new System.Drawing.Size(178, 24);
            this.comboBoxTYPECar.TabIndex = 10;
            // 
            // textBoxMODEL
            // 
            this.textBoxMODEL.Location = new System.Drawing.Point(227, 305);
            this.textBoxMODEL.Name = "textBoxMODEL";
            this.textBoxMODEL.Size = new System.Drawing.Size(178, 22);
            this.textBoxMODEL.TabIndex = 9;
            this.textBoxMODEL.TextChanged += new System.EventHandler(this.textBoxMODEL_TextChanged);
            // 
            // textBoxPLATENO
            // 
            this.textBoxPLATENO.Location = new System.Drawing.Point(227, 249);
            this.textBoxPLATENO.Name = "textBoxPLATENO";
            this.textBoxPLATENO.Size = new System.Drawing.Size(122, 22);
            this.textBoxPLATENO.TabIndex = 8;
            this.textBoxPLATENO.TextChanged += new System.EventHandler(this.textBoxPLATENO_TextChanged);
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Location = new System.Drawing.Point(227, 199);
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(397, 22);
            this.textBoxNAME.TabIndex = 7;
            this.textBoxNAME.TextChanged += new System.EventHandler(this.textBoxNAME_TextChanged);
            // 
            // labelPHOTO
            // 
            this.labelPHOTO.AutoSize = true;
            this.labelPHOTO.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPHOTO.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPHOTO.Location = new System.Drawing.Point(662, 199);
            this.labelPHOTO.Name = "labelPHOTO";
            this.labelPHOTO.Size = new System.Drawing.Size(79, 19);
            this.labelPHOTO.TabIndex = 6;
            this.labelPHOTO.Text = "PHOTO :";
            // 
            // labelAVAILABILITY
            // 
            this.labelAVAILABILITY.AutoSize = true;
            this.labelAVAILABILITY.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAVAILABILITY.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelAVAILABILITY.Location = new System.Drawing.Point(80, 414);
            this.labelAVAILABILITY.Name = "labelAVAILABILITY";
            this.labelAVAILABILITY.Size = new System.Drawing.Size(130, 19);
            this.labelAVAILABILITY.TabIndex = 5;
            this.labelAVAILABILITY.Text = " AVAILABILITY :";
            // 
            // labelTYPE
            // 
            this.labelTYPE.AutoSize = true;
            this.labelTYPE.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTYPE.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTYPE.Location = new System.Drawing.Point(80, 358);
            this.labelTYPE.Name = "labelTYPE";
            this.labelTYPE.Size = new System.Drawing.Size(62, 19);
            this.labelTYPE.TabIndex = 4;
            this.labelTYPE.Text = "TYPE :";
            // 
            // labelMODEL
            // 
            this.labelMODEL.AutoSize = true;
            this.labelMODEL.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMODEL.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelMODEL.Location = new System.Drawing.Point(80, 305);
            this.labelMODEL.Name = "labelMODEL";
            this.labelMODEL.Size = new System.Drawing.Size(79, 19);
            this.labelMODEL.TabIndex = 3;
            this.labelMODEL.Text = "MODEL :";
            // 
            // labelPLATENO
            // 
            this.labelPLATENO.AutoSize = true;
            this.labelPLATENO.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPLATENO.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPLATENO.Location = new System.Drawing.Point(80, 252);
            this.labelPLATENO.Name = "labelPLATENO";
            this.labelPLATENO.Size = new System.Drawing.Size(102, 19);
            this.labelPLATENO.TabIndex = 2;
            this.labelPLATENO.Text = "PLATE NO :";
            // 
            // labelNAME
            // 
            this.labelNAME.AutoSize = true;
            this.labelNAME.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNAME.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelNAME.Location = new System.Drawing.Point(80, 199);
            this.labelNAME.Name = "labelNAME";
            this.labelNAME.Size = new System.Drawing.Size(67, 19);
            this.labelNAME.TabIndex = 1;
            this.labelNAME.Text = "NAME :";
            // 
            // labelCarRegistration
            // 
            this.labelCarRegistration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCarRegistration.AutoSize = true;
            this.labelCarRegistration.BackColor = System.Drawing.Color.Brown;
            this.labelCarRegistration.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarRegistration.ForeColor = System.Drawing.Color.White;
            this.labelCarRegistration.Location = new System.Drawing.Point(422, 73);
            this.labelCarRegistration.Name = "labelCarRegistration";
            this.labelCarRegistration.Padding = new System.Windows.Forms.Padding(20);
            this.labelCarRegistration.Size = new System.Drawing.Size(351, 75);
            this.labelCarRegistration.TabIndex = 0;
            this.labelCarRegistration.Text = "CAR REGISTRATION";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CarRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 758);
            this.ControlBox = false;
            this.Controls.Add(this.panelCarRegistration);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarRegistrationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarRegistrationForm";
            this.panelCarRegistration.ResumeLayout(false);
            this.panelCarRegistration.PerformLayout();
            this.tableLayoutPanelPHOTO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPHOTOCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCarRegistration;
        private System.Windows.Forms.ComboBox comboBoxTYPECar;
        private System.Windows.Forms.TextBox textBoxMODEL;
        private System.Windows.Forms.TextBox textBoxPLATENO;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.Label labelPHOTO;
        private System.Windows.Forms.Label labelAVAILABILITY;
        private System.Windows.Forms.Label labelTYPE;
        private System.Windows.Forms.Label labelMODEL;
        private System.Windows.Forms.Label labelPLATENO;
        private System.Windows.Forms.Label labelNAME;
        private System.Windows.Forms.Label labelCarRegistration;
        private System.Windows.Forms.ComboBox comboBoxAvailability;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPHOTO;
        private System.Windows.Forms.PictureBox pictureBoxPHOTOCar;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}