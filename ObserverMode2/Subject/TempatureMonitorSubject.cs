using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode2
{
    public class TemperatureMonitorSubject : ITemperatureMonitorSubject
    {
        private double temperature;
        public double Temperature
        {
            get { return temperature; }
            set
            {
                var oldTemperature = temperature;
                if (oldTemperature != value)
                {
                    temperature = value;
                    NotifyTemperature();
                }
            }
        }

        private List<ITemperatureMonitorObserver> observers;

        public TemperatureMonitorSubject()
        {
            observers = new List<ITemperatureMonitorObserver>();
        }

        public void NotifyTemperature()
        {
            foreach (var observer in observers)
            {
                observer.OnTemperatureChanged(temperature);
            }
        }

        public void RegisterObserver(ITemperatureMonitorObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(ITemperatureMonitorObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
