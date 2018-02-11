﻿using System.Threading.Tasks;

namespace Miki.Common.Interfaces
{
    public interface IDiscordEmbed
    {
        IEmbedAuthor Author { get; set; }
        Color Color { get; set; }
        string Description { get; set; }
        IEmbedFooter Footer { get; set; }
        string ImageUrl { get; set; }
        string ThumbnailUrl { get; set; }
        string Title { get; set; }
        string Url { get; set; }

        IDiscordEmbed AddField(string title, string value);
        IDiscordEmbed AddField(IEmbedField field);

        IDiscordEmbed AddInlineField(object title, object value);

        IEmbedAuthor CreateAuthor();
        IDiscordEmbed CreateAuthor(string text, string iconUrl, string url);

        IEmbedFooter CreateFooter();
        IDiscordEmbed CreateFooter(string text, string iconUrl);

        IDiscordEmbed SetAuthor(string name, string imageurl, string url);

        IDiscordEmbed SetColor(Color color);
        IDiscordEmbed SetColor(float r, float g, float b);
		IDiscordEmbed SetColor(int r, int g, int b);

        IDiscordEmbed SetDescription(string description);

        IDiscordEmbed SetFooter(string text, string iconurl);

        IDiscordEmbed SetImageUrl(string url);

        IDiscordEmbed SetThumbnailUrl(string url);

        IDiscordEmbed SetTitle(string title);

        IDiscordEmbed SetUrl(string url);

        Task<IDiscordMessage> SendToChannel(ulong channelId);
        Task<IDiscordMessage> SendToChannel(IDiscordMessageChannel channel);

		Task QueueToChannel(ulong channelId);
		Task QueueToChannel(IDiscordMessageChannel channel);

        Task<IDiscordMessage> SendToUser(ulong userId);
        Task<IDiscordMessage> SendToUser(IDiscordUser user);

		Task QueueToUser(ulong userId);
		Task QueueToUser(IDiscordUser user);

        Task ModifyMessage(IDiscordMessage message);
    }

	public interface IEmbedAuthor
	{
		string Name { get; set; }
		string IconUrl { get; set; }
		string Url { get; set; }
	}

	public interface IEmbedField
	{
		string Name { get; set; }
		string Value { get; set; }

		bool IsInline { get; set; }
	}

	public interface IEmbedFooter
	{
		string IconUrl { get; set; }
		string Text { get; set; }
	}
}