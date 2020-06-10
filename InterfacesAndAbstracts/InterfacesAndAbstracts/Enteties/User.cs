using InterfacesAndAbstracts.Interfaces;

namespace InterfacesAndAbstracts.Enteties
{
    public abstract class User : IUser
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string Username { get; set; }
        public abstract int Password { get; set; }

        public abstract void PrintUser(IUser user);
    }
}
