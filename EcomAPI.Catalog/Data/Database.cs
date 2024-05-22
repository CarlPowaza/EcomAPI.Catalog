namespace EcomAPI.Catalog.Data
{
    using global::MongoDB.Driver;
    using global::MongoDB.Bson;
    public class Database
    {

        const string connectionUri = "mongodb+srv://carlpowaza:tarl@ecomapicatalog.xvxesuv.mongodb.net/?retryWrites=true&w=majority&appName=EcomAPICatalog";
        private MongoClientSettings settings;
        private MongoClient client;
     

        public Database()
        {

            settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to set the version of the Stable API on the client
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            client = new MongoClient(settings);


        }

        public void testingDB()
        {
            try
            {
                var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");


                client.GetDatabase("Catalog").
                










            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }






    }
}
