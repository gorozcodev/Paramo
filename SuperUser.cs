namespace Paramo
{
    public class SuperUser : IUser
    {
        private decimal money;

        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal Money
        {
            get => money;

            set
            {               
                if (value > 100)
                {
                    var percentage = Convert.ToDecimal(0.20);
                    var gif = value * percentage;
                    money = value + gif;
                }                
            }
        }

        public Result accept(UserVisitor v)
        {
            return v.visit(this);
        }
    }
}
