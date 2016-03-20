using System;

namespace AlchemyMiniGame
{
    internal class PotionBottle
    {
        internal BottleType Type { get; set; }
        internal BottleBehaviour Behaviour { get; set; }

		internal PotionBottle()
		{
			Type = BottleType.Big;
			Behaviour = new BottleBehaviour ();
		}
    }
}
