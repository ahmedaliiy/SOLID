namespace OpenClosed.WithOpenClosed
{
    public class ProposedInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
            => base.GetInvoiceDiscount(amount) - 40;
    }
}
