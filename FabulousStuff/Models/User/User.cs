using System;
using System.Configuration;
using MongoDB.Bson.Serialization.Attributes;

namespace FabulousStuff.Models.User
{
    public class User
    {
        public User()
        {
            DateCreated = DateTime.Now;
        }

        [BsonId]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public string UserName { get; set; }
        private DateTime? DateCreated { get; }
        private DateTime? LastLoginTime { get; set; }
        private DateTime? LastActivityDate { get; set; }

        // Level of User.
        // Will be defined by another Function.
        private byte Level { get; set; }
    }
}