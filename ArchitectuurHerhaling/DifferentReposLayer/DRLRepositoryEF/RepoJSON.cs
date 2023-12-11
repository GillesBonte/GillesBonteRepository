using DRLUserModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using System.Xml;

namespace DRLRepositoryEF
{
    
    public class RepoJSON : IRepo
    {
        private string _jsonFile;

        public RepoJSON()
        {
            _jsonFile = AppDomain.CurrentDomain.BaseDirectory + "Users.json";
        }

        public void Add(User user)
        {
            List<User> users = GetAll();
            users.Add(user);
            string updatedJSON = JsonSerializer.Serialize(users);
            File.WriteAllText(_jsonFile, updatedJSON);
        }

        public void Create()
        {

        }

        public void Delete(User user)
        {
            List<User> users = GetAll();
            User userToRemove = users.Find(u => u.Id == user.Id);

            if (userToRemove != null) 
            {
                users.Remove(userToRemove);
                string updatedJSON = JsonSerializer.Serialize(users);
                File.WriteAllText(_jsonFile, updatedJSON);
            }


        }

        public List<User> GetAll()
        {
            List<User> users;

            try
            {
                using StreamReader reader = new StreamReader(_jsonFile);
                string json = reader.ReadToEnd();
                users = JsonSerializer.Deserialize<List<User>>(json);

            }
            catch (Exception)
            {
                users = new List<User>();
            }

            return users;
        }

        public void Update(User user)
        {
        }
    }
}
