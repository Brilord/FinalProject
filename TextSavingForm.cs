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
            this.MinimumSize = new Size(900, 700);
            // Set an appropriate StartPosition (e.g., CenterScreen or Manual)
            this.StartPosition = FormStartPosition.CenterScreen;
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

        private void helpButton_Click(object sender, EventArgs e)
        {
            // Initialize a counter variable
            int controlNumber = 1;

            // Iterate through all controls on the form
            foreach (Control control in Controls)
            {
                // Display information based on the type of control
                if (control is Button)
                {
                    // For buttons, display name, associated functionality, and description
                    DisplayControlInformation($"Button {controlNumber}", control, GetButtonFunctionality(control));
                }
                else if (control is TextBox)
                {
                    // For text boxes, display name, type, and any specific information
                    DisplayControlInformation($"TextBox {controlNumber}", control, "Accepts user input for text");
                }
                // Add more conditions for other types of controls as needed

                // Increment the control number for the next iteration
                controlNumber++;
            }
        }

        // Helper method to display information about a control in a message box
        private void DisplayControlInformation(string controlType, Control control, string description)
        {
            // Get the control's name
            string controlName = control.Name;

            // Display the information in a message box with the control type, name, description, and additional details
            MessageBox.Show($"{controlType}: {controlName} - Type: {control.GetType().Name}\nDescription: {description}",
                            "Control Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        // Helper method to get the functionality associated with a button
        // Helper method to get the functionality associated with a button
        private string GetButtonFunctionality(Control button)
        {
            // You can customize this method based on how you've implemented the functionality for each button
            switch (button.Name)
            {
                case "addDateTimeButton":
                    return "Adds current user and date information to the description";

                case "quitButton":
                    return "Closes the form";

                case "saveButton":
                    return "Saves the content (title and description) to a text file";

                case "editTextFileButton":
                    return "Imports text content from a selected text file";

                case "helpButton":
                    return "Displays information about each control on the form";

                // Add more cases for other buttons as needed

                default:
                    return "Functionality not specified for this button";
            }
        }


    }
}
