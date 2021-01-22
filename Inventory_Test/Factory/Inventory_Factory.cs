using Shared.Shared.ApiModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_Test.Factory
{
	public static class Inventory_Factory
	{
		public static InventoryModel GenerateInventory(int seed)
		{
			int maxFood = 10;

			var r = new Random(seed);
			InventoryModel inventory = new InventoryModel();

			inventory.id = Guid.NewGuid();
			inventory.userId = Guid.NewGuid();
			inventory.itemId = new List<Guid>();

			List<FoodModel> foodmodels = Food_Factory.GenerateFood(r.Next(0, maxFood), seed);

			for (int i = 0; i < foodmodels.Count; i++)
				inventory.itemId.Add(foodmodels[i].id);

			return inventory;
		}

		public static List<InventoryModel> GenerateInventory(int amount, int seed)
		{
			List<InventoryModel> inventories = new List<InventoryModel>();

			for (int i = 0; i < amount; i++)
				inventories.Add(GenerateInventory(seed));

			return inventories;
		}
	}
}
