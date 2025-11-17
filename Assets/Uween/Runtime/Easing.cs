using UnityEngine;

namespace Uween
{
    public abstract class Easing
    {
        /// <summary>
        /// Calculate Robert Penner's easing.
        /// </summary>
        /// <param name="elapsedTime">Time.</param>
        /// <param name="startValue">Beginning value.</param>
        /// <param name="changeInValue">Value delta.</param>
        /// <param name="duration">Duration.</param>
        public abstract float Calculate(float elapsedTime, float startValue, float changeInValue, float duration);
    }

    public static class Linear
    {
        public static readonly Easing EaseNone = new LinearEaseNone();
    }

    public static class Back
    {
        public static readonly Easing EaseIn = new BackEaseIn();
        public static readonly Easing EaseInOut = new BackEaseInOut();
        public static readonly Easing EaseOut = new BackEaseOut();
        public static readonly Easing EaseOutIn = new BackEaseOutIn();

        public static T EaseInBack<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseIn;
            return tween;
        }

        public static T EaseInOutBack<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseInOut;
            return tween;
        }

        public static T EaseOutBack<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOut;
            return tween;
        }

        public static T EaseOutInBack<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOutIn;
            return tween;
        }

        public static T EaseInBackWith<T>(this T tween, float s) where T : TweenBase
        {
            tween.Easing = new BackEaseIn(s);
            return tween;
        }

        public static T EaseInOutBackWith<T>(this T tween, float s) where T : TweenBase
        {
            tween.Easing = new BackEaseInOut(s);
            return tween;
        }

        public static T EaseOutBackWith<T>(this T tween, float s) where T : TweenBase
        {
            tween.Easing = new BackEaseOut(s);
            return tween;
        }

        public static T EaseOutInBackWith<T>(this T tween, float s) where T : TweenBase
        {
            tween.Easing = new BackEaseOutIn(s);
            return tween;
        }
    }

    public static class Bounce
    {
        public static readonly Easing EaseIn = new BounceEaseIn();
        public static readonly Easing EaseInOut = new BounceEaseInOut();
        public static readonly Easing EaseOut = new BounceEaseOut();
        public static readonly Easing EaseOutIn = new BounceEaseOutIn();

        public static T EaseInBounce<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseIn;
            return tween;
        }

        public static T EaseInOutBounce<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseInOut;
            return tween;
        }

        public static T EaseOutBounce<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOut;
            return tween;
        }

        public static T EaseOutInBounce<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOutIn;
            return tween;
        }
    }

    public static class Circular
    {
        public static readonly Easing EaseIn = new CircularEaseIn();
        public static readonly Easing EaseInOut = new CircularEaseInOut();
        public static readonly Easing EaseOut = new CircularEaseOut();
        public static readonly Easing EaseOutIn = new CircularEaseOutIn();

        public static T EaseInCircular<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseIn;
            return tween;
        }

        public static T EaseInOutCircular<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseInOut;
            return tween;
        }

        public static T EaseOutCircular<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOut;
            return tween;
        }

        public static T EaseOutInCircular<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOutIn;
            return tween;
        }

        public static T EaseInCirc<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseIn;
            return tween;
        }

        public static T EaseInOutCirc<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseInOut;
            return tween;
        }

        public static T EaseOutCirc<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOut;
            return tween;
        }

        public static T EaseOutInCirc<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOutIn;
            return tween;
        }
    }

    public static class Cubic
    {
        public static readonly Easing EaseIn = new CubicEaseIn();
        public static readonly Easing EaseInOut = new CubicEaseInOut();
        public static readonly Easing EaseOut = new CubicEaseOut();
        public static readonly Easing EaseOutIn = new CubicEaseOutIn();

        public static T EaseInCubic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseIn;
            return tween;
        }

        public static T EaseInOutCubic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseInOut;
            return tween;
        }

        public static T EaseOutCubic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOut;
            return tween;
        }

        public static T EaseOutInCubic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOutIn;
            return tween;
        }
    }

    public static class Elastic
    {
        public static readonly Easing EaseIn = new ElasticEaseIn();
        public static readonly Easing EaseInOut = new ElasticEaseInOut();
        public static readonly Easing EaseOut = new ElasticEaseOut();
        public static readonly Easing EaseOutIn = new ElasticEaseOutIn();

        public static T EaseInElastic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseIn;
            return tween;
        }

        public static T EaseInOutElastic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseInOut;
            return tween;
        }

        public static T EaseOutElastic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOut;
            return tween;
        }

        public static T EaseOutInElastic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOutIn;
            return tween;
        }

        public static T EaseInElasticWith<T>(this T tween, float a, float p) where T : TweenBase
        {
            tween.Easing = new ElasticEaseIn(a, p);
            return tween;
        }

        public static T EaseInOutElasticWith<T>(this T tween, float a, float p) where T : TweenBase
        {
            tween.Easing = new ElasticEaseInOut(a, p);
            return tween;
        }

        public static T EaseOutElasticWith<T>(this T tween, float a, float p) where T : TweenBase
        {
            tween.Easing = new ElasticEaseOut(a, p);
            return tween;
        }

        public static T EaseOutInElasticWith<T>(this T tween, float a, float p) where T : TweenBase
        {
            tween.Easing = new ElasticEaseOutIn(a, p);
            return tween;
        }
    }

    public static class Exponential
    {
        public static readonly Easing EaseIn = new ExponentialEaseIn();
        public static readonly Easing EaseInOut = new ExponentialEaseInOut();
        public static readonly Easing EaseOut = new ExponentialEaseOut();
        public static readonly Easing EaseOutIn = new ExponentialEaseOutIn();

        public static T EaseInExponential<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseIn;
            return tween;
        }

        public static T EaseInOutExponential<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseInOut;
            return tween;
        }

        public static T EaseOutExponential<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOut;
            return tween;
        }

        public static T EaseOutInExponential<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOutIn;
            return tween;
        }

        public static T EaseInExpo<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseIn;
            return tween;
        }

        public static T EaseInOutExpo<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseInOut;
            return tween;
        }

        public static T EaseOutExpo<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOut;
            return tween;
        }

        public static T EaseOutInExpo<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOutIn;
            return tween;
        }
    }

    public static class Quadratic
    {
        public static readonly Easing EaseIn = new QuadraticEaseIn();
        public static readonly Easing EaseInOut = new QuadraticEaseInOut();
        public static readonly Easing EaseOut = new QuadraticEaseOut();
        public static readonly Easing EaseOutIn = new QuadraticEaseOutIn();

        public static T EaseInQuadratic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseIn;
            return tween;
        }

        public static T EaseInOutQuadratic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseInOut;
            return tween;
        }

        public static T EaseOutQuadratic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOut;
            return tween;
        }

        public static T EaseOutInQuadratic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOutIn;
            return tween;
        }

        public static T EaseInQuad<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseIn;
            return tween;
        }

        public static T EaseInOutQuad<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseInOut;
            return tween;
        }

        public static T EaseOutQuad<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOut;
            return tween;
        }

        public static T EaseOutInQuad<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOutIn;
            return tween;
        }
    }

    public static class Quartic
    {
        public static readonly Easing EaseIn = new QuarticEaseIn();
        public static readonly Easing EaseInOut = new QuarticEaseInOut();
        public static readonly Easing EaseOut = new QuarticEaseOut();
        public static readonly Easing EaseOutIn = new QuarticEaseOutIn();

        public static T EaseInQuartic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseIn;
            return tween;
        }

        public static T EaseInOutQuartic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseInOut;
            return tween;
        }

        public static T EaseOutQuartic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOut;
            return tween;
        }

        public static T EaseOutInQuartic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOutIn;
            return tween;
        }

        public static T EaseInQuart<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseIn;
            return tween;
        }

        public static T EaseInOutQuart<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseInOut;
            return tween;
        }

        public static T EaseOutQuart<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOut;
            return tween;
        }

        public static T EaseOutInQuart<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOutIn;
            return tween;
        }
    }

    public static class Quintic
    {
        public static readonly Easing EaseIn = new QuinticEaseIn();
        public static readonly Easing EaseInOut = new QuinticEaseInOut();
        public static readonly Easing EaseOut = new QuinticEaseOut();
        public static readonly Easing EaseOutIn = new QuinticEaseOutIn();

        public static T EaseInQuintic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseIn;
            return tween;
        }

        public static T EaseInOutQuintic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseInOut;
            return tween;
        }

        public static T EaseOutQuintic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOut;
            return tween;
        }

        public static T EaseOutInQuintic<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOutIn;
            return tween;
        }

        public static T EaseInQuint<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseIn;
            return tween;
        }

        public static T EaseInOutQuint<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseInOut;
            return tween;
        }

        public static T EaseOutQuint<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOut;
            return tween;
        }

        public static T EaseOutInQuint<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOutIn;
            return tween;
        }
    }

    public static class Sine
    {
        public static readonly Easing EaseIn = new SineEaseIn();
        public static readonly Easing EaseInOut = new SineEaseInOut();
        public static readonly Easing EaseOut = new SineEaseOut();
        public static readonly Easing EaseOutIn = new SineEaseOutIn();

        public static T EaseInSine<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseIn;
            return tween;
        }

        public static T EaseInOutSine<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseInOut;
            return tween;
        }

        public static T EaseOutSine<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOut;
            return tween;
        }

        public static T EaseOutInSine<T>(this T tween) where T : TweenBase
        {
            tween.Easing = EaseOutIn;
            return tween;
        }
    }

    public class LinearEaseNone : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return c * t / d + b;
        }
    }

    public class BackEaseIn : Easing
    {
        public BackEaseIn()
        {
        }

        public BackEaseIn(float s)
        {
            S = s;
        }

        public float S = 1.70158f;

        public override float Calculate(float t, float b, float c, float d)
        {
            return c * (t /= d) * t * ((S + 1f) * t - S) + b;
        }
    }

    public class BackEaseInOut : Easing
    {
        public BackEaseInOut()
        {
        }

        public BackEaseInOut(float s)
        {
            S = s;
        }

        public float S = 1.70158f;

        public override float Calculate(float t, float b, float c, float d)
        {
            if ((t /= d / 2f) < 1f)
            {
                return c / 2f * (t * t * (((S * 1.525f) + 1f) * t - S * 1.525f)) + b;
            }

            return c / 2f * ((t -= 2f) * t * (((S * 1.525f) + 1f) * t + S * 1.525f) + 2f) + b;
        }
    }

    public class BackEaseOut : Easing
    {
        public BackEaseOut()
        {
        }

        public BackEaseOut(float s)
        {
            S = s;
        }

        public float S = 1.70158f;

        public override float Calculate(float t, float b, float c, float d)
        {
            return c * ((t = t / d - 1f) * t * ((S + 1f) * t + S) + 1f) + b;
        }
    }

    public class BackEaseOutIn : Easing
    {
        public BackEaseOutIn()
        {
        }

        public BackEaseOutIn(float s)
        {
            S = s;
        }

        public float S = 1.70158f;

        public override float Calculate(float t, float b, float c, float d)
        {
            if (t < d / 2f)
            {
                return (c / 2f) * ((t = (t * 2f) / d - 1f) * t * ((S + 1f) * t + S) + 1f) + b;
            }

            return (c / 2f) * (t = (t * 2f - d) / d) * t * ((S + 1f) * t - S) + (b + c / 2f);
        }
    }

    public class BounceEaseIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            if ((t = (d - t) / d) < (1f / 2.75f))
            {
                return c - (c * (7.5625f * t * t)) + b;
            }

            if (t < (2f / 2.75f))
            {
                return c - (c * (7.5625f * (t -= (1.5f / 2.75f)) * t + 0.75f)) + b;
            }

            if (t < (2.5f / 2.75f))
            {
                return c - (c * (7.5625f * (t -= (2.25f / 2.75f)) * t + 0.9375f)) + b;
            }

            return c - (c * (7.5625f * (t -= (2.625f / 2.75f)) * t + 0.984375f)) + b;
        }
    }

    public class BounceEaseInOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            if (t < d / 2f)
            {
                if ((t = (d - t * 2f) / d) < (1f / 2.75f))
                {
                    return (c - (c * (7.5625f * t * t))) * 0.5f + b;
                }

                if (t < (2f / 2.75f))
                {
                    return (c - (c * (7.5625f * (t -= (1.5f / 2.75f)) * t + 0.75f))) * 0.5f + b;
                }

                if (t < (2.5f / 2.75f))
                {
                    return (c - (c * (7.5625f * (t -= (2.25f / 2.75f)) * t + 0.9375f))) * 0.5f + b;
                }

                return (c - (c * (7.5625f * (t -= (2.625f / 2.75f)) * t + 0.984375f))) * 0.5f + b;
            }
            else
            {
                if ((t = (t * 2f - d) / d) < (1f / 2.75f))
                {
                    return (c * (7.5625f * t * t)) * 0.5f + c * 0.5f + b;
                }

                if (t < (2f / 2.75f))
                {
                    return (c * (7.5625f * (t -= (1.5f / 2.75f)) * t + 0.75f)) * 0.5f + c * 0.5f + b;
                }

                if (t < (2.5f / 2.75f))
                {
                    return (c * (7.5625f * (t -= (2.25f / 2.75f)) * t + 0.9375f)) * 0.5f + c * 0.5f + b;
                }

                return (c * (7.5625f * (t -= (2.625f / 2.75f)) * t + 0.984375f)) * 0.5f + c * 0.5f + b;
            }
        }
    }

    public class BounceEaseOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            if ((t /= d) < (1f / 2.75f))
            {
                return c * (7.5625f * t * t) + b;
            }

            if (t < (2f / 2.75f))
            {
                return c * (7.5625f * (t -= (1.5f / 2.75f)) * t + 0.75f) + b;
            }

            if (t < (2.5f / 2.75f))
            {
                return c * (7.5625f * (t -= (2.25f / 2.75f)) * t + 0.9375f) + b;
            }

            return c * (7.5625f * (t -= (2.625f / 2.75f)) * t + 0.984375f) + b;
        }
    }

    public class BounceEaseOutIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            if (t < d / 2f)
            {
                if ((t = (t * 2f) / d) < (1f / 2.75f))
                {
                    return (c / 2f) * (7.5625f * t * t) + b;
                }

                if (t < (2f / 2.75f))
                {
                    return (c / 2f) * (7.5625f * (t -= (1.5f / 2.75f)) * t + 0.75f) + b;
                }

                if (t < (2.5f / 2.75f))
                {
                    return (c / 2f) * (7.5625f * (t -= (2.25f / 2.75f)) * t + 0.9375f) + b;
                }

                return (c / 2f) * (7.5625f * (t -= (2.625f / 2.75f)) * t + 0.984375f) + b;
            }
            else
            {
                if ((t = (d - (t * 2f - d)) / d) < (1f / 2.75f))
                {
                    return (c / 2f) - ((c / 2f) * (7.5625f * t * t)) + (b + c / 2f);
                }

                if (t < (2f / 2.75f))
                {
                    return (c / 2f) - ((c / 2f) * (7.5625f * (t -= (1.5f / 2.75f)) * t + 0.75f)) + (b + c / 2f);
                }

                if (t < (2.5f / 2.75f))
                {
                    return (c / 2f) - ((c / 2f) * (7.5625f * (t -= (2.25f / 2.75f)) * t + 0.9375f)) + (b + c / 2f);
                }

                return (c / 2f) - ((c / 2f) * (7.5625f * (t -= (2.625f / 2.75f)) * t + 0.984375f)) + (b + c / 2f);
            }
        }
    }

    public class CircularEaseIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return -c * (Mathf.Sqrt(1f - (t /= d) * t) - 1f) + b;
        }
    }

    public class CircularEaseInOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            if ((t /= d / 2f) < 1f)
            {
                return -c / 2f * (Mathf.Sqrt(1f - t * t) - 1f) + b;
            }

            return c / 2f * (Mathf.Sqrt(1f - (t -= 2f) * t) + 1f) + b;
        }
    }

    public class CircularEaseOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return c * Mathf.Sqrt(1f - (t = t / d - 1f) * t) + b;
        }
    }

    public class CircularEaseOutIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            if (t < d / 2f)
            {
                return (c / 2f) * Mathf.Sqrt(1f - (t = (t * 2f) / d - 1f) * t) + b;
            }

            return -(c / 2f) * (Mathf.Sqrt(1f - (t = (t * 2f - d) / d) * t) - 1f) + (b + c / 2f);
        }
    }

    public class CubicEaseIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return c * (t /= d) * t * t + b;
        }
    }

    public class CubicEaseInOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return ((t /= d / 2f) < 1f) ? c / 2f * t * t * t + b : c / 2f * ((t -= 2f) * t * t + 2f) + b;
        }
    }

    public class CubicEaseOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return c * ((t = t / d - 1f) * t * t + 1f) + b;
        }
    }

    public class CubicEaseOutIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return t < d / 2f ? c / 2f * ((t = t * 2f / d - 1f) * t * t + 1f) + b : c / 2f * (t = (t * 2f - d) / d) * t * t + b + c / 2f;
        }
    }

    public class ElasticEaseIn : Easing
    {
        public ElasticEaseIn()
        {
        }

        public ElasticEaseIn(float a, float p)
        {
            A = a;
            P = p;
        }

        public readonly float A = 0f;
        public readonly float P = 0f;

        public override float Calculate(float t, float b, float c, float d)
        {
            if (t == 0f)
            {
                return b;
            }

            if ((t /= d) == 1)
            {
                return b + c;
            }

            var a = A;
            var p = P;
            if (p == 0f)
            {
                p = d * 0.3f;
            }

            float s;
            if (a == 0f || a < Mathf.Abs(c))
            {
                a = c;
                s = p / 4f;
            }
            else
            {
                s = p / (2f * Mathf.PI) * Mathf.Asin(c / a);
            }

            return -(a * Mathf.Pow(2f, 10f * (t -= 1f)) * Mathf.Sin((t * d - s) * (2f * Mathf.PI) / p)) + b;
        }
    }

    public class ElasticEaseInOut : Easing
    {
        public ElasticEaseInOut()
        {
        }

        public ElasticEaseInOut(float a, float p)
        {
            A = a;
            P = p;
        }

        public readonly float A = 0f;
        public readonly float P = 0f;

        override public float Calculate(float t, float b, float c, float d)
        {
            if (t == 0f)
            {
                return b;
            }

            if ((t /= d / 2f) == 2f)
            {
                return b + c;
            }

            var a = A;
            var p = P;
            if (p == 0f)
            {
                p = d * (0.3f * 1.5f);
            }

            float s;
            if (a == 0f || a < Mathf.Abs(c))
            {
                a = c;
                s = p / 4f;
            }
            else
            {
                s = p / (2f * Mathf.PI) * Mathf.Asin(c / a);
            }

            if (t < 1f)
            {
                return -0.5f * (a * Mathf.Pow(2f, 10f * (t -= 1f)) * Mathf.Sin((t * d - s) * (2f * Mathf.PI) / p)) + b;
            }

            return a * Mathf.Pow(2f, -10f * (t -= 1f)) * Mathf.Sin((t * d - s) * (2f * Mathf.PI) / p) * 0.5f + c + b;
        }
    }

    public class ElasticEaseOut : Easing
    {
        public ElasticEaseOut()
        {
        }

        public ElasticEaseOut(float a, float p)
        {
            A = a;
            P = p;
        }

        public readonly float A = 0f;
        public readonly float P = 0f;

        public override float Calculate(float t, float b, float c, float d)
        {
            if (t == 0f)
            {
                return b;
            }

            if ((t /= d) == 1f)
            {
                return b + c;
            }

            var a = A;
            var p = P;
            if (p == 0f)
            {
                p = d * 0.3f;
            }

            float s;
            if (a == 0f || a < Mathf.Abs(c))
            {
                a = c;
                s = p / 4f;
            }
            else
            {
                s = p / (2f * Mathf.PI) * Mathf.Asin(c / a);
            }

            return a * Mathf.Pow(2f, -10f * t) * Mathf.Sin((t * d - s) * (2f * Mathf.PI) / p) + c + b;
        }
    }

    public class ElasticEaseOutIn : Easing
    {
        public ElasticEaseOutIn()
        {
        }

        public ElasticEaseOutIn(float a, float p)
        {
            A = a;
            P = p;
        }

        public readonly float A = 0f;
        public readonly float P = 0f;

        public override float Calculate(float t, float b, float c, float d)
        {
            float s;
            var a = A;
            var p = P;

            c /= 2f;

            if (t < d / 2f)
            {
                if ((t *= 2f) == 0)
                {
                    return b;
                }

                if ((t /= d) == 1f)
                {
                    return b + c;
                }

                if (p == 0f)
                {
                    p = d * 0.3f;
                }

                if (a == 0f || a < Mathf.Abs(c))
                {
                    a = c;
                    s = p / 4f;
                }
                else
                {
                    s = p / (2f * Mathf.PI) * Mathf.Asin(c / a);
                }

                return a * Mathf.Pow(2f, -10f * t) * Mathf.Sin((t * d - s) * (2f * Mathf.PI) / p) + c + b;
            }
            else
            {
                if ((t = t * 2f - d) == 0f)
                {
                    return (b + c);
                }

                if ((t /= d) == 1f)
                {
                    return (b + c) + c;
                }

                if (p == 0f)
                {
                    p = d * 0.3f;
                }

                if (a == 0f || a < Mathf.Abs(c))
                {
                    a = c;
                    s = p / 4f;
                }
                else
                {
                    s = p / (2f * Mathf.PI) * Mathf.Asin(c / a);
                }

                return -(a * Mathf.Pow(2f, 10f * (t -= 1f)) * Mathf.Sin((t * d - s) * (2f * Mathf.PI) / p)) + (b + c);
            }
        }
    }

    public class ExponentialEaseIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return t == 0f ? b : c * Mathf.Pow(2f, 10f * (t / d - 1f)) + b;
        }
    }

    public class ExponentialEaseInOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            if (t == 0f)
            {
                return b;
            }

            if (t == d)
            {
                return b + c;
            }

            if ((t /= d / 2.0f) < 1.0f)
            {
                return c / 2f * Mathf.Pow(2f, 10f * (t - 1f)) + b;
            }

            return c / 2f * (2f - Mathf.Pow(2f, -10f * --t)) + b;
        }
    }

    public class ExponentialEaseOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return t == d ? b + c : c * (1f - Mathf.Pow(2f, -10f * t / d)) + b;
        }
    }

    public class ExponentialEaseOutIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            if (t < d / 2.0f)
            {
                return t * 2.0f == d ? b + c / 2.0f : c / 2.0f * (1f - Mathf.Pow(2f, -10f * t * 2.0f / d)) + b;
            }

            return (t * 2.0f - d) == 0f ? b + c / 2.0f : c / 2.0f * Mathf.Pow(2f, 10f * ((t * 2f - d) / d - 1f)) + b + c / 2.0f;
        }
    }

    public class QuadraticEaseIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return c * (t /= d) * t + b;
        }
    }

    public class QuadraticEaseInOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            if ((t /= d / 2f) < 1f)
            {
                return c / 2f * t * t + b;
            }

            return -c / 2f * ((--t) * (t - 2f) - 1f) + b;
        }
    }

    public class QuadraticEaseOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return -c * (t /= d) * (t - 2f) + b;
        }
    }

    public class QuadraticEaseOutIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            if (t < d / 2f)
            {
                return -(c / 2f) * (t = (t * 2f / d)) * (t - 2f) + b;
            }

            return (c / 2f) * (t = (t * 2f - d) / d) * t + (b + c / 2f);
        }
    }

    public class QuarticEaseIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return c * (t /= d) * t * t * t + b;
        }
    }

    public class QuarticEaseInOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            if ((t /= d / 2f) < 1f)
            {
                return c / 2 * t * t * t * t + b;
            }

            return -c / 2f * ((t -= 2f) * t * t * t - 2f) + b;
        }
    }

    public class QuarticEaseOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return -c * ((t = t / d - 1f) * t * t * t - 1f) + b;
        }
    }

    public class QuarticEaseOutIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            if (t < d / 2f)
            {
                return -(c / 2f) * ((t = (t * 2f) / d - 1f) * t * t * t - 1f) + b;
            }

            return (c / 2f) * (t = (t * 2f - d) / d) * t * t * t + (b + c / 2f);
        }
    }

    public class QuinticEaseIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return c * (t /= d) * t * t * t * t + b;
        }
    }

    public class QuinticEaseInOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            if ((t /= d / 2f) < 1f)
            {
                return c / 2f * t * t * t * t * t + b;
            }

            return c / 2f * ((t -= 2f) * t * t * t * t + 2f) + b;
        }
    }

    public class QuinticEaseOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return c * ((t = t / d - 1f) * t * t * t * t + 1f) + b;
        }
    }

    public class QuinticEaseOutIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            if (t < d / 2f)
            {
                return (c / 2f) * ((t = (t * 2f) / d - 1f) * t * t * t * t + 1f) + b;
            }

            return (c / 2f) * (t = (t * 2f - d) / d) * t * t * t * t + (b + c / 2f);
        }
    }

    public class SineEaseIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return -c * Mathf.Cos(t / d * (Mathf.PI / 2f)) + c + b;
        }
    }

    public class SineEaseInOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return -c / 2f * (Mathf.Cos(Mathf.PI * t / d) - 1f) + b;
        }
    }

    public class SineEaseOut : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            return c * Mathf.Sin(t / d * (Mathf.PI / 2f)) + b;
        }
    }

    public class SineEaseOutIn : Easing
    {
        public override float Calculate(float t, float b, float c, float d)
        {
            if (t < d / 2f)
            {
                return (c / 2f) * Mathf.Sin((t * 2f) / d * (Mathf.PI / 2f)) + b;
            }

            return -(c / 2f) * Mathf.Cos((t * 2f - d) / d * (Mathf.PI / 2f)) + (c / 2f) + (b + c / 2f);
        }
    }
}