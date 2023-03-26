using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Paramo
{
    public class UserVisitor : IVisitor
    {
        private List<IUser> _users;

        public UserVisitor()
        {
            this._users =  new FileUtil().GetUsers();
        }

        public Result visit(Normal usr)
        { 
            if (_users.Where(c=> c.Email.Equals(usr.Email) || c.Phone.Equals(usr.Phone) || c.Name.Equals(usr.Name)).Any())
            {
                Debug.WriteLine("The user is duplicated");

                return new Result()
                {
                    IsSuccess = false,
                    Errors = "The user is duplicated"
                };
            }

            Debug.WriteLine("User Created");

            return new Result()
            {
                IsSuccess = true,
                Errors = "User Created"
            };
        }

        public Result visit(Premium usr)
        {
            if (_users.Where(c => c.Email.Equals(usr.Email) || c.Phone.Equals(usr.Phone) || c.Name.Equals(usr.Name)).Any())
            {
                Debug.WriteLine("The user is duplicated");

                return new Result()
                {
                    IsSuccess = false,
                    Errors = "The user is duplicated"
                };
            }

            Debug.WriteLine("User Created");

            return new Result()
            {
                IsSuccess = true,
                Errors = "User Created"
            };
        }

        public Result visit(SuperUser usr)
        {
            if (_users.Where(c => c.Email.Equals(usr.Email) || c.Phone.Equals(usr.Phone) || c.Name.Equals(usr.Name)).Any())
            {
                Debug.WriteLine("The user is duplicated");

                return new Result()
                {
                    IsSuccess = false,
                    Errors = "The user is duplicated"
                };
            }

            Debug.WriteLine("User Created");

            return new Result()
            {
                IsSuccess = true,
                Errors = "User Created"
            };
        }       
    }
}
