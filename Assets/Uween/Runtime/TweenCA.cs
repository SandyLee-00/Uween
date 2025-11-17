using UnityEngine;
using UnityEngine.UI;

namespace Uween
{
    public class TweenCA : Tween4
    {
        private Graphic _graphic;

        public static TweenCA Add(GameObject g, float duration)
        {
            return Add<TweenCA>(g, duration);
        }

        public static TweenCA Add(GameObject g, float duration, Vector4 to)
        {
            return Add<TweenCA>(g, duration, to);
        }

        public static TweenCA Add(GameObject g, float duration, Color to)
        {
            return Add<TweenCA>(g, duration, (Vector4)to);
        }

        public static TweenCA Add(GameObject g, float duration, float toR, float toG, float toB, float toA)
        {
            return Add<TweenCA>(g, duration, toR, toG, toB, toA);
        }

        protected Graphic GetGraphic()
        {
            if (_graphic == null)
            {
                _graphic = GetComponent<Graphic>();
            }

            return _graphic;
        }

        protected override Vector4 Value
        {
            get { return GetGraphic().color; }
            set { GetGraphic().color = value; }
        }
    }
}