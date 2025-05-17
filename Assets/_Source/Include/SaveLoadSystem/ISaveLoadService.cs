namespace Include
{
    public interface ISaveLoadService
    {
        void Save(string dataID, object data);
        T Load<T>(string dataID);
    }
}