using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace WeatherConsole
{
    public class Program
    {

        IServiceCollection service;
        

        public static void Main(string[] args)
        {
            var mmessage = "";


            Console.WriteLine("Weather Console!");
            Console.WriteLine("Write elements:");
            string user_date = Console.ReadLine();
            DateDelivered(user_date);

            Console.ReadLine();
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
                    channel.QueueDeclare("delivered", false, false, false, null);
                    var body = Encoding.UTF8.GetBytes(message);
                    channel.BasicPublish("", "delivered", null, body);

                    channel.QueueDeclare("send", false, false, false, null);
                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += async (model, content) =>
                    {
                        var body = content.Body.ToArray();
                        var mmessage = Encoding.UTF8.GetString(body);
                        Console.WriteLine(mmessage);
                    };

                    channel.BasicConsume("send", true, consumer);
                }
            }

            
        }

    }
}
