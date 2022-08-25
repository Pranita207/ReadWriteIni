using System;

namespace ReadWriteIni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            IniFile settingsIni = new IniFile (@".\\TestData.ini");

            string executionMode = settingsIni.Read ("BrowserName", "BrowserInfo").ToLower ();
            Console.WriteLine (executionMode);

            string WebdriverToUse = settingsIni.Read ("WebDriverLocation", "BrowserInfo").ToLower ();
            Console.WriteLine (WebdriverToUse);
            settingsIni.Write("TimeOut","4000","BrowserInfo");
            
            


    
           string timeOut = settingsIni.Read ("TimeOut", "BrowserInfo").ToLower ();
            Console.WriteLine (timeOut);

            settingsIni.Write("BrowserName","IE","BrowserInfo");
            
            

        }
    }
}
