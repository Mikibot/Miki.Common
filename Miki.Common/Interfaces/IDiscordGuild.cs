﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Miki.Common.Interfaces
{
    public interface IDiscordGuild : IDiscordEntity
    {
        string AvatarUrl { get; }
        string Name { get; }

		ulong OwnerId { get; }

		Task<int> GetChannelCountAsync();
		Task<int> GetVoiceChannelCountAsync();
		Task<int> GetUserCountAsync();

		Task<IDiscordUser> GetOwnerAsync();
		Task<IDiscordUser> GetCurrentUserAsync();

        List<IDiscordRole> Roles { get; }

        Task<IDiscordUser> GetUserAsync(ulong user_id);

        Task<List<IDiscordMessageChannel>> GetChannels();

        Task<IDiscordMessageChannel> GetDefaultChannel();

        IDiscordRole GetRole(ulong role_id);
    }
}