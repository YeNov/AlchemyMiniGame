using System;
using UnityEngine;
using System.Threading;

namespace AlchemyMiniGame
{
	public class MovingMouse:MonoBehaviour
	{
		  // C#
		public float horizontalSpeed = 10f; // looks like "10" maps to the native speed
		public float verticalSpeed = 10f;	 
		public Transform cursorObj;	 
		public bool allowCursorMove = true;
		 
		private RandomMoving rndMove;
		private float depth = -1;

		void CheckCursorLock()
		{
		    if (Cursor.lockState == CursorLockMode.None)
		    {
		        Cursor.lockState = CursorLockMode.Locked;
		        Cursor.visible = false;
		    }
		}

		void Start()
		{
		    CheckCursorLock();
			rndMove = new RandomMoving ();
		}

		void Update()
		{
		    if (Input.GetMouseButtonDown(0))
		    {
		        CheckCursorLock();
		    }
		    float h = horizontalSpeed * Input.GetAxis("Mouse X");
		    float v = verticalSpeed * Input.GetAxis("Mouse Y");
		    Vector3 delta = new Vector3(h,v,0);
		    if (allowCursorMove)
		    {
				Thread.Sleep (30);
				var newVec = rndMove.Move (cursorObj);
		        cursorObj.position += delta; // moves the virtual cursor
				cursorObj.transform.Translate(newVec);
				cursorObj.position = new Vector3 (cursorObj.position.x, cursorObj.position.y, depth);
		        // You need to clamp the position to be inside your wanted area here,
		        // otherwise the cursor can go way off screen
		    }
		}

		public void DestroyThis()
		{
			Destroy (gameObject);
		}
	}
}

