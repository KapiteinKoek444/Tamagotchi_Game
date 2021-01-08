using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using MongoDB_API.Controllers;
using MongoDB_API.Entities;
using Shared.Extensions.ActiveMQ;
using Shared.Shared.ApiModels;


namespace AnimalAPITests
{
    [TestClass]
    public class UserApi_Tests
    {
        UserController controller;
        List<User> models;

        int amount = 10;
        int seed = 888;

        [TestInitialize]
        public void Init()
        {
            controller = new UserController(
                new MongoClient("mongodb+srv://Mickey:Mickey123@fontysprojects.b76fa.azure.mongodb.net/?retryWrites=true&w=majority"),
                new ActiveMQLog("tcp://82.169.80.49:61616", "admin", "admin")
            );

            models = User_Test_Factory.GenerateAnimals(amount, seed);

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
        public void TestLogin()
        {
            foreach (var model in models)
            {
                var actual = controller.Login(model).Result;
                var okResult = actual as OkObjectResult;

                Assert.IsNotNull(okResult);
                Assert.AreEqual(200, okResult.StatusCode);
            }
        }

        [TestMethod]
        public void GetOneTest()
        {
            User expected = models[2];

            var actual = controller.Get(models[2].Id).Result;

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Id, actual.Id, "failed - unable to get data.");
        }

        [TestMethod]
        public void GetAllTest()
        {
            foreach (var model in models)
            {
                User expected = model;
                User actual = controller.Get(model.Id).Result;



                Assert.IsNotNull(actual);
                Assert.AreEqual(expected.Id, actual.Id, "failed - unable to get data with id: " + expected.Id + ".");
            }
        }

        [TestMethod]
        public void RemoveTest()
        {
            User expected = models[1];
            controller.Remove(expected.Id);

            User actual = controller.Get(expected.Id).Result;

            Assert.AreEqual(null, actual, "failed - unable to remove item.");
        }

        [TestMethod]
        public void PostTest()
        {
            User expected = User_Test_Factory.GenerateUsers(seed + seed);
            controller.Post(expected);
            models.Add(expected);

            User actual = controller.Get(expected.Id).Result;

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Id, actual.Id, "failed - unable to add item.");
        }
        [TestMethod]
        public void RegisterWithExistingData()
        {
            User expected = models[1];
            User clone = new User
            {
                Id = Guid.NewGuid(),
                Email = expected.Email,
                Password = expected.Password,
            };

            controller.Post(clone);

            User actual = controller.Get(clone.Id).Result;

            Assert.IsNull(actual);
        }
    }
    public static class User_Test_Factory
    {
        public static User GenerateUsers(int seed)
        {
            User user = new User
            {
                Id = Guid.NewGuid(),
                Email = $"test@{seed}.be",
                Password = $"{seed}"
            };

            return user;
        }
        public static List<User> GenerateAnimals(int amount, int seed)
        {
            var users = new List<User>();

            for (int i = 0; i < amount; i++)
                users.Add(GenerateUsers(i + seed));

            return users;
        }
    }

}

