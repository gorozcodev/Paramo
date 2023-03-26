namespace Paramo
{
    public interface IUser
    {
        string Name { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string Phone { get; set; }
        decimal Money { get; set; }

        public Result accept(UserVisitor v);
    }
}
