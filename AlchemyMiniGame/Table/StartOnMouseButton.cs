using System;
using UnityEngine;

namespace AlchemyMiniGame
{
	public class StartOnMouseButton : MonoBehaviour
	{
		public GameObject MovingCircle;
		private bool Instantiated;

		void OnMouseDown()
		{
			Debug.Log ("OnMouseDown()");
			if(!(AlchemyTable.CanBrew && AlchemyTable.Finished))
				Instantiate (MovingCircle);
			AlchemyTable.StartBrew (MovingCircle);
		}
	}
}

