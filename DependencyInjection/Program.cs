using System;

namespace DependencyInjection
{
    class Program
    {
      static  void Main(string[] args)
        {
            // Usage
            ILog log = new DatabaseLog();
            INotification notification = new EmailNotification();
            Customer customer = new Customer(log, notification);
            customer.Add();

            // Or
            ILog log2 = new FileLog();
            INotification notification2 = new SMSNotification();
            Customer customer2 = new Customer(log2, notification2);
            customer2.Add();

            // or
            ILog log3 = new DatabaseLog();
            INotification notification3 = new SMSNotification();
            Customer customer3 = new Customer(log3, notification3);
            customer3.Add();

            //or
            ILog log4 = new FileLog();
            INotification notification4 = new EmailNotification();
            Customer customer4 = new Customer(log4, notification4);
            customer4.Add();
            Console.WriteLine("Hello World!");
        }
    }
    public interface ILog
    {
        void Log(string message);
    }

    public class DatabaseLog : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine("Log record to Database"); 
        }
    }

    public class FileLog : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine("Log record to File");
        }
    }

    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Notification sent by Email"); 
        }
    }

    public class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Notification sent by SMS"); 
        }
    }

    public class Customer
    {
        private ILog _log;
        private INotification _notification;

        public Customer(ILog log, INotification notification)
        {
            _log = log;
            _notification = notification;
        }

        public void Add()
        { 
            _log.Log("Customer added.");
            _notification.Send("Customer added.");
        }
    } 
}
