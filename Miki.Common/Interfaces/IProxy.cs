namespace Miki.Common
{
    public interface IProxy<T>
    {
        T ToNativeObject();
    }
}