using Miki.Common.Interfaces;
using System.Threading.Tasks;

namespace Miki.Common.Events
{
    public class EventContext
    {
        public string arguments;

		public IBot bot;

		public ICommandHandler commandHandler;

        public IDiscordMessage message;

        public IDiscordUser Author => message.Author;

        public IDiscordMessageChannel Channel => message.Channel;

		public IDiscordGuild Guild => message.Guild;

		public IEventSystem EventSystem;

		public async Task<IDiscordUser> GetCurrentUserAsync()
			=> await Guild.GetCurrentUserAsync();
	}
}