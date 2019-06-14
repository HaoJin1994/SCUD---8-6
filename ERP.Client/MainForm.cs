using ERP.Client.Analytics;
using ERP.Client.Properties;
using ERP.Client.CustomControls.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Analytics;
using Telerik.WinControls.UI;

namespace ERP.Client
{
    public partial class MainForm : ShapedForm
    {
        InfoControl infoControl;
        ProjectOverview projectOverviewControl = new ProjectOverview();
        ProjectDetails projectDetailsControl = new ProjectDetails();

        public MainForm()
        {
            ControlTraceMonitor.AnalyticsMonitor = new GoogleAnalyticsMonitor();

            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.radCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.ShowHeaderLine = false;
            topControl1.ViewLabel.TextChanged += ViewLabel_TextChanged;
            ThemeResolutionService.ApplicationThemeChanged += ThemeResolutionService_ApplicationThemeChanged;
            radTreeView1.SelectedNodeChanged += RadTreeView1_SelectedNodeChanged;
            radBreadCrumb1.DefaultTreeView = radTreeView1;

            this.Icon = Resources.ERP;
            this.Text = "ERP Demo";

            foreach (RadTreeNode item in radTreeView1.TreeViewElement.GetNodes())
            {
                if (item.Nodes.Count > 0)
                {
                    item.Image = Resources.folder;
                }
            }
            topControl1.ViewLabel.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            topControl1.ViewLabel.Text = "";
            radCollapsiblePanel1.EnableAnimation = false;
            radCollapsiblePanel1.Collapsed += RadCollapsiblePanel1_Collapsed;
            radCollapsiblePanel1.Expanded += RadCollapsiblePanel1_Expanded;
        }

        private void ViewLabel_TextChanged(object sender, EventArgs e)
        {
            radCollapsiblePanel1.HeaderText = topControl1.ViewLabel.Text;
        }

        private void RadCollapsiblePanel1_Expanded(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnStyles[0].Width = 267;
        }

        private void RadCollapsiblePanel1_Collapsed(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnStyles[0].Width = 40;
        }

        private void ThemeResolutionService_ApplicationThemeChanged(object sender, ThemeChangedEventArgs args)
        {
            OnThemeChanged();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            OnThemeChanged();
            radTreeView1.Nodes[0].Nodes[0].Selected = true;
            if (ControlTraceMonitor.AnalyticsMonitor != null)
            {
                ControlTraceMonitor.AnalyticsMonitor.TrackAtomicFeature("ApplicationStarted." + DateTime.Now.ToShortDateString());
            }
        }

        private void RadTreeView1_SelectedNodeChanged(object sender, Telerik.WinControls.UI.RadTreeViewEventArgs e)
        {
            if (ControlTraceMonitor.AnalyticsMonitor != null)
            {
                ControlTraceMonitor.AnalyticsMonitor.TrackAtomicFeature("ViewChanged." + e.Node.Name);
            }
            switch (e.Node.Name)
            {
                case "overview":
                    topControl1.ViewLabel.Text = "overview";
                    tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 2));
                    tableLayoutPanel1.Controls.Add(projectOverviewControl, 1, 2);
                    break;
                case "details":
                    topControl1.ViewLabel.Text = "details";
                    tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 2));
                    tableLayoutPanel1.Controls.Add(projectDetailsControl, 1, 2);
                    break;
            }
        }

        public void AttachGridControl<T>(ref BaseGridControl ctrl) where T : BaseGridControl, new()
        {
            if (ctrl == null)
            {
                ctrl = new T();
                ctrl.Dock = DockStyle.Fill;
                ctrl.Margin = new Padding(0, 0, 7, 7);
            }

            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 2));
            tableLayoutPanel1.Controls.Add(ctrl, 1, 2);

        }

        public void AttachGridControlUC<T>(ref UserControl ctrl) where T : UserControl, new()
        {
            if (ctrl == null)
            {
                ctrl = new T();
                ctrl.Dock = DockStyle.Fill;
                ctrl.Margin = new Padding(0, 0, 7, 7);
            }

            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 2));
            tableLayoutPanel1.Controls.Add(ctrl, 1, 2);

        }

        public void AttachInfoControl(string document)
        {
            if (infoControl == null)
            {
                infoControl = new InfoControl();
                infoControl.Dock = DockStyle.Fill;
                infoControl.Margin = new Padding(0, 0, 7, 7);
            }

            infoControl.InfoPdfViewer.LoadDocument(@"..\..\ERP.Client\Documents\" + document);
            infoControl.DocumentName = document;
           
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 2));
            tableLayoutPanel1.Controls.Add(infoControl, 1, 2);
        }

        protected void OnThemeChanged()
        {
            Theme theme = ThemeResolutionService.GetTheme(ThemeResolutionService.ApplicationThemeName);
       
            foreach (StyleGroup styleGroup in theme.StyleGroups)
            {
                foreach (PropertySettingGroup propertySettingGroup in styleGroup.PropertySettingGroups)
                {
                    if (propertySettingGroup.Selector.Value == "RadFormElement")
                    {
                        foreach (PropertySetting propertySetting in propertySettingGroup.PropertySettings)
                        {
                            if (propertySetting.Name == "BackColor")
                            {
                                this.BackColor = (Color)propertySetting.Value;
                                return;
                            }
                        }
                    }
                    if (styleGroup.Registrations[0].ControlType == "Telerik.WinControls.UI.RadForm" && propertySettingGroup.Selector.Value == "Telerik.WinControls.RootRadElement")
                    {
                        foreach (PropertySetting propertySetting in propertySettingGroup.PropertySettings)
                        {
                            if (propertySetting.Name == "BackColor")
                            {
                                this.BackColor = (Color)propertySetting.Value;
                                return;
                            }
                        }
                    }

                }

            }
        }

        private void radTreeView1_SelectedNodeChanged_1(object sender, RadTreeViewEventArgs e)
        {

        }

        private void TitleBarControl1_Load(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
