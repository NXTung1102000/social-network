using Microsoft.EntityFrameworkCore;
using Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Schema
{
    [Table("Message")]
    public class Message : IdentityAbstractClass<Guid>
    {
        public MessageTypeEnum MessageType { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdateAt { get; set; } = DateTime.UtcNow;

        public virtual required Chat Chat { get; set; }
        public virtual required User Creator { get; set; }
        public virtual Media? Media { get; set; } = null;

        public virtual ICollection<Like> Likes { get; set; }

        public Message()
        {
            this.Likes = new HashSet<Like>();
        }

        public static void Fluent(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>(entity =>
            {

            });
        }
    }
}
