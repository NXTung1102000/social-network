using Model.Schema;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Chat> _chatsRepository;
        private IGenericRepository<ChatMember> _chatMembersRepository;
        private IGenericRepository<Comment> _commentsRepository;
        private IGenericRepository<Like> _likesRepository;
        private IGenericRepository<Media> _mediasRepository;
        private IGenericRepository<Message> _messagesRepository;
        private IGenericRepository<Notification> _notificationsRepository;
        private IGenericRepository<Post> _postsRepository;
        private IGenericRepository<RelationShip> _relationShipRepository;
        private IGenericRepository<User> _userRepository;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IGenericRepository<Chat> ChatRepository => _chatsRepository ??= new GenericRepository<Chat>(_context);
        public IGenericRepository<ChatMember> ChatMemberRepository => _chatMembersRepository ??= new GenericRepository<ChatMember>(_context);
        public IGenericRepository<Comment> CommentRepository => _commentsRepository ??= new GenericRepository<Comment>(_context);
        public IGenericRepository<Like> LikeRepository => _likesRepository ??= new GenericRepository<Like>(_context);
        public IGenericRepository<Media> MediaRepository => _mediasRepository ??= new GenericRepository<Media>(_context);
        public IGenericRepository<Message> MessageRepository => _messagesRepository ??= new GenericRepository<Message>(_context);
        public IGenericRepository<Notification> NotificationRepository => _notificationsRepository ??= new GenericRepository<Notification>(_context);
        public IGenericRepository<Post> PostRepository => _postsRepository ??= new GenericRepository<Post>(_context);
        public IGenericRepository<RelationShip> RelationShipRepository => _relationShipRepository ??= new GenericRepository<RelationShip>(_context);
        public IGenericRepository<User> UserRepository => _userRepository ??= new GenericRepository<User>(_context);

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
