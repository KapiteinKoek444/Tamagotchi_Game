using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Apache.NMS;
using Apache.NMS.ActiveMQ.Commands;
using Microsoft.AspNetCore.SignalR;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using Shared.Extensions.ActiveMQ;
using Shared.Shared.ApiModels;
using TamagotchiAnimalAPI.Controllers;
using TamagotchiAnimalAPI.Entities;
using TamagotchiAnimalAPI.SignalR;

namespace AnimalAPITests
{
    [TestClass]
    public class AnimalApi_Tests
    {
        AnimalController controller;
        private IHubContext<AnimalValuesHub> context;
        private ActiveMQLog activeMq;
        List<Animal> models;

        int amount = 10;
        int seed = 888;

        [TestInitialize]
        public void Init()
        {
            activeMq = new ActiveMQLog("tcp://82.169.80.49:61616", "admin", "admin");

            controller = new AnimalController(
                new MongoClient("mongodb+srv://Mickey:Mickey123@fontysprojects.b76fa.azure.mongodb.net/?retryWrites=true&w=majority"),
                activeMq,
                context
            );

            models = Animal_Test_Factory.GenerateAnimals(amount, seed);

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
            Animal expected = models[2];

            var actual = controller.Get(models[2].UserId).Result;

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Id, actual.Id, "failed - unable to get data.");
        }

        [TestMethod]
        public void UponClockMessageTest()
        {
            Animal animal = models[2];
            activeMq.ConnectSender("Clock.GetUserTimeStamp.queue");
            IMessage Textmessage = activeMq.ConvertObjectToIMessage<Animal>(animal);

            controller.UponClockMessage(Textmessage);
            var result = controller.message;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetAllTest()
        {
            foreach (var model in models)
            {
                Animal expected = model;
                Animal actual = controller.Get(model.UserId).Result;
                Assert.AreEqual(expected.Id, actual.Id, "failed - unable to get data with id: " + expected.Id + ".");
            }
        }

        [TestMethod]
        public void RemoveTest()
        {
            Animal expected = models[1];
            controller.Remove(expected.Id);

            Animal actual = controller.Get(expected.Id).Result;

            Assert.AreEqual(null, actual, "failed - unable to remove item.");
        }

        [TestMethod]
        public void PostTest()
        {
            Animal expected = Animal_Test_Factory.GenerateAnimals(seed);
            controller.Post(expected);
            models.Add(expected);

            Animal actual = controller.Get(expected.UserId).Result;

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Id, actual.Id, "failed - unable to add item.");
        }

        [TestMethod]
        public void UpdateTest()
        {
            Animal expected = models[1];
            expected.Name = "changed stuff";
            expected.Energy = 101;
            expected.Food = 101;
            expected.Happiness = 101;

            controller.Update(expected.UserId,expected);

            Animal actual = controller.Get(expected.UserId).Result;

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Id, actual.Id, "failed - unable to add item.");
            Assert.AreEqual(expected.Name, actual.Name, "failed - names not equal.");
            Assert.AreEqual(expected.Energy, actual.Energy, "failed - energy stats are not equal.");
            Assert.AreEqual(expected.Food, actual.Food, "failed - food stats are not equal.");
            Assert.AreEqual(expected.Happiness, actual.Happiness, "failed - happiness stats are not equal.");
        }
    }
    public static class Animal_Test_Factory
    {
        public static Animal GenerateAnimals( int seed)
        {
            int maxvalue = 100;

            var r = new Random(seed);
            Animal animal = new Animal
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                AnimalType = 1,
                Food = r.Next(0, maxvalue),
                Energy = r.Next(0, maxvalue),
                Happiness = r.Next(0, maxvalue),
                Name = $"test animal: {seed}"
            };

            return animal;
        }
        public static List<Animal> GenerateAnimals(int amount, int seed)
        {
            var Animallist = new List<Animal>();

            for (int i = 0; i < amount; i++)
                Animallist.Add(GenerateAnimals(seed));

            return Animallist;
        }
    }
}

