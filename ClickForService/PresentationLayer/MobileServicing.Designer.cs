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
            this.mobileadvancesearch = new System.Windows.Forms.Label();
            this.mobileserveiceinglabel = new System.Windows.Forms.Label();
            this.mobileservicingdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mobileservicingdataGridView)).BeginInit();
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
            // mobileadvancesearch
            // 
            this.mobileadvancesearch.AutoSize = true;
            this.mobileadvancesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileadvancesearch.Location = new System.Drawing.Point(12, 167);
            this.mobileadvancesearch.Name = "mobileadvancesearch";
            this.mobileadvancesearch.Size = new System.Drawing.Size(176, 25);
            this.mobileadvancesearch.TabIndex = 10;
            this.mobileadvancesearch.Text = "Advance Search:";
            // 
            // mobileserveiceinglabel
            // 
            this.mobileserveiceinglabel.AutoSize = true;
            this.mobileserveiceinglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileserveiceinglabel.Location = new System.Drawing.Point(154, 9);
            this.mobileserveiceinglabel.Name = "mobileserveiceinglabel";
            this.mobileserveiceinglabel.Size = new System.Drawing.Size(261, 25);
            this.mobileserveiceinglabel.TabIndex = 9;
            this.mobileserveiceinglabel.Text = "List of All service Provider";
            // 
            // mobileservicingdataGridView
            // 
            this.mobileservicingdataGridView.AllowUserToAddRows = false;
            this.mobileservicingdataGridView.AllowUserToDeleteRows = false;
            this.mobileservicingdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mobileservicingdataGridView.Location = new System.Drawing.Point(104, 37);
            this.mobileservicingdataGridView.Name = "mobileservicingdataGridView";
            this.mobileservicingdataGridView.ReadOnly = true;
            this.mobileservicingdataGridView.Size = new System.Drawing.Size(353, 115);
            this.mobileservicingdataGridView.TabIndex = 8;
            // 
            // MobileServicing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 482);
            this.Controls.Add(this.mobileadvancesearch);
            this.Controls.Add(this.mobileserveiceinglabel);
            this.Controls.Add(this.mobileservicingdataGridView);
            this.Controls.Add(this.mobileservcingbackbutton);
            this.Name = "MobileServicing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MobileServicing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MobileServicing_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MobileServicing_FormClosed);
            this.Load += new System.EventHandler(this.MobileServicing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mobileservicingdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mobileservcingbackbutton;
        private System.Windows.Forms.Label mobileadvancesearch;
        private System.Windows.Forms.Label mobileserveiceinglabel;
        private System.Windows.Forms.DataGridView mobileservicingdataGridView;
    }
}