using System;
using System.Collections.Generic;
using System.Text;

namespace WhatAppPlus.Models
{
    public class Chat
    {
        public int ID { get; set; }
        public string Guest { get; set; }
        public Message Messages { get; set; }
    }

    public class ChatGroup
    {
        public int ID { get; set; }
        public string[] users { get; set; }
        public Message Messages { get; set; }
    }
}
