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
        bool customTextSelected = false;
        bool customBodySelected = false;
        int numPages = 0;
        string path = "";
        string projectName = "";
        //other global data
        string errorMsg = "";

        #region Controls Events
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
            progressBar.Value = 0;
            progressBar.Visible = true;
            //get form data
            if(!ReadForm())
            {
                //reset all data
                ResetForm(false);
                //enable all controls
                EnableControls();
                //hide progress bar
                progressBar.Visible = false;
            }
            else
            {
                progressBar.Value = 10;
                //generate the template
                GenerateTemplate();
                progressBar.Value = 100;
                //enable all controls and reset all data
                ResetForm(true);
                EnableControls();                
            }
        }
        private void customTextCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //disable the custom html in all bodies option
            customBodyCheckbox.Checked = false;

            //enable/disable custom input field
            if (!customTextCheckbox.Checked)
            {
                customTextInput.Enabled = false;
                customTextSelected = false;
            }
            else
            {
                customTextInput.Enabled = true;
                customTextSelected = true;
            }
        }
        private void customBodyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //uncheck the place custom html in all files option
            customTextCheckbox.Checked = false;

            //enable/disable custom input field
            if (!customBodyCheckbox.Checked)
            {
                customTextInput.Enabled = false;
                customBodySelected = false;
            }
            else
            {
                customTextInput.Enabled = true;
                customBodySelected = true;
            }
        }
        #endregion
        //disables form controls
        public void DisableControls()
        {
            //checkboxes
            stylesheetOption.Enabled = false;
            jsOption.Enabled = false;
            bootstrapOption.Enabled = false;
            customTextInput.Enabled = false;
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
        public void ResetForm(bool resetControls)
        {
            //global variable reset
            jsOptionSelected = false;
            stylesheetOptionSelected = false;
            bootstrapOptionSelected = false;
            customTextSelected = false;
            numPages = 0;
            path = "";
            projectName = "";
            if(resetControls)
            {
                jsOption.Checked = false;
                bootstrapOption.Checked = false;
                stylesheetOption.Checked = false;
                pageNumInput.Text = "";
                projectDirectoryInput.Text = "";
                nameInput.Text = "";
            }
        }
        //build template
        public void GenerateTemplate()
        {
            string stylesheetText = "";
            string jsText = "";
            string bootstrapText = "";
            string indexText = "";
            //create project directory
            //use this for tests D:\Programming
            DirectoryInfo di = Directory.CreateDirectory(path);
            progressBar.Value = 15;
            //create index.html
            if (!customTextSelected)
            {
                //check options
                if (stylesheetOptionSelected)
                    stylesheetText = "<link rel=\"stylesheet\" href=\"styles/myStyle.css\">";
                progressBar.Value = 20;
                if (jsOptionSelected)
                    jsText = "<script src=\"/scripts/myScript.js\"></script>";
                progressBar.Value = 25;
                if (bootstrapOptionSelected)
                    bootstrapText = "<link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We\" crossorigin=\"anonymous\">\n<script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj\" crossorigin=\"anonymous\"></script>";
                progressBar.Value = 30;
                //get text for options
                string bodyText = GenerateBodyText(true, "-1");
                progressBar.Value = 40;
                string headerText = $"<meta charset=\"UTF - 8\">\n<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1.0\">\n<title>{projectName}</title>\n";
                indexText = $"<!DOCTYPE html>\n<html>\n<head>\n{headerText}\n{stylesheetText}\n{bootstrapText}\n</head>\n<body>\n{bodyText}\n{jsText}\n</body>\n</html>";
            }
            else
            {
                //put custom input into indexText
                foreach (char c in customTextInput.Text)
                {
                    indexText += c;
                }
            }
            //generate index page
            GeneratePage(indexText, path + "\\index.html");
            progressBar.Value = 50;

            //generate extra pages
            GenerateExtraPages();

            //if styles added create stylesheet
            if (stylesheetOptionSelected)
                GenerateCSS();
            //if js added create js
            if (jsOptionSelected)
                GenerateJS();
            //create assets directory (for images and other stuff)
            GenerateAssets();
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
        //generate bodytext
        public string GenerateBodyText(bool isIndex, string pageNumber)
        {
            if (isIndex)
            {
                string bodyText = $"\n<a href =\"index.html\"><h1>{projectName}</h1></a>\n<br>\n";
                for (int i = 0; i < numPages; i++)
                {
                    bodyText += $"\n<a href = \"pages/page{i}.html\">Page {i}</a><br>";
                }
                if(customBodySelected)
                    bodyText += "\n" + customTextInput.Text;
               return bodyText;
            }
            else
            {
                string bodyText = $"\n<a href =\"../index.html\"><h1>{projectName} - {pageNumber}</h1></a>\n<br>\n";
                for (int i = 0; i < numPages; i++)
                {
                    bodyText += $"\n<a href = \"page{i}.html\">Page {i}</a><br>";
                }
                if (customBodySelected)
                    bodyText += "\n" + customTextInput.Text;
                return bodyText;
            }
        }
        //generate all extra pages
        public void GenerateExtraPages()
        {
            DirectoryInfo di = Directory.CreateDirectory(path + "\\pages");
            string indexText = "";
            string headerText = "";
            string bodyText = "";
            string stylesheetText = "";
            string jsText = "";
            string bootstrapText = "";
            for (int i = 0; i < numPages; i++)
            {
                if (!customTextSelected)
                {
                    headerText = $"<meta charset=\"UTF - 8\">\n<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1.0\">\n<title>{projectName} - {i}</title>\n";
                    bodyText = GenerateBodyText(false, i.ToString());

                    //check options
                    if (stylesheetOptionSelected)
                        stylesheetText = "<link rel=\"stylesheet\" href=\"../styles/myStyle.css\">";
                    if (jsOptionSelected)
                        jsText = "<script src=\"../scripts/myScript.js\"></script>";
                    if (bootstrapOptionSelected)
                        bootstrapText = "<link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We\" crossorigin=\"anonymous\">\n<script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj\" crossorigin=\"anonymous\"></script>";

                    indexText = $"<!DOCTYPE html>\n<html>\n<head>\n{headerText}\n{stylesheetText}\n{bootstrapText}\n</head>\n<body>\n{bodyText}\n{jsText}\n</body>\n</html>";
                }
                else
                {
                    //put custom input into indexText
                    foreach(char c in customTextInput.Text)
                    {
                        indexText += c;
                    }
                }
                //generate page
                GeneratePage(indexText, path + $"\\pages\\page{i}.html");
            }
        }
        //generate CSS file and directory
        public void GenerateCSS()
        {
            //make directory for style sheets
            DirectoryInfo di = Directory.CreateDirectory(path + "\\styles");

            //make file
            GeneratePage("/*Place your styles here*/", path + "\\styles\\myStlye.css");
        }

        //generate JS file and directory
        public void GenerateJS()
        {
            //make directory for scripts
            DirectoryInfo di = Directory.CreateDirectory(path + "\\scripts");

            //make file
            GeneratePage("//Place your JS here", path + "\\scripts\\myScript.js");
        }
        //Generate Assets directory and assets
        public void GenerateAssets()
        {
            //make directory for assets
            DirectoryInfo di = Directory.CreateDirectory(path + "\\assets");
        }

        
    }
}
