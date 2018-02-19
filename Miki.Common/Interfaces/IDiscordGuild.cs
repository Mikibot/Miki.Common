using System.Collections.Generic;
using System.Threading.Tasks;

namespace Miki.Common.Interfaces
{
    public interface IDiscordGuild : IDiscordEntity
    {
        string AvatarUrl { get; }

        string Name { get; }

		ulong OwnerId { get; }

		List<IDiscordRole> Roles { get; }

		Task<int> GetChannelCountAsync();

		Task<List<IDiscordMessageChannel>> GetChannelsAsync();

		Task<IDiscordUser> GetCurrentUserAsync();

		Task<IDiscordMessageChannel> GetDefaultChannelAsync();

		Task<IDiscordUser> GetOwnerAsync();

		IDiscordRole GetRole(ulong role_id);

		Task<IDiscordUser> GetUserAsync(ulong user_id);
		Task<IDiscordUser> GetUserAsync(string username);

		Task<List<IDiscordUser>> GetUsersAsync();

		Task<int> GetUserCountAsync();

		Task<int> GetVoiceChannelCountAsync();
    }
}