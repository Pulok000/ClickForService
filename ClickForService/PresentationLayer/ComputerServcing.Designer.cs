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
            this.advancesearchcpmputerservicelabel = new System.Windows.Forms.Label();
            this.computerservcinglistlabel = new System.Windows.Forms.Label();
            this.computerservicingdataGridView = new System.Windows.Forms.DataGridView();
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
            // advancesearchcpmputerservicelabel
            // 
            this.advancesearchcpmputerservicelabel.AutoSize = true;
            this.advancesearchcpmputerservicelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancesearchcpmputerservicelabel.Location = new System.Drawing.Point(20, 176);
            this.advancesearchcpmputerservicelabel.Name = "advancesearchcpmputerservicelabel";
            this.advancesearchcpmputerservicelabel.Size = new System.Drawing.Size(176, 25);
            this.advancesearchcpmputerservicelabel.TabIndex = 7;
            this.advancesearchcpmputerservicelabel.Text = "Advance Search:";
            // 
            // computerservcinglistlabel
            // 
            this.computerservcinglistlabel.AutoSize = true;
            this.computerservcinglistlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerservcinglistlabel.Location = new System.Drawing.Point(162, 18);
            this.computerservcinglistlabel.Name = "computerservcinglistlabel";
            this.computerservcinglistlabel.Size = new System.Drawing.Size(261, 25);
            this.computerservcinglistlabel.TabIndex = 6;
            this.computerservcinglistlabel.Text = "List of All service Provider";
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
            // 
            // ComputerServcing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 480);
            this.Controls.Add(this.advancesearchcpmputerservicelabel);
            this.Controls.Add(this.computerservcinglistlabel);
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
        private System.Windows.Forms.Label advancesearchcpmputerservicelabel;
        private System.Windows.Forms.Label computerservcinglistlabel;
        private System.Windows.Forms.DataGridView computerservicingdataGridView;
    }
}