
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
            this.SuspendLayout();
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Location = new System.Drawing.Point(23, 67);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(49, 15);
            this.optionsLabel.TabIndex = 1;
            this.optionsLabel.Text = "Options";
            // 
            // stylesheetOption
            // 
            this.stylesheetOption.AutoSize = true;
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
            this.bootstrapOption.Location = new System.Drawing.Point(23, 145);
            this.bootstrapOption.Name = "bootstrapOption";
            this.bootstrapOption.Size = new System.Drawing.Size(119, 19);
            this.bootstrapOption.TabIndex = 4;
            this.bootstrapOption.Text = "Include Bootstrap";
            this.bootstrapOption.UseVisualStyleBackColor = true;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(108, 196);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(242, 23);
            this.nameInput.TabIndex = 5;
            // 
            // nameInputLabel
            // 
            this.nameInputLabel.AutoSize = true;
            this.nameInputLabel.Location = new System.Drawing.Point(23, 199);
            this.nameInputLabel.Name = "nameInputLabel";
            this.nameInputLabel.Size = new System.Drawing.Size(82, 15);
            this.nameInputLabel.TabIndex = 6;
            this.nameInputLabel.Text = "Project Name:";
            // 
            // pageNumInputLabel
            // 
            this.pageNumInputLabel.AutoSize = true;
            this.pageNumInputLabel.Location = new System.Drawing.Point(23, 231);
            this.pageNumInputLabel.Name = "pageNumInputLabel";
            this.pageNumInputLabel.Size = new System.Drawing.Size(272, 15);
            this.pageNumInputLabel.TabIndex = 7;
            this.pageNumInputLabel.Text = "Number of Additional Pages:                           (0-10)";
            // 
            // pageNumInput
            // 
            this.pageNumInput.Location = new System.Drawing.Point(189, 228);
            this.pageNumInput.Name = "pageNumInput";
            this.pageNumInput.Size = new System.Drawing.Size(34, 23);
            this.pageNumInput.TabIndex = 8;
            // 
            // generateTemplateButton
            // 
            this.generateTemplateButton.Location = new System.Drawing.Point(53, 305);
            this.generateTemplateButton.Name = "generateTemplateButton";
            this.generateTemplateButton.Size = new System.Drawing.Size(129, 33);
            this.generateTemplateButton.TabIndex = 9;
            this.generateTemplateButton.Text = "button1";
            this.generateTemplateButton.UseVisualStyleBackColor = true;
            this.generateTemplateButton.Click += new System.EventHandler(this.generateTemplateButton_Click);
            // 
            // projectDirectoryInput
            // 
            this.projectDirectoryInput.Location = new System.Drawing.Point(127, 257);
            this.projectDirectoryInput.Name = "projectDirectoryInput";
            this.projectDirectoryInput.Size = new System.Drawing.Size(223, 23);
            this.projectDirectoryInput.TabIndex = 10;
            // 
            // projectDirectoryInputLabel
            // 
            this.projectDirectoryInputLabel.AutoSize = true;
            this.projectDirectoryInputLabel.Location = new System.Drawing.Point(23, 258);
            this.projectDirectoryInputLabel.Name = "projectDirectoryInputLabel";
            this.projectDirectoryInputLabel.Size = new System.Drawing.Size(98, 15);
            this.projectDirectoryInputLabel.TabIndex = 11;
            this.projectDirectoryInputLabel.Text = "Project Directory:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(23, 344);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 23);
            this.progressBar.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 688);
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
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

