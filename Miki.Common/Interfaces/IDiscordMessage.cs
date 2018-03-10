using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Miki.Common.Interfaces
{
	public interface IDiscordMessage : IDiscordEntity
	{
		IReadOnlyCollection<IDiscordAttachment> Attachments { get; }

		IDiscordUser Author { get; }
		IDiscordUser Bot { get; }

		IDiscordClient Discord { get; }

		IDiscordMessageChannel Channel { get; }

		IDiscordGuild Guild { get; }

		Dictionary<DiscordEmoji, DiscordReactionMetadata> Reactions { get; }

		string Content { get; }
		string ResolvedContent { get; }

		DateTimeOffset Timestamp { get; }

		IReadOnlyCollection<ulong> MentionedUserIds { get; }
		IReadOnlyCollection<ulong> MentionedRoleIds { get; }
		IReadOnlyCollection<ulong> MentionedChannelIds { get; }

		Task AddReactionAsync(string emoji);

		Task DeleteAsync();

		Task<IReadOnlyList<IDiscordUser>> GetReactionUsersAsync(DiscordEmoji emoji, int limit = 100, ulong? afterUserId = null);

		void Modify(string message, IDiscordEmbed embed);

		Task PinAsync();

		Task RemoveReactionAsync(string emoji, IDiscordUser user);

		Task UnpinAsync();
	}
}