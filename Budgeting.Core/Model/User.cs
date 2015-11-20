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

        public User()
        {

        }

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
    }

    [XmlRoot("Users")]
    public class UserCollection
    {
        [XmlElement("User")]
        public User[] Users { get; set; }
    }
}