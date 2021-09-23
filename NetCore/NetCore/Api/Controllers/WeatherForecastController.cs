﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IStringLocalizer<WeatherForecastController> _localizer;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IStringLocalizer<WeatherForecastController> localizer)
        {
            _logger = logger;
            this._localizer = localizer;
        }

        [HttpGet]
        public string Get()
        {
            return this._localizer["Invalid"];
        }
    }
}
