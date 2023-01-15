namespace OpenClosed.WithOpenClosed
{
    public class RecurringInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
            => base.GetInvoiceDiscount(amount) - 30;
    }
}
