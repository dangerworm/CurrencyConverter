namespace CurrencyConverter
{
    partial class Main
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
            this.BigBox = new System.Windows.Forms.TextBox();
            this.ConvertFromLabel = new System.Windows.Forms.Label();
            this.FromAmountText = new System.Windows.Forms.TextBox();
            this.CurrencyCombo = new System.Windows.Forms.ComboBox();
            this.FromAmountLabel = new System.Windows.Forms.Label();
            this.ConvertToLabel = new System.Windows.Forms.Label();
            this.ToAmountLabel = new System.Windows.Forms.Label();
            this.ToAmountText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BigBox
            // 
            this.BigBox.Location = new System.Drawing.Point(347, 12);
            this.BigBox.Multiline = true;
            this.BigBox.Name = "BigBox";
            this.BigBox.Size = new System.Drawing.Size(441, 426);
            this.BigBox.TabIndex = 0;
            // 
            // ConvertFromLabel
            // 
            this.ConvertFromLabel.AutoSize = true;
            this.ConvertFromLabel.Location = new System.Drawing.Point(12, 12);
            this.ConvertFromLabel.Name = "ConvertFromLabel";
            this.ConvertFromLabel.Size = new System.Drawing.Size(110, 15);
            this.ConvertFromLabel.TabIndex = 1;
            this.ConvertFromLabel.Text = "Convert from Euros";
            // 
            // FromAmountText
            // 
            this.FromAmountText.Location = new System.Drawing.Point(72, 30);
            this.FromAmountText.Name = "FromAmountText";
            this.FromAmountText.Size = new System.Drawing.Size(100, 23);
            this.FromAmountText.TabIndex = 2;
            // 
            // CurrencyCombo
            // 
            this.CurrencyCombo.FormattingEnabled = true;
            this.CurrencyCombo.Location = new System.Drawing.Point(12, 90);
            this.CurrencyCombo.Name = "CurrencyCombo";
            this.CurrencyCombo.Size = new System.Drawing.Size(160, 23);
            this.CurrencyCombo.TabIndex = 3;
            // 
            // FromAmountLabel
            // 
            this.FromAmountLabel.AutoSize = true;
            this.FromAmountLabel.Location = new System.Drawing.Point(12, 33);
            this.FromAmountLabel.Name = "FromAmountLabel";
            this.FromAmountLabel.Size = new System.Drawing.Size(54, 15);
            this.FromAmountLabel.TabIndex = 4;
            this.FromAmountLabel.Text = "Amount:";
            this.FromAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConvertToLabel
            // 
            this.ConvertToLabel.AutoSize = true;
            this.ConvertToLabel.Location = new System.Drawing.Point(12, 72);
            this.ConvertToLabel.Name = "ConvertToLabel";
            this.ConvertToLabel.Size = new System.Drawing.Size(72, 15);
            this.ConvertToLabel.TabIndex = 5;
            this.ConvertToLabel.Text = "Convert to...";
            // 
            // ToAmountLabel
            // 
            this.ToAmountLabel.AutoSize = true;
            this.ToAmountLabel.Location = new System.Drawing.Point(12, 122);
            this.ToAmountLabel.Name = "ToAmountLabel";
            this.ToAmountLabel.Size = new System.Drawing.Size(54, 15);
            this.ToAmountLabel.TabIndex = 7;
            this.ToAmountLabel.Text = "Amount:";
            this.ToAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ToAmountText
            // 
            this.ToAmountText.Location = new System.Drawing.Point(72, 119);
            this.ToAmountText.Name = "ToAmountText";
            this.ToAmountText.Size = new System.Drawing.Size(100, 23);
            this.ToAmountText.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToAmountLabel);
            this.Controls.Add(this.ToAmountText);
            this.Controls.Add(this.ConvertToLabel);
            this.Controls.Add(this.FromAmountLabel);
            this.Controls.Add(this.CurrencyCombo);
            this.Controls.Add(this.FromAmountText);
            this.Controls.Add(this.ConvertFromLabel);
            this.Controls.Add(this.BigBox);
            this.Name = "Main";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox BigBox;
        private Label ConvertFromLabel;
        private TextBox FromAmountText;
        private ComboBox CurrencyCombo;
        private Label FromAmountLabel;
        private Label ConvertToLabel;
        private Label ToAmountLabel;
        private TextBox ToAmountText;
    }
}