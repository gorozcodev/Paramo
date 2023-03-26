namespace Paramo
{
    public interface IVisitor
    {
        public Result visit(Normal usr);
        public Result visit(Premium usr);
        public Result visit(SuperUser usr);
    }
}
