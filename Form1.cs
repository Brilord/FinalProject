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
        public UltimateApp()
        {
            InitializeComponent();
            // Add items to the ComboBox
            comboBox1.Items.Add("Option 1");
            comboBox1.Items.Add("Option 2");
            comboBox1.Items.Add("Option 3");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Handle the dropdown change event here
            string selectedItem = comboBox1.SelectedItem.ToString();
            MessageBox.Show("Selected item: " + selectedItem);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of TextSavingForm
            TextSavingForm textSavingForm = new TextSavingForm();

            // Show the form
            textSavingForm.Show();
        }

    }
}
