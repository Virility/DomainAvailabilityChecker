using System.Globalization;
using DomainAvailabilityChecker.Core.Models;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace DomainAvailabilityChecker.UI.Controls
{
    public class DomainViewItem : ListViewItem
    {
        public string Domain { get; }

        private DomainReport _lastDomainReport;
        public DomainReport LastDomainReport
        {
            get
            {
                return _lastDomainReport;
            }
            set
            {
                _lastDomainReport = value;
                InvalidateDomainReport(value);
            }
        }

        public DomainViewItem(int number, string domain)
        {
            Domain = domain;

            Text = number.ToString();
            SubItems.AddRange(new []
            {          
                domain,
                "Not Checked",
                "-"
            });
        }

        public void InvalidateDomainReport(DomainReport domainReport)
        {
            SubItems[2].Text = domainReport.Available.ToString();

            if (domainReport.Available)
                SubItems[3].Text = domainReport.Price.ToString(CultureInfo.InvariantCulture);  
        }
    }
}