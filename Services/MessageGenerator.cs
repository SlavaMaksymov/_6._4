using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6._4.Entity;

namespace _6._4.Services
{
    public class MessageGenerator
    {

        public MessageGenerator() { }

        
        public void showData(Message message)

        {
            message.setSendTime();
            Console.WriteLine(message.getAuthor());
            Console.WriteLine(message.getText());
            Console.WriteLine(message.getSendTime());
        }
    }
}


