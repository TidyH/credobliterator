namespace CreditObliterator
{
    partial class mainPage
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.doubleButton = new System.Windows.Forms.Button();
            this.customTextBox = new System.Windows.Forms.TextBox();
            this.trippleButton = new System.Windows.Forms.Button();
            this.addCardButton = new System.Windows.Forms.Button();
            this.cardGroupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(29, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(137, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Select Credit Card";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doubleButton
            // 
            this.doubleButton.Location = new System.Drawing.Point(171, 64);
            this.doubleButton.Name = "doubleButton";
            this.doubleButton.Size = new System.Drawing.Size(114, 23);
            this.doubleButton.TabIndex = 3;
            this.doubleButton.Text = "Double Interest";
            this.doubleButton.UseVisualStyleBackColor = true;
            this.doubleButton.Click += new System.EventHandler(this.doubleButton_Click);
            // 
            // customTextBox
            // 
            this.customTextBox.Location = new System.Drawing.Point(171, 122);
            this.customTextBox.Name = "customTextBox";
            this.customTextBox.Size = new System.Drawing.Size(114, 22);
            this.customTextBox.TabIndex = 4;
            this.customTextBox.Text = "0";
            // 
            // trippleButton
            // 
            this.trippleButton.Location = new System.Drawing.Point(171, 93);
            this.trippleButton.Name = "trippleButton";
            this.trippleButton.Size = new System.Drawing.Size(114, 23);
            this.trippleButton.TabIndex = 5;
            this.trippleButton.Text = "Tripple Interest";
            this.trippleButton.UseVisualStyleBackColor = true;
            this.trippleButton.Click += new System.EventHandler(this.trippleButton_Click);
            // 
            // addCardButton
            // 
            this.addCardButton.Location = new System.Drawing.Point(171, 150);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(114, 68);
            this.addCardButton.TabIndex = 9;
            this.addCardButton.Text = "Add Credit Card";
            this.addCardButton.UseVisualStyleBackColor = true;
            this.addCardButton.Click += new System.EventHandler(this.addCardButton_Click);
            // 
            // cardGroupBox
            // 
            this.cardGroupBox.Location = new System.Drawing.Point(15, 64);
            this.cardGroupBox.Name = "cardGroupBox";
            this.cardGroupBox.Size = new System.Drawing.Size(150, 386);
            this.cardGroupBox.TabIndex = 10;
            this.cardGroupBox.TabStop = false;
            this.cardGroupBox.Text = "Cards";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 68);
            this.button2.TabIndex = 11;
            this.button2.Text = "Remove Credit Card";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 471);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cardGroupBox);
            this.Controls.Add(this.addCardButton);
            this.Controls.Add(this.trippleButton);
            this.Controls.Add(this.customTextBox);
            this.Controls.Add(this.doubleButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titleLabel);
            this.Name = "mainPage";
            this.Text = "Credit Obliterator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button doubleButton;
        private System.Windows.Forms.TextBox customTextBox;
        private System.Windows.Forms.Button trippleButton;
        private System.Windows.Forms.Button addCardButton;
        private System.Windows.Forms.GroupBox cardGroupBox;
        private System.Windows.Forms.Button button2;
    }
}

