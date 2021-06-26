using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WhatAppPlus.Models;
using WhatAppPlus.Views.Room;
using Xamarin.Forms;

namespace WhatAppPlus.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public Contact[] ContactSource
        {
            get
            {
                return new Contact[]
                {
                    new Contact() { ContactImage = "user.png", PhoneNumber = "+62812-3456-7899", Username = "Salman Syahbani", LatestMessage = "Hello, how r u?"},
                    new Contact() { ContactImage = "user.png", PhoneNumber = "+62812-4357-6664", LatestMessage = "STFU", Username = "HolaHola"},
                    new Contact() { ContactImage = "user.png", PhoneNumber = "+62812-5477-8538", LatestMessage = "GTFO", Username = "GukGuk"},
                    new Contact() { ContactImage = "user.png", PhoneNumber = "+62812-7463-5232", Username = "ilham pret", LatestMessage = "pret"},
                    new Contact() { ContactImage = "user.png", PhoneNumber = "+62812-5236-5737", Username = "Hendrox Garroxx", LatestMessage = "PUBG KUY"},
                    new Contact() { ContactImage = "user.png", PhoneNumber = "+62812-4564-6739", Username = "BLACK LIVES MATTER", LatestMessage = "ini gwe eki anjng"},
                    new Contact() { ContactImage = "user.png", PhoneNumber = "+62812-2655-6748", Username = "i pantat", LatestMessage = "uou"},
                };
            }
        }

        public Story[] StorySource
        {
            get
            {
                return new Story[]
                {
                    new Story() { Username = "Hendroxx Garroxx", ContactImage = "user.png", StoryCount = 3},
                    new Story() { Username = "i pantat", ContactImage = "user.png", StoryCount = 1}
                };
            }
        }

        public Calls[] CallSource
        {
            get
            {
                return new Calls[]
                {
                    new Calls() {Username = "Hendroxx Garroxx", CallCount = 5, Condition = Calls.CallCondition.MISSED.ToString().ToLower(), 
                        Type = Calls.CallType.OUTGOING.ToString().ToLower(), IconCall = "call.png"},
                    new Calls() {Username = "ilham pret", CallCount = 1, Condition = Calls.CallCondition.ANSWERED.ToString().ToLower(), 
                        Type = Calls.CallType.INCOMING.ToString().ToLower(), IconCall = "incomingcall.png"},
                    new Calls() {Username = "i pantat", CallCount = 1, Condition = Calls.CallCondition.MISSED.ToString().ToLower(), 
                        Type = Calls.CallType.INCOMING.ToString().ToLower(), IconCall = "call.png"},
                    new Calls() {Username = "Hendroxx Garroxx", CallCount = 1, Condition = Calls.CallCondition.REJECTED.ToString().ToLower(), 
                        Type = Calls.CallType.OUTGOING.ToString().ToLower(), IconCall = "call.png"},
                    new Calls() {Username = "ilham pret", CallCount = 3, Condition = Calls.CallCondition.REJECTED.ToString().ToLower(), 
                        Type = Calls.CallType.INCOMING.ToString().ToLower(), IconCall = "call.png"},
                    new Calls() {Username = "Hendroxx Garroxx", CallCount = 1, Condition = Calls.CallCondition.MISSED.ToString().ToLower(), 
                        Type = Calls.CallType.INCOMING.ToString().ToLower(), IconCall = "call.png"},
                    new Calls() {Username = "Hendroxx Garroxx", CallCount = 1, Condition = Calls.CallCondition.ANSWERED.ToString().ToLower(), 
                        Type = Calls.CallType.OUTGOING.ToString().ToLower(), IconCall = "outgoingcall.png"},
                    new Calls() {Username = "Hendroxx Garroxx", CallCount = 1, Condition = Calls.CallCondition.ANSWERED.ToString().ToLower(), 
                        Type = Calls.CallType.INCOMING.ToString().ToLower(), IconCall = "incomingcall.png"},
                    new Calls() {Username = "Hendroxx Garroxx", CallCount = 1, Condition = Calls.CallCondition.ANSWERED.ToString().ToLower(), 
                        Type = Calls.CallType.INCOMING.ToString().ToLower(), IconCall = "incomingcall.png"},
                };
            }
        }

        public Message Message
        {
            get
            {
                return new Message()
                {
                    Msg = new string[]
                    {
                        "Oii", "p", "p", "Mabar Kuy", "Kuy"
                    }
                };
            }
        }

        //Command
        //public ICommand ChatSelectionChangeComand { get; private set; }

        //SelectedItem of CollectionView
        public Contact ChatSelectedItems { get; set; }


        public HomeViewModel()
        {
        } 
    }
}
