using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using WeatherConsole.Background;

namespace WeatherConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Weather Console!");
            Console.WriteLine("Write elements:");
            string user_date = Console.ReadLine();
            DateDelivered(user_date);
        }


        private static void DateDelivered(string message)
        {
            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                Port = 5672
            };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("reventuki", false, false, false, null);
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish("", "reventuki", null, body);
                }
            }
        }

        private static void ReceiveWeather(string message)
        {
            
        }


    }
}
