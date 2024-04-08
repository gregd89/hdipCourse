namespace foodChargeCalculator
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
            this.labelFoodCharge = new System.Windows.Forms.Label();
            this.textBoxMealCost = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.labelDisplayCosts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFoodCharge
            // 
            this.labelFoodCharge.AutoSize = true;
            this.labelFoodCharge.Location = new System.Drawing.Point(51, 45);
            this.labelFoodCharge.Name = "labelFoodCharge";
            this.labelFoodCharge.Size = new System.Drawing.Size(145, 13);
            this.labelFoodCharge.TabIndex = 0;
            this.labelFoodCharge.Text = "What is the cost of the meal?";
            // 
            // textBoxMealCost
            // 
            this.textBoxMealCost.Location = new System.Drawing.Point(304, 42);
            this.textBoxMealCost.Name = "textBoxMealCost";
            this.textBoxMealCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxMealCost.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(695, 396);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(536, 40);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // labelDisplayCosts
            // 
            this.labelDisplayCosts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayCosts.Location = new System.Drawing.Point(304, 78);
            this.labelDisplayCosts.Name = "labelDisplayCosts";
            this.labelDisplayCosts.Size = new System.Drawing.Size(307, 117);
            this.labelDisplayCosts.TabIndex = 4;
            this.labelDisplayCosts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDisplayCosts);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.textBoxMealCost);
            this.Controls.Add(this.labelFoodCharge);
            this.Name = "Form1";
            this.Text = "Calculate Meal Cost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFoodCharge;
        private System.Windows.Forms.TextBox textBoxMealCost;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label labelDisplayCosts;
    }
}

