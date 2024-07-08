using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _6._4.Entity;
using _6._4.Services;
using _6._4.Services.SecondMessageGenerator;

namespace _6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            Services.MessageGenerator messageGenerator = new Services.MessageGenerator();
            Services.SecondMessageGenerator.MessageGenerator messageGenerator1 = new Services.SecondMessageGenerator.MessageGenerator();
            
            Message message = new Message("Автор", "Текст", "https:photosOrVideos", now) ;
            messageGenerator.showData(message);
            Console.WriteLine("-------------------------------------------------");

            Thread.Sleep(2000);
            messageGenerator1.showData(message);
        }
    }
}
