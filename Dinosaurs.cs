using System;

namespace JurassicPark
{
    class Dinosaurs
    {
        public string Name { get; set; }

        public string DietType { get; set; }

        public string WhenAcquired { get; set; }
        // figure out if whenAcquired is a string int, etc
        public int Weight { get; set; }

        public int EnclosedNumber { get; set; }

        public string Description()
        {
            var descriptionOfDinosaurs = ($"{Name} was acquired to us around {WhenAcquired} and weighs in about {Weight} lbs. You can locate {Name} in  "
        }
    }
}