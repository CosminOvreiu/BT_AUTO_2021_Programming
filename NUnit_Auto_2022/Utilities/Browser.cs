using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Utilities
{
    public class Browser
    {
        public static IWebDriver GetDriver(WebBrowsers browserType)
        {
            switch (browserType)
            {
                // Instantiate a chrome driver
                case WebBrowsers.Chrome:
                    {
                        var options = new ChromeOptions();
                        // Options for the driver based on flags from FrameworkConstants
                        if (FrameworkConstants.startMaximized)
                        {
                            options.AddArgument("--start-maximized");
                        }
                        if (FrameworkConstants.startHeadless)
                        {
                            options.AddArgument("headless");
                        }
                        if (FrameworkConstants.ignoreCertErr)
                        {
                            options.AddArgument("ignore-certificate-errors");
                        }
                        // Proxy definition
                        var proxy = new Proxy
                        {
                            HttpProxy = FrameworkConstants.browserProxy,
                            IsAutoDetect = false
                        };
                        if (FrameworkConstants.useProxy)
                        {
                            options.Proxy = proxy;
                        }
                        // Initiate chrome driver with options
                        return new ChromeDriver(options);
                    }

                case WebBrowsers.Firefox:
                    {
                        return new FirefoxDriver();
                    }


                case WebBrowsers.Edge:
                    {
                        // Adding edge options based on the flags in the FrameWorkConstants
                        var edgeOptions = new EdgeOptions();
                        
                        if (FrameworkConstants.startMaximized)
                        {
                            edgeOptions.AddArgument("--start-maximized");
                        }
                        // instantiate Edge driver with options defined
                        return new EdgeDriver(edgeOptions);
                    }

                     
                default:
                    {
                        // If the driver specified is not implemented
                        throw new BrowserTypeException(browserType.ToString());
                    }



            }
        }


    }

    // Browser Enum with the suported browser types
    public enum WebBrowsers
    {
        Chrome,
        Firefox,
        Edge
    }



}
