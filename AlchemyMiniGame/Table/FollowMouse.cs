using System;
using UnityEngine;

namespace AssemblyCSharp
{
	public class FollowMouse : MonoBehaviour
	{
		public float depth = -12;
		void Update()
		{
			//var position =  Camera.main.ScreenToWorldPoint (new Vector3 (Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y"), depth));
			var position =  Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, depth));
			transform.Translate (position * Time.deltaTime);
		}
	}
}

