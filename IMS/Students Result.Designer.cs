namespace IMS
{
    partial class Students_Result
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
            this.btn_Main_Page = new System.Windows.Forms.Button();
            this.dataGrid_students_result = new System.Windows.Forms.DataGridView();
            this.label_students_result = new System.Windows.Forms.Label();
            this.label_vcw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_students_result)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Main_Page
            // 
            this.btn_Main_Page.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Main_Page.Location = new System.Drawing.Point(557, 505);
            this.btn_Main_Page.Name = "btn_Main_Page";
            this.btn_Main_Page.Size = new System.Drawing.Size(96, 29);
            this.btn_Main_Page.TabIndex = 32;
            this.btn_Main_Page.Text = "Main Page";
            this.btn_Main_Page.UseVisualStyleBackColor = true;
            // 
            // dataGrid_students_result
            // 
            this.dataGrid_students_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_students_result.Location = new System.Drawing.Point(99, 125);
            this.dataGrid_students_result.Name = "dataGrid_students_result";
            this.dataGrid_students_result.Size = new System.Drawing.Size(1013, 331);
            this.dataGrid_students_result.TabIndex = 31;
            // 
            // label_students_result
            // 
            this.label_students_result.AutoSize = true;
            this.label_students_result.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_students_result.Location = new System.Drawing.Point(101, 88);
            this.label_students_result.Name = "label_students_result";
            this.label_students_result.Size = new System.Drawing.Size(140, 23);
            this.label_students_result.TabIndex = 30;
            this.label_students_result.Text = "Students Result";
            // 
            // label_vcw
            // 
            this.label_vcw.AutoSize = true;
            this.label_vcw.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vcw.Location = new System.Drawing.Point(481, 36);
            this.label_vcw.Name = "label_vcw";
            this.label_vcw.Size = new System.Drawing.Size(249, 32);
            this.label_vcw.TabIndex = 29;
            this.label_vcw.Text = "VCW Game Studio";
            // 
            // Students_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 586);
            this.Controls.Add(this.btn_Main_Page);
            this.Controls.Add(this.dataGrid_students_result);
            this.Controls.Add(this.label_students_result);
            this.Controls.Add(this.label_vcw);
            this.Name = "Students_Result";
            this.Text = "Students Result";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_students_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Main_Page;
        private System.Windows.Forms.DataGridView dataGrid_students_result;
        private System.Windows.Forms.Label label_students_result;
        private System.Windows.Forms.Label label_vcw;
    }
}