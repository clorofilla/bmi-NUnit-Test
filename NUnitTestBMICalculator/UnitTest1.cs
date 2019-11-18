using NUnit.Framework;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Http;

namespace BMICalculator.Tests
{
    [TestFixture]
    public class BMITest
    {


        [Test]
        public void Test_BMICategoryok()
        {
            //Assert.Pass();
            BMI bmi = new BMI() { WeightStones = 12, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Normal);
        }

        [Test]
        public void Test_BMICategoryunder()
        {

            BMI bmi = new BMI() { WeightStones = 5, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Underweight);
        }

        [Test]
        public void Test_BMICategoryover()
        {

            BMI bmi = new BMI() { WeightStones = 14, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Overweight);
        }
        [Test]
        public void Test_BMICategoryobese()
        {

            BMI bmi = new BMI() { WeightStones = 35, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Obese);
        }

    }

    public class ProgramTest
    {

        [Test]
        public async Task CanGetHomePage()
        {
            // Arrange
            var webHostBuilder = Program.CreateWebHostBuilder(Array.Empty<string>()).UseContentRoot(Path.GetFullPath("../../../../../bmi-master/BMICalculator"));
            
            var server = new TestServer(webHostBuilder);
            var client = server.CreateClient();
            
            // Act
            var response = await client.GetAsync("/");

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        //[Test]
        //public async Task Configure()
        //{
        //    // Arrange
        //    var test = new Startup();
        //    var result = test.Configure()
        //    var webHostBuilder = Program.CreateWebHostBuilder(Array.Empty<string>()).UseContentRoot(Path.GetFullPath("../../../../../bmi-master/BMICalculator"));

        //    var server = new TestServer(webHostBuilder);
        //    var client = server.CreateClient();

        //    // Act
        //    var response = await client.GetAsync("/");

        //    // Assert
        //    Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        //}
    }

    public class AboutModel
    {

        [Test]
        public void TestAboutModel()
        {
            var model = new BMICalculator.Pages.AboutModel() { };
            model.OnGet();
            Assert.AreEqual("Your application description page.", model.Message);
        }
    }

    public class BMIModel
    {

        [Test]
        public void TestContactModel()
        {
            var model = new BMICalculator.Pages.ContactModel() { };
            model.OnGet();
            Assert.AreEqual("Your contact page.", model.Message);
        }
    }

    public class PrivacyModel
    {

        [Test]


        public void TestPrivacyModel()
        {

            var model = new BMICalculator.Pages.PrivacyModel();
            model.OnGet();
            Assert.AreEqual("Your Privacy Policy.", model.Message);
        }
    }

}