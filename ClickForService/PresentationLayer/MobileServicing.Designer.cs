namespace ClickForService.PresentationLayer
{
    partial class MobileServicing
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
            this.mobileservcingbackbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mobileservcingbackbutton
            // 
            this.mobileservcingbackbutton.Location = new System.Drawing.Point(417, 447);
            this.mobileservcingbackbutton.Name = "mobileservcingbackbutton";
            this.mobileservcingbackbutton.Size = new System.Drawing.Size(75, 23);
            this.mobileservcingbackbutton.TabIndex = 0;
            this.mobileservcingbackbutton.Text = "Back";
            this.mobileservcingbackbutton.UseVisualStyleBackColor = true;
            this.mobileservcingbackbutton.Click += new System.EventHandler(this.mobileservcingbackbutton_Click);
            // 
            // MobileServicing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 482);
            this.Controls.Add(this.mobileservcingbackbutton);
            this.Name = "MobileServicing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MobileServicing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MobileServicing_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MobileServicing_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mobileservcingbackbutton;
    }
}