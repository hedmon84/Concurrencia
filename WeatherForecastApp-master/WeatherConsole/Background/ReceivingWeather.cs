using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WeatherConsole.Background
{
   
    public class ReceivingWeather : BackgroundService
    {
        private readonly ILogger<ReceivingWeather> _logger;
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private readonly EventingBasicConsumer _consumer;

        public ReceivingWeather(ILogger<ReceivingWeather> logger)
        {
            _logger = logger;
            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                Port = 5672
            };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare("violento", false, false, false, null);
            _consumer = new EventingBasicConsumer(_channel);
        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            _consumer.Received += async (model, content) =>
            {
                var body = content.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                var a = 15;
            };

            _channel.BasicConsume("violento", true, _consumer);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(200, stoppingToken);
            }
        }

        class format_date
        {
            string temperatureC { get; set; }
            string temperatureF { get; set; }
            string summary { get; set; }
        }
    }
}
