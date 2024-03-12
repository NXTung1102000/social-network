using Microsoft.EntityFrameworkCore;
using Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Schema
{
    [Table("Chat")]
    public class Chat : IdentityAbstractClass<Guid>
    {
        public required string DisplayName { get; set; }
        public string LastMessage { get; set; } = string.Empty;
        public DateTime? Time { get; set; } = null;

        public virtual Media? ImageCover { get; set; } = null;
        public virtual ICollection<User> Members { get; set; }

        public Chat()
        {
            this.Members = new HashSet<User>();
        }

        public static void Fluent(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>(entity =>
            {

            });
        }
    }
}
