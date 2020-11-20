using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConnectDB()
        {
            //MongoCRUD db = new MongoCRUD("Test");
            //PersonModel p1 = new PersonModel
            //{
            //    Email = "Test@WerktDit.be",
            //    Password = "test12345"
            //};

            //db.InsertRecord("Users", p1);

        }
    }

    class PersonModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
