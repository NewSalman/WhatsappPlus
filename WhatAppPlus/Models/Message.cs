using System;
using System.Collections.Generic;
using System.Text;

namespace WhatAppPlus.Models
{
    public class Message
    {
        public enum UserType
        {
            MASTER,
            GUEST
        }


        public string[] Msg { get; set; }
    }
}
