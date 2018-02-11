namespace Miki.Common.Interfaces
{
    public interface IQuery<T>
    {
        T Query(string query);
    }
}