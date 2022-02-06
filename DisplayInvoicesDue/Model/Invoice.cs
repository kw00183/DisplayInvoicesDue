using System;
using System.Collections.Generic;

namespace DisplayInvoicesDue
{
    /// <summary>
    /// class to create Invoice object
    /// </summary>
    public class Invoice
    {
        #region Data Members

        private string invoiceNumber;
        private DateTime invoiceDate;
        private decimal invoiceTotal;
        private decimal paymentTotal;
        private decimal creditTotal;
        private DateTime dueDate;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor for Invoice object
        /// </summary>
        public Invoice()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// getter and setter for Invoice Number
        /// </summary>
        public string InvoiceNumber
        {
            get
            {
                return invoiceNumber;
            }
            set
            {
                invoiceNumber = value;
            }
        }

        /// <summary>
        /// getter and setter for Invoice Date
        /// </summary>
        public DateTime InvoiceDate
        {
            get
            {
                return invoiceDate;
            }
            set
            {
                invoiceDate = value;
            }
        }

        /// <summary>
        /// getter and setter for Invoice Total
        /// </summary>
        public decimal InvoiceTotal
        {
            get
            {
                return invoiceTotal;
            }
            set
            {
                invoiceTotal = value;
            }
        }

        /// <summary>
        /// getter and setter for Payment Total
        /// </summary>
        public decimal PaymentTotal
        {
            get
            {
                return paymentTotal;
            }
            set
            {
                paymentTotal = value;
            }
        }

        /// <summary>
        /// getter and setter for Credit Total
        /// </summary>
        public decimal CreditTotal
        {
            get
            {
                return creditTotal;
            }
            set
            {
                creditTotal = value;
            }
        }

        /// <summary>
        /// getter and setter for Due Date
        /// </summary>
        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }

        /// <summary>
        /// method to return Balance Due on Invoice
        /// </summary>
        public decimal BalanceDue()
        {
            return invoiceTotal - paymentTotal - creditTotal;
        }

        #endregion
    }
}
