namespace eRent.Services
{
    public interface IService<T, TSearch> where T : class where TSearch : class
    {
        IEnumerable<T> Get(TSearch search = null);
        T GetById(int id);

        T Test(int id);
    }
}
