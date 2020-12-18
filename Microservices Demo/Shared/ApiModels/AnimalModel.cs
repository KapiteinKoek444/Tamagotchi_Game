using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Shared.ApiModels
{
	public class AnimalModel
	{
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public float Food { get; set; }
        public float Energy { get; set; }
        public float Happiness { get; set; }
        public int AnimalType { get; set; }
    }
}
