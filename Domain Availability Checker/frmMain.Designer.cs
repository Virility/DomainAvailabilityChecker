namespace Domain_Availability_Checker
{
    partial class frmMain
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
            this.lblDomains = new System.Windows.Forms.Label();
            this.tbDomainsPath = new System.Windows.Forms.TextBox();
            this.btnDomains = new System.Windows.Forms.Button();
            this.dgvDomains = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomains)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDomains
            // 
            this.lblDomains.AutoSize = true;
            this.lblDomains.Location = new System.Drawing.Point(12, 15);
            this.lblDomains.Name = "lblDomains";
            this.lblDomains.Size = new System.Drawing.Size(51, 13);
            this.lblDomains.TabIndex = 0;
            this.lblDomains.Text = "Domains:";
            // 
            // tbDomainsPath
            // 
            this.tbDomainsPath.Location = new System.Drawing.Point(69, 12);
            this.tbDomainsPath.Name = "tbDomainsPath";
            this.tbDomainsPath.Size = new System.Drawing.Size(484, 20);
            this.tbDomainsPath.TabIndex = 1;
            // 
            // btnDomains
            // 
            this.btnDomains.Location = new System.Drawing.Point(559, 10);
            this.btnDomains.Name = "btnDomains";
            this.btnDomains.Size = new System.Drawing.Size(24, 23);
            this.btnDomains.TabIndex = 2;
            this.btnDomains.Text = "...";
            this.btnDomains.UseVisualStyleBackColor = true;
            this.btnDomains.Click += new System.EventHandler(this.btnDomains_Click);
            // 
            // dgvDomains
            // 
            this.dgvDomains.AllowUserToAddRows = false;
            this.dgvDomains.AllowUserToResizeColumns = false;
            this.dgvDomains.AllowUserToResizeRows = false;
            this.dgvDomains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomains.EnableHeadersVisualStyles = false;
            this.dgvDomains.Location = new System.Drawing.Point(12, 64);
            this.dgvDomains.Name = "dgvDomains";
            this.dgvDomains.RowHeadersVisible = false;
            this.dgvDomains.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDomains.Size = new System.Drawing.Size(571, 294);
            this.dgvDomains.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 370);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dgvDomains);
            this.Controls.Add(this.btnDomains);
            this.Controls.Add(this.tbDomainsPath);
            this.Controls.Add(this.lblDomains);
            this.Name = "frmMain";
            this.Text = "GoDaddy Domain Checker";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomains)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDomains;
        private System.Windows.Forms.TextBox tbDomainsPath;
        private System.Windows.Forms.Button btnDomains;
        private System.Windows.Forms.DataGridView dgvDomains;
        private System.Windows.Forms.Button btnStart;
    }
}

