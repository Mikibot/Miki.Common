using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Miki.Common.Interfaces
{
    public interface IDiscordMessageChannel : IDiscordChannel
    {
        bool Nsfw { get; }

        Task DeleteMessagesAsync(List<IDiscordMessage> messages);

        Task<List<IDiscordMessage>> GetMessagesAsync(int amount = 100);

		void QueueMessageAsync(string message);

		Task<IDiscordMessage> SendFileAsync(string path, string message = null);
        Task<IDiscordMessage> SendFileAsync(MemoryStream stream, string message = null);

        Task<IDiscordMessage> SendMessageAsync(string message, IDiscordEmbed embed = null);

        Task SendTypingAsync();
    }
}