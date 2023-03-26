using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace Paramo
{
    public class FileUtil
    {

        private readonly List<IUser> _users = new List<IUser>();

        public List<IUser> GetUsers() {

            var reader = ReadUsersFromFile();

            while (reader.Peek() >= 0)
            {
                var line = reader.ReadLineAsync().Result;

                IUser user;
                
                var name = line.Split(',')[0].ToString();
                var email = line.Split(',')[1].ToString();
                var phone = line.Split(',')[2].ToString();
                var address = line.Split(',')[3].ToString();
                var userType = line.Split(',')[4].ToString();
                var money = decimal.Parse(line.Split(',')[5].ToString());

                
                if (userType.Equals("Normal"))
                {
                    user = new Normal() { Name = name, Email = email, Address = address, Phone = phone, Money = money };
                }
                else if (userType.Equals("SuperUser"))
                {
                    user = new SuperUser() { Name = name, Email = email, Address = address, Phone = phone, Money = money };
                }
                else if (userType.Equals("Premium"))
                {
                    user = new Premium() { Name = name, Email = email, Address = address, Phone = phone, Money = money };
                }
                else
                {
                    user = new Normal() { Name = name, Email = email, Address = address, Phone = phone, Money = money };
                }                   

                _users.Add(user);
            }

            reader.Close();

            return this._users; 
        }

        private StreamReader ReadUsersFromFile()
        {
            var path = Directory.GetCurrentDirectory() + "/Files/Users.txt";

            FileStream fileStream = new FileStream(path, FileMode.Open);

            StreamReader reader = new StreamReader(fileStream);
            return reader;
        }
    }
}
