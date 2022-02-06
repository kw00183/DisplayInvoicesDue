using DisplayInvoicesDue.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DisplayInvoicesDue.View
{
    /// <summary>
    /// class to control form1 object
    /// </summary>
    public partial class Form1 : Form
    {
        #region Data Members

        private readonly InvoiceController invoiceController;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor the generates form1 object
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            invoiceController = new InvoiceController();
        }

        #endregion

        #region Methods

        private void GetAllInvoices()
        {
            ListViewItems(invoiceController.GetAllInvoices());
        }

        private void GetVendorInvoices(int vendorID)
        {
            ListViewItems(invoiceController.GetVendorInvoices(vendorID));
        }

        private void VendorIDTextBox_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        private void ShowInvalidErrorMessage(string message)
        {
            errorMessageLabel.Text = message;
            errorMessageLabel.ForeColor = Color.Red;
        }

        private void ListViewItems(List<Invoice> list)
        {
            List<Invoice> invoiceList;
            try
            {
                lvInvoices.Items.Clear();
                invoiceList = list;
                if (invoiceList.Count > 0)
                {
                    Invoice invoice;
                    for (int i = 0; i < invoiceList.Count; i++)
                    {
                        invoice = invoiceList[i];
                        lvInvoices.Items.Add(invoice.InvoiceNumber);
                        lvInvoices.Items[i].SubItems.Add(invoice.InvoiceDate.ToShortDateString());
                        lvInvoices.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.PaymentTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.CreditTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.BalanceDue().ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.DueDate.ToShortDateString());
                    }
                }
                else
                {
                    ShowInvalidErrorMessage("No Invoices");
                }
            }
            catch (Exception)
            {
                ShowInvalidErrorMessage("");
            }
        }

        private void GetAllInvoicesButton_Click(object sender, EventArgs e)
        {
            vendorIDTextBox.Text = "";
            ShowInvalidErrorMessage("");
            GetAllInvoices();
        }

        private void GetVendorInvoicesButton_Click(object sender, EventArgs e)
        {
            try
            {
                var vendorID = int.Parse(vendorIDTextBox.Text);
                GetVendorInvoices(vendorID);
            }
            catch (Exception)
            {
                ShowInvalidErrorMessage("VendorID must be a number");
            }
        }

        #endregion
    }
}
