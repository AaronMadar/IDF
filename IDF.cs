using System;
using System.Collections.Generic; // ajouté pour List

namespace ProjectClassIDF
{
    public class IDF
    {
        public DateTime Creation { get; set; } = new DateTime(1948, 5, 26);

        public string Chief = "Eyal Zamir";

        public List<StrikeOption> StrikeOptions = new List<StrikeOption>();
    }

    public abstract class StrikeOption
    {
        public abstract string Name { get; set; }
        public abstract float AmmunitionCapacity { get; set; }
        public float CurrentAmmunition { get; set; }
        public abstract float FuelCapacity { get; set; }
        public float CurrentFuelCapacity { get; set; }
        public abstract string EffectiveTargets { get; set; }
    }





    public class F16 : StrikeOption
    {
        public int Id;

        // Constructeur 1 pour les algo: name, id, currentAmmunition, currentFuelCapacity, effectiveTargets
        public F16(string name, int id, float currentAmmunition, float currentFuelCapacity, string effectiveTargets)
        {
            this.Name = name;
            this.Id = id;
            this.CurrentAmmunition = currentAmmunition;
            this.CurrentFuelCapacity = currentFuelCapacity;
            this.EffectiveTargets = effectiveTargets;
        }

        // Constructeur 2 pour la liste IDF : name, fuelCapacity, ammunitionCapacity, effectiveTargets
        public F16(string name, float fuelCapacity, float ammunitionCapacity, string effectiveTargets)
        {
            this.Name = name;
            this.FuelCapacity = fuelCapacity;
            this.AmmunitionCapacity = ammunitionCapacity;
            this.EffectiveTargets = effectiveTargets;
        }


    }


    public class Hermes460 : StrikeOption
    {
        public int Id;

        // Constructeur 1 : name, id, currentAmmunition, currentFuelCapacity, effectiveTargets
        public Hermes460(string name, int id, float currentAmmunition, float currentFuelCapacity, string effectiveTargets)
        {
            this.Name = name;
            this.Id = id;
            this.CurrentAmmunition = currentAmmunition;
            this.CurrentFuelCapacity = currentFuelCapacity;
            this.EffectiveTargets = effectiveTargets;
        }

        // Constructeur 2 : name, fuelCapacity, ammunitionCapacity, effectiveTargets
        public Hermes460(string name, float fuelCapacity, float ammunitionCapacity, string effectiveTargets)
        {
            this.Name = name;
            this.FuelCapacity = fuelCapacity;
            this.AmmunitionCapacity = ammunitionCapacity;
            this.EffectiveTargets = effectiveTargets;
        }
    }




    public class M109 : StrikeOption
    {
        public int Id;

        // Constructeur 1 : name, id, currentAmmunition, currentFuelCapacity, effectiveTargets
        public M109(string name, int id, float currentAmmunition, float currentFuelCapacity, string effectiveTargets)
        {
            this.Name = name;
            this.Id = id;
            this.CurrentAmmunition = currentAmmunition;
            this.CurrentFuelCapacity = currentFuelCapacity;
            this.EffectiveTargets = effectiveTargets;
        }

        // Constructeur 2 : name, fuelCapacity, ammunitionCapacity, effectiveTargets
        public M109(string name, float fuelCapacity, float ammunitionCapacity, string effectiveTargets)
        {
            this.Name = name;
            this.FuelCapacity = fuelCapacity;
            this.AmmunitionCapacity = ammunitionCapacity;
            this.EffectiveTargets = effectiveTargets;
        }
    }






}
