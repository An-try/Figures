namespace Figures
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
            this.GenerateFiguresButton = new System.Windows.Forms.Button();
            this.OutputInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateFiguresButton
            // 
            this.GenerateFiguresButton.Location = new System.Drawing.Point(12, 12);
            this.GenerateFiguresButton.Name = "GenerateFiguresButton";
            this.GenerateFiguresButton.Size = new System.Drawing.Size(272, 30);
            this.GenerateFiguresButton.TabIndex = 0;
            this.GenerateFiguresButton.Text = "Generate figures";
            this.GenerateFiguresButton.UseVisualStyleBackColor = true;
            this.GenerateFiguresButton.Click += new System.EventHandler(this.GenerateFiguresButton_Click);
            // 
            // OutputInfo
            // 
            this.OutputInfo.AllowDrop = true;
            this.OutputInfo.Location = new System.Drawing.Point(12, 49);
            this.OutputInfo.Name = "OutputInfo";
            this.OutputInfo.Size = new System.Drawing.Size(272, 684);
            this.OutputInfo.TabIndex = 1;
            this.OutputInfo.Text = "OutputInfo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.OutputInfo);
            this.Controls.Add(this.GenerateFiguresButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateFiguresButton;
        private System.Windows.Forms.Label OutputInfo;
    }
}

