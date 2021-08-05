using System;
using System.IO;
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
        //global form data
        bool jsOptionSelected = false;
        bool stylesheetOptionSelected = false;
        bool bootstrapOptionSelected = false;
        int numPages = 0;
        string path = "";
        string projectName = "";
        //other global data
        string errorMsg = "";

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
            progressBar.Visible = true;
            //get form data
            if(!readForm())
            {
                //display error

                //reset all data
            }
            else
            {
                progressBar.Value = 10;
            }
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
        //read data from form
        public bool readForm()
        {            
            jsOptionSelected = jsOption.Checked;
            stylesheetOptionSelected = stylesheetOption.Checked;
            bootstrapOptionSelected = bootstrapOption.Checked;
            //validate data            
            if(!Int32.TryParse(pageNumInput.Text, out numPages) || (numPages < 0 || numPages > 10))
            {
                errorMsg = "Invalid Number of Pages!";
                errorProvider.SetError(pageNumInput, errorMsg);
                return false;
            }
            //check if the initial directory already exists            
            if(!Directory.Exists(projectDirectoryInput.Text))
            {
                errorMsg = "Initial Directory Does Not Exist!";
                errorProvider.SetError(projectDirectoryInput, errorMsg);
                return false;
            }
            else
            {
                string tempPath = projectDirectoryInput.Text;
                if (Directory.Exists(tempPath + "\\" + nameInput.Text))
                {
                    errorMsg = "Project Directory Already Exists!";
                    errorProvider.SetError(nameInput, errorMsg);
                    return false;
                }
                else
                {
                    path = tempPath + "\\" + nameInput.Text;
                    projectName = nameInput.Text;
                }
            }
            return true;
            
        }
        
    }
}
