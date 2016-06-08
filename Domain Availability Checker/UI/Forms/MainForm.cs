using System;
using System.Collections.Generic;
using System.IO;     
using System.Threading.Tasks;
using System.Windows.Forms;                   
using DomainAvailabilityChecker.Core.Providers;
using DomainAvailabilityChecker.UI.Controls;

namespace DomainAvailabilityChecker.UI.Forms
{
    public partial class MainForm : Form
    {
        private readonly GodaddyProvider _godaddyProvider;       

        public MainForm()
        {
            InitializeComponent();
            _godaddyProvider = new GodaddyProvider();              
        }
                
        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            using (var dialog = new DomainInputDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    lvDomains.Items.Add(new DomainViewItem(lvDomains.Items.Count + 1, dialog.Domain));
            }
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                var items = new List<DomainViewItem>();
                using (var reader = new StreamReader(dialog.FileName))
                {
                    while (!reader.EndOfStream)
                        items.Add(new DomainViewItem(items.Count + 1, reader.ReadLine()));
                }
                lvDomains.Items.AddRange(items.ToArray());
            }
        }
            
        private async void tsmiCheckDomains_Click(object sender, EventArgs e)
        {
            var tasks = new List<Task>();
            foreach (DomainViewItem item in lvDomains.Items)
            {
                var task = Task.Run(async () =>
                {
                    var report = await _godaddyProvider.GetDomainReport(item.Domain);
                    Invoke(new Action(() => { item.LastDomainReport = report; }));
                });       
                tasks.Add(task);
            }           
            await Task.WhenAll(tasks);                                                      
        }    
    }
}
