using System.Threading.Tasks;

namespace Miki.Common.Interfaces
{
    public interface IDiscordAudioChannel : IDiscordChannel
    {
        Task<IDiscordAudioClient> ConnectAsync();
    }
}