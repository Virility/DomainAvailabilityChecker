namespace DomainAvailabilityChecker.Core.Models
{
    public class DomainReport
    {
        public string Domain { get; }

        public bool Available { get; }

        public decimal Price { get; }

        public DomainReport(string domain, bool available, decimal price = 0)
        {
            Domain = domain;
            Available = available;
            Price = price;
        }
    }
}            