using InterfaceSegregation.WithInterfaceSegregation.Interfaces;

namespace InterfaceSegregation.WithInterfaceSegregation.Services
{
    class LiquidInkjetPrinter : IPrinterTasks
    {
        public void Print(string PrintContent)
            => Console.WriteLine("Print Done");
        public void Scan(string ScanContent)
            => Console.WriteLine("Scan content");
    }
}
