using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class TextSavingForm : Form
    {
        public TextSavingForm()
        {
            InitializeComponent();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void addDateTimeButton_Click(object sender, EventArgs e)
        {
            // Get the content from the title box and description box
            string title = titleOfTextBox.Text;
            string userName = Environment.UserName; // Get the current user's name
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"); // Get the current date and time

            // Create a string with the user and date information
            string userAndDate = $"Written by: {userName}\r\nDate: {currentDate}\r\n\r\n";

            // Append the user and date information to the existing description
            descriptionOfTextBox.Text = userAndDate + descriptionOfTextBox.Text;
        }

        private void descriptionOfTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleOfTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            // Close the form if the user clicks "Yes"
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Get the content from the title box and description box
            string title = titleOfTextBox.Text;
            string description = descriptionOfTextBox.Text;

            // Create a SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            saveFileDialog.Title = "Save Description File";
            saveFileDialog.DefaultExt = "txt";

            // Set the default file name based on the title
            saveFileDialog.FileName = title;

            // Show the SaveFileDialog and get the result
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Get the selected file path from the SaveFileDialog
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Write the content to the selected text file
                    System.IO.File.WriteAllText(filePath, description);

                    // Add the file path to the dataset


                    MessageBox.Show("Description saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving description: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editTextFileButton_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to allow only text files
            openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

            // Set the title of the dialog
            openFileDialog.Title = "Import Text File";

            // Show the dialog and get the result
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Get the selected file path from the OpenFileDialog
                string filePath = openFileDialog.FileName;

                try
                {
                    // Read the content from the selected text file
                    string fileContent = System.IO.File.ReadAllText(filePath);

                    // Set the title to the file name (without extension)
                    string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(filePath);
                    titleOfTextBox.Text = fileNameWithoutExtension;

                    // Set the description to the file content
                    descriptionOfTextBox.Text = fileContent;

                    MessageBox.Show("Text file imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error importing text file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
