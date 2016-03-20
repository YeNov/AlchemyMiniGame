using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlchemyMiniGame
{
	public static class AlchemyTable
	{
		internal static List<AlchemyEquipment> Equipment = new List<AlchemyEquipment>();
		internal static PotionBottle Bottle { get; set; }
		internal static GameObject BorderObject { get; set; }
		internal static bool CanBrew{ get; set; }
		internal static bool Finished{ get; set; }

		private static GameObject MovingCircle;

		public static void AddIngredient(AlchemyEquipment ingredient)
		{
			if (Equipment.Count >= 5)
				return;
			Equipment.Add(ingredient);
		}

		public static void DeleteIngredient(AlchemyEquipment ingredient)
		{
			Equipment.Remove(ingredient);
		}

		public static void StartBrew()
		{
			//Finished = false;
			CanBrew = true;
		}

		public static void Brew()
		{
			Debug.Log ("Try to brew");
			if (Bottle.Behaviour.TimeToBrew <= 0) 
			{
				Debug.Log ("Brewing is finished");
				GameObject MC = GameObject.FindGameObjectWithTag ("MovingCircle");
				(MC.GetComponent ("MovingMouse") as MovingMouse).DestroyThis();
				Finished = true;
				CanBrew = false;
				/*Тут, думаю, нужно добавить эффекты к зелью. Как именно - пока думаю.
				  Предположение: просто впихнуть их в виде массива Effects[]*/
				return;
			}
			if (CanBrew && Equipment.Count != 0) 
			{
				//Debug.Log ("Can brew");
				foreach (var ingredient in Equipment)
				{
					if (ingredient is Ingredient)
					{
						Debug.Log ("Try to burn");
						if (!(ingredient as Ingredient).Burn ())
						{
							CanBrew = false;
							break;
						} 
					}
				}
				Bottle.Behaviour.TimeToBrew--;
				return;
			}
			else
			{
				CanBrew = false;
				//Debug.Log ("Can't brew");
			}
		}

		public static void StopBrew()
		{
			CanBrew = false;
		}
	}
}