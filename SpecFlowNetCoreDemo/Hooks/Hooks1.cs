using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowNetCoreDemo.Hooks
{
    [Binding]
    public sealed class Hooks1
    {

        private DriverHelper _driverHelper;
        public Hooks1(DriverHelper driverHelper)
        {
            this._driverHelper=driverHelper;
        }

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
        }
   
   
        [BeforeScenario(Order = 1)]
        public void BeforeScenario()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");
            

            new DriverManager().SetUpDriver(new ChromeConfig());
            Console.WriteLine("Setup");
            _driverHelper.Driver = new ChromeDriver(option);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
    }
}