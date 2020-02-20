using GRinger.Model.Abstractions.Telegram;
using System;
using System.Collections.Generic;
using System.Text;

namespace GRinger.Model.Telegram
{
    public class User : IUser
    {
        public string Username { get; set; }

        public string Phone { get; set; }
    }
}