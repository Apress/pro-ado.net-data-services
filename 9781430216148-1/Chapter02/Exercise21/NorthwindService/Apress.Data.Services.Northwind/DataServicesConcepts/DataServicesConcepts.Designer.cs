namespace DataServicesConcepts
{
    partial class frmDataServicesConcepts
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
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.queryOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filteringDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logicalOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filteringDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mathToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.expandingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metaDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerNotInContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedConceptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concurrenctToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherConceptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lazyLoadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asyncLoadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(7, 27);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(818, 628);
            this.txtResponse.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryOperationsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cRUDOperationsToolStripMenuItem,
            this.advancedConceptsToolStripMenuItem,
            this.otherConceptsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // queryOperationsToolStripMenuItem
            // 
            this.queryOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filteringDataToolStripMenuItem,
            this.sortingToolStripMenuItem,
            this.pagingToolStripMenuItem,
            this.expandingToolStripMenuItem,
            this.metaDataToolStripMenuItem});
            this.queryOperationsToolStripMenuItem.Name = "queryOperationsToolStripMenuItem";
            this.queryOperationsToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.queryOperationsToolStripMenuItem.Text = "LINQ Query Operations";
            // 
            // filteringDataToolStripMenuItem
            // 
            this.filteringDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logicalOperationToolStripMenuItem,
            this.stringOperationToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.mathToolStripMenuItem,
            this.typeToolStripMenuItem});
            this.filteringDataToolStripMenuItem.Name = "filteringDataToolStripMenuItem";
            this.filteringDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filteringDataToolStripMenuItem.Text = "Filtering Data";
            // 
            // logicalOperationToolStripMenuItem
            // 
            this.logicalOperationToolStripMenuItem.Name = "logicalOperationToolStripMenuItem";
            this.logicalOperationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logicalOperationToolStripMenuItem.Text = "Logical";
            this.logicalOperationToolStripMenuItem.Click += new System.EventHandler(this.logicalOperationToolStripMenuItem_Click);
            // 
            // stringOperationToolStripMenuItem
            // 
            this.stringOperationToolStripMenuItem.Name = "stringOperationToolStripMenuItem";
            this.stringOperationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stringOperationToolStripMenuItem.Text = "String";
            this.stringOperationToolStripMenuItem.Click += new System.EventHandler(this.stringOperationToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dateToolStripMenuItem.Text = "Date ";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // mathToolStripMenuItem
            // 
            this.mathToolStripMenuItem.Name = "mathToolStripMenuItem";
            this.mathToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mathToolStripMenuItem.Text = "Math";
            this.mathToolStripMenuItem.Click += new System.EventHandler(this.mathToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.typeToolStripMenuItem.Text = "Type";
            this.typeToolStripMenuItem.Click += new System.EventHandler(this.typeToolStripMenuItem_Click);
            // 
            // sortingToolStripMenuItem
            // 
            this.sortingToolStripMenuItem.Name = "sortingToolStripMenuItem";
            this.sortingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sortingToolStripMenuItem.Text = "Sorting";
            this.sortingToolStripMenuItem.Click += new System.EventHandler(this.sortingToolStripMenuItem_Click);
            // 
            // pagingToolStripMenuItem
            // 
            this.pagingToolStripMenuItem.Name = "pagingToolStripMenuItem";
            this.pagingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pagingToolStripMenuItem.Text = "Paging";
            this.pagingToolStripMenuItem.Click += new System.EventHandler(this.pagingToolStripMenuItem_Click);
            // 
            // expandingToolStripMenuItem
            // 
            this.expandingToolStripMenuItem.Name = "expandingToolStripMenuItem";
            this.expandingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.expandingToolStripMenuItem.Text = "Expanding";
            this.expandingToolStripMenuItem.Click += new System.EventHandler(this.expandingToolStripMenuItem_Click);
            // 
            // metaDataToolStripMenuItem
            // 
            this.metaDataToolStripMenuItem.Name = "metaDataToolStripMenuItem";
            this.metaDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.metaDataToolStripMenuItem.Text = "MetaData";
            this.metaDataToolStripMenuItem.Click += new System.EventHandler(this.metaDataToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filteringDataToolStripMenuItem1,
            this.sortingDataToolStripMenuItem,
            this.pagingToolStripMenuItem1,
            this.expandingToolStripMenuItem1,
            this.metaDataToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 20);
            this.toolStripMenuItem1.Text = "URI Query Operations";
            // 
            // filteringDataToolStripMenuItem1
            // 
            this.filteringDataToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logicalToolStripMenuItem,
            this.stringToolStripMenuItem,
            this.dateToolStripMenuItem1,
            this.mathToolStripMenuItem1,
            this.typeToolStripMenuItem1});
            this.filteringDataToolStripMenuItem1.Name = "filteringDataToolStripMenuItem1";
            this.filteringDataToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.filteringDataToolStripMenuItem1.Text = "Filtering Data";
            // 
            // logicalToolStripMenuItem
            // 
            this.logicalToolStripMenuItem.Name = "logicalToolStripMenuItem";
            this.logicalToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logicalToolStripMenuItem.Text = "Logical";
            this.logicalToolStripMenuItem.Click += new System.EventHandler(this.logicalToolStripMenuItem_Click);
            // 
            // stringToolStripMenuItem
            // 
            this.stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            this.stringToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.stringToolStripMenuItem.Text = "String";
            this.stringToolStripMenuItem.Click += new System.EventHandler(this.stringToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem1
            // 
            this.dateToolStripMenuItem1.Name = "dateToolStripMenuItem1";
            this.dateToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.dateToolStripMenuItem1.Text = "Date";
            this.dateToolStripMenuItem1.Click += new System.EventHandler(this.dateToolStripMenuItem1_Click);
            // 
            // mathToolStripMenuItem1
            // 
            this.mathToolStripMenuItem1.Name = "mathToolStripMenuItem1";
            this.mathToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.mathToolStripMenuItem1.Text = "Math";
            this.mathToolStripMenuItem1.Click += new System.EventHandler(this.mathToolStripMenuItem1_Click);
            // 
            // typeToolStripMenuItem1
            // 
            this.typeToolStripMenuItem1.Name = "typeToolStripMenuItem1";
            this.typeToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.typeToolStripMenuItem1.Text = "Type";
            this.typeToolStripMenuItem1.Click += new System.EventHandler(this.typeToolStripMenuItem1_Click);
            // 
            // sortingDataToolStripMenuItem
            // 
            this.sortingDataToolStripMenuItem.Name = "sortingDataToolStripMenuItem";
            this.sortingDataToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.sortingDataToolStripMenuItem.Text = "Sorting Data";
            this.sortingDataToolStripMenuItem.Click += new System.EventHandler(this.sortingDataToolStripMenuItem_Click);
            // 
            // pagingToolStripMenuItem1
            // 
            this.pagingToolStripMenuItem1.Name = "pagingToolStripMenuItem1";
            this.pagingToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.pagingToolStripMenuItem1.Text = "Paging";
            this.pagingToolStripMenuItem1.Click += new System.EventHandler(this.pagingToolStripMenuItem1_Click);
            // 
            // expandingToolStripMenuItem1
            // 
            this.expandingToolStripMenuItem1.Name = "expandingToolStripMenuItem1";
            this.expandingToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.expandingToolStripMenuItem1.Text = "Expanding";
            this.expandingToolStripMenuItem1.Click += new System.EventHandler(this.expandingToolStripMenuItem1_Click);
            // 
            // metaDataToolStripMenuItem1
            // 
            this.metaDataToolStripMenuItem1.Name = "metaDataToolStripMenuItem1";
            this.metaDataToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.metaDataToolStripMenuItem1.Text = "MetaData";
            this.metaDataToolStripMenuItem1.Click += new System.EventHandler(this.metaDataToolStripMenuItem1_Click);
            // 
            // cRUDOperationsToolStripMenuItem
            // 
            this.cRUDOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCustomerToolStripMenuItem,
            this.updateCustomerToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem,
            this.deleteCustomerNotInContextToolStripMenuItem});
            this.cRUDOperationsToolStripMenuItem.Name = "cRUDOperationsToolStripMenuItem";
            this.cRUDOperationsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.cRUDOperationsToolStripMenuItem.Text = "CRUD Operations";
            // 
            // createCustomerToolStripMenuItem
            // 
            this.createCustomerToolStripMenuItem.Name = "createCustomerToolStripMenuItem";
            this.createCustomerToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.createCustomerToolStripMenuItem.Text = "Create Customer";
            this.createCustomerToolStripMenuItem.Click += new System.EventHandler(this.createCustomerToolStripMenuItem_Click);
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            this.deleteCustomerToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomerToolStripMenuItem_Click);
            // 
            // deleteCustomerNotInContextToolStripMenuItem
            // 
            this.deleteCustomerNotInContextToolStripMenuItem.Name = "deleteCustomerNotInContextToolStripMenuItem";
            this.deleteCustomerNotInContextToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.deleteCustomerNotInContextToolStripMenuItem.Text = "Delete Customer Not in Context";
            this.deleteCustomerNotInContextToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomerNotInContextToolStripMenuItem_Click);
            // 
            // advancedConceptsToolStripMenuItem
            // 
            this.advancedConceptsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batchingToolStripMenuItem,
            this.serviceOperationToolStripMenuItem,
            this.concurrenctToolStripMenuItem});
            this.advancedConceptsToolStripMenuItem.Name = "advancedConceptsToolStripMenuItem";
            this.advancedConceptsToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.advancedConceptsToolStripMenuItem.Text = "Advanced Concepts";
            // 
            // batchingToolStripMenuItem
            // 
            this.batchingToolStripMenuItem.Name = "batchingToolStripMenuItem";
            this.batchingToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.batchingToolStripMenuItem.Text = "Batching";
            this.batchingToolStripMenuItem.Click += new System.EventHandler(this.batchingToolStripMenuItem_Click);
            // 
            // serviceOperationToolStripMenuItem
            // 
            this.serviceOperationToolStripMenuItem.Name = "serviceOperationToolStripMenuItem";
            this.serviceOperationToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.serviceOperationToolStripMenuItem.Text = "Service Operation";
            this.serviceOperationToolStripMenuItem.Click += new System.EventHandler(this.serviceOperationToolStripMenuItem_Click);
            // 
            // concurrenctToolStripMenuItem
            // 
            this.concurrenctToolStripMenuItem.Name = "concurrenctToolStripMenuItem";
            this.concurrenctToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.concurrenctToolStripMenuItem.Text = "Concurrency";
            this.concurrenctToolStripMenuItem.Click += new System.EventHandler(this.concurrencyToolStripMenuItem_Click);
            // 
            // otherConceptsToolStripMenuItem
            // 
            this.otherConceptsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lazyLoadingToolStripMenuItem,
            this.asyncLoadingToolStripMenuItem});
            this.otherConceptsToolStripMenuItem.Name = "otherConceptsToolStripMenuItem";
            this.otherConceptsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.otherConceptsToolStripMenuItem.Text = "Other Concepts";
            this.otherConceptsToolStripMenuItem.Click += new System.EventHandler(this.otherConceptsToolStripMenuItem_Click);
            // 
            // lazyLoadingToolStripMenuItem
            // 
            this.lazyLoadingToolStripMenuItem.Name = "lazyLoadingToolStripMenuItem";
            this.lazyLoadingToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.lazyLoadingToolStripMenuItem.Text = "Lazy Loading";
            this.lazyLoadingToolStripMenuItem.Click += new System.EventHandler(this.lazyLoadingToolStripMenuItem_Click);
            // 
            // asyncLoadingToolStripMenuItem
            // 
            this.asyncLoadingToolStripMenuItem.Name = "asyncLoadingToolStripMenuItem";
            this.asyncLoadingToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.asyncLoadingToolStripMenuItem.Text = "Async Loading";
            this.asyncLoadingToolStripMenuItem.Click += new System.EventHandler(this.asyncLoadingToolStripMenuItem_Click);
            // 
            // frmDataServicesConcepts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 667);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(829, 694);
            this.Name = "frmDataServicesConcepts";
            this.Text = "Data Services Concepts";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem queryOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedConceptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filteringDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logicalOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metaDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filteringDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortingDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem expandingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem metaDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mathToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem otherConceptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lazyLoadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asyncLoadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerNotInContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concurrenctToolStripMenuItem;
    }
}

