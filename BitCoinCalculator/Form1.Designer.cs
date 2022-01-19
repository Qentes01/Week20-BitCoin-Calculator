namespace BitCoinCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyBox = new System.Windows.Forms.ComboBox();
            this.getRatesBtn = new System.Windows.Forms.Button();
            this.amountOfBtc = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.resultbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyBox
            // 
            this.currencyBox.FormattingEnabled = true;
            this.currencyBox.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.currencyBox.Location = new System.Drawing.Point(118, 71);
            this.currencyBox.Name = "currencyBox";
            this.currencyBox.Size = new System.Drawing.Size(139, 23);
            this.currencyBox.TabIndex = 0;
            this.currencyBox.Text = "Select Currency";
            this.currencyBox.SelectedIndexChanged += new System.EventHandler(this.currencyBox_SelectedIndexChanged);
            // 
            // getRatesBtn
            // 
            this.getRatesBtn.Location = new System.Drawing.Point(283, 115);
            this.getRatesBtn.Name = "getRatesBtn";
            this.getRatesBtn.Size = new System.Drawing.Size(75, 23);
            this.getRatesBtn.TabIndex = 1;
            this.getRatesBtn.Text = "Get Rates";
            this.getRatesBtn.UseVisualStyleBackColor = true;
            this.getRatesBtn.Click += new System.EventHandler(this.getRatesBtn_Click);
            // 
            // amountOfBtc
            // 
            this.amountOfBtc.Location = new System.Drawing.Point(118, 115);
            this.amountOfBtc.Name = "amountOfBtc";
            this.amountOfBtc.PlaceholderText = "Amount of Bitcoin";
            this.amountOfBtc.Size = new System.Drawing.Size(139, 23);
            this.amountOfBtc.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(118, 201);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(139, 23);
            this.result.TabIndex = 3;
            this.result.Text = "Result";
            this.result.Visible = false;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // resultbl
            // 
            this.resultbl.AutoSize = true;
            this.resultbl.Location = new System.Drawing.Point(118, 163);
            this.resultbl.Name = "resultbl";
            this.resultbl.Size = new System.Drawing.Size(39, 15);
            this.resultbl.TabIndex = 4;
            this.resultbl.Text = "Result";
            this.resultbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultbl);
            this.Controls.Add(this.result);
            this.Controls.Add(this.amountOfBtc);
            this.Controls.Add(this.getRatesBtn);
            this.Controls.Add(this.currencyBox);
            this.Name = "Form1";
            this.Text = "BitCoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyBox;
        private System.Windows.Forms.Button getRatesBtn;
        private System.Windows.Forms.TextBox amountOfBtc;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label resultbl;
    }
}

