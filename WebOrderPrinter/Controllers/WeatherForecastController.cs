using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Models.Restaurant;

namespace WebOrderPrinter.Controllers
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
        private readonly IUnitOfWork _unitOfWork;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            var notifications = _unitOfWork.Notifications.Get();
            var deviceDetails = _unitOfWork.DeviceDetails.Get();
            var deviceDetailsid = _unitOfWork.DeviceDetails.GetByID(100);
            var notificationsforDev = _unitOfWork.Notifications.Get(notification => notification.DeviceDetail.Id == 100);
            var notificationsbranh = _unitOfWork.Notifications.Get(notification => notification.DeviceDetail.Id == 100, null, $"{nameof(Branch)}");



            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
