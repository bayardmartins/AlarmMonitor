using AlarmMonitor.Domain.Entities;
using AlarmMonitor.Infrastructure.Context;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace AlarmMonitor.Presentation.Views
{
    public partial class FrmPanel : Form
    {
        private AlarmMonitorContext _context;
        delegate void SetDataSourceToGridPanelCallBack();
        delegate void SetDataSourceToGridEventsCallBack();

        public FrmPanel(AlarmMonitorContext context)
        {
            this._context = context;
            InitializeComponent();
            this.SetupGrids();
        }
        
        private void SetupGrids()
        {
            _context.GetPanels().CollectionChanged += panel_CollectionChanged;
            _context.GetEvents().CollectionChanged += events_CollectionChanged;
        }

        /// <summary>
        /// Delego a tarefa para a thread do Form para não causar conflito
        /// </summary>
        private void panel_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (this.grdPanel.InvokeRequired)
            {
                SetDataSourceToGridPanelCallBack a = new SetDataSourceToGridPanelCallBack(UpdatePanel);
                this.Invoke(a, new object[] { });
            }
            else
            {
                this.UpdatePanel();   
            }
        }

        private void events_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (this.grdPanel.InvokeRequired)
            {
                SetDataSourceToGridPanelCallBack a = new SetDataSourceToGridPanelCallBack(UpdateEvent);
                this.Invoke(a, new object[] { });
            }
            else
            {
                this.UpdateEvent();
            }
        }

        private void UpdatePanel()
        {
            this.grdPanel.DataSource = null;
            this.grdPanel.DataSource = _context.GetPanels();
        }
        private void UpdateEvent()
        {
            this.grdEvent.DataSource = null;
            this.grdEvent.DataSource = _context.GetEvents();
        }

    }
}
