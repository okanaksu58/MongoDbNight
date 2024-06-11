namespace MongoDbNight.Settings
{
    public interface IDatabaseSettings
    {
        public string CategoryCollectionName { get; }
        public string ProductCollectionName { get; }
        public string ConnectionString { get; }
        public string DatabaseName { get; }
    }
}
