namespace WindowsFormsApp1
{
    partial class ManageInvoices
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.invoicesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicesDataGridView
            // 
            this.invoicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesDataGridView.Location = new System.Drawing.Point(0, 3);
            this.invoicesDataGridView.Name = "invoicesDataGridView";
            this.invoicesDataGridView.RowHeadersWidth = 51;
            this.invoicesDataGridView.RowTemplate.Height = 24;
            this.invoicesDataGridView.Size = new System.Drawing.Size(1315, 548);
            this.invoicesDataGridView.TabIndex = 0;
            // 
            // ManageInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.invoicesDataGridView);
            this.Name = "ManageInvoices";
            this.Size = new System.Drawing.Size(1315, 554);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView invoicesDataGridView;
    }
}
