namespace BlogSystem.ConsoleClient
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using BlogSystem.Data;
    using BlogSystem.Models;

    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new BlogSystemDbContext();

            db.Users.Add(new User
            {
				Username = "csyntax",
				Gender = Gender.Male,
				RegistrationDate = DateTime.Now,
				FullName = "Ivan Ivanov",
				Birthday = new DateTime(1876, 11, 12),
				ContactInfo = new UserContactInfo
				{
                    Twitter = "@slayer.word.11",
                    Facebook = "IvanIvanov",
                    PhoneNumber = "0888888888",
                    Skype = "ivanivanov982"
                }
            });

            db.SaveChanges();

            Console.WriteLine(db.Users.Count());
        }
    }
}