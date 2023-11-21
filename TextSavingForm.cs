using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class TextSavingForm : Form
    {
        public TextSavingForm()
        {
            InitializeComponent();
            formatChoosingBox.Items.Add("default");
            formatChoosingBox.Items.Add("practical");
            formatChoosingBox.Items.Add("something unique");
            this.MinimumSize = new Size(900, 700);
            // Set an appropriate StartPosition (e.g., CenterScreen or Manual)
            this.StartPosition = FormStartPosition.CenterScreen;
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
            try
            {
                // Close the form if the user clicks "Yes"
                this.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception here, for example, show an error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (control is System.Windows.Forms.Button)
                {
                    // For buttons, display name, associated functionality, and description
                    DisplayControlInformation($"Button", control, GetButtonFunctionality(control), controlNumber);
                }
                else if (control is System.Windows.Forms.TextBox)
                {
                    // For text boxes, display name, type, and any specific information
                    DisplayControlInformation($"TextBox", control, "Accepts user input for text", controlNumber);
                }
                else if (control is System.Windows.Forms.ComboBox)
                {
                    // For comboBox, display name, type, and any specific information
                    DisplayControlInformation($"ComboBox", control, "Allows the selection of different drawing styles", controlNumber);
                }
                // Add more conditions for other types of controls as needed

                // Increment the control number for the next iteration
                controlNumber++;
            }

            MessageBox.Show("esc key will close this form, and enter key will save the text file.");
        }

        // Updated DisplayControlInformation method to handle ComboBox separately
        private void DisplayControlInformation(string controlType, Control control, string description, int controlNumber)
        {
            // Get the control's name
            string controlName = control.Name;

            // Display the information in a message box with the control type, name, description, and additional details
            MessageBox.Show($"{controlNumber}. {controlType}: {controlName} - Type: {control.GetType().Name}\nDescription: {description}",
                            "Control Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }



        // Helper method to get the functionality associated with a button
        private string GetButtonFunctionality(Control button)
        {
            // You can customize this method based on how you've implemented the functionality for each button
            switch (button.Name)
            {
                case "addDateTimeButton":
                    return "Adds the current user's name and date/time information to the description box.";

                case "quitButton":
                    return "Closes the form.";

                case "saveButton":
                    return "Saves the content (title and description) to a text file. The title is used as the filename.";

                case "editTextFileButton":
                    return "Imports text content from a selected text file. The title is set to the filename without extension.";

                case "helpButton":
                    return "Displays information about each control on the form in a message box. Pressing the 'esc' key will close this form, and the 'enter' key will save the text file.";

                case "addStartingFormat":
                    return "Generates a fancy drawing based on symbols and sets it as the content of the description box. The drawing style is chosen from the comboBox1 selection.";

                // Add more cases for other buttons as needed
                default:
                    return "Functionality not specified for this button";
            }
        }


        private void TextSavingForm_Load(object sender, EventArgs e)
        {

        }

        private void addStartingFormat_Click(object sender, EventArgs e)
        {
            // Call the method to generate a fancy drawing based on symbols
            string fancyDrawing = GenerateFancyDrawing();

            // Set the description text to the generated fancy drawing
            descriptionOfTextBox.Text = fancyDrawing;
        }

        
        // Helper method to generate a fancy drawing based on symbols
        private string GenerateFancyDrawing()
        {
            StringBuilder drawing = new StringBuilder();

            // Get the selected item from comboBox1
            string comboBoxSelection = formatChoosingBox.SelectedItem as string;

            // Add lines of symbols to create a fancy drawing based on comboBox1 choice
            switch (comboBoxSelection)
            {
                case "default":
                    drawing.AppendLine("Default drawing:");
                    drawing.AppendLine("*****************");
                    drawing.AppendLine("*               *");
                    drawing.AppendLine("*  Fancy Text   *");
                    drawing.AppendLine("*               *");
                    drawing.AppendLine("*****************");
                    break;

                case "practical":
                    drawing.AppendLine("Practical drawing:");
                    drawing.AppendLine("-----------------");
                    drawing.AppendLine("|               |");
                    drawing.AppendLine("|  User's Note  |");
                    drawing.AppendLine("|               |");
                    drawing.AppendLine("-----------------");
                    break;

                case "something unique":
                    drawing.AppendLine("Something Unique drawing:");
                    drawing.AppendLine("@@@@@@@@@@@@@@@@@@@");
                    drawing.AppendLine("@   Unique Note   @");
                    drawing.AppendLine("@@@@@@@@@@@@@@@@@@@");
                    break;

                // Add more cases for other comboBox1 items as needed

                default:
                    drawing.AppendLine("No drawing selected");
                    break;
            }
            return drawing.ToString();
        }


        private void formatChoosingBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tipLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
