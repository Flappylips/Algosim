
namespace AlgorithmSimulator
{
    partial class Bubblesort
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
            this.BubStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BubStart
            // 
            this.BubStart.Location = new System.Drawing.Point(47, 41);
            this.BubStart.Name = "BubStart";
            this.BubStart.Size = new System.Drawing.Size(187, 61);
            this.BubStart.TabIndex = 0;
            this.BubStart.Text = "button1";
            this.BubStart.UseVisualStyleBackColor = true;
            this.BubStart.Click += new System.EventHandler(this.BubStart_Click);
            // 
            // Bubblesort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BubStart);
            this.Name = "Bubblesort";
            this.Text = "Bubblesort";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BubStart;
    }
}