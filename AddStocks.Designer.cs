namespace Payroll
{
    partial class AddStocks
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
            this.tbxstockno = new System.Windows.Forms.TextBox();
            this.tbxprice = new System.Windows.Forms.TextBox();
            this.tbxdesc = new System.Windows.Forms.TextBox();
            this.tbxtotal = new System.Windows.Forms.TextBox();
            this.lblstockno = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lbldater = new System.Windows.Forms.Label();
            this.lbldated = new System.Windows.Forms.Label();
            this.dtpr = new System.Windows.Forms.DateTimePicker();
            this.dtpd = new System.Windows.Forms.DateTimePicker();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxstockno
            // 
            this.tbxstockno.Location = new System.Drawing.Point(69, 15);
            this.tbxstockno.Name = "tbxstockno";
            this.tbxstockno.Size = new System.Drawing.Size(100, 20);
            this.tbxstockno.TabIndex = 0;
            // 
            // tbxprice
            // 
            this.tbxprice.Location = new System.Drawing.Point(69, 48);
            this.tbxprice.Name = "tbxprice";
            this.tbxprice.Size = new System.Drawing.Size(100, 20);
            this.tbxprice.TabIndex = 1;
            // 
            // tbxdesc
            // 
            this.tbxdesc.Location = new System.Drawing.Point(69, 86);
            this.tbxdesc.Name = "tbxdesc";
            this.tbxdesc.Size = new System.Drawing.Size(409, 20);
            this.tbxdesc.TabIndex = 2;
            // 
            // tbxtotal
            // 
            this.tbxtotal.Location = new System.Drawing.Point(378, 385);
            this.tbxtotal.Name = "tbxtotal";
            this.tbxtotal.Size = new System.Drawing.Size(100, 20);
            this.tbxtotal.TabIndex = 3;
            // 
            // lblstockno
            // 
            this.lblstockno.AutoSize = true;
            this.lblstockno.Location = new System.Drawing.Point(3, 18);
            this.lblstockno.Name = "lblstockno";
            this.lblstockno.Size = new System.Drawing.Size(55, 13);
            this.lblstockno.TabIndex = 4;
            this.lblstockno.Text = "Stock No.";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(3, 52);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(31, 13);
            this.lblprice.TabIndex = 5;
            this.lblprice.Text = "Price";
            // 
            // lbldater
            // 
            this.lbldater.AutoSize = true;
            this.lbldater.Location = new System.Drawing.Point(294, 15);
            this.lbldater.Name = "lbldater";
            this.lbldater.Size = new System.Drawing.Size(79, 13);
            this.lbldater.TabIndex = 6;
            this.lbldater.Text = "Date Received";
            // 
            // lbldated
            // 
            this.lbldated.AutoSize = true;
            this.lbldated.Location = new System.Drawing.Point(294, 55);
            this.lbldated.Name = "lbldated";
            this.lbldated.Size = new System.Drawing.Size(78, 13);
            this.lbldated.TabIndex = 7;
            this.lbldated.Text = "Date Delivered";
            // 
            // dtpr
            // 
            this.dtpr.CustomFormat = "mm-dd-yyyy";
            this.dtpr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpr.Location = new System.Drawing.Point(376, 12);
            this.dtpr.Name = "dtpr";
            this.dtpr.Size = new System.Drawing.Size(102, 20);
            this.dtpr.TabIndex = 8;
            // 
            // dtpd
            // 
            this.dtpd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpd.Location = new System.Drawing.Point(378, 52);
            this.dtpd.Name = "dtpd";
            this.dtpd.Size = new System.Drawing.Size(100, 20);
            this.dtpd.TabIndex = 9;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Location = new System.Drawing.Point(3, 89);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(60, 13);
            this.lbldescription.TabIndex = 10;
            this.lbldescription.Text = "Description";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(300, 388);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(73, 13);
            this.lbltotal.TabIndex = 11;
            this.lbltotal.Text = "Total Quantity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 217);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(15, 117);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Add Detail";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(97, 117);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 14;
            this.btnedit.Text = "Edit Detail";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(392, 410);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 15;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // AddStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 445);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.dtpd);
            this.Controls.Add(this.dtpr);
            this.Controls.Add(this.lbldated);
            this.Controls.Add(this.lbldater);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblstockno);
            this.Controls.Add(this.tbxtotal);
            this.Controls.Add(this.tbxdesc);
            this.Controls.Add(this.tbxprice);
            this.Controls.Add(this.tbxstockno);
            this.Name = "AddStocks";
            this.Text = "AddStocks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxstockno;
        private System.Windows.Forms.TextBox tbxprice;
        private System.Windows.Forms.TextBox tbxdesc;
        private System.Windows.Forms.TextBox tbxtotal;
        private System.Windows.Forms.Label lblstockno;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lbldater;
        private System.Windows.Forms.Label lbldated;
        private System.Windows.Forms.DateTimePicker dtpr;
        private System.Windows.Forms.DateTimePicker dtpd;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
    }
}