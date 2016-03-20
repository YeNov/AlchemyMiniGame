using System;

namespace AlchemyMiniGame
{
	internal class Ingredient1 : Ingredient
	{
		public Ingredient1 () : base ("Ingredient1", new Effect[]{ new PosEffect1(), new NegEffect1() }, 1, 100)
		{
		}
	}
}

