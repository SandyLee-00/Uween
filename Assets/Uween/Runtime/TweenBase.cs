using UnityEngine;

namespace Uween
{
    /// <summary>
    /// A base class for Uween's tweens.
    /// </summary>
    public abstract class TweenBase : MonoBehaviour
    {
        protected static T Set<T>(GameObject g, float duration) where T : TweenBase
        {
            T tween = g.GetComponent<T>();
            if (tween == null)
            {
                tween = g.AddComponent<T>();
            }

            tween.Reset();
            tween._duration = duration;
            tween.enabled = true;
            return tween;
        }

        protected float _duration;
        protected float _delayTime;
        protected float _elapsedTime;
        protected Easing _easing;

        /// <summary>
        /// Total duration of this tween (sec).
        /// </summary>
        /// <value>The duration.</value>
        public float Duration
        {
            get { return Mathf.Max(0f, _duration); }
        }

        /// <summary>
        /// Current playing position (sec).
        /// </summary>
        /// <value>The position.</value>
        public float TweenTime
        {
            get { return Mathf.Max(0f, _elapsedTime - DelayTime); }
        }

        /// <summary>
        /// Delay for starting tween (sec).
        /// </summary>
        /// <value>The delay time.</value>
        public float DelayTime
        {
            get { return Mathf.Max(0f, _delayTime); }
            set { _delayTime = value; }
        }

        /// <summary>
        /// Easing that be used for calculating tweening value.
        /// </summary>
        /// <value>The easing.</value>
        public Easing Easing
        {
            get { return _easing ?? Linear.EaseNone; }
            set { _easing = value; }
        }

        /// <summary>
        /// Whether tween has been completed or not.
        /// </summary>
        /// <value><c>true</c> if this tween is complete; otherwise, <c>false</c>.</value>
        public bool IsComplete
        {
            get { return TweenTime >= Duration; }
        }

        /// <summary>
        /// Occurs when on tween complete.
        /// </summary>
        public event Callback OnComplete;

        public void Skip()
        {
            _elapsedTime = DelayTime + Duration;
            Update();
        }

        protected virtual void Reset()
        {
            _duration = 0f;
            _delayTime = 0f;
            _elapsedTime = 0f;
            _easing = null;
            OnComplete = null;
        }

        public virtual void Update()
        {
            Update(_elapsedTime + Time.deltaTime);
        }

        public virtual void Update(float elapsed)
        {
            _elapsedTime = elapsed;

            // 딜레이 시간 동안 기다림
            if (_elapsedTime < DelayTime)
            {
                return;
            }

            // 트윈 완료 여부 체크
            bool justCompleted = false;
            if (IsComplete)
            {
                _elapsedTime = DelayTime + Duration;
                enabled = false;
                justCompleted = false;
            }

            // 트윈 값 업데이트
            UpdateValue(Easing, TweenTime, Duration);

            // 완료 시 콜백 호출
            if (justCompleted && OnComplete != null)
            {
                var callback = OnComplete;
                OnComplete = null;
                callback();
            }
        }

        protected abstract void UpdateValue(Easing easing, float tweenTime, float duration);
    }
}