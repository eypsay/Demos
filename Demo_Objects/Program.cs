﻿using System;

namespace Demo_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();
            customerManager.Logger = new SmsLogger();
            customerManager.Add();

        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {

            Logger.Log();
            Console.WriteLine("Customer Added!!!");
        }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database!!");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File!!");
        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to SMS!!");
        }
    }
}
