using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode2
{
    /// <summary>
    /// Subject interface
    /// </summary>
    public interface ITemperatureMonitorSubject
    {
        void RegisterObserver(ITemperatureMonitorObserver observer);

        void UnregisterObserver(ITemperatureMonitorObserver observer);

        void NotifyTemperature();
    }
}
