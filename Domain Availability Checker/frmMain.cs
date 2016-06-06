using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.Threading;

namespace Domain_Availability_Checker
{
    public partial class frmMain : Form
    {
        private BindingList<Domain> domainsBind;

        public frmMain()
        {
            InitializeComponent();

            domainsBind = new BindingList<Domain>();
            dgvDomains.DataSource = domainsBind;

            dgvDomains.Columns[0].Width = 60;
            dgvDomains.Columns[1].Width = 300;
            dgvDomains.Columns[2].Width = 80;
            dgvDomains.Columns[3].Width = 80;
        }

        private void btnDomains_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { RestoreDirectory = true })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    domainsBind.Clear();
                    tbDomainsPath.Text = dialog.FileName;
                    using (StreamReader reader = new StreamReader(dialog.FileName))
                    {
                        while (!reader.EndOfStream)
                        {
                            string domain = reader.ReadLine();
                            domainsBind.Add(new Domain(dgvDomains.Rows.Count + 1, domain, "-"));
                        }
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Task t = new Task(() =>
            {
                for (int i = 0; i < domainsBind.Count; i++)
                {
                    Domain domain = domainsBind[i];
                    domain.Check();
                    domainsBind[i] = domain;
                }
            });
            t.Start();
        }
    }
}
