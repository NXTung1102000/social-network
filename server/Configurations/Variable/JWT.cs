using Microsoft.Extensions.DependencyInjection;

namespace Configurations
{
    public class JWT
    {
        public readonly string SecretKey;
        public readonly string Issuer;
        public readonly string Audience;
        //ConfigurationManager
    }
}
