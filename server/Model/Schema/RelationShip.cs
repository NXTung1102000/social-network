using Microsoft.EntityFrameworkCore;
using Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Schema
{
    [Table("RelationShip")]
    public class RelationShip
    {
        public required Guid UserId1 { get; set; }
        public required Guid UserId2 { get; set; }
        public required RelationShipEnum Relation { get; set; }

        public virtual required User User1 { get; set; }
        public virtual required User User2 { get; set; }

        public static void Fluent(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RelationShip>(entity =>
            {
                entity.HasKey(k => new { k.UserId1, k.UserId2 });
            });
        }
    }
}
