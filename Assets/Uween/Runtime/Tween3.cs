using UnityEngine;

namespace Uween
{
    public abstract class Tween3 : TweenBase
    {
        private Vector3 _fromValue;
        private Vector3 _toValue;
        protected abstract Vector3 Value { get; set; }

        protected static T Add<T>(GameObject g, float duration) where T : Tween3
        {
            return TweenBase.Set<T>(g, duration);
        }

        protected static T Add<T>(GameObject g, float duration, Vector3 to) where T : Tween3
        {
            var t = Add<T>(g, duration);
            t._toValue = to;
            return t;
        }

        protected static T Add<T>(GameObject g, float duration, float x, float y, float z) where T : Tween3
        {
            return Add<T>(g, duration, new Vector3(x, y, z));
        }

        protected override void Reset()
        {
            base.Reset();
            _fromValue = Value;
            _toValue = Value;
        }

        protected override void UpdateValue(Easing e, float t, float d)
        {
            var v = Vector3.zero;
            v.x = e.Calculate(t, _fromValue.x, _toValue.x - _fromValue.x, d);
            v.y = e.Calculate(t, _fromValue.y, _toValue.y - _fromValue.y, d);
            v.z = e.Calculate(t, _fromValue.z, _toValue.z - _fromValue.z, d);
            Value = v;
        }

        public Tween3 Relative()
        {
            _toValue += Value;
            return this;
        }

        public Tween3 By()
        {
            return Relative();
        }

        public Tween3 From(Vector3 v)
        {
            _fromValue = v;
            Value = _fromValue;
            return this;
        }

        public Tween3 FromRelative(Vector3 v)
        {
            _fromValue = Value + v;
            Value = _fromValue;
            return this;
        }

        public Tween3 FromRelative(float x, float y, float z)
        {
            return FromRelative(new Vector3(x, y, z));
        }

        public Tween3 FromRelative(float v)
        {
            return FromRelative(v, v, v);
        }

        public Tween3 From(float x, float y, float z)
        {
            return From(new Vector3(x, y, z));
        }

        public Tween3 From(float v)
        {
            return From(v, v, v);
        }

        public Tween3 FromBy(Vector3 v)
        {
            return FromRelative(v);
        }

        public Tween3 FromBy(float x, float y, float z)
        {
            return FromRelative(x, y, z);
        }

        public Tween3 FromBy(float v)
        {
            return FromRelative(v);
        }

        public Tween3 FromThat()
        {
            _fromValue = _toValue;
            _toValue = Value;
            Value = _fromValue;
            return this;
        }

        public Tween3 FromThatBy()
        {
            _fromValue = Value + _toValue;
            _toValue = Value;
            Value = _fromValue;
            return this;
        }
    }
}