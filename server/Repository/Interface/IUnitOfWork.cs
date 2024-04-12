using Model.Schema;

namespace Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Chat> ChatRepository { get; }
        IGenericRepository<ChatMember> ChatMemberRepository { get; }
        IGenericRepository<Comment> CommentRepository { get; }
        IGenericRepository<Like> LikeRepository { get; }
        IGenericRepository<Media> MediaRepository { get; }
        IGenericRepository<Message> MessageRepository { get; }
        IGenericRepository<Notification> NotificationRepository { get; }
        IGenericRepository<Post> PostRepository { get; }
        IGenericRepository<RelationShip> RelationShipRepository { get; }
        IGenericRepository<User> UserRepository { get; }
        Task Save();
    }
}