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
            if(!ReadForm())
            {
                //reset all data
                ResetForm();
                //enable all controls
                EnableControls();
                //hide progress bar
                progressBar.Visible = false;
            }
            else
            {
                GenerateTemplate();
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
        public bool ReadForm()
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
        //reset all form values
        public void ResetForm()
        {
            //global variable reset
            jsOptionSelected = false;
            stylesheetOptionSelected = false;
            bootstrapOptionSelected = false;
            numPages = 0;
            path = "";
            projectName = "";
        }
        //build template
        public void GenerateTemplate()
        {
            string stylesheetText = "";
            string jsText = "";
            string bootstrapText = "";
            //create project directory
            //use this for tests D:\Programming
            DirectoryInfo di = Directory.CreateDirectory(path);
            //create index.html
            //check options
            if (stylesheetOptionSelected)
                stylesheetText = "<link rel=\"stylesheet\" href=\"styles/mystyle.css\">";
            if (jsOptionSelected)
                jsText = "<script src=\"/scripts/myScript.js\"></script>";
            if (bootstrapOptionSelected)
                bootstrapText = "<link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We\" crossorigin=\"anonymous\">\n<script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj\" crossorigin=\"anonymous\"></script>";
            string bodyText = GenerateBodyText();
            string headerText = "";
            string indexText = $"<!DOCTYPE html>\n<html>\n<head>\n{stylesheetText}\n{bootstrapText}\n</head>\n<body>\n{bodyText}\n{jsText}\n</body>\n</html>";
            GeneratePage(indexText, path + "\\index.html");
            //if styles added create stylesheet

            //if js added create js
        }
        public void GeneratePage(string fileContent, string filePath)
        {
            using (FileStream fs = File.Create(filePath))
            {

                byte[] info = new UTF8Encoding(true).GetBytes(fileContent);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        public string GenerateBodyText()
        {
            string bodyText = $"\n<h1>{projectName}</h1>\n";

            return bodyText;
        }

    }
}
