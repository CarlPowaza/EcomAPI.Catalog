namespace EcomAPI.Catalog.Data
{
    using global::MongoDB.Driver;
    using global::MongoDB.Bson;
    public class Database
    {

        const string connectionUri = "mongodb+srv://carlpowaza:tarl@ecomapicatalog.xvxesuv.mongodb.net/?retryWrites=true&w=majority&appName=EcomAPICatalog";
        private MongoClientSettings settings;
        private MongoClient client;

        private static IMongoCollection<Item> _collection;

            // Connection string to your MongoDB server
            //var connectionString = connectionUri;
            //var client = new MongoClient(connectionString);

            //// Database name
            //var databaseName = "Catalog";
            //var database = client.GetDatabase(databaseName);

            //// Collection name
            //var collectionName = "Item";
            //_collection = database.GetCollection<Item>(collectionName);

            // Create a collection (MongoDB creates it automatically when you insert a document)
            // CreateCollection is not necessary unless you need specific options

            // Insert a new user
            //var newUser = new Item { Name = "John Doe", Age = 30 };
            //await InsertUser(newUser);

            //// Update the user's age
            //var userId = newUser.Id;
            //await UpdateUserAge(userId, 31);

            //// Fetch and print all users
            //await PrintAllUsers();

            //// Delete the user
            //await DeleteUser(userId);

            //// Print all users again to confirm deletion
            //await PrintAllUsers();
        
        public Database()
        {
            settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to set the version of the Stable API on the client
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
                      
            // Create a new client and connect to the server
            client = new MongoClient(settings);       
            
            //// Database name
            var databaseName = "Catalog";
            var database = client.GetDatabase(databaseName);

            //// Collection name
            var collectionName = "Item";
            _collection = database.GetCollection<Item>(collectionName);
        }

        public void testingDB()
        {
            try
            {
                var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");


                var ok = client.GetDatabase("Catalog").ListCollectionNames().Any();


                var test = 1;











            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        public async Task<bool> InsertUser(Item item)
        {
            await _collection.InsertOneAsync(item);
            Console.WriteLine($"Inserted user: {item.Name} with ID: {item.Id}");
            return true;
        }


    }
}
