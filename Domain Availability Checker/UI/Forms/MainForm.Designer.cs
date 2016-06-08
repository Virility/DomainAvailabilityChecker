namespace DomainAvailabilityChecker.UI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvDomains = new System.Windows.Forms.ListView();
            this.chNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAvailable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsDomains = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckDomains = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDomains.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDomains
            // 
            this.lvDomains.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDomains.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNumber,
            this.ch,
            this.chAvailable,
            this.chPrice});
            this.lvDomains.ContextMenuStrip = this.cmsDomains;
            this.lvDomains.FullRowSelect = true;
            this.lvDomains.Location = new System.Drawing.Point(12, 12);
            this.lvDomains.Name = "lvDomains";
            this.lvDomains.Size = new System.Drawing.Size(443, 244);
            this.lvDomains.TabIndex = 7;
            this.lvDomains.UseCompatibleStateImageBehavior = false;
            this.lvDomains.View = System.Windows.Forms.View.Details;
            // 
            // chNumber
            // 
            this.chNumber.Text = "Number";
            // 
            // ch
            // 
            this.ch.Text = "Domain";
            this.ch.Width = 179;
            // 
            // chAvailable
            // 
            this.chAvailable.Text = "Available";
            this.chAvailable.Width = 97;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            // 
            // cmsDomains
            // 
            this.cmsDomains.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiOpen,
            this.tsmiCheckDomains});
            this.cmsDomains.Name = "cmsDomains";
            this.cmsDomains.Size = new System.Drawing.Size(158, 70);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(157, 22);
            this.tsmiAdd.Text = "Add";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(157, 22);
            this.tsmiOpen.Text = "Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiCheckDomains
            // 
            this.tsmiCheckDomains.Name = "tsmiCheckDomains";
            this.tsmiCheckDomains.Size = new System.Drawing.Size(157, 22);
            this.tsmiCheckDomains.Text = "Check Domains";
            this.tsmiCheckDomains.Click += new System.EventHandler(this.tsmiCheckDomains_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 268);
            this.Controls.Add(this.lvDomains);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "MainForm";
            this.Text = "GoDaddy Domain Availability Checker";
            this.cmsDomains.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvDomains;
        private System.Windows.Forms.ColumnHeader chNumber;
        private System.Windows.Forms.ColumnHeader ch;
        private System.Windows.Forms.ColumnHeader chAvailable;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.ContextMenuStrip cmsDomains;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckDomains;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
    }
}

