﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Domain.Entities
{
    public class EventList : ObservableCollection<Event>, INotifyCollectionChanged
    {
    }
}
