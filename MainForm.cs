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
    }
}
