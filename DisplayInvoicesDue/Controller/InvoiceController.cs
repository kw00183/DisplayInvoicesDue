
using System.Collections.Generic;

using DisplayInvoicesDue.DAL;

namespace DisplayInvoicesDue.Controller
{
    /// <summary>
    /// The controller class deals with the DAL and delegates the work to DAL
    /// </summary>

    public class InvoiceController
    {
        private readonly InvoiceDAL invoiceSource;

        /// <summary>
        /// InvoiceController constructor.
        /// </summary>
        public InvoiceController()
        {
            this.invoiceSource = new InvoiceDAL();

        }
        
        /// <summary>
        /// Get a list of all invoices
        /// </summary>
        /// <returns>all invoices</returns>
        public List<Invoice> GetAllInvoices()
        {
            return this.invoiceSource.GetAllInvoices();
        }

        /// <summary>
        /// Get a list of vendor invoices
        /// </summary>
        /// <returns>vendor invoices</returns>
        public List<Invoice> GetVendorInvoices(int vendorID)
        {
            return this.invoiceSource.GetVendorInvoices(vendorID);
        }
    }
}
