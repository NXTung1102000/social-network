using Microsoft.EntityFrameworkCore;
using Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Schema
{
    [Table("Media")]
    public class Media : IdentityAbstractClass<Guid>
    {
        public required string Url { get; set; }
        public required string Title { get; set; }
        public required MessageTypeEnum Type { get; set; }

        public static void Fluent(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Media>(entity =>
            {

            });
        }
    }
}
