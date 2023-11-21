namespace FinalProject
{
    partial class UltimateApp
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
            this.startAppButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.tipLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startAppButton
            // 
            this.startAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startAppButton.Location = new System.Drawing.Point(940, 626);
            this.startAppButton.Name = "startAppButton";
            this.startAppButton.Size = new System.Drawing.Size(476, 128);
            this.startAppButton.TabIndex = 3;
            this.startAppButton.Text = "Start";
            this.startAppButton.UseVisualStyleBackColor = true;
            this.startAppButton.Click += new System.EventHandler(this.startAppButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.Location = new System.Drawing.Point(1221, 13);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(221, 74);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Location = new System.Drawing.Point(23, 13);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(52, 24);
            this.tipLabel.TabIndex = 6;
            this.tipLabel.Text = "Tips";
            this.tipLabel.Click += new System.EventHandler(this.tipLabel_Click);
            // 
            // UltimateApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 785);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.startAppButton);
            this.Name = "UltimateApp";
            this.Text = "Ultimate App Launcher";
            this.Load += new System.EventHandler(this.UltimateApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startAppButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label tipLabel;
    }
}

