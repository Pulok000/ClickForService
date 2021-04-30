
namespace ClickForService.PresentationLayer
{
    partial class DashboardforAdmin
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
            this.buttonUserList = new System.Windows.Forms.Button();
            this.buttonUC = new System.Windows.Forms.Button();
            this.buttonSPL = new System.Windows.Forms.Button();
            this.buttonUPU = new System.Windows.Forms.Button();
            this.buttonSI = new System.Windows.Forms.Button();
            this.buttonAL = new System.Windows.Forms.Button();
            this.buttonBU = new System.Windows.Forms.Button();
            this.buttonMP = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUserList
            // 
            this.buttonUserList.Location = new System.Drawing.Point(74, 58);
            this.buttonUserList.Name = "buttonUserList";
            this.buttonUserList.Size = new System.Drawing.Size(107, 70);
            this.buttonUserList.TabIndex = 0;
            this.buttonUserList.Text = "User List";
            this.buttonUserList.UseVisualStyleBackColor = true;
            // 
            // buttonUC
            // 
            this.buttonUC.Location = new System.Drawing.Point(417, 58);
            this.buttonUC.Name = "buttonUC";
            this.buttonUC.Size = new System.Drawing.Size(107, 70);
            this.buttonUC.TabIndex = 1;
            this.buttonUC.Text = "User Complain";
            this.buttonUC.UseVisualStyleBackColor = true;
            this.buttonUC.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSPL
            // 
            this.buttonSPL.Location = new System.Drawing.Point(254, 58);
            this.buttonSPL.Name = "buttonSPL";
            this.buttonSPL.Size = new System.Drawing.Size(107, 70);
            this.buttonSPL.TabIndex = 2;
            this.buttonSPL.Text = "Service Provider List";
            this.buttonSPL.UseVisualStyleBackColor = true;
            this.buttonSPL.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonUPU
            // 
            this.buttonUPU.Location = new System.Drawing.Point(572, 58);
            this.buttonUPU.Name = "buttonUPU";
            this.buttonUPU.Size = new System.Drawing.Size(107, 70);
            this.buttonUPU.TabIndex = 3;
            this.buttonUPU.Text = "Users Profile Edit/Update";
            this.buttonUPU.UseVisualStyleBackColor = true;
            // 
            // buttonSI
            // 
            this.buttonSI.Location = new System.Drawing.Point(74, 187);
            this.buttonSI.Name = "buttonSI";
            this.buttonSI.Size = new System.Drawing.Size(107, 70);
            this.buttonSI.TabIndex = 4;
            this.buttonSI.Text = "Subscription Issue";
            this.buttonSI.UseVisualStyleBackColor = true;
            // 
            // buttonAL
            // 
            this.buttonAL.Location = new System.Drawing.Point(254, 187);
            this.buttonAL.Name = "buttonAL";
            this.buttonAL.Size = new System.Drawing.Size(107, 70);
            this.buttonAL.TabIndex = 5;
            this.buttonAL.Text = "Admin\'s List";
            this.buttonAL.UseVisualStyleBackColor = true;
            // 
            // buttonBU
            // 
            this.buttonBU.Location = new System.Drawing.Point(417, 187);
            this.buttonBU.Name = "buttonBU";
            this.buttonBU.Size = new System.Drawing.Size(107, 70);
            this.buttonBU.TabIndex = 6;
            this.buttonBU.Text = "Block User";
            this.buttonBU.UseVisualStyleBackColor = true;
            // 
            // buttonMP
            // 
            this.buttonMP.Location = new System.Drawing.Point(572, 187);
            this.buttonMP.Name = "buttonMP";
            this.buttonMP.Size = new System.Drawing.Size(107, 70);
            this.buttonMP.TabIndex = 7;
            this.buttonMP.Text = "My Profile";
            this.buttonMP.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(685, 345);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 27);
            this.button9.TabIndex = 8;
            this.button9.Text = "Log Out";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // DashboardforAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonMP);
            this.Controls.Add(this.buttonBU);
            this.Controls.Add(this.buttonAL);
            this.Controls.Add(this.buttonSI);
            this.Controls.Add(this.buttonUPU);
            this.Controls.Add(this.buttonSPL);
            this.Controls.Add(this.buttonUC);
            this.Controls.Add(this.buttonUserList);
            this.Name = "DashboardforAdmin";
            this.Text = "DashboardforAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardforAdmin_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUserList;
        private System.Windows.Forms.Button buttonUC;
        private System.Windows.Forms.Button buttonSPL;
        private System.Windows.Forms.Button buttonUPU;
        private System.Windows.Forms.Button buttonSI;
        private System.Windows.Forms.Button buttonAL;
        private System.Windows.Forms.Button buttonBU;
        private System.Windows.Forms.Button buttonMP;
        private System.Windows.Forms.Button button9;
    }
}