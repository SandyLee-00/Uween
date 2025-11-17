using UnityEngine;

namespace Uween
{
    public static class FluentSyntax
    {
        public static T Delay<T>(this T tween, float delay) where T : TweenBase
        {
            tween.DelayTime = delay;
            return tween;
        }

        public static T Animate<T>(this T tween, bool animated) where T : TweenBase
        {
            if (!animated)
            {
                tween.Skip();
            }

            return tween;
        }

        public static T Then<T>(this T tween, Callback callback) where T : TweenBase
        {
            if (tween.enabled || !tween.IsComplete)
            {
                tween.OnComplete += callback;
            }
            else
            {
                callback();
            }

            return tween;
        }

        public static void PauseTweens(this GameObject g)
        {
            PauseTweens<TweenBase>(g);
        }

        public static void PauseTweens<T>(this GameObject g) where T : TweenBase
        {
            foreach (T t in g.GetComponents<T>())
            {
                if (!t.IsComplete)
                {
                    t.enabled = false;
                }
            }
        }

        public static void ResumeTweens(this GameObject g)
        {
            ResumeTweens<TweenBase>(g);
        }

        public static void ResumeTweens<T>(this GameObject g) where T : TweenBase
        {
            foreach (T t in g.GetComponents<T>())
            {
                if (!t.IsComplete)
                {
                    t.enabled = true;
                }
            }
        }

        public static void SkipTweens(this GameObject g)
        {
            SkipTweens<TweenBase>(g);
        }

        public static void SkipTweens<T>(this GameObject g) where T : TweenBase
        {
            foreach (T t in g.GetComponents<T>())
            {
                if (!t.IsComplete)
                {
                    t.Skip();
                }
            }
        }
    }
}