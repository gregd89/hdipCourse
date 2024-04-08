namespace distanceTraveled
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCarSpeed = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.button5Hrs = new System.Windows.Forms.Button();
            this.button8Hrs = new System.Windows.Forms.Button();
            this.button12Hrs = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the car\'s speed (MPH)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCarSpeed
            // 
            this.textBoxCarSpeed.Location = new System.Drawing.Point(240, 29);
            this.textBoxCarSpeed.Name = "textBoxCarSpeed";
            this.textBoxCarSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarSpeed.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(680, 387);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button5Hrs
            // 
            this.button5Hrs.Location = new System.Drawing.Point(31, 94);
            this.button5Hrs.Name = "button5Hrs";
            this.button5Hrs.Size = new System.Drawing.Size(158, 74);
            this.button5Hrs.TabIndex = 3;
            this.button5Hrs.Text = "The distance the car will travel in 5 Hours";
            this.button5Hrs.UseVisualStyleBackColor = true;
            this.button5Hrs.Click += new System.EventHandler(this.button5Hrs_Click);
            // 
            // button8Hrs
            // 
            this.button8Hrs.Location = new System.Drawing.Point(240, 94);
            this.button8Hrs.Name = "button8Hrs";
            this.button8Hrs.Size = new System.Drawing.Size(138, 74);
            this.button8Hrs.TabIndex = 4;
            this.button8Hrs.Text = "The distance the car will travel in 8 Hours";
            this.button8Hrs.UseVisualStyleBackColor = true;
            this.button8Hrs.Click += new System.EventHandler(this.button8Hrs_Click);
            // 
            // button12Hrs
            // 
            this.button12Hrs.Location = new System.Drawing.Point(416, 94);
            this.button12Hrs.Name = "button12Hrs";
            this.button12Hrs.Size = new System.Drawing.Size(149, 74);
            this.button12Hrs.TabIndex = 5;
            this.button12Hrs.Text = "The distance the car will travel in 12 Hours";
            this.button12Hrs.UseVisualStyleBackColor = true;
            this.button12Hrs.Click += new System.EventHandler(this.button12Hrs_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(31, 222);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(534, 110);
            this.outputLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.button12Hrs);
            this.Controls.Add(this.button8Hrs);
            this.Controls.Add(this.button5Hrs);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.textBoxCarSpeed);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Distance Travelled Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCarSpeed;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button5Hrs;
        private System.Windows.Forms.Button button8Hrs;
        private System.Windows.Forms.Button button12Hrs;
        private System.Windows.Forms.Label outputLabel;
    }
}

