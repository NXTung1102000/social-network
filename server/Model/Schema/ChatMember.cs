using Microsoft.EntityFrameworkCore;
using Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Schema
{
    [Table("ChatMember")]
    public class ChatMember
    {
        public Guid ChatId { get; set; }
        public Guid UserId { get; set; }
        public ChatRoleEnum Role { get; set; }
        public string NickName { get; set; } = string.Empty;

        public virtual required Chat Chat { get; set; }
        public virtual required User User { get; set; }

        public static void Fluent(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatMember>(entity =>
            {
                entity.HasKey(k => new { k.ChatId, k.UserId });
            });
        }

    }
}
