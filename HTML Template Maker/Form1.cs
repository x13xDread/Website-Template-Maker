using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTML_Template_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //enable all controls
            EnableControls();
            //hide progress bar
            progressBar.Visible = false;
        }
        private void generateTemplateButton_Click(object sender, EventArgs e)
        {
            //disable all controls except for the progress bar
            DisableControls();
            //show progress bar control
        }
        //disables form controls
        public void DisableControls()
        {
            //checkboxes
            stylesheetOption.Enabled = false;
            jsOption.Enabled = false;
            bootstrapOption.Enabled = false;

            //text fields
            nameInput.Enabled = false;
            pageNumInput.Enabled = false;
            projectDirectoryInput.Enabled = false;

            //submit button
            generateTemplateButton.Enabled = false;
        }
        //enables form controls
        public void EnableControls()
        {
            //checkboxes
            stylesheetOption.Enabled = true;
            jsOption.Enabled = true;
            bootstrapOption.Enabled = true;

            //text fields
            nameInput.Enabled = true;
            pageNumInput.Enabled = true;
            projectDirectoryInput.Enabled = true;

            //submit button
            generateTemplateButton.Enabled = true;
        }
        
    }
}
