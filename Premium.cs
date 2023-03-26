namespace Paramo
{
    public class Premium : IUser
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
                    var gif = value * 2;
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
