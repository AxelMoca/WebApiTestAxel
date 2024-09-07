namespace ApiTestMobileAxel
{
    public class UserService
    {
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User { Id = 1, Name = "Axel", Email = "axel@email.com" });
            users.Add(new User { Id = 2, Name = "Juan", Email = "juan@email.com" });
            users.Add(new User { Id = 3, Name = "Pedro", Email = "pedro@email.com" });
            users.Add(new User { Id = 4, Name = "Fernando", Email = "fernando@email.com" });
            return users;
       
        }
    }
}
