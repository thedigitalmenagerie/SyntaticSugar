using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaticSugar.Bug
{
    public class Bug
    {
        /*
            You can declare a typed public property, make it read-only,
            and initialize it with a default value all on the same
            line of code in C#. Readonly properties can be set in the
            class' constructors, but not by external code. 
        // completed for role?
        */
        public string Role { get; } = "Pollinator";
        public string Name { get; } = "";
        public string Species { get; } = "";
        public List<string> Predators { get; } = new List<string>();
        public List<string> Prey { get; } = new List<string>();

        // Convert this readonly property to an expression member
        // completed for FormalName? 

        public string FormalName => ($"{this.Name} the {this.Species}");

        // Class constructor
        public Bug(string name, string species, List<string> predators, List<string> prey)
        {
            this.Name = name;
            this.Species = species;
            this.Predators = predators;
            this.Prey = prey;
        }

        // Convert this method to an expression member
        // completed?
        public string PreyList => (string.Join(", ", this.Prey));

        // Convert this method to an expression member

        public string PredatorList => (string.Join(", ", this.Predators));

        // Convert this to expression method
        // confusion ensues
        public string Eat(string food)
        {
            if (this.Prey.Contains(food))
            {
                return $"{this.Name} ate the {food}.";
            }
            else
            {
                return $"{this.Name} is still hungry.";
            }
        }
    }
}
