namespace Paramo
{
    public static class UserFactory
    {
        public static IUser getUser(string name, string email, string address, string phone, string userType, string money)
        {
            if (userType.Equals("Normal"))
            {

                //Normalize email
                var aux = email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                var atIndex = aux[0].IndexOf("+", StringComparison.Ordinal);
                aux[0] = atIndex < 0 ? aux[0].Replace(".", "") : aux[0].Replace(".", "").Remove(atIndex);

                return new Normal() { Name = name, Email = string.Join("@", new string[] { aux[0], aux[1] }), Address  = address, Phone = phone, Money = decimal.Parse(money) };
            }
            else if (userType.Equals("SuperUser"))
            {
                //Normalize email
                var aux = email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                var atIndex = aux[0].IndexOf("+", StringComparison.Ordinal);
                aux[0] = atIndex < 0 ? aux[0].Replace(".", "") : aux[0].Replace(".", "").Remove(atIndex);

                return new SuperUser() { Name = name, Email = string.Join("@", new string[] { aux[0], aux[1] }), Address = address, Phone = phone, Money = decimal.Parse(money) };
            }
            else if (userType.Equals("Premium"))
            {
                //Normalize email
                var aux = email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                var atIndex = aux[0].IndexOf("+", StringComparison.Ordinal);
                aux[0] = atIndex < 0 ? aux[0].Replace(".", "") : aux[0].Replace(".", "").Remove(atIndex);

                return new Premium() { Name = name, Email = string.Join("@", new string[] { aux[0], aux[1] }), Address = address, Phone = phone, Money = decimal.Parse(money) };
            }
            else
            {
                //Normalize email
                var aux = email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                var atIndex = aux[0].IndexOf("+", StringComparison.Ordinal);
                aux[0] = atIndex < 0 ? aux[0].Replace(".", "") : aux[0].Replace(".", "").Remove(atIndex);

                return new Normal() { Name = name, Email = string.Join("@", new string[] { aux[0], aux[1] }), Address = address, Phone = phone, Money = decimal.Parse(money) };
            }
        }
    }
}
