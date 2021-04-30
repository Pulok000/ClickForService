
namespace ClickForService.PresentationLayer
{
    partial class Profile
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
            this.buttonCPI = new System.Windows.Forms.Button();
            this.buttonCP = new System.Windows.Forms.Button();
            this.buttonSPI = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCPI
            // 
            this.buttonCPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCPI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCPI.Location = new System.Drawing.Point(149, 193);
            this.buttonCPI.Name = "buttonCPI";
            this.buttonCPI.Size = new System.Drawing.Size(184, 96);
            this.buttonCPI.TabIndex = 0;
            this.buttonCPI.Text = "Change Profile Info";
            this.buttonCPI.UseVisualStyleBackColor = false;
            // 
            // buttonCP
            // 
            this.buttonCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCP.Location = new System.Drawing.Point(459, 193);
            this.buttonCP.Name = "buttonCP";
            this.buttonCP.Size = new System.Drawing.Size(207, 98);
            this.buttonCP.TabIndex = 1;
            this.buttonCP.Text = "Change Password";
            this.buttonCP.UseVisualStyleBackColor = false;
            // 
            // buttonSPI
            // 
            this.buttonSPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSPI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSPI.Location = new System.Drawing.Point(303, 40);
            this.buttonSPI.Name = "buttonSPI";
            this.buttonSPI.Size = new System.Drawing.Size(215, 96);
            this.buttonSPI.TabIndex = 2;
            this.buttonSPI.Text = "Show Profile Information";
            this.buttonSPI.UseVisualStyleBackColor = false;
            this.buttonSPI.Click += new System.EventHandler(this.buttonSPI_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(672, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSPI);
            this.Controls.Add(this.buttonCP);
            this.Controls.Add(this.buttonCPI);
            this.Name = "Profile";
            this.Text = "Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profile_FormClosing);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCPI;
        private System.Windows.Forms.Button buttonCP;
        private System.Windows.Forms.Button buttonSPI;
        private System.Windows.Forms.Button button1;
    }
}