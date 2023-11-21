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
            this.SuspendLayout();
            // 
            // titleOfTextBox
            // 
            this.titleOfTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.titleOfTextBox.Location = new System.Drawing.Point(31, 47);
            this.titleOfTextBox.Name = "titleOfTextBox";
            this.titleOfTextBox.Size = new System.Drawing.Size(747, 35);
            this.titleOfTextBox.TabIndex = 0;
            this.titleOfTextBox.TextChanged += new System.EventHandler(this.titleOfTextBox_TextChanged);
            // 
            // descriptionOfTextBox
            // 
            this.descriptionOfTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.descriptionOfTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.descriptionOfTextBox.Location = new System.Drawing.Point(31, 129);
            this.descriptionOfTextBox.Multiline = true;
            this.descriptionOfTextBox.Name = "descriptionOfTextBox";
            this.descriptionOfTextBox.Size = new System.Drawing.Size(747, 573);
            this.descriptionOfTextBox.TabIndex = 1;
            this.descriptionOfTextBox.TextChanged += new System.EventHandler(this.descriptionOfTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "title of text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "description of text";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.Lime;
            this.saveButton.Location = new System.Drawing.Point(1011, 646);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(192, 76);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addDateTimeButton
            // 
            this.addDateTimeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addDateTimeButton.Location = new System.Drawing.Point(1011, 561);
            this.addDateTimeButton.Name = "addDateTimeButton";
            this.addDateTimeButton.Size = new System.Drawing.Size(196, 70);
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
            this.quitButton.Location = new System.Drawing.Point(1011, 485);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(196, 70);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // editTextFileButton
            // 
            this.editTextFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editTextFileButton.Location = new System.Drawing.Point(1007, 413);
            this.editTextFileButton.Name = "editTextFileButton";
            this.editTextFileButton.Size = new System.Drawing.Size(196, 66);
            this.editTextFileButton.TabIndex = 7;
            this.editTextFileButton.Text = "Edit Text File";
            this.editTextFileButton.UseVisualStyleBackColor = true;
            this.editTextFileButton.Click += new System.EventHandler(this.editTextFileButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.helpButton.Location = new System.Drawing.Point(1007, 17);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(196, 53);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // addStartingFormat
            // 
            this.addStartingFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addStartingFormat.Location = new System.Drawing.Point(1011, 289);
            this.addStartingFormat.Name = "addStartingFormat";
            this.addStartingFormat.Size = new System.Drawing.Size(196, 118);
            this.addStartingFormat.TabIndex = 9;
            this.addStartingFormat.Text = "Add Fancy Text Format";
            this.addStartingFormat.UseVisualStyleBackColor = true;
            this.addStartingFormat.Click += new System.EventHandler(this.addStartingFormat_Click);
            // 
            // formatChoosingBox
            // 
            this.formatChoosingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formatChoosingBox.FormattingEnabled = true;
            this.formatChoosingBox.Location = new System.Drawing.Point(1011, 76);
            this.formatChoosingBox.Name = "formatChoosingBox";
            this.formatChoosingBox.Size = new System.Drawing.Size(192, 32);
            this.formatChoosingBox.TabIndex = 10;
            this.formatChoosingBox.SelectedIndexChanged += new System.EventHandler(this.formatChoosingBox_SelectedIndexChanged);
            // 
            // TextSavingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.quitButton;
            this.ClientSize = new System.Drawing.Size(1215, 734);
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
    }
}