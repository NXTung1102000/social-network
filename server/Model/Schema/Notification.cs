using Microsoft.EntityFrameworkCore;
using Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Model.Schema
{
    [Table("Notification")]
    public class Notification : IdentityAbstractClass<int>
    {
        public RedirectNoti Redirect { get; set; } = RedirectNoti.None;
        public string Description { get; set; } = string.Empty;
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public string Target {  get; set; } = string.Empty;

        public virtual required User User { get; set; }

        public static void Fluent(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notification>(entity =>
            {

            });
        }
    }
}
