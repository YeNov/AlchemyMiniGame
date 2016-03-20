using System;

namespace AlchemyMiniGame
{
    internal abstract class Effect
    {
        internal string Name { get; private set; }
        internal IEffect Behaviour;

        internal Effect(string name)
        {
            Name = name;
        }
    }
}
