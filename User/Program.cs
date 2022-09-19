using System;

namespace User
{
    public class User
    {
        private readonly DateTime joinDate;

        public User(string name, string surname, int age, string login)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Login = login;
            joinDate = DateTime.Today;
        }

        public DateTime JoinDate => joinDate;

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Login { get; set; }

        public override string ToString()
        {
            return $"Name: {Name,-5} Surname: {Surname,-10} Login: {Login,-15} Age: {Age,-5} Joined: {JoinDate.ToShortDateString()}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("John", "Shelby", 18, "Shelby");
            Console.WriteLine(user.ToString());
        }
    }
}
