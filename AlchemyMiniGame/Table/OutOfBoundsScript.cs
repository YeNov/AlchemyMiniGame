using System;
using UnityEngine;

namespace AlchemyMiniGame
{
	public class OutOfBoundsScript : MonoBehaviour
	{
		//internal AlchemyTable Table;

		void OnTriggerExit2D(Collider2D col)
		{
			Debug.Log ("Exit");
			AlchemyTable.StopBrew ();
		}

		void OnTriggerEnter2D(Collider2D col)
		{
			//Debug.Log ("Enter");
		}
	}
}

