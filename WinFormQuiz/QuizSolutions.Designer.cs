namespace WinFormQuiz
{
    partial class QuizSolutions
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
            this.gridView_results = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_results)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView_results
            // 
            this.gridView_results.AllowUserToAddRows = false;
            this.gridView_results.AllowUserToDeleteRows = false;
            this.gridView_results.AllowUserToResizeRows = false;
            this.gridView_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView_results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridView_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_results.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridView_results.Location = new System.Drawing.Point(12, 12);
            this.gridView_results.Name = "gridView_results";
            this.gridView_results.RowHeadersVisible = false;
            this.gridView_results.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridView_results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridView_results.Size = new System.Drawing.Size(776, 426);
            this.gridView_results.TabIndex = 12;
            // 
            // QuizSolutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridView_results);
            this.Name = "QuizSolutions";
            this.Text = "QuizSolutions";
            this.Load += new System.EventHandler(this.QuizSolutions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView_results;
    }
}