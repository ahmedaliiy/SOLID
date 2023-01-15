namespace OpenClosed.WithOpenClosed
{
    public class FinalInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
            => base.GetInvoiceDiscount(amount) - 50;
    }
}
