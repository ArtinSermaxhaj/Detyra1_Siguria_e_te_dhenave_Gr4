
namespace TapCodeAlgorithm1
{
    partial class TapCode
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
            this.plainTextLabel = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.cipherTextLabel = new System.Windows.Forms.Label();
            this.txtCipherText = new System.Windows.Forms.TextBox();
            this.decryptedTextLabel = new System.Windows.Forms.Label();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.btnEnkripto = new System.Windows.Forms.Button();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plainTextLabel
            // 
            this.plainTextLabel.AutoSize = true;
            this.plainTextLabel.Location = new System.Drawing.Point(36, 25);
            this.plainTextLabel.Name = "plainTextLabel";
            this.plainTextLabel.Size = new System.Drawing.Size(51, 13);
            this.plainTextLabel.TabIndex = 0;
            this.plainTextLabel.Text = "PlainText";
            // 
            // txtPlainText
            // 
            this.txtPlainText.AccessibleName = "";
            this.txtPlainText.Location = new System.Drawing.Point(35, 50);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(351, 20);
            this.txtPlainText.TabIndex = 1;
            // 
            // cipherTextLabel
            // 
            this.cipherTextLabel.AutoSize = true;
            this.cipherTextLabel.Location = new System.Drawing.Point(36, 93);
            this.cipherTextLabel.Name = "cipherTextLabel";
            this.cipherTextLabel.Size = new System.Drawing.Size(58, 13);
            this.cipherTextLabel.TabIndex = 2;
            this.cipherTextLabel.Text = "CipherText";
            // 
            // txtCipherText
            // 
            this.txtCipherText.AccessibleName = "";
            this.txtCipherText.Location = new System.Drawing.Point(35, 125);
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.Size = new System.Drawing.Size(427, 20);
            this.txtCipherText.TabIndex = 3;
            // 
            // decryptedTextLabel
            // 
            this.decryptedTextLabel.AutoSize = true;
            this.decryptedTextLabel.Location = new System.Drawing.Point(32, 196);
            this.decryptedTextLabel.Name = "decryptedTextLabel";
            this.decryptedTextLabel.Size = new System.Drawing.Size(77, 13);
            this.decryptedTextLabel.TabIndex = 4;
            this.decryptedTextLabel.Text = "DecryptedText";
            this.decryptedTextLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.AccessibleName = "";
            this.txtDecryptedText.Location = new System.Drawing.Point(35, 242);
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.Size = new System.Drawing.Size(427, 20);
            this.txtDecryptedText.TabIndex = 5;
            // 
            // btnEnkripto
            // 
            this.btnEnkripto.AccessibleName = "";
            this.btnEnkripto.Location = new System.Drawing.Point(560, 121);
            this.btnEnkripto.Name = "btnEnkripto";
            this.btnEnkripto.Size = new System.Drawing.Size(123, 21);
            this.btnEnkripto.TabIndex = 6;
            this.btnEnkripto.Text = "Enkripto";
            this.btnEnkripto.UseVisualStyleBackColor = true;
            this.btnEnkripto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDekripto
            // 
            this.btnDekripto.Location = new System.Drawing.Point(560, 160);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(121, 24);
            this.btnDekripto.TabIndex = 7;
            this.btnDekripto.Text = "Dekripto";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // TapCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.btnEnkripto);
            this.Controls.Add(this.txtDecryptedText);
            this.Controls.Add(this.decryptedTextLabel);
            this.Controls.Add(this.txtCipherText);
            this.Controls.Add(this.cipherTextLabel);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.plainTextLabel);
            this.Name = "TapCode";
            this.Text = "TapCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label plainTextLabel;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Label cipherTextLabel;
        private System.Windows.Forms.TextBox txtCipherText;
        private System.Windows.Forms.Label decryptedTextLabel;
        private System.Windows.Forms.TextBox txtDecryptedText;
        private System.Windows.Forms.Button btnEnkripto;
        private System.Windows.Forms.Button btnDekripto;
    }
}

