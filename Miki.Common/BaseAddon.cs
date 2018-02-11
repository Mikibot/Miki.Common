using System.Threading.Tasks;

namespace Miki.Common
{
    public interface IAddon
    {
        Task<IAddonInstance> Create(IAddonInstance i);
    }
}