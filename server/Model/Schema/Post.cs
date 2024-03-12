using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Schema
{
    [Table("Post")]
    public class Post : IdentityAbstractClass<Guid>
    {
        public string Description { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;

        public virtual required User Creator { get; set; }
        public virtual ICollection<Media> Medias { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }

        public Post()
        {
            this.Medias = new HashSet<Media>();
            this.Comments = new HashSet<Comment>();
            this.Likes = new HashSet<Like>();
        }

        public static void Fluent(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>(entity =>
            {

            });
        }
    }
}
