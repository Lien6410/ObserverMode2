using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode2
{
    /// <summary>
    /// Observer interface 
    /// </summary>
    public interface ITemperatureMonitorObserver
    {
        void OnTemperatureChanged(double tempature);
    }
}
