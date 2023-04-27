// add namespace for WeatherForecastController
using WebApi.Controllers;

namespace WebApiTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
    }

    // add a test method that tests the GetWeatherForecastByLength
    // from WeatherForecastController
    // Path: test/WebAPITests/Controllers/WeatherForecastControllerTests.cs
    [TestMethod]
    public void GetWeatherForecastByLengthTest()
    {
        // Arrange
        var controller = new WeatherForecastController(null);

        // Act
        var result = controller.Get(new DateRange { Length = 5 });

        // Assert
        Assert.AreEqual(5, result.Count());
    } 
}