using System;

namespace MoonTools.Core.Easing
{
    public static class Easing
    {
        // argument checker

        private static void CheckTime(float time, float duration)
        {
            if (time > duration) { throw new ArgumentException($"{time} is invalid. Must be less than {duration}."); }
        }

        private static void CheckTime(double time, double duration)
        {
            if (time > duration) { throw new ArgumentException($"{time} is invalid. Must be less than {duration}."); }
        }

        // function transformations
        private static float NormalizedTime(Func<float, float, float, float, float> easingFunction, float t) => easingFunction(t, 0, 1, 1);
        private static float TimeRange(Func<float, float> easingFunction, float time, float start, float end) => start + (end - start) * easingFunction((time - start) / (end - start));

        private static double NormalizedTime(Func<double, double, double, double, double> easingFunction, double t) => easingFunction(t, 0, 1, 1);
        private static double TimeRange(Func<double, double> easingFunction, double time, double start, double end) => start + (end - start) * easingFunction((time - start) / (end - start));

        /********* EASING FUNCTIONS ********/

        // LINEAR

        public static float Linear(float t) => NormalizedTime(Linear, t);
        public static float Linear(float time, float start, float end) => TimeRange(Linear, time, start, end);

        public static float Linear(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            return c * t / d + b;
        }

        public static double Linear(double t) => NormalizedTime(Linear, t);
        public static double Linear(double time, double start, double end) => TimeRange(Linear, time, start, end);

        public static double Linear(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            return c * t / d + b;
        }

        // IN QUAD

        public static float InQuad(float t) => NormalizedTime(InQuad, t);
        public static float InQuad(float time, float start, float end) => TimeRange(InQuad, time, start, end);

        public static float InQuad(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d;
            return c * (t * t) + b;
        }

        public static double InQuad(double t) => NormalizedTime(InQuad, t);
        public static double InQuad(double time, double start, double end) => TimeRange(InQuad, time, start, end);

        public static double InQuad(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d;
            return c * (t * t) + b;
        }

        // OUT QUAD

        public static float OutQuad(float t) => NormalizedTime(OutQuad, t);
        public static float OutQuad(float time, float start, float end) => TimeRange(OutQuad, time, start, end);

        public static float OutQuad(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d;
            return -c * t * (t - 2) + b;
        }

        public static double OutQuad(double t) => NormalizedTime(OutQuad, t);
        public static double OutQuad(double time, double start, double end) => TimeRange(OutQuad, time, start, end);

        public static double OutQuad(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d;
            return -c * t * (t - 2) + b;
        }

        // IN OUT QUAD

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

        public static double InOutQuad(double t) => NormalizedTime(InOutQuad, t);
        public static double InOutQuad(double time, double start, double end) => TimeRange(InOutQuad, time, start, end);

        public static double InOutQuad(double t, double b, double c, double d)
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

        // OUT IN QUAD

        public static float OutInQuad(float t) => NormalizedTime(OutInQuad, t);
        public static float OutInQuad(float time, float start, float end) => TimeRange(OutInQuad, time, start, end);

        public static float OutInQuad(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            if (t < d / 2)
            {
                return OutQuad(t * 2, b, c / 2, d);
            }
            else
            {
                return InQuad((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static double OutInQuad(double t) => NormalizedTime(OutInQuad, t);
        public static double OutInQuad(double time, double start, double end) => TimeRange(OutInQuad, time, start, end);

        public static double OutInQuad(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            if (t < d / 2)
            {
                return OutQuad(t * 2, b, c / 2, d);
            }
            else
            {
                return InQuad((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        // IN CUBIC

        public static float InCubic(float t) => NormalizedTime(InCubic, t);
        public static float InCubic(float time, float start, float end) => TimeRange(InCubic, time, start, end);

        public static float InCubic(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d;
            return c * (t * t * t) + b;
        }

        public static double InCubic(double t) => NormalizedTime(InCubic, t);
        public static double InCubic(double time, double start, double end) => TimeRange(InCubic, time, start, end);

        public static double InCubic(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d;
            return c * (t * t * t) + b;
        }

        // OUT CUBIC

        public static float OutCubic(float t) => NormalizedTime(OutCubic, t);
        public static float OutCubic(float time, float start, float end) => TimeRange(OutCubic, time, start, end);

        public static float OutCubic(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d - 1;
            return c * (t * t * t + 1) + b;
        }

        public static double OutCubic(double t) => NormalizedTime(OutCubic, t);
        public static double OutCubic(double time, double start, double end) => TimeRange(OutCubic, time, start, end);

        public static double OutCubic(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d - 1;
            return c * (t * t * t + 1) + b;
        }
    }
}
