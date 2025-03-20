using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleHealthConversationApp.Models
{
    public class MessageModel
    {
        public string Speaker { get; set; }
        public string Language { get; set; }
        public string MessageText { get; set; }
        public bool IsDoctor { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
