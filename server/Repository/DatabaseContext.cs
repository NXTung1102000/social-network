using Microsoft.EntityFrameworkCore;
using Model.Seeding;
using Model.Schema;
namespace Repository
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> option) : base(option) { }

        #region DbSet
        public DbSet<Chat>? Chats { get; set; }
        public DbSet<ChatMember>? ChatMembers { get; set; }
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<Like>? Likes { get; set; }
        public DbSet<Media>? Medias { get; set; }
        public DbSet<Message>? Messages { get; set; }
        public DbSet<Notification>? Notifications { get; set; }
        public DbSet<Post>? Posts { get; set; }
        public DbSet<RelationShip>? RelationShips { get; set; }
        public DbSet<User>? Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Chat.Fluent(modelBuilder);
            ChatMember.Fluent(modelBuilder);
            Comment.Fluent(modelBuilder);
            Like.Fluent(modelBuilder);
            Media.Fluent(modelBuilder);
            Message.Fluent(modelBuilder);
            Notification.Fluent(modelBuilder);
            Post.Fluent(modelBuilder);
            RelationShip.Fluent(modelBuilder);
            User.Fluent(modelBuilder);
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsersSeed());
        }
    }
}
