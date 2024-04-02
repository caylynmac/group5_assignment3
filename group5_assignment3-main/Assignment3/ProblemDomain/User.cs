using System;
using Assignment3.Utility;
using Assignment3;
namespace Assignment3.ProblemDomain
{
    public class User : IEquatable<User>
    {
        public int Id { get; }
        public string Name { get; }
        public string Email { get; }
        private string PasswordHash { get; }

        public User(int id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            PasswordHash = HashPassword(password);
        }

        public bool IsCorrectPassword(string input)
        {
            string inputHash = HashPassword(input);
            return PasswordHash == inputHash;
        }

        private string HashPassword(string password)
        {
            return password.GetHashCode().ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            User other = (User)obj;
            return Id == other.Id &&
                   Name == other.Name &&
                   Email == other.Email &&
                   PasswordHash == other.PasswordHash;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Email, PasswordHash);
        }

        public bool Equals(User other)
        {
            if (other == null)
                return false;

            return Id == other.Id &&
                   Name == other.Name &&
                   Email == other.Email &&
                   PasswordHash == other.PasswordHash;
        }
    }
}
