using Miki.Common.Interfaces;
using System.Threading.Tasks;

namespace Miki.Common.Events
{
    public interface ICommandHandler
    {
        bool IsPrivate { get; set; }
        bool ShouldBeDisposed { get; set; }

        ulong Owner { get; set; }

        bool ShouldDispose();

        void AddCommand(ICommandEvent cmd);

        void AddModule(IModule module);

        EventAccessibility GetUserAccessibility(IDiscordMessage message);

        ICommandEvent GetCommandEvent(string id);

        IEvent GetEvent(string id);

        IModule GetModule(string id);

		Task<string> GetPrefixAsync(ulong id);

        Task RequestDisposeAsync();

        string[] GetAllEventNames();
    }
}