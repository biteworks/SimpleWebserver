using System;
using System.IO;
using System.Net;
using static SimpleWebserver.HTTPServer;

namespace SimpleWebserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pathToWebsite = desktopPath + "\\Website";
            string ip = "localhost";
            int port = 8080;

            HTTPServer server = new HTTPServer(pathToWebsite, ip, port);
            server.Start();
            Console.ReadKey();
        }
    }
}
