namespace IMS
{
    partial class Fee_Balances
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
            this.label_time = new System.Windows.Forms.Label();
            this.label_vcw = new System.Windows.Forms.Label();
            this.label_fee_balances = new System.Windows.Forms.Label();
            this.dataGrid_fees_balance = new System.Windows.Forms.DataGridView();
            this.btn_main_page = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_fees_balance)).BeginInit();
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(728, 41);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(47, 21);
            this.label_time.TabIndex = 8;
            this.label_time.Text = "Time";
            // 
            // label_vcw
            // 
            this.label_vcw.AutoSize = true;
            this.label_vcw.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vcw.Location = new System.Drawing.Point(328, 61);
            this.label_vcw.Name = "label_vcw";
            this.label_vcw.Size = new System.Drawing.Size(249, 32);
            this.label_vcw.TabIndex = 7;
            this.label_vcw.Text = "VCW Game Studio";
            // 
            // label_fee_balances
            // 
            this.label_fee_balances.AutoSize = true;
            this.label_fee_balances.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fee_balances.Location = new System.Drawing.Point(100, 160);
            this.label_fee_balances.Name = "label_fee_balances";
            this.label_fee_balances.Size = new System.Drawing.Size(119, 23);
            this.label_fee_balances.TabIndex = 9;
            this.label_fee_balances.Text = "Fee Balances";
            // 
            // dataGrid_fees_balance
            // 
            this.dataGrid_fees_balance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_fees_balance.Location = new System.Drawing.Point(72, 236);
            this.dataGrid_fees_balance.Name = "dataGrid_fees_balance";
            this.dataGrid_fees_balance.Size = new System.Drawing.Size(567, 438);
            this.dataGrid_fees_balance.TabIndex = 10;
            // 
            // btn_main_page
            // 
            this.btn_main_page.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_page.Location = new System.Drawing.Point(289, 708);
            this.btn_main_page.Name = "btn_main_page";
            this.btn_main_page.Size = new System.Drawing.Size(136, 29);
            this.btn_main_page.TabIndex = 11;
            this.btn_main_page.Text = "Main Page";
            this.btn_main_page.UseVisualStyleBackColor = true;
            // 
            // Fee_Balances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 749);
            this.Controls.Add(this.btn_main_page);
            this.Controls.Add(this.dataGrid_fees_balance);
            this.Controls.Add(this.label_fee_balances);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_vcw);
            this.Name = "Fee_Balances";
            this.Text = "Fee Balances";
            this.Load += new System.EventHandler(this.Fee_Balances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_fees_balance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_vcw;
        private System.Windows.Forms.Label label_fee_balances;
        private System.Windows.Forms.DataGridView dataGrid_fees_balance;
        private System.Windows.Forms.Button btn_main_page;
    }
}