namespace MongoDbNight.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string CategoryCollectionName { get; }
        public string ProductCollectionName { get; }
        public string ConnectionString { get; }
        public string DatabaseName { get; }
    }
}
