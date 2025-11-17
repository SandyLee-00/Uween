using UnityEngine;

namespace Uween
{
    public class TweenNull : TweenBase
    {
        public static TweenNull Add(GameObject g, float duration)
        {
            return Set<TweenNull>(g, duration);
        }

        protected override void UpdateValue(Easing e, float t, float d)
        {
        }
    }
}