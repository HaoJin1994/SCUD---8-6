namespace ERP.Client 
{
    partial class OrderDetailsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.orderDetailsPageView = new Telerik.WinControls.UI.RadPageView();
            this.orderDetailsPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.shipingDetailsPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.shipingDetailsMapControl = new ERP.Client.DetailsMapControl();
            this.customerDetailsPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.customerDetailsMapControl = new ERP.Client.DetailsMapControl();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsPageView)).BeginInit();
            this.orderDetailsPageView.SuspendLayout();
            this.orderDetailsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.shipingDetailsPage.SuspendLayout();
            this.customerDetailsPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderDetailsPageView
            // 
            this.orderDetailsPageView.Controls.Add(this.orderDetailsPage);
            this.orderDetailsPageView.Controls.Add(this.shipingDetailsPage);
            this.orderDetailsPageView.Controls.Add(this.customerDetailsPage);
            this.orderDetailsPageView.Controls.Add(this.radPageViewPage1);
            this.orderDetailsPageView.DefaultPage = this.orderDetailsPage;
            this.orderDetailsPageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDetailsPageView.ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth;
            this.orderDetailsPageView.Location = new System.Drawing.Point(3, 3);
            this.orderDetailsPageView.Name = "orderDetailsPageView";
            this.orderDetailsPageView.SelectedPage = this.orderDetailsPage;
            this.orderDetailsPageView.Size = new System.Drawing.Size(919, 348);
            this.orderDetailsPageView.TabIndex = 0;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.orderDetailsPageView.GetChildAt(0))).ItemDragMode = Telerik.WinControls.UI.PageViewItemDragMode.Immediate;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.orderDetailsPageView.GetChildAt(0))).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth;
            // 
            // orderDetailsPage
            // 
            this.orderDetailsPage.Controls.Add(this.radGridView1);
            this.orderDetailsPage.ItemSize = new System.Drawing.SizeF(112F, 28F);
            this.orderDetailsPage.Location = new System.Drawing.Point(10, 37);
            this.orderDetailsPage.Name = "orderDetailsPage";
            this.orderDetailsPage.Size = new System.Drawing.Size(898, 300);
            this.orderDetailsPage.Text = "Order Details";
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn3.HeaderText = "Product";
            gridViewTextBoxColumn3.Name = "column1";
            gridViewTextBoxColumn4.HeaderText = "Carrier Tracking Number";
            gridViewTextBoxColumn4.Name = "column2";
            gridViewDecimalColumn5.HeaderText = "Order Quantity";
            gridViewDecimalColumn5.Name = "column3";
            gridViewDecimalColumn6.HeaderText = "Unit Price";
            gridViewDecimalColumn6.Name = "column4";
            gridViewDecimalColumn7.HeaderText = "Unit Price Discount";
            gridViewDecimalColumn7.Name = "column5";
            gridViewDecimalColumn8.HeaderText = "Line Total";
            gridViewDecimalColumn8.Name = "column6";
            gridViewDateTimeColumn2.HeaderText = "Modified Date";
            gridViewDateTimeColumn2.Name = "column7";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewDecimalColumn8,
            gridViewDateTimeColumn2});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(898, 300);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Click += new System.EventHandler(this.RadGridView1_Click);
            // 
            // shipingDetailsPage
            // 
            this.shipingDetailsPage.Controls.Add(this.shipingDetailsMapControl);
            this.shipingDetailsPage.ItemSize = new System.Drawing.SizeF(112F, 28F);
            this.shipingDetailsPage.Location = new System.Drawing.Point(10, 37);
            this.shipingDetailsPage.Name = "shipingDetailsPage";
            this.shipingDetailsPage.Size = new System.Drawing.Size(898, 300);
            this.shipingDetailsPage.Text = "Shipping Details";
            // 
            // shipingDetailsMapControl
            // 
            this.shipingDetailsMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipingDetailsMapControl.Location = new System.Drawing.Point(0, 0);
            this.shipingDetailsMapControl.Name = "shipingDetailsMapControl";
            this.shipingDetailsMapControl.Size = new System.Drawing.Size(898, 300);
            this.shipingDetailsMapControl.TabIndex = 0;
            // 
            // customerDetailsPage
            // 
            this.customerDetailsPage.Controls.Add(this.customerDetailsMapControl);
            this.customerDetailsPage.ItemSize = new System.Drawing.SizeF(112F, 28F);
            this.customerDetailsPage.Location = new System.Drawing.Point(10, 37);
            this.customerDetailsPage.Name = "customerDetailsPage";
            this.customerDetailsPage.Size = new System.Drawing.Size(898, 300);
            this.customerDetailsPage.Text = "Customer Details";
            // 
            // customerDetailsMapControl
            // 
            this.customerDetailsMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDetailsMapControl.Location = new System.Drawing.Point(0, 0);
            this.customerDetailsMapControl.Name = "customerDetailsMapControl";
            this.customerDetailsMapControl.Size = new System.Drawing.Size(898, 300);
            this.customerDetailsMapControl.TabIndex = 0;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(112F, 28F);
            this.radPageViewPage1.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(898, 300);
            this.radPageViewPage1.Text = "radPageViewPage1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.orderDetailsPageView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(925, 354);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // OrderDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrderDetailsControl";
            this.Size = new System.Drawing.Size(925, 354);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsPageView)).EndInit();
            this.orderDetailsPageView.ResumeLayout(false);
            this.orderDetailsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.shipingDetailsPage.ResumeLayout(false);
            this.customerDetailsPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView orderDetailsPageView;
        private Telerik.WinControls.UI.RadPageViewPage orderDetailsPage;
        private Telerik.WinControls.UI.RadPageViewPage customerDetailsPage;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadPageViewPage shipingDetailsPage;
        private DetailsMapControl shipingDetailsMapControl;
        private DetailsMapControl customerDetailsMapControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
    }
}
