
namespace HTML_Template_Maker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.stylesheetOption = new System.Windows.Forms.CheckBox();
            this.jsOption = new System.Windows.Forms.CheckBox();
            this.bootstrapOption = new System.Windows.Forms.CheckBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameInputLabel = new System.Windows.Forms.Label();
            this.pageNumInputLabel = new System.Windows.Forms.Label();
            this.pageNumInput = new System.Windows.Forms.TextBox();
            this.generateTemplateButton = new System.Windows.Forms.Button();
            this.projectDirectoryInput = new System.Windows.Forms.TextBox();
            this.projectDirectoryInputLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.customTextInput = new System.Windows.Forms.RichTextBox();
            this.customInputLabel = new System.Windows.Forms.Label();
            this.customTextCheckbox = new System.Windows.Forms.CheckBox();
            this.customBodyCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.ForeColor = System.Drawing.Color.Azure;
            this.optionsLabel.Location = new System.Drawing.Point(23, 67);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(49, 15);
            this.optionsLabel.TabIndex = 1;
            this.optionsLabel.Text = "Options";
            // 
            // stylesheetOption
            // 
            this.stylesheetOption.AutoSize = true;
            this.stylesheetOption.ForeColor = System.Drawing.Color.Azure;
            this.stylesheetOption.Location = new System.Drawing.Point(23, 95);
            this.stylesheetOption.Name = "stylesheetOption";
            this.stylesheetOption.Size = new System.Drawing.Size(121, 19);
            this.stylesheetOption.TabIndex = 2;
            this.stylesheetOption.Text = "Include Stylesheet";
            this.stylesheetOption.UseVisualStyleBackColor = true;
            // 
            // jsOption
            // 
            this.jsOption.AutoSize = true;
            this.jsOption.ForeColor = System.Drawing.Color.Azure;
            this.jsOption.Location = new System.Drawing.Point(23, 120);
            this.jsOption.Name = "jsOption";
            this.jsOption.Size = new System.Drawing.Size(128, 19);
            this.jsOption.TabIndex = 3;
            this.jsOption.Text = "Include JS template";
            this.jsOption.UseVisualStyleBackColor = true;
            // 
            // bootstrapOption
            // 
            this.bootstrapOption.AutoSize = true;
            this.bootstrapOption.ForeColor = System.Drawing.Color.Azure;
            this.bootstrapOption.Location = new System.Drawing.Point(23, 145);
            this.bootstrapOption.Name = "bootstrapOption";
            this.bootstrapOption.Size = new System.Drawing.Size(119, 19);
            this.bootstrapOption.TabIndex = 4;
            this.bootstrapOption.Text = "Include Bootstrap";
            this.bootstrapOption.UseVisualStyleBackColor = true;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(108, 292);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(242, 23);
            this.nameInput.TabIndex = 5;
            // 
            // nameInputLabel
            // 
            this.nameInputLabel.AutoSize = true;
            this.nameInputLabel.ForeColor = System.Drawing.Color.Azure;
            this.nameInputLabel.Location = new System.Drawing.Point(20, 295);
            this.nameInputLabel.Name = "nameInputLabel";
            this.nameInputLabel.Size = new System.Drawing.Size(82, 15);
            this.nameInputLabel.TabIndex = 6;
            this.nameInputLabel.Text = "Project Name:";
            // 
            // pageNumInputLabel
            // 
            this.pageNumInputLabel.AutoSize = true;
            this.pageNumInputLabel.ForeColor = System.Drawing.Color.Azure;
            this.pageNumInputLabel.Location = new System.Drawing.Point(22, 324);
            this.pageNumInputLabel.Name = "pageNumInputLabel";
            this.pageNumInputLabel.Size = new System.Drawing.Size(272, 15);
            this.pageNumInputLabel.TabIndex = 7;
            this.pageNumInputLabel.Text = "Number of Additional Pages:                           (0-10)";
            // 
            // pageNumInput
            // 
            this.pageNumInput.Location = new System.Drawing.Point(189, 321);
            this.pageNumInput.Name = "pageNumInput";
            this.pageNumInput.Size = new System.Drawing.Size(34, 23);
            this.pageNumInput.TabIndex = 8;
            // 
            // generateTemplateButton
            // 
            this.generateTemplateButton.BackColor = System.Drawing.Color.Teal;
            this.generateTemplateButton.ForeColor = System.Drawing.Color.Azure;
            this.generateTemplateButton.Location = new System.Drawing.Point(59, 390);
            this.generateTemplateButton.Name = "generateTemplateButton";
            this.generateTemplateButton.Size = new System.Drawing.Size(129, 33);
            this.generateTemplateButton.TabIndex = 9;
            this.generateTemplateButton.Text = "Generate Template";
            this.generateTemplateButton.UseVisualStyleBackColor = false;
            this.generateTemplateButton.Click += new System.EventHandler(this.generateTemplateButton_Click);
            // 
            // projectDirectoryInput
            // 
            this.projectDirectoryInput.Location = new System.Drawing.Point(127, 350);
            this.projectDirectoryInput.Name = "projectDirectoryInput";
            this.projectDirectoryInput.Size = new System.Drawing.Size(223, 23);
            this.projectDirectoryInput.TabIndex = 10;
            // 
            // projectDirectoryInputLabel
            // 
            this.projectDirectoryInputLabel.AutoSize = true;
            this.projectDirectoryInputLabel.ForeColor = System.Drawing.Color.Azure;
            this.projectDirectoryInputLabel.Location = new System.Drawing.Point(20, 353);
            this.projectDirectoryInputLabel.Name = "projectDirectoryInputLabel";
            this.projectDirectoryInputLabel.Size = new System.Drawing.Size(98, 15);
            this.projectDirectoryInputLabel.TabIndex = 11;
            this.projectDirectoryInputLabel.Text = "Project Directory:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(23, 429);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 23);
            this.progressBar.TabIndex = 12;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // customTextInput
            // 
            this.customTextInput.Enabled = false;
            this.customTextInput.Location = new System.Drawing.Point(369, 93);
            this.customTextInput.Name = "customTextInput";
            this.customTextInput.Size = new System.Drawing.Size(765, 508);
            this.customTextInput.TabIndex = 13;
            this.customTextInput.Text = "<!DOCTYPE html>\n<html>\n<head></head>\n<body></body>\n<footer></footer>\n</html>";
            // 
            // customInputLabel
            // 
            this.customInputLabel.AutoSize = true;
            this.customInputLabel.ForeColor = System.Drawing.Color.White;
            this.customInputLabel.Location = new System.Drawing.Point(369, 66);
            this.customInputLabel.Name = "customInputLabel";
            this.customInputLabel.Size = new System.Drawing.Size(118, 15);
            this.customInputLabel.TabIndex = 14;
            this.customInputLabel.Text = "Custom HTML Input:";
            // 
            // customTextCheckbox
            // 
            this.customTextCheckbox.AutoSize = true;
            this.customTextCheckbox.ForeColor = System.Drawing.Color.White;
            this.customTextCheckbox.Location = new System.Drawing.Point(22, 170);
            this.customTextCheckbox.Name = "customTextCheckbox";
            this.customTextCheckbox.Size = new System.Drawing.Size(180, 19);
            this.customTextCheckbox.TabIndex = 15;
            this.customTextCheckbox.Text = "Use custom HTML for all files";
            this.customTextCheckbox.UseVisualStyleBackColor = true;
            this.customTextCheckbox.CheckedChanged += new System.EventHandler(this.customTextCheckbox_CheckedChanged);
            // 
            // customBodyCheckbox
            // 
            this.customBodyCheckbox.AutoSize = true;
            this.customBodyCheckbox.ForeColor = System.Drawing.Color.White;
            this.customBodyCheckbox.Location = new System.Drawing.Point(23, 195);
            this.customBodyCheckbox.Name = "customBodyCheckbox";
            this.customBodyCheckbox.Size = new System.Drawing.Size(250, 19);
            this.customBodyCheckbox.TabIndex = 16;
            this.customBodyCheckbox.Text = "Place Custom HTML in the body of all files";
            this.customBodyCheckbox.UseVisualStyleBackColor = true;
            this.customBodyCheckbox.CheckedChanged += new System.EventHandler(this.customBodyCheckbox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1165, 688);
            this.Controls.Add(this.customBodyCheckbox);
            this.Controls.Add(this.customTextCheckbox);
            this.Controls.Add(this.customInputLabel);
            this.Controls.Add(this.customTextInput);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.projectDirectoryInputLabel);
            this.Controls.Add(this.projectDirectoryInput);
            this.Controls.Add(this.generateTemplateButton);
            this.Controls.Add(this.pageNumInput);
            this.Controls.Add(this.pageNumInputLabel);
            this.Controls.Add(this.nameInputLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.bootstrapOption);
            this.Controls.Add(this.jsOption);
            this.Controls.Add(this.stylesheetOption);
            this.Controls.Add(this.optionsLabel);
            this.Name = "Form1";
            this.Text = "Website Template Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.CheckBox stylesheetOption;
        private System.Windows.Forms.CheckBox jsOption;
        private System.Windows.Forms.CheckBox bootstrapOption;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameInputLabel;
        private System.Windows.Forms.Label pageNumInputLabel;
        private System.Windows.Forms.TextBox pageNumInput;
        private System.Windows.Forms.Button generateTemplateButton;
        private System.Windows.Forms.TextBox projectDirectoryInput;
        private System.Windows.Forms.Label projectDirectoryInputLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox customTextCheckbox;
        private System.Windows.Forms.Label customInputLabel;
        private System.Windows.Forms.RichTextBox customTextInput;
        private System.Windows.Forms.CheckBox customBodyCheckbox;
    }
}

