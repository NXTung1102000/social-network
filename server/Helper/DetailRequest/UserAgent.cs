using Microsoft.Extensions.Primitives;
using UAParser;

namespace Helper
{
    public class UserAgent
    {
        public static (string, string) GetUserAgentData(StringValues userAgentHeader)
        {
            var uaParser = Parser.GetDefault();
            var clietnInfo = uaParser.Parse(userAgentHeader);

            return new(
                clietnInfo.OS.ToString(), // operation system: win10, win 11, ubuntu,..
                clietnInfo.UA.ToString()  // brower
            );
        }
    }
}
