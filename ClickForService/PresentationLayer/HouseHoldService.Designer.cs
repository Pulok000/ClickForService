
namespace ClickForService.PresentationLayer
{
    partial class HouseHoldService
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
            this.buttonMaid = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMaid
            // 
            this.buttonMaid.Location = new System.Drawing.Point(278, 84);
            this.buttonMaid.Name = "buttonMaid";
            this.buttonMaid.Size = new System.Drawing.Size(197, 44);
            this.buttonMaid.TabIndex = 0;
            this.buttonMaid.Text = "Maid Service";
            this.buttonMaid.UseVisualStyleBackColor = true;
            this.buttonMaid.Click += new System.EventHandler(this.buttonMaid_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "AC Servicing/Repair";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Fridge Servicing/Repair";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Car Servicing/Repair";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(278, 284);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "Computer/Laptop Servicing/Repair";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(278, 334);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 44);
            this.button6.TabIndex = 5;
            this.button6.Text = "Mobile Servicing/Repair";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(574, 394);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(197, 44);
            this.button7.TabIndex = 6;
            this.button7.Text = "Back";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose The Service From Below";
            // 
            // HouseHoldService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonMaid);
            this.Name = "HouseHoldService";
            this.Text = "HouseHoldService";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HouseHoldService_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMaid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
    }
}