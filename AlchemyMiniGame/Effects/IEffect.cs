using System;

namespace AlchemyMiniGame
{
    internal interface IEffect
    {
        void SetEffect(int delta, ref float feature);//delta - насколько изменяется характеристика
        void SetEffect(float percent, ref float feature);//percent - процент от текущего показателя характеристики
    }
}
