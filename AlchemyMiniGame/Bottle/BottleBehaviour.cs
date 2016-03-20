using System;
using UnityEngine;

namespace AlchemyMiniGame
{
    internal class BottleBehaviour
    {
        internal float TimeToBrew { get; set; }

		internal static float CursorShifting(BottleType type)
        {
//			switch(type)
//			{
//				case BottleType.Big: return (float)1;
//				case BottleType.Medium: return (float)1.25;
//				case BottleType.Small: return (float)1.5;
//				case BottleType.Ether: return (float)2;
//				default: return 0;
//			}
			return (float)type;
			
        }

        internal bool IsPotionFinished()
        {
            throw new NotImplementedException();
        }
    }
}
