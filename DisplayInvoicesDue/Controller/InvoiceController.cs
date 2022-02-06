
using System.Collections.Generic;

using DisplayInvoicesDue.DAL;

namespace DisplayInvoicesDue.Controller
{
    /// <summary>
    /// The controller class deals with the DAL and delegates the work to DAL
    /// </summary>

    public class InvoiceController
    {
        /// <summary>
        /// InvoiceController constructor.
        /// 
        /// </summary>
        public InvoiceController()
        {
            new InvoiceDAL();

        }
        /// <summary>
        /// Get a list of invoces that are due.
        /// </summary>
        /// <returns></returns>
        public List<Invoice> GetInvoicesDue()
        {
            return GetInvoicesDue();
        }

    }
}
