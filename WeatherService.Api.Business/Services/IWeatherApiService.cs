﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using Microsoft.Extensions.Configuration;

namespace WeatherService.Api.Business.Services
{
    public interface IWeatherApiService
    {
        Task<HttpResponseMessage> GetRealTimeWeatherAsync(string city);
    }
}
