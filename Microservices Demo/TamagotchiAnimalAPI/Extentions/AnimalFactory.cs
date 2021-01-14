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
        private const int MaxExperience = 100;
        public static Animal CalculateAnimalScore(Animal animal ,DateTime userDateTime,double ScoreMultiplier = 1f)
        {
            var oldTimestamp = DateTime.SpecifyKind(userDateTime, DateTimeKind.Local);
            DateTime currentTimestamp = DateTime.Now;

            TimeSpan span = oldTimestamp.Subtract(currentTimestamp);
            double totalMinutes = -span.TotalMinutes;
            double ScoreValue = (totalMinutes/ ScoreDivider) * ScoreMultiplier;

            if (ScoreValue < 0)
            {
                ScoreValue = 0;
            }

            animal.Food -= (float)ScoreValue;
            animal.Energy -= (float)ScoreValue;
            animal.Happiness -= (float)ScoreValue;

            animal.Experience += (float)ScoreValue;

            if (!(animal.Experience >= MaxExperience)) return animal;
            animal.Experience = 0;
            animal.Level++;

            return animal;
        }

    }
}
