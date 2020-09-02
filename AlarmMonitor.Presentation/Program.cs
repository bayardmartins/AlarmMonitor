using AlarmMonitor.Domain.Interfaces.Repositories;
using AlarmMonitor.Infrastructure.Context;
using AlarmMonitor.Infrastructure.Repositories;
using AlarmMonitor.Presentation.Presenter;
using AlarmMonitor.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmMonitor.Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            AlarmMonitorContext _context = new AlarmMonitorContext();
            PanelPresenter panelPresenter = new PanelPresenter(_context);
            FrmPanel frmPanel = new FrmPanel(_context);
            System.Windows.Forms.Application.Run(frmPanel);

        }
    }
}
