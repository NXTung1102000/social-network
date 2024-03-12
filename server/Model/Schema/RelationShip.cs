using Microsoft.EntityFrameworkCore;
using Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Schema
{
    [Table("RelationShip")]
    public class RelationShip
    {
        public required RelationShipEnum Relation {  get; set; }

        public virtual required User User1 { get; set; }
        public virtual required User User2 { get; set; }

        public static void Fluent(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RelationShip>(entity =>
            {

            });
        }
    }
}
