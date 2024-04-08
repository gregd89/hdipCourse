namespace nameFormatter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonFullName = new System.Windows.Forms.Button();
            this.buttonFMLName = new System.Windows.Forms.Button();
            this.buttonFLName = new System.Windows.Forms.Button();
            this.buttonLFMTName = new System.Windows.Forms.Button();
            this.buttonLFMName = new System.Windows.Forms.Button();
            this.buttonLFName = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.labelDisplayOutput = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(47, 37);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(47, 67);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(69, 13);
            this.labelMiddleName.TabIndex = 1;
            this.labelMiddleName.Text = "Middle Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(47, 100);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(47, 127);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(73, 13);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Preferred Title";
            // 
            // buttonFullName
            // 
            this.buttonFullName.Location = new System.Drawing.Point(31, 295);
            this.buttonFullName.Name = "buttonFullName";
            this.buttonFullName.Size = new System.Drawing.Size(159, 23);
            this.buttonFullName.TabIndex = 12;
            this.buttonFullName.Text = "Full Name";
            this.buttonFullName.UseVisualStyleBackColor = true;
            this.buttonFullName.Click += new System.EventHandler(this.buttonFullName_Click);
            // 
            // buttonFMLName
            // 
            this.buttonFMLName.Location = new System.Drawing.Point(31, 352);
            this.buttonFMLName.Name = "buttonFMLName";
            this.buttonFMLName.Size = new System.Drawing.Size(159, 23);
            this.buttonFMLName.TabIndex = 13;
            this.buttonFMLName.Text = "First, Middle and Last Name";
            this.buttonFMLName.UseVisualStyleBackColor = true;
            this.buttonFMLName.Click += new System.EventHandler(this.buttonFMLName_Click);
            // 
            // buttonFLName
            // 
            this.buttonFLName.Location = new System.Drawing.Point(31, 405);
            this.buttonFLName.Name = "buttonFLName";
            this.buttonFLName.Size = new System.Drawing.Size(159, 23);
            this.buttonFLName.TabIndex = 14;
            this.buttonFLName.Text = "First and Last Name";
            this.buttonFLName.UseVisualStyleBackColor = true;
            this.buttonFLName.Click += new System.EventHandler(this.buttonFLName_Click);
            // 
            // buttonLFMTName
            // 
            this.buttonLFMTName.Location = new System.Drawing.Point(215, 295);
            this.buttonLFMTName.Name = "buttonLFMTName";
            this.buttonLFMTName.Size = new System.Drawing.Size(146, 23);
            this.buttonLFMTName.TabIndex = 15;
            this.buttonLFMTName.Text = "Last, First, Middle and Title";
            this.buttonLFMTName.UseVisualStyleBackColor = true;
            this.buttonLFMTName.Click += new System.EventHandler(this.buttonLFMTName_Click);
            // 
            // buttonLFMName
            // 
            this.buttonLFMName.Location = new System.Drawing.Point(215, 352);
            this.buttonLFMName.Name = "buttonLFMName";
            this.buttonLFMName.Size = new System.Drawing.Size(146, 23);
            this.buttonLFMName.TabIndex = 16;
            this.buttonLFMName.Text = "Last, First Middle Name";
            this.buttonLFMName.UseVisualStyleBackColor = true;
            this.buttonLFMName.Click += new System.EventHandler(this.buttonLFMName_Click);
            // 
            // buttonLFName
            // 
            this.buttonLFName.Location = new System.Drawing.Point(215, 405);
            this.buttonLFName.Name = "buttonLFName";
            this.buttonLFName.Size = new System.Drawing.Size(146, 23);
            this.buttonLFName.TabIndex = 17;
            this.buttonLFName.Text = "Last, First Name";
            this.buttonLFName.UseVisualStyleBackColor = true;
            this.buttonLFName.Click += new System.EventHandler(this.buttonLFName_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(697, 405);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // labelDisplayOutput
            // 
            this.labelDisplayOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayOutput.Location = new System.Drawing.Point(405, 295);
            this.labelDisplayOutput.Name = "labelDisplayOutput";
            this.labelDisplayOutput.Size = new System.Drawing.Size(264, 133);
            this.labelDisplayOutput.TabIndex = 19;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(194, 37);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 20;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(194, 67);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMiddleName.TabIndex = 21;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(194, 100);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 22;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(194, 127);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelDisplayOutput);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.buttonLFName);
            this.Controls.Add(this.buttonLFMName);
            this.Controls.Add(this.buttonLFMTName);
            this.Controls.Add(this.buttonFLName);
            this.Controls.Add(this.buttonFMLName);
            this.Controls.Add(this.buttonFullName);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "Form1";
            this.Text = "Name Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonFullName;
        private System.Windows.Forms.Button buttonFMLName;
        private System.Windows.Forms.Button buttonFLName;
        private System.Windows.Forms.Button buttonLFMTName;
        private System.Windows.Forms.Button buttonLFMName;
        private System.Windows.Forms.Button buttonLFName;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label labelDisplayOutput;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxTitle;
    }
}

