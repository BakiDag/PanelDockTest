
namespace PanelDockTest
{
    partial class Form2
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
            this.Form2label2 = new System.Windows.Forms.Label();
            this.Form2label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Form2label2
            // 
            this.Form2label2.AutoSize = true;
            this.Form2label2.Location = new System.Drawing.Point(35, 68);
            this.Form2label2.Name = "Form2label2";
            this.Form2label2.Size = new System.Drawing.Size(45, 13);
            this.Form2label2.TabIndex = 1;
            this.Form2label2.Text = "Y Coord";
            // 
            // Form2label1
            // 
            this.Form2label1.AutoSize = true;
            this.Form2label1.Location = new System.Drawing.Point(32, 28);
            this.Form2label1.Name = "Form2label1";
            this.Form2label1.Size = new System.Drawing.Size(45, 13);
            this.Form2label1.TabIndex = 0;
            this.Form2label1.Text = "X Coord";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 217);
            this.ControlBox = false;
            this.Controls.Add(this.Form2label2);
            this.Controls.Add(this.Form2label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Form2label2;
        private System.Windows.Forms.Label Form2label1;
    }
}