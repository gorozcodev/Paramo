namespace Paramo
{
    public class Normal : IUser
    {
        private decimal money;

        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal Money { get => money; 
            
            set 
            {
                //If new user is normal and has more than USD100
                if (value > 100)
                {
                    var percentage = Convert.ToDecimal(0.12);                                      
                    var gif = value * percentage;
                    money = value + gif;
                }
                else if (value < 100)
                {
                    if (value > 10)
                    {
                        var percentage = Convert.ToDecimal(0.8);
                        var gif = value * percentage;
                        money = value + gif;
                    }
                }
            } 
        }

        public Result accept(UserVisitor v)
        {
            return v.visit(this);
        }
    }
}
