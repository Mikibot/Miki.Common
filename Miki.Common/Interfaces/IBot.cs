using Miki.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Miki.Common
{
	public interface IClient
	{
		IDiscordSelfUser CurrentUser { get; }

		IReadOnlyList<IDiscordGuild> Guilds { get; }

		int Latency { get; }
	}

	public interface IBot : IClient
    {
		event Func<IDiscordGuild, Task> GuildJoin;
		event Func<IDiscordGuild, Task> GuildLeave;
		event Func<IDiscordGuild, IDiscordGuild, Task> GuildUpdate;

		event Func<IDiscordMessage, Task> MessageReceived;

		event Func<int, Task> ShardConnect;
		event Func<Exception, int, Task> ShardDisconnect;

		event Func<IDiscordUser, Task> UserJoin;
		event Func<IDiscordUser, Task> UserLeave;
		event Func<IDiscordUser, IDiscordUser, Task> UserUpdate;

		ClientInformation Information { get; }

		IReadOnlyList<IShard> Shards { get; }

		Task ConnectAsync();

		IDiscordMessageChannel GetChannel(ulong id);

		IDiscordGuild GetGuild(ulong id);

		IDiscordUser GetUser(ulong id);

		IShard GetShard(int id);
		IShard GetShardFor(IDiscordGuild guild);
    }

	public interface IShard : IClient
	{
		ShardConnectionState ConnectionState { get; }

		int Id { get; }
	}

	public enum ShardConnectionState : byte
	{
		Disconnected = 0,
		Connecting = 1,
		Connected = 2,
		Disconnecting = 3
	}
}
