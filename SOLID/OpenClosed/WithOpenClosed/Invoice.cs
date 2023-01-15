namespace OpenClosed.WithOpenClosed
{
    public class Invoice
    {
        public virtual double GetInvoiceDiscount(double amount)
            => amount - 10;
    }
}
