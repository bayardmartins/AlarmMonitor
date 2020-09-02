using System;
using System.Linq;
using AlarmMonitor.Domain.Entities;
using AlarmMonitor.Domain.Services;
using AlarmMonitor.Infrastructure.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlarmMonitorTest.Test
{
    [TestClass]
    public class AlarmMonitorUnitTest
    {
        [TestMethod]
        public void CreateEvent_WithValidCodeEvent()
        {
            int account = 7;
            int eventCode = 1130;
            int panel = 2;
            string partition = "1";
            string zone = "3";
            string user = "1";

            AlarmMonitorContext context = new AlarmMonitorContext();
            EventService service = new EventService(context.GetEventRepository(), context.GetEventUnitRepository());
            service.CreateEvent(account, eventCode, panel, partition, zone, user);

            int actual = context.GetEventRepository().GetAll().Count();
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreatePanel_WithAddingPanel()
        {
            int code = 2;
            AlarmMonitorContext context = new AlarmMonitorContext();
            PanelService service = new PanelService(context.GetPanelRepository());
            service.CreatePanel(code);

            int actual = context.GetPanelRepository().GetAll().Count();
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}
