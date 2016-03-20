using System;
using UnityEngine;
using System.Collections.Generic;

namespace AlchemyMiniGame
{
	public class GameManager : MonoBehaviour
	{
		//internal AlchemyTable Table;

		public BottleType TestBottle = BottleType.Medium;
		public float TestTimeToBrew = 50;
		public GameObject TestPotion;
		void Awake()
		{
			AlchemyTable.Bottle = new PotionBottle();
			AlchemyTable.Bottle.Type = TestBottle;
			AlchemyTable.Bottle.Behaviour = new BottleBehaviour ();
			AlchemyTable.Bottle.Behaviour.TimeToBrew = TestTimeToBrew;
			var borders = new GetBorders ();
			borders.Check ();
			AlchemyTable.AddIngredient (new Ingredient1());
			AlchemyTable.AddIngredient (new Ingredient2());
		}

		void Update()
		{
			//Debug.Log ("CanBrew is " + AlchemyTable.CanBrew);
			if (!AlchemyTable.CanBrew)
				return;
			Brew ();
			if (AlchemyTable.Finished)
				Instantiate (TestPotion);
		}

		void Brew()
		{
			AlchemyTable.Brew ();
			Debug.Log ("Brew step");
		}
	}
}

