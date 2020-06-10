namespace InterfacesAndAbstracts.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string Username { get; set; }
        int Password { get; set; }

        void PrintUser(IUser user);

    }
}
