namespace CreditObliterator
{
    partial class addForm
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
            this.creditCardNameLAbel = new System.Windows.Forms.Label();
            this.newCardRateLabel = new System.Windows.Forms.Label();
            this.cardPrincipalLabel = new System.Windows.Forms.Label();
            this.newCardNameTextBox = new System.Windows.Forms.TextBox();
            this.newCardPrincipalTextBox = new System.Windows.Forms.TextBox();
            this.newCardRateTextBox = new System.Windows.Forms.TextBox();
            this.addFormTitle = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creditCardNameLAbel
            // 
            this.creditCardNameLAbel.Location = new System.Drawing.Point(31, 65);
            this.creditCardNameLAbel.Name = "creditCardNameLAbel";
            this.creditCardNameLAbel.Size = new System.Drawing.Size(100, 23);
            this.creditCardNameLAbel.TabIndex = 0;
            this.creditCardNameLAbel.Text = "Name of Card:";
            // 
            // newCardRateLabel
            // 
            this.newCardRateLabel.AutoSize = true;
            this.newCardRateLabel.Location = new System.Drawing.Point(55, 113);
            this.newCardRateLabel.Name = "newCardRateLabel";
            this.newCardRateLabel.Size = new System.Drawing.Size(76, 17);
            this.newCardRateLabel.TabIndex = 1;
            this.newCardRateLabel.Text = "Card Rate:";
            // 
            // cardPrincipalLabel
            // 
            this.cardPrincipalLabel.AutoSize = true;
            this.cardPrincipalLabel.Location = new System.Drawing.Point(65, 166);
            this.cardPrincipalLabel.Name = "cardPrincipalLabel";
            this.cardPrincipalLabel.Size = new System.Drawing.Size(66, 17);
            this.cardPrincipalLabel.TabIndex = 2;
            this.cardPrincipalLabel.Text = "Principal:";
            // 
            // newCardNameTextBox
            // 
            this.newCardNameTextBox.Location = new System.Drawing.Point(137, 62);
            this.newCardNameTextBox.Name = "newCardNameTextBox";
            this.newCardNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.newCardNameTextBox.TabIndex = 3;
            this.newCardNameTextBox.Text = "0";
            // 
            // newCardPrincipalTextBox
            // 
            this.newCardPrincipalTextBox.Location = new System.Drawing.Point(137, 161);
            this.newCardPrincipalTextBox.Name = "newCardPrincipalTextBox";
            this.newCardPrincipalTextBox.Size = new System.Drawing.Size(100, 22);
            this.newCardPrincipalTextBox.TabIndex = 4;
            this.newCardPrincipalTextBox.Text = "0";
            // 
            // newCardRateTextBox
            // 
            this.newCardRateTextBox.Location = new System.Drawing.Point(137, 113);
            this.newCardRateTextBox.Name = "newCardRateTextBox";
            this.newCardRateTextBox.Size = new System.Drawing.Size(100, 22);
            this.newCardRateTextBox.TabIndex = 5;
            this.newCardRateTextBox.Text = "0";
            // 
            // addFormTitle
            // 
            this.addFormTitle.Location = new System.Drawing.Point(34, 13);
            this.addFormTitle.Name = "addFormTitle";
            this.addFormTitle.Size = new System.Drawing.Size(160, 23);
            this.addFormTitle.TabIndex = 6;
            this.addFormTitle.Text = "Enter Card Information";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(96, 197);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 232);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addFormTitle);
            this.Controls.Add(this.newCardRateTextBox);
            this.Controls.Add(this.newCardPrincipalTextBox);
            this.Controls.Add(this.newCardNameTextBox);
            this.Controls.Add(this.cardPrincipalLabel);
            this.Controls.Add(this.newCardRateLabel);
            this.Controls.Add(this.creditCardNameLAbel);
            this.Name = "addForm";
            this.Text = "addForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creditCardNameLAbel;
        private System.Windows.Forms.Label newCardRateLabel;
        private System.Windows.Forms.Label cardPrincipalLabel;
        private System.Windows.Forms.TextBox newCardNameTextBox;
        private System.Windows.Forms.TextBox newCardPrincipalTextBox;
        private System.Windows.Forms.TextBox newCardRateTextBox;
        private System.Windows.Forms.Label addFormTitle;
        private System.Windows.Forms.Button saveButton;
    }
}