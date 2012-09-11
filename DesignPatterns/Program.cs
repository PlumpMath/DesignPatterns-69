using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Proxy;

namespace DesignPatterns
{
    class Program
    {
        private static IClient _client;
        static void Main(string[] args)
        {
            DisplayInstructions();
            ProcessAnwser();
        }

        private static void ProcessAnwser()
        {
            string readLine = Console.ReadLine();

            if (readLine != "")
            {
                ClientFactory clientFactory = new ClientFactory();
                _client = clientFactory.GetClient(readLine);
                _client.Init();
                Question();
            }
        }

        private static void Question()
        {
            DisplayInstructions();
            ProcessAnwser();
        }

        private static void DisplayInstructions()
        {
            Console.WriteLine("--------------------------" +
                              "\nChoose example to run:\n" +
                              "1) Basic Decorator\n" +
                              "2) Basic Proxy\n" +
                              "3) Basic Bridge\n" +
                              "4) Basic Composite" +
                              "\n--------------------------");
        }
    }
}
