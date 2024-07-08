using System;
using System.Data.SqlTypes;

namespace _6._4.Entity
{
    public class Message
    {
        
        int id;
        string author;
        string text;
        string imageLink;
        
        DateTime send;

        public Message(string author, string text, string imageLink, DateTime send) 
        {
            this.author = author;
            this.text = text;
            this.imageLink = imageLink;
            this.send = send;
        }
        
        public string getAuthor() { return author; }

        public string getText() { return text; }

        public string getImageLink() { return imageLink;}
        
        public string getSendTime() { return send.ToString("yyyy-MM-dd hh:mm:ss"); }

        public DateTime setSendTime() { 
            DateTime now = DateTime.Now;
            this.send = now;
            return now;
        }
    }
}
