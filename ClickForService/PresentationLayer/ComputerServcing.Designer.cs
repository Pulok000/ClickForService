namespace ClickForService.PresentationLayer
{
    partial class ComputerServcing
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
            this.computerservicingdataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Registerformbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.computerservicingdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mobileservcingbackbutton
            // 
            this.mobileservcingbackbutton.Location = new System.Drawing.Point(457, 445);
            this.mobileservcingbackbutton.Name = "mobileservcingbackbutton";
            this.mobileservcingbackbutton.Size = new System.Drawing.Size(75, 23);
            this.mobileservcingbackbutton.TabIndex = 0;
            this.mobileservcingbackbutton.Text = "Back";
            this.mobileservcingbackbutton.UseVisualStyleBackColor = true;
            this.mobileservcingbackbutton.Click += new System.EventHandler(this.mobileservcingbackbutton_Click);
            // 
            // computerservicingdataGridView
            // 
            this.computerservicingdataGridView.AllowUserToAddRows = false;
            this.computerservicingdataGridView.AllowUserToDeleteRows = false;
            this.computerservicingdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computerservicingdataGridView.Location = new System.Drawing.Point(112, 46);
            this.computerservicingdataGridView.Name = "computerservicingdataGridView";
            this.computerservicingdataGridView.ReadOnly = true;
            this.computerservicingdataGridView.Size = new System.Drawing.Size(353, 115);
            this.computerservicingdataGridView.TabIndex = 5;
            this.computerservicingdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.computerservicingdataGridView_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(155, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 25);
            this.label7.TabIndex = 175;
            this.label7.Text = "List of service Provider";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(29, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 176;
            this.label1.Text = "Advance Search:";
            // 
            // Registerformbutton
            // 
            this.Registerformbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Registerformbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Registerformbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerformbutton.Location = new System.Drawing.Point(222, 412);
            this.Registerformbutton.Name = "Registerformbutton";
            this.Registerformbutton.Size = new System.Drawing.Size(94, 27);
            this.Registerformbutton.TabIndex = 177;
            this.Registerformbutton.Text = "Search";
            this.Registerformbutton.UseVisualStyleBackColor = false;
            // 
            // ComputerServcing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 480);
            this.Controls.Add(this.Registerformbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.computerservicingdataGridView);
            this.Controls.Add(this.mobileservcingbackbutton);
            this.Name = "ComputerServcing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComputerServcing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComputerServcing_FormClosing);
            this.Load += new System.EventHandler(this.ComputerServcing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerservicingdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mobileservcingbackbutton;
        private System.Windows.Forms.DataGridView computerservicingdataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Registerformbutton;
    }
}