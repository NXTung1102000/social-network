using Microsoft.Extensions.DependencyInjection;
using Repository;
using Model.Schema;

namespace Configurations
{
    public static class Service
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            #region Add-UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            #region Add-Repository
            services.AddScoped<IGenericRepository<Chat>, GenericRepository<Chat>>();
            services.AddScoped<IGenericRepository<ChatMember>, GenericRepository<ChatMember>>();
            services.AddScoped<IGenericRepository<ChatMember>, GenericRepository<ChatMember>>();
            services.AddScoped<IGenericRepository<Like>, GenericRepository<Like>>();
            services.AddScoped<IGenericRepository<Media>, GenericRepository<Media>>();
            services.AddScoped<IGenericRepository<Message>, GenericRepository<Message>>();
            services.AddScoped<IGenericRepository<Notification>, GenericRepository<Notification>>();
            services.AddScoped<IGenericRepository<Post>, GenericRepository<Post>>();
            services.AddScoped<IGenericRepository<RelationShip>, GenericRepository<RelationShip>>();
            services.AddScoped<IGenericRepository<User>, GenericRepository<User>>();
            #endregion
            return services;
        }
    }
}