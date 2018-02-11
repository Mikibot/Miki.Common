namespace Miki.Common.Interfaces
{
    public interface IDiscordRole
    {
        ulong Id { get; }

        int Position { get; }

        Color Color { get; }

        string Mention { get; }
        string Name { get; }
    }
}