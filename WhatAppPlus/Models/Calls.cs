using System;
using System.Collections.Generic;
using System.Text;

namespace WhatAppPlus.Models
{
    public class Calls
    {
        public enum CallCondition
        {
            MISSED,
            REJECTED,
            ANSWERED,
        }

        public enum CallType
        {
            OUTGOING,
            INCOMING,
        }


        public string Username { get; set; }
        public string Condition { get; set; }
        public string Type { get; set; }
        public string IconCall { get; set; }
        public int CallCount { get; set; }
        public DateTime At { get; set; }
    }
}
