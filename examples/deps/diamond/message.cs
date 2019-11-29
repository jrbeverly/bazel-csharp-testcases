using System;

using Auth;

namespace Messaging
{
    public static class MessageBook
    {
        public static bool WriteMessage(string username, string environment, string message)
        {
            if (!Permissions.IsAuthorized(username, environment))
            {
                return false;
            }

            Console.WriteLine($"[{username}@{environment}]: {message}");
            return true;
        }
    }
}