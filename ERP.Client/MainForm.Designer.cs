namespace ERP.Client
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
            Telerik.WinControls.UI.RadTreeNode radTreeNode1 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode2 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode3 = new Telerik.WinControls.UI.RadTreeNode();
            this.radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.topControl1 = new ERP.Client.TopControl();
            this.radBreadCrumb1 = new Telerik.WinControls.UI.RadBreadCrumb();
            this.titleBarControl1 = new ERP.Client.CustomControls.TitleBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).BeginInit();
            this.radCollapsiblePanel1.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBreadCrumb1)).BeginInit();
            this.SuspendLayout();
            // 
            // radCollapsiblePanel1
            // 
            this.radCollapsiblePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCollapsiblePanel1.ExpandDirection = Telerik.WinControls.UI.RadDirection.Right;
            this.radCollapsiblePanel1.HorizontalHeaderAlignment = Telerik.WinControls.UI.RadHorizontalAlignment.Center;
            this.radCollapsiblePanel1.Location = new System.Drawing.Point(10, 88);
            this.radCollapsiblePanel1.Margin = new System.Windows.Forms.Padding(10, 4, 7, 10);
            this.radCollapsiblePanel1.Name = "radCollapsiblePanel1";
            this.radCollapsiblePanel1.OwnerBoundsCache = new System.Drawing.Rectangle(10, 3, 231, 755);
            // 
            // radCollapsiblePanel1.PanelContainer
            // 
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.radTreeView1);
            this.radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(236, 745);
            this.tableLayoutPanel1.SetRowSpan(this.radCollapsiblePanel1, 2);
            this.radCollapsiblePanel1.Size = new System.Drawing.Size(260, 747);
            this.radCollapsiblePanel1.TabIndex = 1;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)(this.radCollapsiblePanel1.GetChildAt(0))).ExpandDirection = Telerik.WinControls.UI.RadDirection.Right;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)(this.radCollapsiblePanel1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)(this.radCollapsiblePanel1.GetChildAt(0))).Margin = new System.Windows.Forms.Padding(0);
            // 
            // radTreeView1
            // 
            this.radTreeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radTreeView1.ForeColor = System.Drawing.Color.Black;
            this.radTreeView1.ItemHeight = 94;
            this.radTreeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.radTreeView1.LineStyle = Telerik.WinControls.UI.TreeLineStyle.Solid;
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            radTreeNode1.Expanded = true;
            radTreeNode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            radTreeNode1.Name = "salesNode";
            radTreeNode2.Expanded = true;
            radTreeNode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            radTreeNode2.Name = "overview";
            radTreeNode2.Text = "项目概览";
            radTreeNode3.Expanded = true;
            radTreeNode3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            radTreeNode3.Name = "details";
            radTreeNode3.Text = "项目明细";
            radTreeNode1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode2,
            radTreeNode3});
            radTreeNode1.Text = "项目管理";
            this.radTreeView1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode1});
            this.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radTreeView1.Size = new System.Drawing.Size(236, 745);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 0;
            this.radTreeView1.TreeIndent = 67;
            this.radTreeView1.SelectedNodeChanged += new Telerik.WinControls.UI.RadTreeView.RadTreeViewEventHandler(this.radTreeView1_SelectedNodeChanged_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 277F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.radCollapsiblePanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.topControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radBreadCrumb1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1300, 845);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // topControl1
            // 
            this.topControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topControl1.Location = new System.Drawing.Point(277, 3);
            this.topControl1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.topControl1.Name = "topControl1";
            this.topControl1.Size = new System.Drawing.Size(1020, 78);
            this.topControl1.TabIndex = 0;
            // 
            // radBreadCrumb1
            // 
            this.radBreadCrumb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radBreadCrumb1.Location = new System.Drawing.Point(280, 87);
            this.radBreadCrumb1.Name = "radBreadCrumb1";
            this.radBreadCrumb1.Size = new System.Drawing.Size(1017, 53);
            this.radBreadCrumb1.TabIndex = 2;
            this.radBreadCrumb1.Text = "radBreadCrumb1";
            this.radBreadCrumb1.UseMnemonic = false;
            // 
            // titleBarControl1
            // 
            this.titleBarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.titleBarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarControl1.Location = new System.Drawing.Point(0, 0);
            this.titleBarControl1.Margin = new System.Windows.Forms.Padding(4);
            this.titleBarControl1.Name = "titleBarControl1";
            this.titleBarControl1.Size = new System.Drawing.Size(1300, 50);
            this.titleBarControl1.TabIndex = 3;
            this.titleBarControl1.Load += new System.EventHandler(this.TitleBarControl1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 895);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.titleBarControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "RadForm1";
            this.radCollapsiblePanel1.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radBreadCrumb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TopControl topControl1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private CustomControls.TitleBarControl titleBarControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadBreadCrumb radBreadCrumb1;
    }
}