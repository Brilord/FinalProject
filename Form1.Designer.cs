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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // startAppButton
            // 
            this.startAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startAppButton.Location = new System.Drawing.Point(1083, 676);
            this.startAppButton.Name = "startAppButton";
            this.startAppButton.Size = new System.Drawing.Size(333, 78);
            this.startAppButton.TabIndex = 3;
            this.startAppButton.Text = "Start";
            this.startAppButton.UseVisualStyleBackColor = true;
            this.startAppButton.Click += new System.EventHandler(this.startAppButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(568, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UltimateApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 785);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.startAppButton);
            this.Name = "UltimateApp";
            this.Text = "Ultimate App Launcher";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startAppButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

