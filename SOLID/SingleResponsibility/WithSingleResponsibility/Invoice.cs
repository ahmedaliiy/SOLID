using SingleResponsibility.WithSingleResponsibility.Interfaces;
using SingleResponsibility.WithSingleResponsibility.Services;

namespace SingleResponsibility.WithSingleResponsibility
{
    public class Invoice
    {
        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }

        private ILogger fileLogger;
        private MailSender emailSender;

        public Invoice()
        {
            fileLogger = new Logger();
            emailSender = new MailSender();
        }

        public void AddInvoice()
        {
            try
            {
                fileLogger.Info("Add method Start");

                // Adding Invoice Logic

                emailSender.EMailFrom = "emailfrom@xyz.com";
                emailSender.EMailTo = "emailto@xyz.com";
                emailSender.EMailSubject = "Single Responsibility Princile";
                emailSender.EMailBody = "A class should have only one reason to change";
                emailSender.SendEmail();
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error Occurred while Generating Invoice", ex);
            }
        }
        public void DeleteInvoice()
        {
            try
            {
                // Deleting Invoice Logic
                fileLogger.Info("Delete Invoice Start at @" + DateTime.Now);
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error Occurred while Deleting Invoice", ex);
            }
        }
    }
}
