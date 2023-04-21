namespace C_GeckoU.Utility
{
    partial class Notepad
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextEditorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is your game specific notepad where you can store any kind of (modding) info" +
    "rmation in text file from.\r\nChanges are stored to the disk immediately";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(790, 314);
            this.textBox1.TabIndex = 1;
            // 
            // TextEditorButton
            // 
            this.TextEditorButton.Location = new System.Drawing.Point(15, 390);
            this.TextEditorButton.Name = "TextEditorButton";
            this.TextEditorButton.Size = new System.Drawing.Size(790, 42);
            this.TextEditorButton.TabIndex = 2;
            this.TextEditorButton.Text = "Open in System Text Editor";
            this.TextEditorButton.UseVisualStyleBackColor = true;
            this.TextEditorButton.Click += new System.EventHandler(this.TextEditorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notepad file location:";
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextEditorButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Notepad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad   |   Pop-Apple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TextEditorButton;
        private System.Windows.Forms.Label label2;
    }
}