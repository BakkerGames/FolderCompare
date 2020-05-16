namespace FolderCompare
{
    partial class FormMain
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
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.textBoxFromPath = new System.Windows.Forms.TextBox();
            this.textBoxToPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMain
            // 
            this.listBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.Location = new System.Drawing.Point(12, 50);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(776, 355);
            this.listBoxMain.TabIndex = 0;
            // 
            // textBoxFromPath
            // 
            this.textBoxFromPath.Location = new System.Drawing.Point(12, 12);
            this.textBoxFromPath.Name = "textBoxFromPath";
            this.textBoxFromPath.Size = new System.Drawing.Size(361, 20);
            this.textBoxFromPath.TabIndex = 1;
            // 
            // textBoxToPath
            // 
            this.textBoxToPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxToPath.Location = new System.Drawing.Point(427, 12);
            this.textBoxToPath.Name = "textBoxToPath";
            this.textBoxToPath.Size = new System.Drawing.Size(361, 20);
            this.textBoxToPath.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(13, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCompare
            // 
            this.buttonCompare.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCompare.Location = new System.Drawing.Point(376, 415);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(75, 23);
            this.buttonCompare.TabIndex = 4;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(713, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxToPath);
            this.Controls.Add(this.textBoxFromPath);
            this.Controls.Add(this.listBoxMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Compare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.TextBox textBoxFromPath;
        private System.Windows.Forms.TextBox textBoxToPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.Button button3;
    }
}

