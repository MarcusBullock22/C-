namespace Kore_Bingo_Generator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberInput;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox listBoxNumbers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCalculationResult;
        private System.Windows.Forms.Button btnClearFile;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberInput = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.listBoxNumbers = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCalculationResult = new System.Windows.Forms.Label();
            this.btnClearFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many cards does the customer want?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumberInput
            // 
            this.txtNumberInput.Location = new System.Drawing.Point(352, 6);
            this.txtNumberInput.Name = "txtNumberInput";
            this.txtNumberInput.Size = new System.Drawing.Size(63, 23);
            this.txtNumberInput.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(494, 9);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(156, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate Numbers";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // listBoxNumbers
            // 
            this.listBoxNumbers.FormattingEnabled = true;
            this.listBoxNumbers.ItemHeight = 15;
            this.listBoxNumbers.Location = new System.Drawing.Point(352, 38);
            this.listBoxNumbers.Name = "listBoxNumbers";
            this.listBoxNumbers.Size = new System.Drawing.Size(298, 94);
            this.listBoxNumbers.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(617, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCalculationResult
            // 
            this.lblCalculationResult.AutoSize = true;
            this.lblCalculationResult.BackColor = System.Drawing.Color.Transparent;
            this.lblCalculationResult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalculationResult.Location = new System.Drawing.Point(352, 145);
            this.lblCalculationResult.Name = "lblCalculationResult";
            this.lblCalculationResult.Size = new System.Drawing.Size(149, 19);
            this.lblCalculationResult.TabIndex = 5;
            this.lblCalculationResult.Text = "Calculated Result:";
            // 
            // btnClearFile
            // 
            this.btnClearFile.Location = new System.Drawing.Point(455, 226);
            this.btnClearFile.Name = "btnClearFile";
            this.btnClearFile.Size = new System.Drawing.Size(156, 23);
            this.btnClearFile.TabIndex = 6;
            this.btnClearFile.Text = "Clear Used Numbers";
            this.btnClearFile.UseVisualStyleBackColor = true;
            this.btnClearFile.Click += new System.EventHandler(this.btnClearFile_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(690, 261);
            this.Controls.Add(this.lblCalculationResult);
            this.Controls.Add(this.btnClearFile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listBoxNumbers);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtNumberInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
