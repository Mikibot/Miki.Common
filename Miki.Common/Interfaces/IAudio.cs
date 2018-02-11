using System.IO;

namespace Miki.Common.Interfaces
{
    public interface IAudio
    {
        Stream AudioBytes { get; set; }
    }
}