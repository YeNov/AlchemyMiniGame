using System;

namespace AlchemyMiniGame
{
    public abstract class AlchemyEquipment
    {
        internal string Name { get; private set; }
        internal Effect[] Effects { get; private set; }
        internal int Id { get; private set; }

        internal AlchemyEquipment(string name, Effect[] effects, int id)
        {
            Name = name;
            if(effects.Length >2)
                throw new Exception("Wrong number of effects.");
            Effects = effects;
            Id = id;
        }
    }
}
