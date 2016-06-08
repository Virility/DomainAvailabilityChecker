using System.Windows.Forms;

namespace DomainAvailabilityChecker.UI.Forms
{
    public partial class DomainInputDialog : Form
    {
        public string Domain => tbDomain.Text;

        public DomainInputDialog()
        {
            InitializeComponent();
        }

        private void tbDomain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)   
                DialogResult = DialogResult.OK;  
        }
    }
}                 