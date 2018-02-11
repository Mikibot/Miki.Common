using Miki.Common.Interfaces;
using System.Threading.Tasks;

namespace Miki.Common
{
    public delegate Task MessageRecievedEventDelegate(IDiscordMessage msg);

    public delegate Task GuildUserEventDelegate(IDiscordGuild guild, IDiscordUser user);

    public delegate Task GuildEventDelegate(IDiscordGuild guild);

    public delegate Task UserUpdatedEventDelegate(IDiscordUser oldUser, IDiscordUser newUser);
}