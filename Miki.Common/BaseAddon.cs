using System.Threading.Tasks;

namespace Miki.Common
{
    public interface IAddon
    {
        IAddonInstance Create(IAddonInstance i);
    }
}