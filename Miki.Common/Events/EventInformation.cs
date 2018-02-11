using Miki.Common.Events;
using Miki.Common.Interfaces;
using System.Threading.Tasks;

namespace Miki.Common
{
    public enum EventAccessibility
    {
        PUBLIC,
        ADMINONLY,
        DEVELOPERONLY
    }

    public enum EventRange
    {
        USER,
        CHANNEL,
        SERVER
    }

    public delegate Task ProcessServerCommand(IDiscordGuild guild);

    public delegate Task ProcessCommandDelegate(EventContext context);

    public delegate bool CheckCommandDelegate(IDiscordMessage message, string command, string[] allAliases);
}