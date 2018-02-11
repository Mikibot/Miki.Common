﻿using System;
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

        Task<IDiscordMessage> SendFileAsync(string path);
        Task<IDiscordMessage> SendFileAsync(MemoryStream stream, string extension);

        Task<IDiscordMessage> SendMessageAsync(string message);
		Task QueueMessageAsync(string message);

        [Obsolete("Use 'IDiscordEmbed.SendToChannel' instead")]
        Task<IDiscordMessage> SendMessage(IDiscordEmbed embed);

        Task SendTypingAsync();
    }
}