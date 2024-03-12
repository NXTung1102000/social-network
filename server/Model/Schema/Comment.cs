using Microsoft.EntityFrameworkCore;
using Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Schema
{
    [Table("Comment")]
    public class Comment : IdentityAbstractClass<int>
    {
        public MessageTypeEnum MessageType { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime LastUpdateAt { get; set; } = DateTime.Now;

        public virtual required User Creator { get; set; }
        public virtual Post? Post { get; set; } = null;
        //public virtual Comment? CommentParent { get; set; } = null;
        public virtual Media? Media { get; set; } = null;
        public virtual ICollection<Like> Likes { get; set; }

        public Comment()
        {
            this.Likes = new HashSet<Like>();
        }

        public static void Fluent(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>(entity =>
            {

            });
        }
    }
}
