using System;

namespace MoonTools.Core.Easing
{
    public static class Easing
    {
        private static void CheckTime(float time, float duration)
        {
            if (time > duration) { throw new ArgumentException($"{time} is invalid. Must be less than {duration}."); }
        }

        private static float NormalizedTime(Func<float, float, float, float, float> easingFunction, float t) => easingFunction(t, 0, 1, 1);
        private static float TimeRange(Func<float, float> easingFunction, float time, float start, float end) => start + (end - start) * easingFunction((time - start) / (end - start));

        public static float Linear(float t) => NormalizedTime(Linear, t);
        public static float Linear(float time, float start, float end) => TimeRange(Linear, time, start, end);

        public static float Linear(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            return c * t / d + b;
        }

        public static float InQuad(float t) => NormalizedTime(InQuad, t);
        public static float InQuad(float time, float start, float end) => TimeRange(InQuad, time, start, end);

        public static float InQuad(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d;
            return c * (t * t) + b;
        }

        public static float OutQuad(float t) => NormalizedTime(OutQuad, t);
        public static float OutQuad(float time, float start, float end) => TimeRange(OutQuad, time, start, end);

        public static float OutQuad(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d;
            return -c * t * (t - 2) + b;
        }

        public static float InOutQuad(float t) => NormalizedTime(InOutQuad, t);
        public static float InOutQuad(float time, float start, float end) => TimeRange(InOutQuad, time, start, end);

        public static float InOutQuad(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d * 2;
            if (t < 1)
            {
                return c / 2 * (t * t) + b;
            }
            else
            {
                return -c / 2 * ((t - 1) * (t - 3) - 1) + b;
            }
        }
    }
}
