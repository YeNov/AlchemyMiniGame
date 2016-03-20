using System;
using UnityEngine;

namespace AlchemyMiniGame
{
	public class RandomMoving
	{
		float shift;
		float movSpeed;

		public RandomMoving()
		{
			shift = BottleBehaviour.CursorShifting (AlchemyTable.Bottle.Type);
			movSpeed = shift * Time.deltaTime / 1;
		}

		internal Vector2 Move(Transform transform)
		{
			var rnd = UnityEngine.Random.Range (-10, 9);

			if(rnd >= -10 && rnd < 2)
			{
				//Debug.Log("RndMoving Update() x");
				var vec = new Vector2 (movSpeed, 0);
				if (transform.position.x >= 0) {
					//Debug.Log ("x>=0");
					return new Vector2 (movSpeed, 0);
				} 
				else {
					//Debug.Log ("!x>=0");
					return new Vector2 (-movSpeed, 0);
				}
			}

			if (rnd <= 9 && rnd >= 2)
			{
				//Debug.Log("RndMoving Update() y");
				var vec = new Vector2 (0, movSpeed);
				if (transform.position.y >= 0) {
					//Debug.Log ("y>=0");
					return new Vector2 (0, movSpeed);
				} else {
					//Debug.Log ("!y>=0");
					return new Vector2 (0, -movSpeed);
				}
			}
			throw new Exception ("Well, this exception is impossible.");
		}
	}
}

