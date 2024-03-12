using Microsoft.EntityFrameworkCore;
using Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Schema
{
    [Table("Like")]
    public class Like : IdentityAbstractClass<int>
    {
        public ReactLikeEnum Type { get; set; } = ReactLikeEnum.Like;

        public virtual required User User { get; set; }
        public virtual Post? Post { get; set; } = null;
        public virtual Comment? Comment { get; set; } = null;
        public virtual Message? Message {  get; set; } = null;

        public static void Fluent(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Like>(entity =>
            {

            });
        }
    }
}
