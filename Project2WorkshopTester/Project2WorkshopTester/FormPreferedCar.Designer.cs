namespace Project2WorkshopTester
{
    partial class FormPreferedCar
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
            this.panelPreferedCar = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelPreferedType = new System.Windows.Forms.Label();
            this.btnExotic = new System.Windows.Forms.Button();
            this.btnMPV = new System.Windows.Forms.Button();
            this.btnSedan = new System.Windows.Forms.Button();
            this.btnCompact = new System.Windows.Forms.Button();
            this.panelPreferedCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPreferedCar
            // 
            this.panelPreferedCar.Controls.Add(this.btnBack);
            this.panelPreferedCar.Controls.Add(this.labelPreferedType);
            this.panelPreferedCar.Controls.Add(this.btnExotic);
            this.panelPreferedCar.Controls.Add(this.btnMPV);
            this.panelPreferedCar.Controls.Add(this.btnSedan);
            this.panelPreferedCar.Controls.Add(this.btnCompact);
            this.panelPreferedCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPreferedCar.Location = new System.Drawing.Point(0, 0);
            this.panelPreferedCar.Name = "panelPreferedCar";
            this.panelPreferedCar.Size = new System.Drawing.Size(1189, 758);
            this.panelPreferedCar.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Brown;
            this.btnBack.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(997, 691);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 55);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Return to home";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelPreferedType
            // 
            this.labelPreferedType.AutoSize = true;
            this.labelPreferedType.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreferedType.Location = new System.Drawing.Point(363, 147);
            this.labelPreferedType.Name = "labelPreferedType";
            this.labelPreferedType.Size = new System.Drawing.Size(470, 27);
            this.labelPreferedType.TabIndex = 4;
            this.labelPreferedType.Text = "PLEASE SELECT YOUR PREFERED TYPE";
            this.labelPreferedType.Click += new System.EventHandler(this.labelPreferedType_Click);
            // 
            // btnExotic
            // 
            this.btnExotic.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExotic.Location = new System.Drawing.Point(486, 510);
            this.btnExotic.Name = "btnExotic";
            this.btnExotic.Size = new System.Drawing.Size(203, 80);
            this.btnExotic.TabIndex = 3;
            this.btnExotic.Text = "EXOTIC";
            this.btnExotic.UseVisualStyleBackColor = true;
            // 
            // btnMPV
            // 
            this.btnMPV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMPV.Location = new System.Drawing.Point(867, 324);
            this.btnMPV.Name = "btnMPV";
            this.btnMPV.Size = new System.Drawing.Size(203, 80);
            this.btnMPV.TabIndex = 2;
            this.btnMPV.Text = "MPV";
            this.btnMPV.UseVisualStyleBackColor = true;
            // 
            // btnSedan
            // 
            this.btnSedan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSedan.Location = new System.Drawing.Point(487, 324);
            this.btnSedan.Name = "btnSedan";
            this.btnSedan.Size = new System.Drawing.Size(203, 80);
            this.btnSedan.TabIndex = 1;
            this.btnSedan.Text = "SEDAN";
            this.btnSedan.UseVisualStyleBackColor = true;
            // 
            // btnCompact
            // 
            this.btnCompact.Location = new System.Drawing.Point(115, 324);
            this.btnCompact.Name = "btnCompact";
            this.btnCompact.Size = new System.Drawing.Size(203, 80);
            this.btnCompact.TabIndex = 0;
            this.btnCompact.Text = "COMPACT";
            this.btnCompact.UseVisualStyleBackColor = true;
            // 
            // FormPreferedCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1189, 758);
            this.ControlBox = false;
            this.Controls.Add(this.panelPreferedCar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPreferedCar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPreferedCar";
            this.panelPreferedCar.ResumeLayout(false);
            this.panelPreferedCar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPreferedCar;
        private System.Windows.Forms.Label labelPreferedType;
        private System.Windows.Forms.Button btnExotic;
        private System.Windows.Forms.Button btnMPV;
        private System.Windows.Forms.Button btnSedan;
        private System.Windows.Forms.Button btnCompact;
        private System.Windows.Forms.Button btnBack;
    }
}