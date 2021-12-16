using System;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NUnit.Framework;

namespace SimpleAPI.Test
{
    [TestFixture]
    public class UnitTest1
    {
        
        WeatherForecastController controller = new WeatherForecastController(); 
        [Test]
        public void GetMyName()
        {
            Console.WriteLine( $"Test runs at {DateTime.Now.ToString()}" );
            System.Collections.Generic.IEnumerable<WeatherForecast> returnValue = controller.Get();

            int count = 0;
            using(IEnumerator<WeatherForecast> enumerator = returnValue.GetEnumerator())
            {
                while(enumerator.MoveNext())
                    count++;
            }
            Assert.AreEqual( count, 5 );
        }

        [Test]
        public async void Test1()
        {
            Console.WriteLine( $"Test runs at {DateTime.Now.ToString()}" );
            string returnValue = await controller.GetMyName();
            Assert.AreEqual("Dand",returnValue);
            //var xxx = JsonConvert.DeserializeObject(returnValue.ToString());
            //Assert.Equal(returnValue.ExecuteResultAsync .Value,3);            //Assert.True(!String.IsNullOrEmpty(returnValue.Value) && returnValue.Value.Equals("dand",StringComparer.OrdinalIgnoreCase));        

        }
    }
}
