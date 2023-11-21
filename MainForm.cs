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
    public partial class UltimateApp : Form
    {

        private Timer tipsTimer;
        private List<string> tipsList;
        private int currentTipIndex;

        public UltimateApp()
        {
            InitializeComponent();

            // Initialize the timer and tips list
            tipsTimer = new Timer();
            tipsTimer.Interval = 3000; // 5 seconds
            tipsTimer.Tick += TipsTimer_Tick;

            tipsList = new List<string>
            {
                "Tip 1: press start to begin.",
                "Tip 2: Here's another helpful tip.",
                

                // Add more tips as needed
            };

            currentTipIndex = 0;

            // Start the timer
            tipsTimer.Start();

            // Show the first tip when the form is loaded
            tipLabel.Text = tipsList[currentTipIndex];
        }

        private void TipsTimer_Tick(object sender, EventArgs e)
        {
            // Show the next tip and update the index
            tipLabel.Text = tipsList[currentTipIndex];
            currentTipIndex = (currentTipIndex + 1) % tipsList.Count;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startAppButton_Click(object sender, EventArgs e)
        {
            // Create an instance of TextSavingForm
            TextSavingForm textSavingForm = new TextSavingForm();
            // Show the form
            textSavingForm.Show();
        }

        private void UltimateApp_Load(object sender, EventArgs e)
        {

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
        }

        // Helper method to get the functionality associated with a button
        private string GetButtonFunctionality(Control button)
        {
            // You can customize this method based on how you've implemented the functionality for each button
            switch (button.Name)
            {
                case "startAppButton":
                    return "Starts the application and opens the TextSavingForm.";

                case "helpButton":
                    return "Displays information about the different controls on the form.";

                // Add more cases for other buttons as needed

                default:
                    return "Functionality not specified.";
            }
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

        private void tipLabel_Click(object sender, EventArgs e)
        {

        }
    }
    
    
}
