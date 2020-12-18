using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TamagotchiAnimalAPI.Controllers;
using TamagotchiAnimalAPI.Entities;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using TamagotchiAnimalAPI.Entities;

namespace TamagotchiAnimalAPI.SignalR
{
    public class AnimalValuesHub : Hub 
    {
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
