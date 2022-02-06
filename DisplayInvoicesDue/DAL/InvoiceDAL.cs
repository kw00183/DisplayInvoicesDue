using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DisplayInvoicesDue.DAL
{
    /// <summary>
    /// class for the data layer
    /// </summary>
    public class InvoiceDAL
    {
        #region Methods

        /// <summary>
        /// method used to control the sql query and return all invoices
        /// </summary>
        /// <returns>list of all invoices</returns>
        public List<Invoice> GetAllInvoices()
        {
            string selectStatement =
                "SELECT InvoiceNumber, InvoiceDate, InvoiceTotal, " +
                "PaymentTotal, CreditTotal, DueDate " +
                "FROM Invoices " +
                "ORDER BY InvoiceNumber";
            return ProcessList(selectStatement);
        }

        /// <summary>
        /// method used to control the sql query and return vendor invoices
        /// </summary>
        /// <returns>list of vendor invoices</returns>
        public List<Invoice> GetVendorInvoices(int vendorID)
        {
            string selectStatement =
                "SELECT InvoiceNumber, InvoiceDate, InvoiceTotal, " +
                "PaymentTotal, CreditTotal, DueDate " +
                "FROM Invoices " +
                "WHERE VendorID = " + vendorID + " " +
                "ORDER BY InvoiceNumber";
            return ProcessList(selectStatement);
        }

        private static List<Invoice> ProcessList(string sql)
        {
            List<Invoice> invoiceList = new List<Invoice>();
            SqlConnection connection = PayablesDBConnection.GetConnection();
            string selectStatement = sql;
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Invoice invoice = new Invoice
                    {
                        InvoiceNumber = reader["InvoiceNumber"].ToString(),
                        InvoiceDate = (DateTime)reader["InvoiceDate"],
                        InvoiceTotal = (decimal)reader["InvoiceTotal"],
                        PaymentTotal = (decimal)reader["PaymentTotal"],
                        CreditTotal = (decimal)reader["CreditTotal"],
                        DueDate = (DateTime)reader["DueDate"]
                    };
                    invoiceList.Add(invoice);
                }
                reader.Close();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return invoiceList;
        }

        #endregion
    }
}
