using System;

namespace JurassicPark
{
    class Dinosaur
    {
        public string Name { get; set; }

        public string DietType { get; set; }

        public DateTime WhenAcquired { get; set; }

        public int Weight { get; set; }

        public int EnclosureNumber { get; set; }

        public string Description()
        {
            var descriptionOfDinosaurs = ($"{Name} was acquired to us around {WhenAcquired} and is located in pin {EnclosureNumber}. {Name} weighs in about {Weight} and eats {DietType}");
            return descriptionOfDinosaurs;
        }


    }
}