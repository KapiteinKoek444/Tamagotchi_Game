using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TamagotchiAnimalAPI.Entities;

namespace TamagotchiAnimalAPI.Extentions
{
    public static class AnimalFactory
    {

        private const double ScoreDivider = 30;
        public static Animal CalculateAnimalScore(Animal animal ,DateTime old,double ScoreMultiplier = 1f)
        {
            DateTime now = DateTime.Now;
            TimeSpan span = old.Subtract(now);
            double totalMinutes = span.TotalMinutes;
            double ScoreValue = (totalMinutes/ ScoreDivider) * ScoreMultiplier;

            if (ScoreValue < 0)
            {
                ScoreValue = 0;
            }

            animal.Food -= (float)ScoreValue;
            animal.Energy -= (float)ScoreValue;
            animal.Happiness -= (float)ScoreValue;

            return animal;
        }


    }
}
