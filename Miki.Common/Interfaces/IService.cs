using Miki.Common.Events;

namespace Miki.Common.Interfaces
{
    public interface IService : IEvent
    {
        void Install(IModule m);

        void Uninstall(IModule m);
    }
}