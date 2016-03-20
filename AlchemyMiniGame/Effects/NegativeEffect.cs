using System;

namespace AlchemyMiniGame
{
    class NegativeEffect : IEffect
    {
        public void SetEffect(int delta, ref float feature)
        {
            feature -= delta;
        }

        public void SetEffect(float percent, ref float feature)
        {
            feature -= feature * percent;
        }
    }
}
