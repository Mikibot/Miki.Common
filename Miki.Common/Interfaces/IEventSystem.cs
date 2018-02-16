using Miki.Common.Events;
using Miki.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Miki.Common
{
    public interface IEventSystem
    {
		ICommandHandler CommandHandler { get; }

		int CommandsUsed { get; }

		List<ulong> DeveloperIds { get; }

		void AddDeveloper(ulong id);

		void AddPrivateCommandHandler(IDiscordMessage msg, ICommandHandler handler);

		void Ignore(ulong id);

		IEvent GetEventByName(string name);

		IModule GetModuleByName(string name);

		Task<string> ListCommandsAsync(IDiscordMessage message);

		Task<IDiscordMessage> ListenNextMessageAsync(ulong channelId, ulong userId);
	}
}
