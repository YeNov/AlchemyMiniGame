using System;
using UnityEngine;

namespace AlchemyMiniGame
{
	internal class GetBorders : MonoBehaviour
	{
		//AlchemyTable Table;

		internal void Check ()
		{
//			if (AlchemyTable.Bottle == null || AlchemyTable.Ingredients.Count <= 1) 
//			{
//				Debug.Log ("Not enough ingredients or no bottle");
//				return;
//			}
			//Table = GetComponent<GameManager>().Table;
			if (IsBottleEther ()) {
				Debug.Log ("Looking for pentagram heart");
				//AlchemyTable.BorderObject = GameObject.Find ("PentagramHeart");
				AlchemyTable.BorderObject = GameObject.Find ("Pentagram");
			} else {
				Debug.Log ("Looking for pentagram");
				//AlchemyTable.BorderObject = GameObject.Find ("Pentagram");
				AlchemyTable.BorderObject = GameObject.Find ("PentagramHeart");
				//(AlchemyTable.BorderObject.GetComponent (typeof(CircleCollider2D)) as CircleCollider2D).isTrigger = true;
			}

			AlchemyTable.BorderObject.SetActive (false);

		}

		bool IsBottleEther()
		{
			return (AlchemyTable.Bottle.Type == BottleType.Ether);
		}
	}

}

