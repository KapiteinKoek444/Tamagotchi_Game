using Shared.Shared.ApiModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_Test.Factory
{
	public static class Food_Factory
	{
		public static FoodModel GenerateFood(int seed)
		{
			int maxvalue = 10;

			var r = new Random(seed);
			FoodModel food = new FoodModel();

			food.id = Guid.NewGuid();
			food.name = "test-gummies";
			food.category = "candy";
			food.price = r.Next(0, maxvalue) + r.NextDouble();
			food.discount = 0.0;
			food.energyVal = r.Next(0, maxvalue);
			food.foodVal = r.Next(0, maxvalue);
			food.happyVal = r.Next(0, maxvalue);

			return food;
		}

		public static List<FoodModel> GenerateFood(int amount, int seed)
		{
			var foodList = new List<FoodModel>();

			for (int i = 0; i < amount; i++)
				foodList.Add(GenerateFood(seed));

			return foodList;
		}
	}
}
