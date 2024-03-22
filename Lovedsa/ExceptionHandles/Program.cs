using ExceptionHandles.Handlers;
using System;

namespace ExceptionHandles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                HandlingCustomException ception = new HandlingCustomException();
                ception.GetYouTubeVideo();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
