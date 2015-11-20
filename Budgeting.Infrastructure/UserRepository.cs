using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Budgeting.Core.Interfaces;
using Budgeting.Core.Model;

namespace Budgeting.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        public User Register(string username, string password)
        {
            User user = new User(username, password);

            SerializeXml(@"C:\Users.txt", user);

            return user;
        }

        public static void SerializeXml(string filepath, object obj)
        {
            var writer = new StreamWriter(filepath);
            var serializer = new XmlSerializer(obj.GetType(), new XmlRootAttribute("ListOfUsers"));

            serializer.Serialize(writer, obj);

            writer.Flush();
            writer.Close();
        }

        public static User DeserializeXml(string filepath)
        {
            var serializer = new XmlSerializer(typeof(List<User>));
            FileStream myFileStream = new FileStream(filepath, FileMode.Open);
            XmlReader reader = XmlReader.Create(myFileStream);
            var user = (User)serializer.Deserialize(reader);
            myFileStream.Close();

            return user;
        }

        public User Login(string user, string password)
        {
            throw new NotImplementedException();
        }
    }
}