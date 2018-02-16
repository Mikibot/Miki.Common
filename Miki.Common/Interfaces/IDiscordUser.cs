using Miki.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Miki.Common
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
        Task AddRolesAsync(params IDiscordRole[] roles);

        Task Ban(IDiscordGuild guild, int pruneDays = 0, string reason = "");

        string GetAvatarUrl(DiscordAvatarType type = DiscordAvatarType.PNG, ushort size = 128);

		string GetName();

		bool HasPermissions(IDiscordChannel channel, params DiscordGuildPermission[] permissions);

		Task Kick(string reason = "");

		Task QueueMessageAsync(string text, IDiscordEmbed embed = null);

		Task RemoveRoleAsync(IDiscordRole role);
        Task RemoveRolesAsync(List<IDiscordRole> roles);

        Task SendFileAsync(string path);

        Task<IDiscordMessage> SendMessageAsync(string text, IDiscordEmbed embed = null);

        Task SetNicknameAsync(string text);

        Task Unban(IDiscordGuild guild);
    }

	public interface IDiscordSelfUser : IDiscordUser
	{
		Task ModifyAsync(Action<SelfUserData> modifiedData);
	}

	public class SelfUserData
	{
		public string Username;
		public DiscordImage? Image;
	}

	public struct DiscordImage
	{
		private Stream stream;

		public DiscordImage(Stream stream)
		{
			this.stream = stream;
		}

		public Stream Stream 
			=> stream;
	}

    public enum DiscordAvatarType
    {
        PNG, GIF
    };
}