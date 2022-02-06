namespace DisplayInvoicesDue.View
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
            this.lvInvoices = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.getAllInvoicesButton = new System.Windows.Forms.Button();
            this.getVendorInvoicesButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vendorIDLabel = new System.Windows.Forms.Label();
            this.vendorIDTextBox = new System.Windows.Forms.TextBox();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvInvoices
            // 
            this.lvInvoices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvInvoices.Location = new System.Drawing.Point(14, 73);
            this.lvInvoices.Name = "lvInvoices";
            this.lvInvoices.Size = new System.Drawing.Size(642, 214);
            this.lvInvoices.TabIndex = 0;
            this.lvInvoices.UseCompatibleStateImageBehavior = false;
            this.lvInvoices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Invoice Number";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Invoice Date";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Invoice Total";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Payment Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Credit Total";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Balance Due";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Due Date";
            this.columnHeader7.Width = 80;
            // 
            // getAllInvoicesButton
            // 
            this.getAllInvoicesButton.AutoSize = true;
            this.getAllInvoicesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllInvoicesButton.Location = new System.Drawing.Point(191, 298);
            this.getAllInvoicesButton.Name = "getAllInvoicesButton";
            this.getAllInvoicesButton.Size = new System.Drawing.Size(129, 30);
            this.getAllInvoicesButton.TabIndex = 1;
            this.getAllInvoicesButton.Text = "Get All Invoices";
            this.getAllInvoicesButton.UseVisualStyleBackColor = true;
            // 
            // getVendorInvoicesButton
            // 
            this.getVendorInvoicesButton.AutoSize = true;
            this.getVendorInvoicesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getVendorInvoicesButton.Location = new System.Drawing.Point(336, 298);
            this.getVendorInvoicesButton.Name = "getVendorInvoicesButton";
            this.getVendorInvoicesButton.Size = new System.Drawing.Size(146, 30);
            this.getVendorInvoicesButton.TabIndex = 2;
            this.getVendorInvoicesButton.Text = "Get Vendor Invoices";
            this.getVendorInvoicesButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanel1.Controls.Add(this.vendorIDLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.vendorIDTextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.errorMessageLabel, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(151, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(385, 68);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // vendorIDLabel
            // 
            this.vendorIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.vendorIDLabel.AutoSize = true;
            this.vendorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorIDLabel.Location = new System.Drawing.Point(30, 5);
            this.vendorIDLabel.Name = "vendorIDLabel";
            this.vendorIDLabel.Size = new System.Drawing.Size(71, 17);
            this.vendorIDLabel.TabIndex = 0;
            this.vendorIDLabel.Text = "Vendor ID";
            // 
            // vendorIDTextBox
            // 
            this.vendorIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.vendorIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorIDTextBox.Location = new System.Drawing.Point(117, 3);
            this.vendorIDTextBox.Name = "vendorIDTextBox";
            this.vendorIDTextBox.Size = new System.Drawing.Size(265, 23);
            this.vendorIDTextBox.TabIndex = 1;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(239, 28);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(20, 40);
            this.errorMessageLabel.TabIndex = 2;
            this.errorMessageLabel.Text = "   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 340);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.getVendorInvoicesButton);
            this.Controls.Add(this.getAllInvoicesButton);
            this.Controls.Add(this.lvInvoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices by Due Date";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvInvoices;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button getAllInvoicesButton;
        private System.Windows.Forms.Button getVendorInvoicesButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label vendorIDLabel;
        private System.Windows.Forms.TextBox vendorIDTextBox;
        private System.Windows.Forms.Label errorMessageLabel;
    }
}

