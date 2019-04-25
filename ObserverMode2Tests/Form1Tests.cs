using NUnit.Framework;
using ObserverMode2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode2.Tests
{
    [TestFixture()]
    public class Form1Tests
    {
        [Test()]
        public void ObModeTest()
        {
            DesktopApp desktopApp = new DesktopApp();
            MobileApp mobileApp = new MobileApp();
            TemperatureMonitorSubject temperatureMonitor = new TemperatureMonitorSubject();

            temperatureMonitor.RegisterObserver(desktopApp);
            temperatureMonitor.RegisterObserver(mobileApp);

            Console.WriteLine("溫度變化了，現在是30.5度");
            temperatureMonitor.Temperature = 30.5;

            Console.WriteLine("溫度沒變化，現在依然是30.5度");
            temperatureMonitor.Temperature = 30.5;

            Console.WriteLine("溫度變化了，現在是28.6度");
            temperatureMonitor.Temperature = 28.6;

            Console.WriteLine("mobileApp不再想觀察了");
            temperatureMonitor.UnregisterObserver(mobileApp);

            Console.WriteLine("溫度變化了，現在是27.6度");
            temperatureMonitor.Temperature = 27.6;
            Console.WriteLine();


            Assert.True(true);
        }


        [Test()]
        public void Form1Test2()
        {
            Assert.Fail();
        }
    }
}