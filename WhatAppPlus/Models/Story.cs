using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WhatAppPlus.Models
{
    public class Story
    {
        public string Username { get; set; }
        public string Caption { get; set; }
        public string[] imageStory { get; set; }
        public DateTime PostedAt { get; set; }
        public bool Readed { get; set; }
        public int StoryCount { get; set; }
        public string ContactImage { get; set; }
    }
}
