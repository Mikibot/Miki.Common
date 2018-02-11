using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Miki.Common.Interfaces
{
    public interface IDiscordUser : IDiscordEntity
    {
        string AvatarUrl { get; }

		DateTimeOffset CreatedAt { get; }

		string Discriminator { get; }

		IDiscordGuild Guild { get; }

		int Hierarchy { get; }

		bool IsBot { get; }

		DateTimeOffset? JoinedAt { get; }

		string Mention { get; }

		string Nickname { get; }

		List<ulong> RoleIds { get; }

        string Username { get; }

        Task AddRoleAsync(IDiscordRole role);
        Task AddRolesAsync(List<IDiscordRole> roles);

        Task Ban(IDiscordGuild guild, int pruneDays = 0, string reason = "");

        string GetAvatarUrl(DiscordAvatarType type = DiscordAvatarType.PNG, ushort size = 128);

		string GetName();

		bool HasPermissions(IDiscordChannel channel, params DiscordGuildPermission[] permissions);

		Task Kick(string reason = "");

		Task QueueMessageAsync(string text);

		Task RemoveRoleAsync(IDiscordRole role);
        Task RemoveRolesAsync(List<IDiscordRole> roles);

        Task SendFile(string path);

        Task<IDiscordMessage> SendMessage(string text);

        Task SetNickname(string text);

        Task Unban(IDiscordGuild guild);
    }

    public enum DiscordAvatarType
    {
        PNG, GIF
    };
}