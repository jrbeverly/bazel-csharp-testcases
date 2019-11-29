using System;
using System.Threading;

using Servers;
using Messaging;

namespace ChatApp
{
    public static class Program
    {
        public static void Main()
        {
            var username = "jrbeverly";

            var servers = Environments.ListEnvironments(username);
            if (servers.Length == 0)
            {
                Console.WriteLine("We couldn't find any servers");
                return;
            }

            foreach (var server in servers)
            {
                var result = MessageBook.WriteMessage(username, server, "Hey everyone!");
                if (!result)
                {
                    Console.WriteLine($"[{username}] failed to send message to {server}.");
                }
                Thread.Sleep(1000);
            }
        }
    }
}
