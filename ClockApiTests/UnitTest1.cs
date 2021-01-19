using System;
using System.Collections.Generic;
using ClockApi.Controllers;
using ClockApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using Shared.Extensions.ActiveMQ;

namespace ClockApiTests
{
    [TestClass]
    public class UnitTest1
    {
        TimeController controller;
        List<TimeStamp> models;

        int amount = 10;
        int seed = 888;

        [TestInitialize]
        public void Init()
        {
            controller = new TimeController(
                new MongoClient("mongodb+srv://Mickey:Mickey123@fontysprojects.b76fa.azure.mongodb.net/?retryWrites=true&w=majority"),
                new ActiveMQLog("tcp://82.169.80.49:61616", "admin", "admin")
            );

            models = Timestamp_Test_Factory.GenerateAnimals(amount, seed);

            foreach (var model in models)
                controller.Post(model);
        }

        [TestCleanup]
        public void Clean()
        {
            foreach (var model in models)
                controller.Remove(model.Id);
        }


        [TestMethod]
        public void GetOneTest()
        {
            TimeStamp expected = models[2];

            var actual = controller.Get(models[2].UserId).Result;

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Id, actual.Id, "failed - unable to get data.");
        }

        [TestMethod]
        public void GetAllTest()
        {
            foreach (var model in models)
            {
                TimeStamp expected = model;
                TimeStamp actual = controller.Get(model.UserId).Result;



                Assert.IsNotNull(actual);
                Assert.AreEqual(expected.Id, actual.Id, "failed - unable to get data with id: " + expected.Id + ".");
            }
        }

        [TestMethod]
        public void RemoveTest()
        {
            TimeStamp expected = models[1];
            controller.Remove(expected.Id);

            TimeStamp actual = controller.Get(expected.Id).Result;

            Assert.AreEqual(null, actual, "failed - unable to remove item.");
        }

        [TestMethod]
        public void PostTest()
        {
            TimeStamp expected = Timestamp_Test_Factory.GenerateUsers(seed);
            controller.Post(expected);
            models.Add(expected);

            TimeStamp actual = controller.Get(expected.UserId).Result;

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Id, actual.Id, "failed - unable to add item.");
        }
    }
    public static class Timestamp_Test_Factory
    {
        public static TimeStamp GenerateUsers(int seed)
        {
            Random gen = new Random(seed);
            TimeStamp timeStamp = new TimeStamp
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                LastOnline = RandomDay(gen),
            };

            return timeStamp;
        }
        public static List<TimeStamp> GenerateAnimals(int amount, int seed)
        {
            var timeStamps = new List<TimeStamp>();
            for (int i = 0; i < amount; i++)
                timeStamps.Add(GenerateUsers(seed));

            return timeStamps;
        }

        private static DateTime RandomDay(Random r)
        {
            DateTime start = new DateTime(2020, 11, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(r.Next(range));
        }
    }
}
