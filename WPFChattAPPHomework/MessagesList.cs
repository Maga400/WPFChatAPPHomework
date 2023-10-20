using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFChattAPPHomework
{
    internal class MessagesList
    {
        public List<Message> Messages { get; set; }

        public MessagesList() 
        {
            Messages = new() {
                new() { message = "Salam", time = "9:41" },
                new() { message = "Necesen", time = "9:50" },
                new() { message = "Ne var ne yox", time = "10:00" },
                new() { message = "Hardasan?", time = "10:18" },
                new() { message = "Shere gedek?", time = "10:47" },
                new() { message = "Bu gun hava cox istidir",time =  "11:51" },
                new() { message = "Men gede bilmeyecem", time = "13:38" },
                new() { message = "Sen necesen?", time = "16:00" },
                new() { message = "Derse geleceksen?", time = "17:35" },
            };
        }

        
    }
}
