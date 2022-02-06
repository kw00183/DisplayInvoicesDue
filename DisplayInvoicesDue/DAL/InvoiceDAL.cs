using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DisplayInvoicesDue.DAL
{
    public class InvoiceDAL
    {
        public static List<Invoice> GetInvoicesDue()
        {
            List<Invoice> invoiceList = new List<Invoice>();
            SqlConnection connection = PayablesDBConnection.GetConnection();
            string selectStatement =
                "SELECT InvoiceNumber, InvoiceDate, InvoiceTotal, " +
                "PaymentTotal, CreditTotal, DueDate " +
                "FROM Invoices " +
                "WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0 " +
                "ORDER BY DueDate";
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
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return invoiceList;
        }
    }
}
