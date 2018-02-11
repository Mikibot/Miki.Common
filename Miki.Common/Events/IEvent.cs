using Miki.Common.Interfaces;
using System.Threading.Tasks;

namespace Miki.Common.Events
{
    public interface IEvent
    {
        string Name { get; set; }

        EventAccessibility Accessibility { get; set; }

        bool OverridableByDefaultPrefix { get; set; }
        bool CanBeDisabled { get; set; }
        bool DefaultEnabled { get; set; }

        IModule Module { get; set; }

        int TimesUsed { get; set; }

        Task<bool> IsEnabled(ulong id);

        Task SetEnabled(ulong id, bool value);

        Task SetEnabledAll(IDiscordGuild guild, bool value);

        IEvent SetName(string name);

        IEvent SetAccessibility(EventAccessibility accessibility);
    }
}