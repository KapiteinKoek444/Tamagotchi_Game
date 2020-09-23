using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.MongoDB
{
    public class MongoCRUD
    {
        private IMongoDatabase db;
        private string connectionString = "mongodb+srv://Mickey:Mic2011Kre@fontysprojects.b76fa.azure.mongodb.net/test?authSource=admin&replicaSet=atlas-tf8vz8-shard-0&readPreference=primary&appname=MongoDB%20Compass&ssl=true";

        public MongoCRUD(string database)
        {
            var client = new MongoClient(connectionString);
            db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table,T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

        public T LoadRecordById<T>(string table,Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }

        public void UpsertRecord<T> (string table, Guid id, T record)
        {
            var collection = db.GetCollection<T>(table);

            collection.ReplaceOne(new BsonDocument("_id", id), record);
        }

        public void DeleteRecord<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            collection.DeleteOne(filter);
        }
    }
}
