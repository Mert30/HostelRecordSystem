namespace HostelRecordSystem
{
    partial class FrmIncomeAndExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIncomeAndExpense));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxPersonalNo = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.LblPersonalSalary = new System.Windows.Forms.Label();
            this.LblTotalSafe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblBill = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblKitchen = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total amount in the safe:\r\n";
            // 
            // TxtBoxPersonalNo
            // 
            this.TxtBoxPersonalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBoxPersonalNo.Location = new System.Drawing.Point(337, 17);
            this.TxtBoxPersonalNo.Name = "TxtBoxPersonalNo";
            this.TxtBoxPersonalNo.Size = new System.Drawing.Size(190, 34);
            this.TxtBoxPersonalNo.TabIndex = 1;
            this.TxtBoxPersonalNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.Color.Silver;
            this.BtnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCalculate.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCalculate.Location = new System.Drawing.Point(337, 385);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(190, 47);
            this.BtnCalculate.TabIndex = 2;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of personal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(88, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personal Salaries:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(221, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Result:";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblResult.ForeColor = System.Drawing.Color.Transparent;
            this.LblResult.Location = new System.Drawing.Point(398, 319);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(41, 29);
            this.LblResult.TabIndex = 6;
            this.LblResult.Text = "00";
            // 
            // LblPersonalSalary
            // 
            this.LblPersonalSalary.AutoSize = true;
            this.LblPersonalSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPersonalSalary.ForeColor = System.Drawing.Color.Transparent;
            this.LblPersonalSalary.Location = new System.Drawing.Point(399, 124);
            this.LblPersonalSalary.Name = "LblPersonalSalary";
            this.LblPersonalSalary.Size = new System.Drawing.Size(41, 29);
            this.LblPersonalSalary.TabIndex = 9;
            this.LblPersonalSalary.Text = "00";
            // 
            // LblTotalSafe
            // 
            this.LblTotalSafe.AutoSize = true;
            this.LblTotalSafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotalSafe.ForeColor = System.Drawing.Color.Transparent;
            this.LblTotalSafe.Location = new System.Drawing.Point(399, 71);
            this.LblTotalSafe.Name = "LblTotalSafe";
            this.LblTotalSafe.Size = new System.Drawing.Size(41, 29);
            this.LblTotalSafe.TabIndex = 10;
            this.LblTotalSafe.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(244, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bills:";
            // 
            // LblBill
            // 
            this.LblBill.AutoSize = true;
            this.LblBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBill.ForeColor = System.Drawing.Color.Transparent;
            this.LblBill.Location = new System.Drawing.Point(398, 242);
            this.LblBill.Name = "LblBill";
            this.LblBill.Size = new System.Drawing.Size(41, 29);
            this.LblBill.TabIndex = 13;
            this.LblBill.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(526, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "---------------------------------------------------------";
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(12, 372);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(70, 60);
            this.BtnBack.TabIndex = 11;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblKitchen
            // 
            this.LblKitchen.AutoSize = true;
            this.LblKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKitchen.ForeColor = System.Drawing.Color.Transparent;
            this.LblKitchen.Location = new System.Drawing.Point(399, 182);
            this.LblKitchen.Name = "LblKitchen";
            this.LblKitchen.Size = new System.Drawing.Size(41, 29);
            this.LblKitchen.TabIndex = 16;
            this.LblKitchen.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(208, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Kitchen:";
            // 
            // FrmIncomeAndExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(536, 446);
            this.Controls.Add(this.LblKitchen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblBill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LblTotalSafe);
            this.Controls.Add(this.LblPersonalSalary);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TxtBoxPersonalNo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIncomeAndExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income and Expense";
            this.Load += new System.EventHandler(this.FrmIncomeAndExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxPersonalNo;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label LblPersonalSalary;
        private System.Windows.Forms.Label LblTotalSafe;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblKitchen;
        private System.Windows.Forms.Label label9;
    }
}