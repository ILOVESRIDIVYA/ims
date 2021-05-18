namespace IMS
{
    partial class Fee_Payment_Record
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
            this.dataGrid_fee_payment_record = new System.Windows.Forms.DataGridView();
            this.label_fee_payment_record = new System.Windows.Forms.Label();
            this.label_vcw = new System.Windows.Forms.Label();
            this.btn_main_page = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_fee_payment_record)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_fee_payment_record
            // 
            this.dataGrid_fee_payment_record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_fee_payment_record.Location = new System.Drawing.Point(123, 213);
            this.dataGrid_fee_payment_record.Name = "dataGrid_fee_payment_record";
            this.dataGrid_fee_payment_record.Size = new System.Drawing.Size(764, 438);
            this.dataGrid_fee_payment_record.TabIndex = 13;
            // 
            // label_fee_payment_record
            // 
            this.label_fee_payment_record.AutoSize = true;
            this.label_fee_payment_record.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fee_payment_record.Location = new System.Drawing.Point(415, 137);
            this.label_fee_payment_record.Name = "label_fee_payment_record";
            this.label_fee_payment_record.Size = new System.Drawing.Size(181, 23);
            this.label_fee_payment_record.TabIndex = 12;
            this.label_fee_payment_record.Text = "Fee Payment Record";
            // 
            // label_vcw
            // 
            this.label_vcw.AutoSize = true;
            this.label_vcw.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vcw.Location = new System.Drawing.Point(381, 38);
            this.label_vcw.Name = "label_vcw";
            this.label_vcw.Size = new System.Drawing.Size(249, 32);
            this.label_vcw.TabIndex = 11;
            this.label_vcw.Text = "VCW Game Studio";
            // 
            // btn_main_page
            // 
            this.btn_main_page.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_page.Location = new System.Drawing.Point(437, 708);
            this.btn_main_page.Name = "btn_main_page";
            this.btn_main_page.Size = new System.Drawing.Size(136, 29);
            this.btn_main_page.TabIndex = 14;
            this.btn_main_page.Text = "Main Page";
            this.btn_main_page.UseVisualStyleBackColor = true;
            // 
            // Fee_Payment_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 749);
            this.Controls.Add(this.btn_main_page);
            this.Controls.Add(this.dataGrid_fee_payment_record);
            this.Controls.Add(this.label_fee_payment_record);
            this.Controls.Add(this.label_vcw);
            this.Name = "Fee_Payment_Record";
            this.Text = "Fee Payment Record";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_fee_payment_record)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_fee_payment_record;
        private System.Windows.Forms.Label label_fee_payment_record;
        private System.Windows.Forms.Label label_vcw;
        private System.Windows.Forms.Button btn_main_page;
    }
}