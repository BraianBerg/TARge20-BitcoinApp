
namespace BTCapp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Currencyselect = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTCAmmounttxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.Resulttxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Currencyselect
            // 
            this.Currencyselect.FormattingEnabled = true;
            this.Currencyselect.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.Currencyselect.Location = new System.Drawing.Point(117, 137);
            this.Currencyselect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Currencyselect.Name = "Currencyselect";
            this.Currencyselect.Size = new System.Drawing.Size(160, 24);
            this.Currencyselect.TabIndex = 0;
            this.Currencyselect.Text = "Select Currency";
            this.Currencyselect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Tag = "Get Rates";
            this.button1.Text = "Get Rates";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTCAmmounttxtbox
            // 
            this.BTCAmmounttxtbox.Location = new System.Drawing.Point(117, 209);
            this.BTCAmmounttxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTCAmmounttxtbox.Name = "BTCAmmounttxtbox";
            this.BTCAmmounttxtbox.Size = new System.Drawing.Size(160, 22);
            this.BTCAmmounttxtbox.TabIndex = 2;
            this.BTCAmmounttxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(113, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "BTC Ammount";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultLabel.Location = new System.Drawing.Point(113, 357);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(48, 17);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result";
            this.resultLabel.Visible = false;
            this.resultLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Resulttxtbox
            // 
            this.Resulttxtbox.Location = new System.Drawing.Point(117, 377);
            this.Resulttxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Resulttxtbox.Name = "Resulttxtbox";
            this.Resulttxtbox.Size = new System.Drawing.Size(132, 22);
            this.Resulttxtbox.TabIndex = 5;
            this.Resulttxtbox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Resulttxtbox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTCAmmounttxtbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Currencyselect);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Bitcoin Calcualtor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Currencyselect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BTCAmmounttxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox Resulttxtbox;
    }
}

