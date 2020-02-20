using System;
using System.Collections.Generic;
using System.Text;

namespace GRinger.Model.Abstractions.Telegram
{
    /// <summary>
    /// Telegram's user grabbed entity
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// User's nickname or username
        /// </summary>
        string Username { get; set; }

        /// <summary>
        /// User's phone number
        /// </summary>
        string Phone { get; set; }
    }
}