using System.Net.Mail;

namespace SingleResponsibility.WithoutSingleResponsibility
{
    public class Invoice
    {
        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }
        public void AddInvoice()
        {
            try
            {
                // Adding Invoice Logic
                MailMessage mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
                SendInvoiceEmail(mailMessage);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
        public void DeleteInvoice()
        {
            try
            {
                // Deleting Invoice Logic
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            try
            {
                // Sending Invoice Email Logic
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
    }
}
