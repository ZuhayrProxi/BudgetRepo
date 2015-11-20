using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Budgeting.Core.Model
{
    [XmlRoot("Users")]
    public class User
    {
        
        public string Username { get; set; }
        public string Password { get; set; }
        public Guid id { get; set; }

<<<<<<< HEAD
        public User(string username, string password)
=======
        public User()
        {

        }

        public User(string Username, string Password)
>>>>>>> f0aa20d6e3002a1e6ba5e20b3fa34137877ef6f6
        {
            this.Username = username;
            this.Password = password;
        }
    }

    [XmlRoot("Users")]
    public class UserCollection
    {
        [XmlElement("User")]
        public User[] Users { get; set; }
    }
}