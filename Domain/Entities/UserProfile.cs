using System;

namespace StartiApi.Domain.Models
{
    public class UserProfile
    {
        public string Id { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public UserProfile(
            string id = null,
            string firstName = "",
            string lastName = "",
            string email = "",
            DateTime? createdAt = null,
            DateTime? updatedAt = null)
        {
            Id = id ?? Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            CreatedAt = createdAt ?? DateTime.Now;
            UpdatedAt = updatedAt ?? DateTime.Now;
        }
    }
}
