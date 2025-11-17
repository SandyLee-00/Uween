using UnityEngine;
using UnityEngine.UI;

namespace Uween
{
    public class TweenFillAmount : TweenValue
    {
        public static TweenFillAmount Add(GameObject g, float duration)
        {
            return Add<TweenFillAmount>(g, duration);
        }

        public static TweenFillAmount Add(GameObject g, float duration, float to)
        {
            return Add<TweenFillAmount>(g, duration, to);
        }

        private Image _image;

        protected Image GetImage()
        {
            if (_image == null)
            {
                _image = GetComponent<Image>();
            }

            return _image;
        }

        protected override float Value
        {
            get { return GetImage().fillAmount; }
            set { GetImage().fillAmount = value; }
        }
    }
}