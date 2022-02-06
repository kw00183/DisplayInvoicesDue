
using System.Collections.Generic;
using DisplayInvoicesDue.DAL;

namespace DisplayInvoicesDue.Controller
{
    /// <summary>
    /// class deals with the DAL and delegates the work to DAL
    /// </summary>
    public class InvoiceController
    {
        #region Data Members
        private readonly InvoiceDAL invoiceSource;

        #endregion

        #region Controllers

        /// <summary>
        /// constructor for the controller
        /// </summary>
        public InvoiceController()
        {
            this.invoiceSource = new InvoiceDAL();

        }

        #endregion

        #region Methods

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

        #endregion
    }
}
