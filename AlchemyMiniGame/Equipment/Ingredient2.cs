using System;

namespace AlchemyMiniGame
{
	internal class Ingredient2 : Ingredient
	{
		public Ingredient2 () : base ("Ingredient2", new Effect[]{ new PosEffect1(), new NegEffect1() }, 2, 200)
		{
		}
	}
}

