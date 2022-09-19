using System;
using System.Threading;

namespace gospodi
{
    class Program
    {
        static ServerObject server; // сервер
        static Thread listenThread; // потока для прослушивания
        static void Main(string[] args)
        {
           server = new ServerObject();
           listenThread = new Thread(new ThreadStart(server.Listen));
           listenThread.Start(); //старт потока
        }
    }
}