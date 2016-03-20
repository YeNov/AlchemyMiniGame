using System;
using UnityEngine;

namespace AlchemyMiniGame
{
    internal class Ingredient : AlchemyEquipment
    {
        internal float BurnTime { get; private set; }
		internal float Life { get; set; }
		private float BurningDelta { get; set; }

		internal Ingredient(string name, Effect[] effects, int id, float burnTime, float burningDelta = 1) : base(name, effects, id)
        {
            BurnTime = burnTime;
			Life = burnTime;
			BurningDelta = burningDelta;
        }

		internal bool Burn()
		{
			if (Life < BurningDelta) 
			{
				//Debug.Log ("Can't burn");
				return false;
			}
			Life -= BurningDelta;
			Debug.Log (Name + " life is" + Life);
			return true;
		}
    }
}
