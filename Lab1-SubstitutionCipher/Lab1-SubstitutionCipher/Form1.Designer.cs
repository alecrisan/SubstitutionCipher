namespace Lab1_SubstitutionCipher
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
            this.encryptButton = new System.Windows.Forms.Button();
            this.plainTextBox = new System.Windows.Forms.TextBox();
            this.encryptionKeyTextBox = new System.Windows.Forms.TextBox();
            this.plainTextLabel = new System.Windows.Forms.Label();
            this.encryptionKeyLabel = new System.Windows.Forms.Label();
            this.cipherTextBox = new System.Windows.Forms.TextBox();
            this.cipherTextLabel = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.decryptionKeyLabel = new System.Windows.Forms.Label();
            this.decryptionKeyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(463, 129);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(115, 36);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // plainTextBox
            // 
            this.plainTextBox.Location = new System.Drawing.Point(62, 74);
            this.plainTextBox.Multiline = true;
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(322, 58);
            this.plainTextBox.TabIndex = 1;
            // 
            // encryptionKeyTextBox
            // 
            this.encryptionKeyTextBox.Location = new System.Drawing.Point(62, 207);
            this.encryptionKeyTextBox.Multiline = true;
            this.encryptionKeyTextBox.Name = "encryptionKeyTextBox";
            this.encryptionKeyTextBox.Size = new System.Drawing.Size(322, 54);
            this.encryptionKeyTextBox.TabIndex = 2;
            // 
            // plainTextLabel
            // 
            this.plainTextLabel.AutoSize = true;
            this.plainTextLabel.Location = new System.Drawing.Point(59, 33);
            this.plainTextLabel.Name = "plainTextLabel";
            this.plainTextLabel.Size = new System.Drawing.Size(50, 13);
            this.plainTextLabel.TabIndex = 3;
            this.plainTextLabel.Text = "Plain text";
            // 
            // encryptionKeyLabel
            // 
            this.encryptionKeyLabel.AutoSize = true;
            this.encryptionKeyLabel.Location = new System.Drawing.Point(59, 170);
            this.encryptionKeyLabel.Name = "encryptionKeyLabel";
            this.encryptionKeyLabel.Size = new System.Drawing.Size(78, 13);
            this.encryptionKeyLabel.TabIndex = 4;
            this.encryptionKeyLabel.Text = "Encryption Key";
            // 
            // cipherTextBox
            // 
            this.cipherTextBox.Location = new System.Drawing.Point(62, 338);
            this.cipherTextBox.Multiline = true;
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.Size = new System.Drawing.Size(322, 58);
            this.cipherTextBox.TabIndex = 6;
            // 
            // cipherTextLabel
            // 
            this.cipherTextLabel.AutoSize = true;
            this.cipherTextLabel.Location = new System.Drawing.Point(59, 301);
            this.cipherTextLabel.Name = "cipherTextLabel";
            this.cipherTextLabel.Size = new System.Drawing.Size(57, 13);
            this.cipherTextLabel.TabIndex = 7;
            this.cipherTextLabel.Text = "Cipher text";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(654, 129);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(97, 36);
            this.decryptButton.TabIndex = 8;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(569, 198);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(99, 37);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // decryptionKeyLabel
            // 
            this.decryptionKeyLabel.AutoSize = true;
            this.decryptionKeyLabel.Location = new System.Drawing.Point(460, 301);
            this.decryptionKeyLabel.Name = "decryptionKeyLabel";
            this.decryptionKeyLabel.Size = new System.Drawing.Size(79, 13);
            this.decryptionKeyLabel.TabIndex = 10;
            this.decryptionKeyLabel.Text = "Decryption Key";
            // 
            // decryptionKeyTextBox
            // 
            this.decryptionKeyTextBox.Location = new System.Drawing.Point(463, 338);
            this.decryptionKeyTextBox.Multiline = true;
            this.decryptionKeyTextBox.Name = "decryptionKeyTextBox";
            this.decryptionKeyTextBox.Size = new System.Drawing.Size(288, 58);
            this.decryptionKeyTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decryptionKeyTextBox);
            this.Controls.Add(this.decryptionKeyLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.cipherTextLabel);
            this.Controls.Add(this.cipherTextBox);
            this.Controls.Add(this.encryptionKeyLabel);
            this.Controls.Add(this.plainTextLabel);
            this.Controls.Add(this.encryptionKeyTextBox);
            this.Controls.Add(this.plainTextBox);
            this.Controls.Add(this.encryptButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox plainTextBox;
        private System.Windows.Forms.TextBox encryptionKeyTextBox;
        private System.Windows.Forms.Label plainTextLabel;
        private System.Windows.Forms.Label encryptionKeyLabel;
        private System.Windows.Forms.TextBox cipherTextBox;
        private System.Windows.Forms.Label cipherTextLabel;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label decryptionKeyLabel;
        private System.Windows.Forms.TextBox decryptionKeyTextBox;
    }
}

