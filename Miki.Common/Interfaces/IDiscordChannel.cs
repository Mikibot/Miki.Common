using System.Collections.Generic;
using System.Threading.Tasks;

namespace Miki.Common.Interfaces
{
    public interface IDiscordChannel : IDiscordEntity
    {
        string Name { get; }

        IDiscordGuild Guild { get; }

        Task<List<IDiscordUser>> GetUsersAsync();
    }
}