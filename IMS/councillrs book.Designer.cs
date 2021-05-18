namespace IMS
{
    partial class councillrs_book
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_councillors_book = new System.Windows.Forms.Label();
            this.dataGrid_councillors_book = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_councillors_book)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_councillors_book);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 81);
            this.panel1.TabIndex = 0;
            // 
            // label_councillors_book
            // 
            this.label_councillors_book.AutoSize = true;
            this.label_councillors_book.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_councillors_book.Location = new System.Drawing.Point(150, 24);
            this.label_councillors_book.Name = "label_councillors_book";
            this.label_councillors_book.Size = new System.Drawing.Size(236, 32);
            this.label_councillors_book.TabIndex = 4;
            this.label_councillors_book.Text = "Councillor`s Book";
            // 
            // dataGrid_councillors_book
            // 
            this.dataGrid_councillors_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_councillors_book.Location = new System.Drawing.Point(13, 94);
            this.dataGrid_councillors_book.Name = "dataGrid_councillors_book";
            this.dataGrid_councillors_book.Size = new System.Drawing.Size(524, 564);
            this.dataGrid_councillors_book.TabIndex = 1;
            // 
            // councillrs_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 681);
            this.Controls.Add(this.dataGrid_councillors_book);
            this.Controls.Add(this.panel1);
            this.Name = "councillrs_book";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_councillors_book)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_councillors_book;
        private System.Windows.Forms.DataGridView dataGrid_councillors_book;
    }
}