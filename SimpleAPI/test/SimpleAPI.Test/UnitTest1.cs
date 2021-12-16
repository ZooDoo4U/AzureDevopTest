using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        private readonly ILogger _logger;
        WeatherForecastController controller = new WeatherForecastController(); //= new WeatherForecastController(ILogger);


        //public UnitTest1(ILogger<SimpleAPI.Controllers.WeatherForecastController> logger)
        //{
        //    //this._logger =  new Logger<SimpleAPI.Controllers.WeatherForecastController>();
        //    this.controller = new WeatherForecastController();
        //}

        [Fact]
        public void GetMyName()
        {
            System.Collections.Generic.IEnumerable<WeatherForecast> returnValue = controller.Get();

            int count = 0;
            using(IEnumerator<WeatherForecast> enumerator = returnValue.GetEnumerator())
            {
                while(enumerator.MoveNext())
                    count++;
            }

            Assert.Equal( count, 5 );
        }

        [Fact]
        public async void Test1()
        {
            string returnValue = await controller.GetMyName();
            Assert.Equal("Dand",returnValue);
            //var xxx = JsonConvert.DeserializeObject(returnValue.ToString());
            //Assert.Equal(returnValue.ExecuteResultAsync .Value,3);            //Assert.True(!String.IsNullOrEmpty(returnValue.Value) && returnValue.Value.Equals("dand",StringComparer.OrdinalIgnoreCase));        

        }
    }
}
