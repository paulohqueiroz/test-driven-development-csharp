using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application.Controllers;
using Microsoft.Extensions.Logging;


namespace Application.Tests
{
    [TestClass]
    public class WeatherForecastTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string Expected = "spring";

            ILogger<WeatherForecastController> logger = null;
            var currentWeaterClass = new WeatherForecastController(logger);

            var result = currentWeaterClass.GetSeasonName();
            
            Assert.AreEqual(Expected, result);
        }
    }
}
