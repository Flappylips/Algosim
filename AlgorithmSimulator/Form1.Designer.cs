
namespace AlgorithmSimulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bubsort = new System.Windows.Forms.Button();
            this.Linear = new System.Windows.Forms.Button();
            this.WelcomeTXT = new System.Windows.Forms.TextBox();
            this.INSTR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Bubsort
            // 
            this.Bubsort.BackColor = System.Drawing.Color.Black;
            this.Bubsort.BackgroundImage = global::AlgorithmSimulator.Properties.Resources.Bubble;
            this.Bubsort.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bubsort.ForeColor = System.Drawing.Color.GreenYellow;
            this.Bubsort.Location = new System.Drawing.Point(60, 126);
            this.Bubsort.Name = "Bubsort";
            this.Bubsort.Size = new System.Drawing.Size(250, 214);
            this.Bubsort.TabIndex = 0;
            this.Bubsort.Text = "Bubble Sort";
            this.Bubsort.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bubsort.UseVisualStyleBackColor = false;
            this.Bubsort.Click += new System.EventHandler(this.Bubsort_Click);
            // 
            // Linear
            // 
            this.Linear.BackColor = System.Drawing.Color.Black;
            this.Linear.BackgroundImage = global::AlgorithmSimulator.Properties.Resources.Searching;
            this.Linear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Linear.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Linear.ForeColor = System.Drawing.Color.LawnGreen;
            this.Linear.Location = new System.Drawing.Point(513, 126);
            this.Linear.Name = "Linear";
            this.Linear.Size = new System.Drawing.Size(250, 214);
            this.Linear.TabIndex = 1;
            this.Linear.Text = "Linear Search";
            this.Linear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Linear.UseVisualStyleBackColor = false;
            this.Linear.Click += new System.EventHandler(this.Linear_Click);
            // 
            // WelcomeTXT
            // 
            this.WelcomeTXT.BackColor = System.Drawing.Color.Black;
            this.WelcomeTXT.CausesValidation = false;
            this.WelcomeTXT.Cursor = System.Windows.Forms.Cursors.Default;
            this.WelcomeTXT.Dock = System.Windows.Forms.DockStyle.Top;
            this.WelcomeTXT.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeTXT.ForeColor = System.Drawing.Color.LawnGreen;
            this.WelcomeTXT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.WelcomeTXT.Location = new System.Drawing.Point(0, 0);
            this.WelcomeTXT.Name = "WelcomeTXT";
            this.WelcomeTXT.ShortcutsEnabled = false;
            this.WelcomeTXT.Size = new System.Drawing.Size(800, 35);
            this.WelcomeTXT.TabIndex = 2;
            this.WelcomeTXT.Text = "WELCOME TO THE ALGORITHM SIMULATOR MKI";
            this.WelcomeTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // INSTR
            // 
            this.INSTR.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.INSTR.BackColor = System.Drawing.Color.Black;
            this.INSTR.CausesValidation = false;
            this.INSTR.Cursor = System.Windows.Forms.Cursors.No;
            this.INSTR.Dock = System.Windows.Forms.DockStyle.Top;
            this.INSTR.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.INSTR.ForeColor = System.Drawing.Color.LawnGreen;
            this.INSTR.Location = new System.Drawing.Point(0, 35);
            this.INSTR.Name = "INSTR";
            this.INSTR.ReadOnly = true;
            this.INSTR.Size = new System.Drawing.Size(800, 29);
            this.INSTR.TabIndex = 3;
            this.INSTR.Text = "Please choose an algorithm to begin";
            this.INSTR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlgorithmSimulator.Properties.Resources.BM2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.INSTR);
            this.Controls.Add(this.WelcomeTXT);
            this.Controls.Add(this.Linear);
            this.Controls.Add(this.Bubsort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bubsort;
        private System.Windows.Forms.Button Linear;
        private System.Windows.Forms.TextBox WelcomeTXT;
        private System.Windows.Forms.TextBox INSTR;
    }
}

