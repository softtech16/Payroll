namespace Payroll
{
    partial class Main
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
            this.btnaddstocks = new System.Windows.Forms.Button();
            this.btnpayroll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnaddstocks
            // 
            this.btnaddstocks.Location = new System.Drawing.Point(101, 50);
            this.btnaddstocks.Name = "btnaddstocks";
            this.btnaddstocks.Size = new System.Drawing.Size(75, 23);
            this.btnaddstocks.TabIndex = 0;
            this.btnaddstocks.Text = "Add Stocks";
            this.btnaddstocks.UseVisualStyleBackColor = true;
            this.btnaddstocks.Click += new System.EventHandler(this.btnaddstocks_Click);
            // 
            // btnpayroll
            // 
            this.btnpayroll.Location = new System.Drawing.Point(101, 124);
            this.btnpayroll.Name = "btnpayroll";
            this.btnpayroll.Size = new System.Drawing.Size(75, 23);
            this.btnpayroll.TabIndex = 1;
            this.btnpayroll.Text = "Payroll";
            this.btnpayroll.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnpayroll);
            this.Controls.Add(this.btnaddstocks);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnaddstocks;
        private System.Windows.Forms.Button btnpayroll;
    }
}

