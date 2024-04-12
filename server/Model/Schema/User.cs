using Microsoft.EntityFrameworkCore;
using Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Schema
{
    [Table("User")]
    public class User : IdentityAbstractClass<Guid>
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public required string Phonenumber { get; set; }
        public required string DisplayName { get; set; }
        public GenderEnum Gender { get; set; } = GenderEnum.None;
        public string? Address { get; set; }
        public DateTime? Birthday { get; set; }
        public bool IsBlock { get; set; } = false;
        public string? RefreshToken { get; set; } = null;

        public virtual Media? Avatar { get; set; } = null;
        public virtual Media? CoverPhoto { get; set; } = null;

        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<Post> NewFeed { get; set; }

        public User()
        {
            this.Notifications = new HashSet<Notification>();
            this.Chats = new HashSet<Chat>();
            this.NewFeed = new HashSet<Post>();
        }

        public static void Fluent(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {

            });
        }
    }
}
