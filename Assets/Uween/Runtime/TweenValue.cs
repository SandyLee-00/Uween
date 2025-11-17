using UnityEngine;

namespace Uween
{
    public abstract class TweenValue : TweenBase
    {
        private float _fromValue;
        private float _toValue;

        protected abstract float Value { get; set; }

        protected static T Add<T>(GameObject go, float duration) where T : TweenValue
        {
            return TweenBase.Set<T>(go, duration);
        }

        protected static T Add<T>(GameObject go, float duration, float to) where T : TweenValue
        {
            var t = Add<T>(go, duration);
            t._toValue = to;
            return t;
        }

        protected override void Reset()
        {
            base.Reset();

            _fromValue = Value;
            _toValue = Value;
        }

        protected override void UpdateValue(Easing e, float t, float d)
        {
            Value = e.Calculate(t, _fromValue, _toValue - _fromValue, d);
        }

        public TweenValue Relative()
        {
            _toValue += Value;
            return this;
        }

        public TweenValue FromRelative(float v)
        {
            _fromValue = Value + v;
            Value = _fromValue;
            return this;
        }

        public TweenValue By()
        {
            return Relative();
        }

        public TweenValue From(float v)
        {
            _fromValue = v;
            Value = _fromValue;
            return this;
        }

        public TweenValue FromBy(float v)
        {
            return FromRelative(v);
        }

        public TweenValue FromThat()
        {
            _fromValue = _toValue;
            _toValue = Value;
            Value = _fromValue;
            return this;
        }

        public TweenValue FromThatBy()
        {
            _fromValue = Value + _toValue;
            _toValue = Value;
            Value = _fromValue;
            return this;
        }
    }
}