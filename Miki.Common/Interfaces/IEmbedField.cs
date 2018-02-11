namespace Miki.Common.Interfaces
{
    public interface IEmbedField
    {
        string Name { get; set; }
        string Value { get; set; }

        bool IsInline { get; set; }
    }
}