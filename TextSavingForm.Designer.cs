namespace FinalProject
{
    partial class TextSavingForm
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
            this.titleOfTextBox = new System.Windows.Forms.TextBox();
            this.descriptionOfTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.addDateTimeButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.editTextFileButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.addStartingFormat = new System.Windows.Forms.Button();
            this.formatChoosingBox = new System.Windows.Forms.ComboBox();
            this.tipLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleOfTextBox
            // 
            this.titleOfTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.titleOfTextBox.Location = new System.Drawing.Point(19, 31);
            this.titleOfTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleOfTextBox.Name = "titleOfTextBox";
            this.titleOfTextBox.Size = new System.Drawing.Size(461, 22);
            this.titleOfTextBox.TabIndex = 0;
            this.titleOfTextBox.TextChanged += new System.EventHandler(this.titleOfTextBox_TextChanged);
            // 
            // descriptionOfTextBox
            // 
            this.descriptionOfTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.descriptionOfTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.descriptionOfTextBox.Location = new System.Drawing.Point(19, 86);
            this.descriptionOfTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionOfTextBox.Multiline = true;
            this.descriptionOfTextBox.Name = "descriptionOfTextBox";
            this.descriptionOfTextBox.Size = new System.Drawing.Size(461, 383);
            this.descriptionOfTextBox.TabIndex = 1;
            this.descriptionOfTextBox.TextChanged += new System.EventHandler(this.descriptionOfTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "title of text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "description of text";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.Lime;
            this.saveButton.Location = new System.Drawing.Point(622, 431);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 51);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addDateTimeButton
            // 
            this.addDateTimeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addDateTimeButton.Location = new System.Drawing.Point(622, 374);
            this.addDateTimeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addDateTimeButton.Name = "addDateTimeButton";
            this.addDateTimeButton.Size = new System.Drawing.Size(121, 47);
            this.addDateTimeButton.TabIndex = 5;
            this.addDateTimeButton.Text = "Add date time username";
            this.addDateTimeButton.UseVisualStyleBackColor = true;
            this.addDateTimeButton.Click += new System.EventHandler(this.addDateTimeButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitButton.BackColor = System.Drawing.Color.Red;
            this.quitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quitButton.Location = new System.Drawing.Point(622, 323);
            this.quitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(121, 47);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // editTextFileButton
            // 
            this.editTextFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editTextFileButton.Location = new System.Drawing.Point(620, 275);
            this.editTextFileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editTextFileButton.Name = "editTextFileButton";
            this.editTextFileButton.Size = new System.Drawing.Size(121, 44);
            this.editTextFileButton.TabIndex = 7;
            this.editTextFileButton.Text = "Edit Text File";
            this.editTextFileButton.UseVisualStyleBackColor = true;
            this.editTextFileButton.Click += new System.EventHandler(this.editTextFileButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.helpButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.helpButton.Location = new System.Drawing.Point(620, 11);
            this.helpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(121, 35);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // addStartingFormat
            // 
            this.addStartingFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addStartingFormat.BackColor = System.Drawing.Color.Yellow;
            this.addStartingFormat.Location = new System.Drawing.Point(622, 193);
            this.addStartingFormat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addStartingFormat.Name = "addStartingFormat";
            this.addStartingFormat.Size = new System.Drawing.Size(121, 79);
            this.addStartingFormat.TabIndex = 9;
            this.addStartingFormat.Text = "Add Fancy Text Format";
            this.addStartingFormat.UseVisualStyleBackColor = false;
            this.addStartingFormat.Click += new System.EventHandler(this.addStartingFormat_Click);
            // 
            // formatChoosingBox
            // 
            this.formatChoosingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formatChoosingBox.FormattingEnabled = true;
            this.formatChoosingBox.Location = new System.Drawing.Point(622, 51);
            this.formatChoosingBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formatChoosingBox.Name = "formatChoosingBox";
            this.formatChoosingBox.Size = new System.Drawing.Size(120, 24);
            this.formatChoosingBox.TabIndex = 10;
            this.formatChoosingBox.SelectedIndexChanged += new System.EventHandler(this.formatChoosingBox_SelectedIndexChanged);
            // 
            // tipLabel
            // 
            this.tipLabel.AllowDrop = true;
            this.tipLabel.AutoSize = true;
            this.tipLabel.Location = new System.Drawing.Point(114, 6);
            this.tipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(0, 16);
            this.tipLabel.TabIndex = 11;
            this.tipLabel.Click += new System.EventHandler(this.tipLabel_Click);
            // 
            // TextSavingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.quitButton;
            this.ClientSize = new System.Drawing.Size(748, 489);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.formatChoosingBox);
            this.Controls.Add(this.addStartingFormat);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.editTextFileButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.addDateTimeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionOfTextBox);
            this.Controls.Add(this.titleOfTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TextSavingForm";
            this.Text = "TextSaveApp";
            this.Load += new System.EventHandler(this.TextSavingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleOfTextBox;
        private System.Windows.Forms.TextBox descriptionOfTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addDateTimeButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button editTextFileButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button addStartingFormat;
        private System.Windows.Forms.ComboBox formatChoosingBox;
        private System.Windows.Forms.Label tipLabel;
    }
}